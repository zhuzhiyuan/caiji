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
                    return (int) LoginStatus.Success;
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
        PasswordError=10002
    }
}