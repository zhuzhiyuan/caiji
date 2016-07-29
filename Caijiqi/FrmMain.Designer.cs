/********************************************************************
 * *
 * * 使本项目源码或本项目生成的DLL前请仔细阅读以下协议内容，如果你同意以下协议才能使用本项目所有的功能，
 * * 否则如果你违反了以下协议，有可能陷入法律纠纷和赔偿，作者保留追究法律责任的权利。
 * *
 * * 1、你可以在开发的软件产品中使用和修改本项目的源码和DLL，但是请保留所有相关的版权信息。
 * * 2、不能将本项目源码与作者的其他项目整合作为一个单独的软件售卖给他人使用。
 * * 3、不能传播本项目的源码和DLL，包括上传到网上、拷贝给他人等方式。
 * * 4、以上协议暂时定制，由于还不完善，作者保留以后修改协议的权利。
 * *
 * * Copyright (C) 2013-? cskin Corporation All rights reserved.
 * * 网站：CSkin界面库 http://www.cskin.net 论坛 http://bbs.cskin.net
 * * 作者： 乔克斯 QQ：345015918 .Net项目技术组群：306485590
 * * 请保留以上版权信息，否则作者将保留追究法律责任。
 * *
 * * 创建时间：2014-08-26
 * * 说明：FrmMain.Designer.cs
 * *
********************************************************************/

