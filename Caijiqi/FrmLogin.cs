using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCWin;
using Newtonsoft.Json;

namespace Caijiqi
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            string account = txtAccount.SkinTxt.Text;
            string password = txtPassword.SkinTxt.Text;
            if (string.IsNullOrEmpty(account))
            {
                MessageBox.Show("请输入账户名");
            }else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("请输入密码");
            }
            else
            {
                var obj = JsonConvert.SerializeObject(new { Account = account, Password = password });
                string result = Business.Common.Post(Business.Common.AuthUrl + "login/login", obj);
                if (!string.IsNullOrEmpty(result))
                {
                    var status = (LoginStatus) int.Parse(result);
                    if (status == LoginStatus.Success)
                    {
                        this.Parent.Hide();
                    }
                    else
                    {
                        MessageBox.Show("登陆失败");
                    }
                }
                
            }
        }
    }
    enum LoginStatus
    {
        Filed = 10000,
        Success = 10001,
        PasswordError = 10002
    }
}
