using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            string shortUrl = Convert(rTxtBefore.Text);
            MessageBox.Show(shortUrl);
        }


        private string Convert(string fromUrl)
        {
            string str = Business.LianMengLogin.Get(
                "http://suggest.taobao.com/sug?code=utf-8&q=https%3A%2F%2Fdetail.tmall.com%2Fitem.htm%3Fspm%3Da220o.1000855.1998025129.2.HKeGVE%26id%3D534408918864%26pvid%3D093c8132-8e3a-45b2-982c-f5a0c8d101db%26abbucket%3D_AB-M32_B12%26acm%3D03054.1003.1.971095%26aldid%3DAU4UYJLV%26abtest%3D_AB-LR32-PR32%26scm%3D1007.12559.40794.100200300000000%26pos%3D2&_ksTS=1469600002317_9029&callback=jsonp9030&isg=Atvb3JsECPqI9nSYQczJFdVMaj91cvXy2yRrSM0A21rIrM2ON4JJAmpqNLvY&isg2=AoKCUlO%2Fa9qH7hhhJCUJfYGNUpL8P4ZU&isg=AklJl72iemBGOAYCp-pbf-tyWHWTVNMtlWq5cuumqTBWMl9EUeR7mKQkBiF-",
                Encoding.UTF8, "http://pub.alimama.com/");

            Business.LianMengLogin.Get(
                "http://gm.mmstat.com/tblm.88.1.a219t.7664554.1998457203.d4808ccd4?logtype=2&cache=0.043569166130123405&autosend=1&spm-cnt=a219t.7664554.0.0",
                Encoding.UTF8, "http://pub.alimama.com/");


            string res =
                Business.LianMengLogin.Get(
                    "http://pub.alimama.com/common/code/getAuctionCode.json?auctionid=534408918864&adzoneid=58974076&siteid=15318418&t=1469600219237&pvid=50_203.156.203.9_393_1469598718486&_tb_token_=AZ4KMTxPGkp&_input_charset=utf-8",
                    Encoding.UTF8, "http://pub.alimama.com/");
            return res;
        }

    }
}
