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

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string ip = string.Empty;
            foreach (NetworkInterface netif in NetworkInterface.GetAllNetworkInterfaces())
            {
                //Console.WriteLine("Network Interface: {0}", netif.Name);
                ip += string.Format("Network Interface: {0}\n", netif.Name);
                IPInterfaceProperties properties = netif.GetIPProperties();
                foreach (IPAddress dns in properties.DnsAddresses)
                    ip += string.Format("\tDNS: {0}\n", dns);
                foreach (IPAddressInformation anycast in properties.AnycastAddresses)
                    ip += string.Format("\tAnyCast: {0}\n", anycast.Address);
                foreach (IPAddressInformation multicast in properties.MulticastAddresses)
                    ip += string.Format("\tMultiCast: {0}\n", multicast.Address);
                foreach (IPAddressInformation unicast in properties.UnicastAddresses)
                    ip += string.Format("\tUniCast: {0}", unicast.Address);
            }
            MessageBox.Show(ip);
            //string ip = Business.Common.GetIP();
            //string shortUrl = Convert("https://detail.tmall.com/item.htm?id=533919683427");
            //MessageBox.Show(shortUrl);
        }


        private string Convert(string fromUrl)
        {

            Paste(fromUrl);
            return GetShort(58974076, 15318418);
//            var obj = GetautId();
//            if (obj != null)
//            {
//                return GetShort(58974076, 15318418);
//            }
//            return null;
        }

        private string Paste(string url)
        {
            string str = Business.LianMengLogin.Get(
                "http://suggest.taobao.com/sug?code=utf-8&q=" + System.Web.HttpUtility.UrlEncode(url) +
                "&_ksTS=1469600002317_9029&callback=jsonp9030&isg=Atvb3JsECPqI9nSYQczJFdVMaj91cvXy2yRrSM0A21rIrM2ON4JJAmpqNLvY&isg2=AoKCUlO%2Fa9qH7hhhJCUJfYGNUpL8P4ZU&isg=AklJl72iemBGOAYCp-pbf-tyWHWTVNMtlWq5cuumqTBWMl9EUeR7mKQkBiF-",
                Encoding.UTF8, "http://pub.alimama.com/");
            return string.Empty;
        }

        private JObject GetPageList(string url)
        {
            string jsonStr = JsonConvert.SerializeObject(new JObject()
            {
                {"q", "url"},
                {"toPage", 1},
                {"perPagesize", 40},
                {"t", DateTime.Now.Ticks/1000},
                {"pvid", "50_203.156.203.9_1301_1469612842225"}
            });
            string response = Business.LianMengLogin.Get("http://pub.alimama.com/pubauc/searchAuctionList.json", Encoding.UTF8,jsonStr);
            if (!string.IsNullOrEmpty(response))
            {
                JObject obj = JsonConvert.DeserializeObject<JObject>(response);
                return obj;
            }
            return new JObject();
        }


        private JArray GetTuiGuangList()
        {
            string response = Business.LianMengLogin.Get("http://pub.alimama.com/common/adzone/newSelfAdzone2.json?tag=29&t=1469611435816&pvid=50_203.156.203.9_368_1469610759773&_tb_token_=AZ4KMTxPGkp&_input_charset=utf-8",Encoding.UTF8);
            if (!string.IsNullOrEmpty(response))
            {
                JObject obj = JsonConvert.DeserializeObject<JObject>(response);
                return obj["otherAdzones"] as JArray;
            }
            return new JArray();
        }

        private string GetShort(int adzoneId, int siteId)
        {
            string res =
                Business.LianMengLogin.Get(
                    "http://pub.alimama.com/common/code/getAuctionCode.json?auctionid=534408918864&adzoneid=" + adzoneId +
                    "&siteid=" + siteId + "&t=" + DateTime.Now.Ticks/1000
                    + "&pvid=50_203.156.203.9_393_1469598718486&_input_charset=utf-8",
                    Encoding.UTF8, "http://pub.alimama.com/");
            return string.Empty;
        }
    }
}
