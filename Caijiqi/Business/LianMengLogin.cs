using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;

namespace Caijiqi.Business
{
    public class LianMengLogin
    {
        public static Dictionary<string, string> Cookies = new Dictionary<string, string>();
        public static string CookieStr = string.Empty;

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool InternetGetCookieEx(string pchURL, string pchCookieName, StringBuilder pchCookieData,
            ref System.UInt32 pcchCookieData, int dwFlags, IntPtr lpReserved);

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int InternetSetCookieEx(string lpszURL, string lpszCookieName, string lpszCookieData, int dwFlags,
            IntPtr dwReserved);


        public static string GetCookies(string url)

        {
            uint datasize = 256;

            StringBuilder cookieData = new StringBuilder((int) datasize);

            if (!InternetGetCookieEx(url, null, cookieData, ref datasize, 0x2000, IntPtr.Zero))
            {

                if (datasize < 0)

                    return null;

                cookieData = new StringBuilder((int) datasize);

                if (!InternetGetCookieEx(url, null, cookieData, ref datasize, 0x00002000, IntPtr.Zero))

                    return null;

            }

            return cookieData.ToString();
        }

        public static string Get(string url, Encoding encoding, string data = default(string))
        {
            string result = string.Empty;
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            try
            {
                CookieStr = GetCookies("http://www.alimama.com");
                FillCookies();
                if (Cookies.ContainsKey("_tb_token_"))
                {
                    url += url.Contains("?") ? "&" : "?";
                    url += "_tb_token_=" + Cookies["_tb_token_"];
                }

                request = (HttpWebRequest)WebRequest.Create(url);
                request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
                request.ContentType = "application/json;chatset=UTF-8";
                request.Method = "GET";
                request.Headers.Add("Cookie", CookieStr);
                request.Referer = "http://www.alimama.com";
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.103 Safari/537.36";
                //request.Connection = "keep-alive";

                response = (HttpWebResponse)request.GetResponse();
                //CookieStr = request.CookieContainer.GetCookieHeader(request.RequestUri);
                var reader = new StreamReader(response.GetResponseStream(), encoding);
                result = reader.ReadToEnd();
                reader.Close();
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

        public static string Post(string url, string json)
        {
            string result = string.Empty;
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            try
            {
                CookieStr = GetCookies("http://www.alimama.com");
                FillCookies();
                if (Cookies.ContainsKey("_tb_token_"))
                {
                    url += url.Contains("?") ? "&" : "?";
                    url += "_tb_token_=" + Cookies["_tb_token_"];
                }
                request = (HttpWebRequest)WebRequest.Create(new Uri(url));
                request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
                request.ContentType = "application/json;chatset=UTF-8";
                request.Method = "GET";
                request.Headers.Add("Cookie", CookieStr);
                request.Referer = "http://www.alimama.com";
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.103 Safari/537.36";
                //request.Connection = "keep-alive";

                var myStreamWriter = new StreamWriter(request.GetRequestStream());
                myStreamWriter.Write(json);
                myStreamWriter.Close();
                response = (HttpWebResponse)request.GetResponse();

                CookieStr = request.CookieContainer.GetCookieHeader(request.RequestUri);

                var reader = new StreamReader(response.GetResponseStream());
                result = reader.ReadToEnd();
                reader.Close();

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

        public static void FillCookies()
        {
            if (!string.IsNullOrEmpty(CookieStr))
            {
                foreach (var cookieStr in CookieStr.Split(';'))
                {
                    var cookieArr = cookieStr.Split('=');
                    if (cookieArr.Length == 2)
                    {
                        if (!Cookies.ContainsKey(cookieArr[0].Trim()))
                        {
                            Cookies.Add(cookieArr[0].Trim(), cookieArr[1]);
                        }
                        else
                        {
                            Cookies[cookieArr[0].Trim()] = cookieArr[1];
                        }
                    }
                }
            }
        }
    }
}
