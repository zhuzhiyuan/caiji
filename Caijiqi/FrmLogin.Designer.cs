﻿namespace Caijiqi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.skinComboBox1 = new CCWin.SkinControl.SkinComboBox();
            this.chbLogin = new CCWin.SkinControl.SkinCheckBox();
            this.chbPassword = new CCWin.SkinControl.SkinCheckBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.txtPassword = new CCWin.SkinControl.SkinTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.skinComboBox1);
            this.panel1.Controls.Add(this.chbLogin);
            this.panel1.Controls.Add(this.chbPassword);
            this.panel1.Controls.Add(this.skinButton1);
            this.panel1.Controls.Add(this.skinLabel2);
            this.panel1.Controls.Add(this.skinLabel1);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Location = new System.Drawing.Point(34, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 162);
            this.panel1.TabIndex = 0;
            // 
            // skinComboBox1
            // 
            this.skinComboBox1.ArrowColor = System.Drawing.Color.Gray;
            this.skinComboBox1.BaseColor = System.Drawing.Color.Transparent;
            this.skinComboBox1.BorderColor = System.Drawing.Color.Transparent;
            this.skinComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox1.FormattingEnabled = true;
            this.skinComboBox1.ItemBorderColor = System.Drawing.Color.DarkGray;
            this.skinComboBox1.ItemHoverForeColor = System.Drawing.Color.Transparent;
            this.skinComboBox1.Location = new System.Drawing.Point(67, 17);
            this.skinComboBox1.MouseColor = System.Drawing.Color.Transparent;
            this.skinComboBox1.MouseGradientColor = System.Drawing.Color.Transparent;
            this.skinComboBox1.Name = "skinComboBox1";
            this.skinComboBox1.Size = new System.Drawing.Size(185, 22);
            this.skinComboBox1.TabIndex = 12;
            this.skinComboBox1.WaterText = "";
            this.skinComboBox1.SelectedValueChanged += new System.EventHandler(this.skinComboBox1_SelectedValueChanged);
            // 
            // chbLogin
            // 
            this.chbLogin.AutoSize = true;
            this.chbLogin.BackColor = System.Drawing.Color.Transparent;
            this.chbLogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.chbLogin.DownBack = null;
            this.chbLogin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chbLogin.Location = new System.Drawing.Point(158, 90);
            this.chbLogin.MouseBack = null;
            this.chbLogin.Name = "chbLogin";
            this.chbLogin.NormlBack = null;
            this.chbLogin.SelectedDownBack = null;
            this.chbLogin.SelectedMouseBack = null;
            this.chbLogin.SelectedNormlBack = null;
            this.chbLogin.Size = new System.Drawing.Size(75, 21);
            this.chbLogin.TabIndex = 11;
            this.chbLogin.Text = "自动登录";
            this.chbLogin.UseVisualStyleBackColor = false;
            // 
            // chbPassword
            // 
            this.chbPassword.AutoSize = true;
            this.chbPassword.BackColor = System.Drawing.Color.Transparent;
            this.chbPassword.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.chbPassword.DownBack = null;
            this.chbPassword.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chbPassword.Location = new System.Drawing.Point(67, 91);
            this.chbPassword.MouseBack = null;
            this.chbPassword.Name = "chbPassword";
            this.chbPassword.NormlBack = null;
            this.chbPassword.SelectedDownBack = null;
            this.chbPassword.SelectedMouseBack = null;
            this.chbPassword.SelectedNormlBack = null;
            this.chbPassword.Size = new System.Drawing.Size(75, 21);
            this.chbPassword.TabIndex = 10;
            this.chbPassword.Text = "记住密码";
            this.chbPassword.UseVisualStyleBackColor = false;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton1.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton1.DownBack = null;
            this.skinButton1.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton1.Location = new System.Drawing.Point(67, 118);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(111, 23);
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
            this.txtPassword.IsPasswordChat = '●';
            this.txtPassword.IsSystemPasswordChar = true;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(67, 59);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtPassword.MouseBack = null;
            this.txtPassword.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NormlBack = null;
            this.txtPassword.Padding = new System.Windows.Forms.Padding(5);
            this.txtPassword.ReadOnly = false;
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txtPassword.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtPassword.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtPassword.SkinTxt.Name = "BaseText";
            this.txtPassword.SkinTxt.PasswordChar = '●';
            this.txtPassword.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.txtPassword.SkinTxt.TabIndex = 0;
            this.txtPassword.SkinTxt.UseSystemPasswordChar = true;
            this.txtPassword.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPassword.SkinTxt.WaterText = "";
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPassword.WaterText = "";
            this.txtPassword.WordWrap = true;
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.skinButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Caijiqi.Properties.Resources.main_7;
            this.ClientSize = new System.Drawing.Size(330, 255);
            this.CloseDownBack = global::Caijiqi.Properties.Resources.btn_close_down1;
            this.CloseMouseBack = global::Caijiqi.Properties.Resources.btn_close_down;
            this.CloseNormlBack = global::Caijiqi.Properties.Resources.btn_close_highlight;
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MiniDownBack = global::Caijiqi.Properties.Resources.btn_mini_down;
            this.MiniMouseBack = global::Caijiqi.Properties.Resources.btn_mini_down;
            this.MiniNormlBack = global::Caijiqi.Properties.Resources.btn_mini_highlight;
            this.Name = "FrmLogin";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.Shown += new System.EventHandler(this.FrmLogin_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinTextBox txtPassword;
        private CCWin.SkinControl.SkinCheckBox chbPassword;
        private CCWin.SkinControl.SkinCheckBox chbLogin;
        private CCWin.SkinControl.SkinComboBox skinComboBox1;
    }
}