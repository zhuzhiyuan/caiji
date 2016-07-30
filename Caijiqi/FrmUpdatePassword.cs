using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Caijiqi
{
    public partial class FrmUpdatePassword : Form
    {
        public FrmUpdatePassword()
        {
            InitializeComponent();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOldPassword.Text)) MessageBox.Show("请输入原密码");
            if (txtNewPassword.Text != txtNewAlignPassword.Text) MessageBox.Show("两次新密码输入不一致");
            if (!string.IsNullOrEmpty(txtOldPassword.Text) && !string.IsNullOrEmpty(txtNewPassword.Text)&&!string.IsNullOrEmpty(Business.Common.LoginAccount))
            {
                var obj = JsonConvert.SerializeObject(new { Account = Business.Common.LoginAccount, Password = txtOldPassword.Text });
                string result = Business.Common.PostJson(Business.Common.AuthUrl + "login/login", obj);
                if (!string.IsNullOrEmpty(result))
                {
                    var status = (LoginStatus)int.Parse(result);
                    if (status == LoginStatus.Success)
                    {
                        obj = JsonConvert.SerializeObject(new { Account = Business.Common.LoginAccount, OldPassword= txtOldPassword.Text, NewPassword = txtNewPassword.Text });
                        result = Business.Common.PostJson(Business.Common.AuthUrl + "login/updatePassword", obj);
                        if (!string.IsNullOrEmpty(result))
                        {
                            status = (LoginStatus)int.Parse(result);
                            if (status == LoginStatus.Success)
                            {
                                MessageBox.Show("密码修改成功");
                            }
                            else
                            {
                                MessageBox.Show("密码修改失败");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("原密码输入错误");
                    }
                }
            }
        }
    }
}
