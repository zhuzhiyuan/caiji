using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Caijiqi
{
    public partial class FrmLinkConvert : Form
    {
        public FrmLinkConvert()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rTxtBefore.Text = "";
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            IDataObject iData = Clipboard.GetDataObject();
            if (iData.GetDataPresent(DataFormats.Text))
            {
                rTxtBefore.Text = (String)iData.GetData(DataFormats.Text);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                JObject item = Convert(rTxtBefore.Text);
                if (item == null)
                {
                    MessageBox.Show("没有找到商品");
                }
                skinDataGridView4.Rows.Add(new object[]
                {
                item["title"].ToString()+"【"+item["nick"]+"】",
                item["zkRate"].ToString(),
                item["zkPrice"].ToString(),
                item["commissionRatePercent"].ToString()+"%",
                item["calCommission"].ToString(),
                item["totalNum"].ToString(),
                item["totalFee"].ToString(),
                item["auctionUrl"].ToString(),
                item["shortLinkUrl"].ToString()
                });
            }
            catch (Newtonsoft.Json.JsonReaderException ex)
            {
                MessageBox.Show("连接转换服务，需要先到首页登录阿里妈妈");
            }
            
           
        }

        #region Convert

        private JObject Convert(string fromUrl)
        {
            string auctionid;
            var page = GetPageList(fromUrl);
            if (page == null)
                return null;

            var pageList = (page["data"] as JObject)["pagelist"] as JArray;

            if (pageList == null)
                return null;

            if (pageList.Count == 0)
                return null;
            var item = pageList[0] as JObject;

            auctionid = item["auctionId"].ToString();

            var obj = GetTuiGuangList();
            if (obj == null)
                return null;
            var otherAdzones = (obj["data"] as JObject)["otherAdzones"] as JArray;

            if (otherAdzones == null)
                return null;

            string siteId;
            string adzoneId ;
            if (otherAdzones.Count == 0)
            {
                MessageBox.Show("请先到网站上添加你的导购推广");
                return null;
            }
            else
            {
                var site = (otherAdzones[0] as JObject);
                siteId = site["id"].ToString();
                var sub = (site["sub"] as JArray)[0] as JObject;
                adzoneId = sub["id"].ToString();
            }

            var shortObj = GetShort(auctionid, adzoneId, siteId);
            if (shortObj == null)
            {
                return null;
            }
            string shortLinkUrl = (shortObj["data"] as JObject)["shortLinkUrl"].ToString();
            item.Add("shortLinkUrl", shortLinkUrl);
            return item;
        }

        private JObject GetPageList(string url)
        {
            var jsonStr = new List<string>()
            {
                "q=" + System.Web.HttpUtility.UrlEncode(url),
                "t=" + DateTime.Now.Ticks/1000,
                "pvid=" + "50_" + Business.Common.IP + "_1301_" + DateTime.Now.Ticks/1000
            };

            string response =
                Business.LianMengLogin.Get(
                    "http://pub.alimama.com/pubauc/searchAuctionList.json?" + string.Join("&", jsonStr.ToArray()),
                    Encoding.UTF8);

            jsonStr = new List<string>()
            {
                "q=" + System.Web.HttpUtility.UrlEncode(url),
                "toPage=" + 1,
                "perPagesize=" + 40,
                "t=" + DateTime.Now.Ticks/1000,
                "pvid=" + "50_" + Business.Common.IP + "_1301_" + DateTime.Now.Ticks/1000
            };

            response =
                Business.LianMengLogin.Get(
                    "http://pub.alimama.com/pubauc/searchAuctionList.json?" + string.Join("&", jsonStr.ToArray()),
                    Encoding.UTF8);
            if (!string.IsNullOrEmpty(response))
            {
                JObject obj = JsonConvert.DeserializeObject<JObject>(response);
                return obj;
            }
            return null;
        }


        private JObject GetTuiGuangList()
        {
            string response =
                Business.LianMengLogin.Get("http://pub.alimama.com/common/adzone/newSelfAdzone2.json?tag=29&t="
                                           + DateTime.Now.Ticks/1000 + "&pvid=50_" + Business.Common.IP +
                                           "_368_" + DateTime.Now.Ticks/1000 + "&_input_charset=utf-8", Encoding.UTF8);
            if (!string.IsNullOrEmpty(response))
            {
                JObject obj = JsonConvert.DeserializeObject<JObject>(response);
                return obj;
            }
            return null;
        }

        private JObject GetShort(string auctionid, string adzoneId, string siteId)
        {
            string response =
                Business.LianMengLogin.Get(
                    "http://pub.alimama.com/common/code/getAuctionCode.json?auctionid=" + auctionid + "&adzoneid=" +
                    adzoneId +
                    "&siteid=" + siteId + "&t=" + DateTime.Now.Ticks/1000
                    + "&pvid=50_" + Business.Common.IP + "_393_" + DateTime.Now.Ticks/1000 + "&_input_charset=utf-8",
                    Encoding.UTF8, "http://pub.alimama.com/");
            if (!string.IsNullOrEmpty(response))
            {
                JObject obj = JsonConvert.DeserializeObject<JObject>(response);
                return obj;
            }
            return null;
        }

        #endregion

        private void skinDataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell is DataGridViewLinkCell)
            {
                System.Diagnostics.Process.Start(cell.Value.ToString());
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (skinDataGridView4.Rows.Count > 0)
            {
                string str = skinDataGridView4.Rows[0].Cells["Url"].Value.ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    Clipboard.SetDataObject(str);
                }
                MessageBox.Show("复制成功");
            }

        }
    }
}
