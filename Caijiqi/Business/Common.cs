﻿using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Net;

namespace Caijiqi.Business
{
    public static class Common
    {
        public static CookieContainer GlobalCookie = new CookieContainer();

        public readonly static string AuthUrl = "http://caijiqi.jywebs.com/api/";

        public readonly static string CopyUrl = "http://121.199.182.59:30003/Copy/OneKey.aspx";

        public static string Get(string url, Encoding encoding,string referer,string data=default(string))
        {
            string result = string.Empty;
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            try
            {
                request = (HttpWebRequest) WebRequest.Create(url);
                request.ContentType = "application/json;";
                request.Method = "GET";
                request.CookieContainer = GlobalCookie;
                request.Referer = referer;

                response = (HttpWebResponse) request.GetResponse();
                response.Cookies = GlobalCookie.GetCookies(request.RequestUri);
                var reader = new StreamReader(response.GetResponseStream(),encoding);
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
                request = (HttpWebRequest) WebRequest.Create(new Uri(url));
                request.Accept = "text/plain";
                request.ContentType = "application/json;charset=UTF-8";
                request.Method = "POST";
                request.ContentLength = json.Length;

                request.CookieContainer = GlobalCookie;

                var myStreamWriter = new StreamWriter(request.GetRequestStream());
                myStreamWriter.Write(json);
                myStreamWriter.Close();
                response = (HttpWebResponse) request.GetResponse();
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
