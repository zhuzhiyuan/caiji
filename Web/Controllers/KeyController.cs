using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web.Controllers
{
    [RoutePrefix("api/key")]
    public class KeyController : ApiController
    {
        [HttpGet]
        [Route("getKeys")]
        public IEnumerable<string> GetKeys()
        {
            return new List<string>()
            {
                "女装",
                "男装",
                "童装",
                "面膜",
                "睫毛膏",
                "BB霜",
                "刀具",
                "枪支弹药",
                "成人用品",
                "零食",
                "瓜果蔬菜",
                "金",
                "银",
                "首饰",
                "洗衣液",
                "洗衣粉",
                "行车记录仪",
                "帽子",
                "狗粮",
                "手表",
                "表带",
                "腰带"
            };
        }
    }
}