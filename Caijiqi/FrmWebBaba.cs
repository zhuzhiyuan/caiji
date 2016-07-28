using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Caijiqi
{
    public partial class FrmWebBaba : Form
    {
        private static List<string> filterKeys = new List<string>();
        public FrmWebBaba()
        {
            InitializeComponent();
        }
        string[] price = { "","0-5.44","5.44-13.4","13.4-21.48","21.48-57.52","52.72-"};
        private void btnCaiji_Click(object sender, EventArgs e)
        {
            if (filterKeys.Count == 0 && chbFilter.Checked)
            {
                string keys = Business.Common.GetJson(Business.Common.AuthUrl + "key/getKeys", Encoding.UTF8);
                filterKeys.AddRange(JsonConvert.DeserializeObject<IEnumerable<string>>(keys));
            }

            string url = "https://daixiao.1688.com/daixiao/rpc_async_render.jsonp?rpcflag=new&_serviceId_=daixiaoOfferResultViewService&_template_=controls%2Fnew_template%2Fproducts%2Fmarketoffersearch%2Fofferresult%2Fpkg-d%2Fviews%2Fofferresult.vm&keywords="
            + System.Web.HttpUtility.UrlEncode(skinTextBox1.SkinTxt.Text,Encoding.Default) + "&enableAsync=true&sug=2_0&asyncCount=20&n=y&async=true&uniqfield=pic_tag_id&token=2336970057";
            
            List<string> tagId=new List<string>();
            if (chxNew.Checked)
            {
                tagId.Add("10010552");
            }
            if (chxPinZhi.Checked)
            {
                tagId.Add("10006483");
            }
            if (tagId.Count > 0)
            {
                url += "&filtHolidayTagId=" + string.Join(";", tagId.ToArray());
            }
            if (chxHuan.Checked)
            {
                url += "&replaceEnsure=qtbh%2Cswtbh%2Cesytbhfw%2Clstbhfw";
            }
            if (chxFaHuo.Checked)
            {
                url += "&sign2=17%2C18%2C19";
            }
            if (skinComboBox1.SelectedIndex > -1)
            {
                string priceStr = price[skinComboBox1.SelectedIndex];
                if (!string.IsNullOrEmpty(priceStr))
                {
                    string[] priceArr = priceStr.Split('-');
                    if (!string.IsNullOrEmpty(priceArr[0]))
                    {
                        url += "&priceStart=" + priceArr[0];
                    }
                    if (!string.IsNullOrEmpty(priceArr[1]))
                    {
                        url += "&priceEnd=" + priceArr[1];
                    }
                }
            }
            ThreadPool.QueueUserWorkItem(delegate(object state)
            {
                string getUrl;
                for (int i = 0; i < int.Parse(pageSize.SkinTxt.Text); i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        getUrl = url + "&startIndex=" + (j*20) + "&beginPage=" + (i + 1) + "&_=" +
                                 DateTime.Now.Ticks/1000;
                        if (j > 0)
                        {
                            getUrl += "&pageSource=page&maxPage=100&pageOffset=0";
                        }
                        string html = Business.Common.GetJson(getUrl, Encoding.Default);
                        html = html.Replace("\\/", "/").Replace("\\\"", "\"");
                        Regex reg =
                            new Regex(
                                @"(?is)<a(?:(?!href=).)*href=(['""]?)(?<url>[^""\s>]*)\1[^>]*>(?<text>(?:(?!</?a\b).)*)</a>");
                        MatchCollection mc = reg.Matches(html);
                        foreach (Match m in mc)
                        {
                            string href = m.Groups["url"].Value;
                            if (href.Contains("detail.1688"))
                            {
                                string title = m.Groups["text"].Value;
                                string strText = System.Text.RegularExpressions.Regex.Replace(title, "<[^>]+>", "");
                                strText = System.Text.RegularExpressions.Regex.Replace(strText, "&[^;]+;", "");
                                strText = strText.Replace("\\n", "");
                                if (!string.IsNullOrEmpty(strText.Trim()))
                                {
                                    if (chbFilter.Checked)
                                    {
                                        var next = true;
                                        foreach (var filterKey in filterKeys)
                                        {
                                            if (strText.Contains(filterKey))
                                            {
                                                next = false;
                                                break;
                                            }
                                        }
                                        if (!next) continue;
                                    }
                                    AddDataGridRow(skinDataGridView4, txtTotal, new object[]
                                    {
                                        strText,
                                        href
                                    });
                                }
                            }
                        }
                        Thread.Sleep(1000);
                    }
                }
                MessageBox.Show("采集完成");
            });
        }

        private void AddDataGridRow(DataGridView gridView, Label txtTotal, object[] row)
        {
            if (gridView.InvokeRequired)
            {
                AddDataGridRowInvoke invoke = AddDataGridRow;
                gridView.Invoke(invoke, new object[] {gridView,txtTotal, row});
            }
            else
            {
                gridView.Rows.Add(row);
                txtTotal.Text = "共采集到" + skinDataGridView4.Rows.Count + "条数据";
            }
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "请选择要导出到的文件夹";
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                int rows = skinDataGridView4.Rows.Count;
                int rowIndex = 0;
                while (rowIndex < rows)
                {
                    string folderPath = folderDialog.SelectedPath;
                    string fileName = @"\维达科技-阿里巴巴采集结果";
                    int index = 0;
                    string outputFileName = folderPath + fileName + ".txt";
                    while (File.Exists(outputFileName))
                    {
                        index++;
                        outputFileName = folderPath + fileName + "(" + index + ").txt";
                    }
                    FileStream fs = File.Create(fileName);
                    fs.Close();
                    fs.Dispose();

                    using (
                        System.IO.StreamWriter sw = new System.IO.StreamWriter(outputFileName, true,
                            System.Text.Encoding.GetEncoding("utf-8")))
                    {
                        int outputSize = int.Parse(txtOutPutSize.SkinTxt.Text);
                        for (var i = 0; rowIndex < rows && i < outputSize; rowIndex++, i++)
                        {
                            sw.WriteLine(skinDataGridView4.Rows[rowIndex].Cells["Url"].Value);
                        }
                    }

                    MessageBox.Show("导出完毕");
                    System.Diagnostics.Process.Start(outputFileName);
                }
            }
        }
    }
}