namespace Caijiqi
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblTs = new System.Windows.Forms.Label();
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.SkinMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SkinTool1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinTool2 = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinTool3 = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinTool4 = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinTool5 = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinTool6 = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinTool7 = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinTool8 = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinTool9 = new System.Windows.Forms.ToolStripMenuItem();
            this.tool1 = new System.Windows.Forms.ToolStripButton();
            this.tool2 = new System.Windows.Forms.ToolStripButton();
            this.tool3 = new System.Windows.Forms.ToolStripButton();
            this.ToolShow = new System.Windows.Forms.ToolStrip();
            this.tool4 = new System.Windows.Forms.ToolStripButton();
            this.tool5 = new System.Windows.Forms.ToolStripButton();
            this.tool6 = new System.Windows.Forms.ToolStripButton();
            this.SkinToolMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.窗口置顶ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.软件设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timColor = new System.Windows.Forms.Timer(this.components);
            this.tabShow = new Caijiqi.Controls.MultiPagePanel();
            this.SkinMenu.SuspendLayout();
            this.ToolShow.SuspendLayout();
            this.SkinToolMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTs
            // 
            this.lblTs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTs.AutoSize = true;
            this.lblTs.BackColor = System.Drawing.Color.Transparent;
            this.lblTs.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblTs.ForeColor = System.Drawing.Color.White;
            this.lblTs.Location = new System.Drawing.Point(5, 579);
            this.lblTs.Name = "lblTs";
            this.lblTs.Size = new System.Drawing.Size(107, 20);
            this.lblTs.TabIndex = 2;
            this.lblTs.Tag = "当前版本:V4.1.5.0";
            this.lblTs.Text = "当前版本:V1.0.0";
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.miniToolStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.miniToolStrip.Size = new System.Drawing.Size(597, 25);
            this.miniToolStrip.TabIndex = 125;
            // 
            // SkinMenu
            // 
            this.SkinMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SkinTool1,
            this.SkinTool2,
            this.SkinTool3,
            this.SkinTool4,
            this.SkinTool5,
            this.SkinTool6,
            this.SkinTool7,
            this.SkinTool8,
            this.SkinTool9});
            this.SkinMenu.Name = "skinContextMenuStrip1";
            this.SkinMenu.Size = new System.Drawing.Size(125, 202);
            // 
            // SkinTool1
            // 
            this.SkinTool1.Checked = true;
            this.SkinTool1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SkinTool1.Name = "SkinTool1";
            this.SkinTool1.Size = new System.Drawing.Size(124, 22);
            this.SkinTool1.Tag = "0";
            this.SkinTool1.Text = "默认皮肤";
            this.SkinTool1.Click += new System.EventHandler(this.SkinTool_Click);
            // 
            // SkinTool2
            // 
            this.SkinTool2.Name = "SkinTool2";
            this.SkinTool2.Size = new System.Drawing.Size(124, 22);
            this.SkinTool2.Tag = "1";
            this.SkinTool2.Text = "绚彩紫色";
            this.SkinTool2.Click += new System.EventHandler(this.SkinTool_Click);
            // 
            // SkinTool3
            // 
            this.SkinTool3.Name = "SkinTool3";
            this.SkinTool3.Size = new System.Drawing.Size(124, 22);
            this.SkinTool3.Tag = "2";
            this.SkinTool3.Text = "悠然百合";
            this.SkinTool3.Click += new System.EventHandler(this.SkinTool_Click);
            // 
            // SkinTool4
            // 
            this.SkinTool4.Name = "SkinTool4";
            this.SkinTool4.Size = new System.Drawing.Size(124, 22);
            this.SkinTool4.Tag = "3";
            this.SkinTool4.Text = "漫舞派对";
            this.SkinTool4.Click += new System.EventHandler(this.SkinTool_Click);
            // 
            // SkinTool5
            // 
            this.SkinTool5.Name = "SkinTool5";
            this.SkinTool5.Size = new System.Drawing.Size(124, 22);
            this.SkinTool5.Tag = "4";
            this.SkinTool5.Text = "绿化环保";
            this.SkinTool5.Click += new System.EventHandler(this.SkinTool_Click);
            // 
            // SkinTool6
            // 
            this.SkinTool6.Name = "SkinTool6";
            this.SkinTool6.Size = new System.Drawing.Size(124, 22);
            this.SkinTool6.Tag = "5";
            this.SkinTool6.Text = "蔚蓝风车";
            this.SkinTool6.Click += new System.EventHandler(this.SkinTool_Click);
            // 
            // SkinTool7
            // 
            this.SkinTool7.Name = "SkinTool7";
            this.SkinTool7.Size = new System.Drawing.Size(124, 22);
            this.SkinTool7.Tag = "6";
            this.SkinTool7.Text = "固若精钢";
            this.SkinTool7.Click += new System.EventHandler(this.SkinTool_Click);
            // 
            // SkinTool8
            // 
            this.SkinTool8.Name = "SkinTool8";
            this.SkinTool8.Size = new System.Drawing.Size(124, 22);
            this.SkinTool8.Tag = "7";
            this.SkinTool8.Text = "原木韵味";
            this.SkinTool8.Click += new System.EventHandler(this.SkinTool_Click);
            // 
            // SkinTool9
            // 
            this.SkinTool9.Name = "SkinTool9";
            this.SkinTool9.Size = new System.Drawing.Size(124, 22);
            this.SkinTool9.Tag = "8";
            this.SkinTool9.Text = "恭贺新春";
            this.SkinTool9.Click += new System.EventHandler(this.SkinTool_Click);
            // 
            // tool1
            // 
            this.tool1.AutoSize = false;
            this.tool1.Checked = true;
            this.tool1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tool1.ForeColor = System.Drawing.Color.Black;
            this.tool1.Image = global::Caijiqi.Properties.Resources.ToolShow_BackgroundImage_Home;
            this.tool1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tool1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool1.Margin = new System.Windows.Forms.Padding(0);
            this.tool1.MergeIndex = 0;
            this.tool1.Name = "tool1";
            this.tool1.Size = new System.Drawing.Size(60, 50);
            this.tool1.Tag = "";
            this.tool1.Text = "主页";
            this.tool1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tool1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tool2
            // 
            this.tool2.AutoSize = false;
            this.tool2.Image = global::Caijiqi.Properties.Resources.ToolShow_BackgroundImage_Caiji;
            this.tool2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tool2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool2.Margin = new System.Windows.Forms.Padding(0);
            this.tool2.MergeIndex = 1;
            this.tool2.Name = "tool2";
            this.tool2.Size = new System.Drawing.Size(60, 50);
            this.tool2.Tag = "FrmWebSpy";
            this.tool2.Text = "采集器";
            this.tool2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tool3
            // 
            this.tool3.AutoSize = false;
            this.tool3.Image = global::Caijiqi.Properties.Resources.ToolShow_BackgroundImage_Copy;
            this.tool3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tool3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool3.Margin = new System.Windows.Forms.Padding(0);
            this.tool3.MergeIndex = 2;
            this.tool3.Name = "tool3";
            this.tool3.Size = new System.Drawing.Size(60, 50);
            this.tool3.Tag = "FrmBbx";
            this.tool3.Text = "超级复制";
            this.tool3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ToolShow
            // 
            this.ToolShow.AutoSize = false;
            this.ToolShow.BackColor = System.Drawing.Color.Transparent;
            this.ToolShow.CanOverflow = false;
            this.ToolShow.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolShow.GripMargin = new System.Windows.Forms.Padding(0);
            this.ToolShow.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolShow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool1,
            this.tool2,
            this.tool3,
            this.tool4,
            this.tool5,
            this.tool6});
            this.ToolShow.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ToolShow.Location = new System.Drawing.Point(-2, -2);
            this.ToolShow.Name = "ToolShow";
            this.ToolShow.Padding = new System.Windows.Forms.Padding(0);
            this.ToolShow.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ToolShow.Size = new System.Drawing.Size(905, 87);
            this.ToolShow.Stretch = true;
            this.ToolShow.TabIndex = 1;
            this.ToolShow.Text = "skinToolStrip1";
            this.ToolShow.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolShow_ItemClicked);
            // 
            // tool4
            // 
            this.tool4.AutoSize = false;
            this.tool4.Image = global::Caijiqi.Properties.Resources.ToolShow_BackgroundImage_Caiji;
            this.tool4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tool4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool4.MergeIndex = 3;
            this.tool4.Name = "tool4";
            this.tool4.Size = new System.Drawing.Size(60, 50);
            this.tool4.Tag = "FrmWebBaba";
            this.tool4.Text = "阿里巴巴";
            this.tool4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tool5
            // 
            this.tool5.AutoSize = false;
            this.tool5.Image = global::Caijiqi.Properties.Resources.imgXz;
            this.tool5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tool5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool5.MergeIndex = 4;
            this.tool5.Name = "tool5";
            this.tool5.Size = new System.Drawing.Size(60, 50);
            this.tool5.Tag = "FrmUpdatePassword";
            this.tool5.Text = "修改密码";
            this.tool5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tool6
            // 
            this.tool6.AutoSize = false;
            this.tool6.Image = global::Caijiqi.Properties.Resources.ImgPer;
            this.tool6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tool6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool6.MergeIndex = 5;
            this.tool6.Name = "tool6";
            this.tool6.Size = new System.Drawing.Size(60, 50);
            this.tool6.Tag = "FrmLinkConvert";
            this.tool6.Text = "生成短链";
            this.tool6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SkinToolMenu
            // 
            this.SkinToolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem4,
            this.窗口置顶ToolStripMenuItem,
            this.软件设置ToolStripMenuItem,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.退出ToolStripMenuItem});
            this.SkinToolMenu.Name = "SkinToolMenu";
            this.SkinToolMenu.Size = new System.Drawing.Size(137, 110);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem5.Text = "显示主界面";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(133, 6);
            // 
            // 窗口置顶ToolStripMenuItem
            // 
            this.窗口置顶ToolStripMenuItem.Name = "窗口置顶ToolStripMenuItem";
            this.窗口置顶ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.窗口置顶ToolStripMenuItem.Text = "窗口置顶";
            // 
            // 软件设置ToolStripMenuItem
            // 
            this.软件设置ToolStripMenuItem.Name = "软件设置ToolStripMenuItem";
            this.软件设置ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.软件设置ToolStripMenuItem.Text = "软件设置";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(133, 6);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(133, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // tabShow
            // 
            this.tabShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabShow.CurrentPageIndex = 0;
            this.tabShow.Location = new System.Drawing.Point(-2, 85);
            this.tabShow.Margin = new System.Windows.Forms.Padding(0);
            this.tabShow.Name = "tabShow";
            this.tabShow.Size = new System.Drawing.Size(905, 494);
            this.tabShow.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.tabShow);
            this.Controls.Add(this.lblTs);
            this.Controls.Add(this.ToolShow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(635, 485);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "维达科技 采集器";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmMain_Paint);
            this.SkinMenu.ResumeLayout(false);
            this.ToolShow.ResumeLayout(false);
            this.ToolShow.PerformLayout();
            this.SkinToolMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip miniToolStrip;
        private System.Windows.Forms.ContextMenuStrip SkinMenu;
        private System.Windows.Forms.ToolStripMenuItem SkinTool1;
        private System.Windows.Forms.ToolStripMenuItem SkinTool2;
        private System.Windows.Forms.ToolStripMenuItem SkinTool3;
        private System.Windows.Forms.ToolStripMenuItem SkinTool4;
        private System.Windows.Forms.ToolStripMenuItem SkinTool5;
        private System.Windows.Forms.ToolStripMenuItem SkinTool6;
        private System.Windows.Forms.ToolStripMenuItem SkinTool7;
        private System.Windows.Forms.ToolStripMenuItem SkinTool8;
        private System.Windows.Forms.ToolStripMenuItem SkinTool9;
        private Controls.MultiPagePanel tabShow;
        private System.Windows.Forms.ToolStripButton tool1;
        private System.Windows.Forms.ToolStripButton tool2;
        private System.Windows.Forms.ToolStripButton tool3;
        private System.Windows.Forms.ToolStripButton tool4;
        private System.Windows.Forms.ToolStripButton tool5;
        private System.Windows.Forms.ToolStripButton tool6;
        private System.Windows.Forms.ToolStrip ToolShow;
        private System.Windows.Forms.ContextMenuStrip SkinToolMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 窗口置顶ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 软件设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Timer timColor;
        public System.Windows.Forms.Label lblTs;
    }
}

