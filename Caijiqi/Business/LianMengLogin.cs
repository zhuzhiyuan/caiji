using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Caijiqi.Business
{
    public class LianMengLogin
    {
        public static CookieContainer LianMengCookie = new CookieContainer();
        public static string Get(string url, Encoding encoding, string referer, string data = default(string))
        {
            string result = string.Empty;
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            try
            {
                request = (HttpWebRequest)WebRequest.Create(url);
                request.ContentType = "application/json;";
                request.Method = "GET";
                request.CookieContainer = LianMengCookie;
                request.Referer = referer;

                response = (HttpWebResponse)request.GetResponse();
                response.Cookies = LianMengCookie.GetCookies(request.RequestUri);
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
                request = (HttpWebRequest)WebRequest.Create(new Uri(url));
                request.Accept = "text/plain";
                request.ContentType = "application/json;charset=UTF-8";
                request.Method = "POST";
                request.ContentLength = json.Length;

                request.CookieContainer = LianMengCookie;

                var myStreamWriter = new StreamWriter(request.GetRequestStream());
                myStreamWriter.Write(json);
                myStreamWriter.Close();
                response = (HttpWebResponse)request.GetResponse();
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
    }
}
