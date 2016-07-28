using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using CCWin;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Caijiqi
{
    public partial class FrmLogin : CCSkinMain
    {
        public FrmLogin()
        {
            InitializeComponent();
            SetStyles();
        }
        #region 减少闪烁
        //减少闪烁
        private void SetStyles()
        {
            base.SetStyle(
              ControlStyles.UserPaint |
              ControlStyles.AllPaintingInWmPaint |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.ResizeRedraw |
              ControlStyles.DoubleBuffer, true);
            base.UpdateStyles();

            base.AutoScaleMode = AutoScaleMode.None;
        }
        #endregion

        void Init()
        {
            using (FileStream fs = new FileStream("data.bin", FileMode.OpenOrCreate))
            {
                if (fs.Length > 0)
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    accounts = bf.Deserialize(fs) as List<LoginAccount>;
                    skinComboBox1.Items.Clear();
                    foreach (var account in accounts)
                    {
                        skinComboBox1.Items.Add(account.Acount);
                        if (!string.IsNullOrEmpty(account.Password))
                        {
                            txtPassword.SkinTxt.Text = account.Password;
                            chbPassword.Checked = true;
                        }
                        else
                        {
                            txtPassword.SkinTxt.Text = "";
                            chbPassword.Checked = false;
                        }
                        chbLogin.Checked = account.AutoLogin;
                    }
                }
                fs.Close();
            }
            if (accounts.Count > 0)
                skinComboBox1.Text = accounts[accounts.Count - 1].Acount;
        }

        void Select(string val)
        {
            var account = accounts.Find(a => a.Acount == val);
            if (account != null)
            {
                if (!string.IsNullOrEmpty(account.Password))
                {
                    txtPassword.SkinTxt.Text = account.Password;
                    chbPassword.Checked = true;
                }
                else
                {
                    txtPassword.SkinTxt.Text = "";
                    chbPassword.Checked = false;
                }
                chbLogin.Checked = account.AutoLogin;
            }
        }

        private List<LoginAccount> accounts = new List<LoginAccount>();
        private void skinButton1_Click(object sender, EventArgs e)
        {
            Login();
        }


        void Login()
        {
            skinButton1.Text = "登录中...";
            skinButton1.Enabled = false;
            string account = skinComboBox1.Text;
            string password = txtPassword.SkinTxt.Text;
            if (string.IsNullOrEmpty(account))
            {
                MessageBox.Show("请输入账户名");
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("请输入密码");
            }
            else
            {
                var obj =
                    JsonConvert.SerializeObject(
                        new
                        {
                            Account = account,
                            Password = password,
                            CPUID = Business.Common.GetCpuInfo(),
                            HDID = Business.Common.GetHDid()
                        });
                string result = Business.Common.PostJson(Business.Common.AuthUrl + "login/login", obj);
                if (!string.IsNullOrEmpty(result))
                {
                    var status = (LoginStatus)int.Parse(result);
                    if (status == LoginStatus.Success)
                    {
                        Business.Common.LoginAccount = account;
                        this.Hide();
                        new FrmMain().Show();
                        var loginAccount = new LoginAccount();
                        loginAccount.Acount = account;

                        if (chbPassword.Checked)
                        {
                            loginAccount.Password = password;

                            if (chbLogin.Checked)
                            {
                                loginAccount.AutoLogin = true;
                            }
                        }
                       
                        if (accounts.Contains(loginAccount))
                        {
                            accounts.Remove(loginAccount);
                        }
                        accounts.Add(loginAccount);
                        using (FileStream fs = new FileStream("data.bin", FileMode.Create))
                        {
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Serialize(fs, accounts);
                            fs.Close();
                        }

                        string ip = Business.Common.GetText(Business.Common.AuthUrl + "login/getIp", Encoding.UTF8);
                        Business.Common.IP = ip.Replace("\"", "");
                    }else if (status == LoginStatus.IDError)
                    {
                        MessageBox.Show("本软件只能在同一台电脑上登录");
                    }
                    else
                    {
                        MessageBox.Show("登陆失败");
                    }
                }
            }
            skinButton1.Enabled = true;
            skinButton1.Text = "登录";
        }

        private void skinComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            Select(skinComboBox1.Text);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void FrmLogin_Shown(object sender, EventArgs e)
        {
            if (accounts.Count > 0)
            {
                if (accounts[accounts.Count - 1].AutoLogin)
                {
                    Login();
                }
            }
            
        }
    }
    [Serializable]
    class LoginAccount
    {
        public string Acount ;
        public string Password;
        public bool AutoLogin;
        public override bool Equals(object obj)
        {
            if (obj is LoginAccount)
            {
                return string.Equals(this.Acount, (obj as LoginAccount).Acount, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }
    }


    class ComboBoxItem
    {
        public ComboBoxItem(string text, string value)
        {
            this.Text = text;
            this.Value = value;
        }
        public string Text { get; set; }
        public string Value { get; set; }
        public override string ToString()
        {
            return this.Text;
        }
    }


    enum LoginStatus
    {
        Filed = 10000,
        Success = 10001,
        PasswordError = 10002,
        IDError=10003
    }
}
