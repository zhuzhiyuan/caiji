namespace Caijiqi
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.txtPassword = new CCWin.SkinControl.SkinTextBox();
            this.txtAccount = new CCWin.SkinControl.SkinTextBox();
            this.panel1.SuspendLayout();
            this.txtPassword.SuspendLayout();
            this.txtAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.skinButton1);
            this.panel1.Controls.Add(this.skinLabel2);
            this.panel1.Controls.Add(this.skinLabel1);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtAccount);
            this.panel1.Location = new System.Drawing.Point(171, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 144);
            this.panel1.TabIndex = 0;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(67, 108);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(75, 23);
            this.skinButton1.TabIndex = 9;
            this.skinButton1.Text = "登录";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(24, 65);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 8;
            this.skinLabel2.Text = "密码";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(12, 17);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(44, 17);
            this.skinLabel1.TabIndex = 7;
            this.skinLabel1.Text = "用户名";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.DownBack = null;
            this.txtPassword.Icon = null;
            this.txtPassword.IconIsButton = false;
            this.txtPassword.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPassword.Location = new System.Drawing.Point(67, 59);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtPassword.MouseBack = null;
            this.txtPassword.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NormlBack = null;
            this.txtPassword.Padding = new System.Windows.Forms.Padding(5);
            this.txtPassword.Size = new System.Drawing.Size(185, 28);
            // 
            // txtPassword.BaseText
            // 
            this.txtPassword.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtPassword.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtPassword.SkinTxt.Name = "BaseText";
            this.txtPassword.SkinTxt.PasswordChar = '*';
            this.txtPassword.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.txtPassword.SkinTxt.TabIndex = 0;
            this.txtPassword.SkinTxt.UseSystemPasswordChar = true;
            this.txtPassword.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPassword.SkinTxt.WaterText = "";
            this.txtPassword.TabIndex = 6;
            // 
            // txtAccount
            // 
            this.txtAccount.BackColor = System.Drawing.Color.Transparent;
            this.txtAccount.DownBack = null;
            this.txtAccount.Icon = null;
            this.txtAccount.IconIsButton = false;
            this.txtAccount.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtAccount.Location = new System.Drawing.Point(67, 11);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(0);
            this.txtAccount.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtAccount.MouseBack = null;
            this.txtAccount.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.NormlBack = null;
            this.txtAccount.Padding = new System.Windows.Forms.Padding(5);
            this.txtAccount.Size = new System.Drawing.Size(185, 28);
            // 
            // txtAccount.BaseText
            // 
            this.txtAccount.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccount.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAccount.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtAccount.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtAccount.SkinTxt.Name = "BaseText";
            this.txtAccount.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.txtAccount.SkinTxt.TabIndex = 0;
            this.txtAccount.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtAccount.SkinTxt.WaterText = "";
            this.txtAccount.TabIndex = 5;
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.skinButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 443);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Text = "登录";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.txtPassword.ResumeLayout(false);
            this.txtPassword.PerformLayout();
            this.txtAccount.ResumeLayout(false);
            this.txtAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinTextBox txtPassword;
        private CCWin.SkinControl.SkinTextBox txtAccount;
    }
}