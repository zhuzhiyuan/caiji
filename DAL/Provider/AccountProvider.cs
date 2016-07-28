using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using ServiceStack.OrmLite;

namespace DAL.Provider
{
    public class AccountProvider: BaseRepository<Entity.Account>
    {
        private AccountProvider()
        {
            DbConnection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
        public static AccountProvider Instance
        {
            get
            {
                return new AccountProvider();
            }
        }


        #region 增

        /// <summary>
        /// 新建帐号
        /// </summary>
        public int InsertAccount(Entity.Account account)
        {
            var status = this.Insert(account);
            return status > 0 ? account.AutoId : 0;
        }

        #endregion

        #region  删
        /// <summary>
        /// 删除账号
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public bool DelAccount(Entity.Account account)
        {
            account.Status = 2;
            var status = this.UpdateNonDefaults(account, a => a.AutoId == account.AutoId);
            return status > 0;
        }

        /// <summary>
        /// 通过ID删除账号
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool DelAccountById(string Id)
        {
            var status = this.DeleteById(Id);
            return status > 0;
        }

        #endregion

        #region 改
        /// <summary>
        /// 更新帐号
        /// </summary>
        public bool UpdateAccount(Entity.Account account)
        {
            var status = this.UpdateNonDefaults(account, a => a.AutoId == account.AutoId);
            return status > 0;
        }
        /// <summary>
        /// 修改绑定的硬盘ID
        /// </summary>
        /// <param name="mobilePhone"></param>
        /// <param name="cPUID"></param>
        /// <param name="hDID"></param>
        /// <returns></returns>
        public bool UpdateUserCPUIDAndHDID(string mobilePhone, string cPUID, string hDID)
        {
            var status = this.Update(new {CPUID = cPUID, HDID = hDID, UpdateTime = DateTime.Now},
                m => m.MobilePhone == mobilePhone);
            return status > 0;
        }

        /// <summary>
        /// 按照手机号码更新密码
        /// </summary>
        /// <param name="mobilePhone"></param>
        /// <param name="newPassword"></param>
        /// <returns></returns>
        public bool UpdateUserPasswordByMobilePhone(string mobilePhone, string newPassword)
        {
            var status = this.Update(new { Password = newPassword, UpdateTime = DateTime.Now }, m => m.MobilePhone == mobilePhone);
            return status > 0;
        }
        #endregion

        #region 查

        public List<Entity.Account> GetAccounts()
        {
            return this.Select(a => a.AutoId > 0);
        }

        /// <summary>
        /// 根据帐号获取账户信息(Email/Mobile 包含密码)
        /// </summary>
        public Entity.Account GetAccount(string account, int status = 1)
        {
            using (var db = OpenDbConnection())
            {
                var q = db.From<Entity.Account>();
                q = q.Where(a => a.MobilePhone == account);
                if (status != 0)
                    q = q.And(a => a.Status == status);
                return db.Single(q);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="account"></param>
        /// <param name="type">0:Email 1: MobilePhone</param>
        /// <returns></returns>
        public List<Entity.Account> GetAccounts(List<string> accounts)
        {
            return this.Select(m => (Sql.In(m.MobilePhone, accounts)) && m.Status != 2);
        }

        #endregion
    }
}
