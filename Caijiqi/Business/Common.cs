using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
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

        public static string Get(string url, Encoding encoding,string referer,string data=default(string))
        {
            string result = string.Empty;
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            try
            {
                CookieStr = LianMengLogin.GetCookies(url);
                request = (HttpWebRequest)WebRequest.Create(url);
                request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
                request.ContentType = "application/json;chatset=UTF-8";
                request.Method = "GET";
                request.Headers.Add("Cookie", CookieStr);
                request.Referer = referer;
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.103 Safari/537.36";

                response = (HttpWebResponse) request.GetResponse();
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

        public static string Post(string url, string json)
        {
            string result = string.Empty;
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            try
            {
                CookieStr = LianMengLogin.GetCookies(url);
                request = (HttpWebRequest)WebRequest.Create(url);
                request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
                request.ContentType = "application/json;chatset=UTF-8";
                request.Method = "POST";
                request.Headers.Add("Cookie", CookieStr);
                request.Referer = url;
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.103 Safari/537.36";
                request.ContentLength = json.Length;

                var myStreamWriter = new StreamWriter(request.GetRequestStream());
                myStreamWriter.Write(json);
                myStreamWriter.Close();
                response = (HttpWebResponse) request.GetResponse();
                var reader = new StreamReader(response.GetResponseStream());
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

        public static string GetIP()
        {
            string strUrl = "http://city.ip138.com/ip2city.asp"; //获得IP的网址了

            string all = Get(strUrl, Encoding.UTF8, strUrl);
            if (!string.IsNullOrEmpty(all))
            {
                int start = all.IndexOf("[") + 1;
                int end = all.IndexOf("]", start);
                return all.Substring(start, end - start);
            }
            else
            {
                return "127.0.0.1";
            }
        }
    }
}
