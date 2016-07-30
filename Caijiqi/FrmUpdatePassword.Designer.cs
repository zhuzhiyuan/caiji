namespace Caijiqi
{
    partial class FrmUpdatePassword
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
            this.skinButton1 = new System.Windows.Forms.Button();
            this.skinLabel3 = new System.Windows.Forms.Label();
            this.skinLabel2 = new System.Windows.Forms.Label();
            this.skinLabel1 = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewAlignPassword = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.txtNewAlignPassword);
            this.panel1.Controls.Add(this.txtNewPassword);
            this.panel1.Controls.Add(this.txtOldPassword);
            this.panel1.Controls.Add(this.skinButton1);
            this.panel1.Controls.Add(this.skinLabel3);
            this.panel1.Controls.Add(this.skinLabel2);
            this.panel1.Controls.Add(this.skinLabel1);
            this.panel1.Location = new System.Drawing.Point(113, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 290);
            this.panel1.TabIndex = 0;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.Location = new System.Drawing.Point(128, 221);
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.Size = new System.Drawing.Size(75, 23);
            this.skinButton1.TabIndex = 6;
            this.skinButton1.Text = "确认修改";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(27, 166);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(92, 17);
            this.skinLabel3.TabIndex = 5;
            this.skinLabel3.Text = "再次输入新密码";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(75, 111);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(44, 17);
            this.skinLabel2.TabIndex = 3;
            this.skinLabel2.Text = "新密码";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(75, 56);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(44, 17);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "旧密码";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(128, 56);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '*';
            this.txtOldPassword.Size = new System.Drawing.Size(188, 21);
            this.txtOldPassword.TabIndex = 7;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(128, 107);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(188, 21);
            this.txtNewPassword.TabIndex = 8;
            // 
            // txtNewAlignPassword
            // 
            this.txtNewAlignPassword.Location = new System.Drawing.Point(128, 166);
            this.txtNewAlignPassword.Name = "txtNewAlignPassword";
            this.txtNewAlignPassword.PasswordChar = '*';
            this.txtNewAlignPassword.Size = new System.Drawing.Size(188, 21);
            this.txtNewAlignPassword.TabIndex = 9;
            // 
            // FrmUpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 470);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUpdatePassword";
            this.Opacity = 0.1D;
            this.Text = "FrmUpdatePassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label skinLabel1;
        private System.Windows.Forms.Label skinLabel3;
        private System.Windows.Forms.Label skinLabel2;
        private System.Windows.Forms.Button skinButton1;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.TextBox txtNewAlignPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
    }
}