using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Net;

namespace HuiXing.Business
{
    public class Common
    {
        public static string Get(string url,string data=default(string))
        {
            string result = string.Empty;
            try
            {
                HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
                request.Accept = "text/plain";
                request.ContentType = "application/json;charset=UTF-8";
                request.Method = "GET";
                request.Headers.Add("Accept-Encoding", "gzip,deflate");
                request.Referer = "http://pub.alimama.com/";

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.ContentEncoding == "gzip")
                {
                    MemoryStream ms = new MemoryStream();
                    GZipStream zip = new GZipStream(response.GetResponseStream(), CompressionMode.Decompress);
                    byte[] buffer = new byte[1024];
                    int l = zip.Read(buffer, 0, buffer.Length);
                    while (l > 0)
                    {
                        ms.Write(buffer, 0, l);
                        l = zip.Read(buffer, 0, buffer.Length);
                    }
                    ms.Dispose();
                    zip.Dispose();
                    result = Encoding.UTF8.GetString(ms.ToArray());
                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public static string Post(string url, string data)
        {
            string result = string.Empty;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Accept = "text/plain";
                request.ContentType = "application/json;charset=UTF-8";
                request.Method = "GET";
                request.Headers.Add("Accept-Encoding", "gzip,deflate");
                request.Referer = "http://pub.alimama.com/";
                request.ContentLength = data.Length;
                Stream postStream = request.GetRequestStream();
                byte[] postData = Encoding.UTF8.GetBytes(data);
                postStream.Write(postData, 0, postData.Length);
                postStream.Dispose();

            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
    }
}
