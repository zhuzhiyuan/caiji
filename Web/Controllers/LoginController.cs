using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;
using Antlr.Runtime.Tree;

namespace Web.Controllers
{
    [RoutePrefix("api/login")]
    public class LoginController : ApiController
    {
        // GET api/<controller>
        [HttpPost]
        [Route("login")]
        public int Login([FromBody] Models.LoginParam account)
        {
            var acc = DAL.Provider.AccountProvider.Instance.GetAccount(account.Account);
            if (acc != null)
            {
                if (acc.Password == account.Password)
                {
                    if (string.IsNullOrEmpty(acc.CPUID) || string.IsNullOrEmpty(acc.HDID))
                    {
                        DAL.Provider.AccountProvider.Instance.UpdateUserCPUIDAndHDID(account.Account, account.CPUID,
                            account.HDID);
                        return (int)LoginStatus.Success;
                    }

                    if (string.Equals(acc.CPUID, account.CPUID) || string.Equals(acc.HDID, account.HDID))
                    {
                        return (int) LoginStatus.Success;
                    }

                    return (int) LoginStatus.IDError;
                }
                return (int) LoginStatus.PasswordError;
            }
            return (int) LoginStatus.Filed;
        }

        [HttpPost]
        [Route("updatePassword")]
        public int UpdatePassword([FromBody] Models.PasswordParam account)
        {
            var acc = DAL.Provider.AccountProvider.Instance.GetAccount(account.Account);
            if (acc != null)
            {
                if (acc.Password == account.OldPassword)
                {
                    if (DAL.Provider.AccountProvider.Instance.UpdateUserPasswordByMobilePhone(account.Account,
                        account.NewPassword))
                    {
                        return (int) LoginStatus.Success;
                    }
                    return (int) LoginStatus.Filed;
                }
                return (int) LoginStatus.PasswordError;
            }
            return (int) LoginStatus.Filed;
        }

        // GET api/<controller>/5
        [HttpGet]
        [Route("getAccounts")]
        public IEnumerable<DAL.Entity.Account> GetAccounts()
        {
            return DAL.Provider.AccountProvider.Instance.GetAccounts();
        }
        [HttpGet]
        [Route("getIp")]
        public string GetIP()
        {
            return Request.GetClientIpAddress();
        }


        [HttpGet]
        [Route("test")]
        public string Test()
        {
            return "test success";
        }

    }
    
    enum  LoginStatus
    {
        Filed = 10000,
        Success =10001,
        PasswordError=10002,
        IDError=10003
    }
   
}
public static class HttpRequestMessageExtensions
{
    private const string HttpContext = "MS_HttpContext";

    public static string GetClientIpAddress(this HttpRequestMessage request)
    {
        // Web-hosting. Needs reference to System.Web.dll
        if (request.Properties.ContainsKey(HttpContext))
        {
            dynamic ctx = request.Properties[HttpContext];
            if (ctx != null)
            {
                var clientIP = ctx.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                ;
                if (string.IsNullOrEmpty(clientIP))
                {
                    clientIP = ctx.Request.ServerVariables["REMOTE_ADDR"];
                }
                if (string.IsNullOrEmpty(clientIP))
                {
                    clientIP = ctx.Request.UserHostAddress;
                }
                return clientIP;
            }
        }

        return null;
    }
}