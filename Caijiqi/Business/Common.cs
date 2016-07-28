using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Text;
using System.Net;

namespace Caijiqi.Business
{
    public static class Common
    {
        public static string CookieStr = string.Empty;

        public readonly static string AuthUrl = "http://caijiqi.jywebs.com/api/";

        public readonly static string CopyUrl = "http://121.199.182.59:30003/Copy/OneKey.aspx";

        public static string LoginAccount;

        public static string IP;

        public static string GetJson(string url, Encoding encoding,string data=default(string))
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/json;chatset=UTF-8";
            request.Method = "GET";
            return Request(request, url, encoding, data);
        }


        public static string GetText(string url, Encoding encoding, string data = default(string))
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/text;chatset=UTF-8";
            request.Method = "GET";
            return Request(request,url, encoding, data);
        }

        private static string Request(HttpWebRequest request,string url, Encoding encoding, string data = default(string))
        {
            string result = string.Empty;
            HttpWebResponse response = null;
            try
            {
                CookieStr = LianMengLogin.GetCookies(url);
                request.Headers.Add("Cookie", CookieStr);
                request.Referer = url;
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.103 Safari/537.36";

                response = (HttpWebResponse)request.GetResponse();
                var reader = new StreamReader(response.GetResponseStream(), encoding);
                result = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (response != null)
                {
                    response.Close();
                    response = null;
                }

                if (request != null)
                {
                    request.Abort();
                }
            }

            return result;
        }

        public static string PostJson(string url, string json)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/json;chatset=UTF-8";
            request.Method = "POST";
            request.ContentLength = json.Length;
            var myStreamWriter = new StreamWriter(request.GetRequestStream());
            myStreamWriter.Write(json);
            myStreamWriter.Close();
            return Request(request, url,Encoding.Default, json);
        }


        /**/
        ///  <summary>   
        /// 获取cpu序列号     
        ///  </summary>   
        ///  <returns>string </returns>   
        public static string GetCpuInfo()
        {
            string cpuInfo = "";
            ManagementClass cimobject = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = cimobject.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                cpuInfo = mo.Properties["ProcessorId"].Value.ToString();
            }
            return cpuInfo;
        }

        /**////  <summary>   
            /// 获取硬盘ID     
            ///  </summary>   
            ///  <returns>string </returns>   
        public static string GetHDid()
        {
            string HDid = "";
            ManagementClass cimobject1 = new ManagementClass("Win32_DiskDrive");
            ManagementObjectCollection moc1 = cimobject1.GetInstances();
            foreach (ManagementObject mo in moc1)
            {
                HDid = (string)mo.Properties["Model"].Value;
            }
            return HDid;
        }
    }
}
