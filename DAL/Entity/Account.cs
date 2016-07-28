using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStack.DataAnnotations;

namespace DAL.Entity
{
    [Serializable]
    [Alias("Account")]
    public class Account
    {
        [AutoIncrement]
        public int AutoId { get; set; }
        public string MobilePhone { get; set; }
        public string Password { get; set; }
        public string CPUID { get; set; }
        public string HDID { get; set; }
        public int? Status { get; set; }

        private DateTime? updateTime;

        public DateTime? UpdateTime
        {
            get { return updateTime; }
            set { updateTime = value; }
        }

        private DateTime? createTime;

        public DateTime? CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }
    }
}
