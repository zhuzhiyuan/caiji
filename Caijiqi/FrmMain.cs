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
 * * 说明：FrmMain.cs
 * *
********************************************************************/

using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Net;

namespace Caijiqi
{
    public partial class FrmMain : Form
    {
        private WebBrowser browser;
        Sunisoft.IrisSkin.SkinEngine se = null;
        public FrmMain() {
            InitializeComponent();
            se = new Sunisoft.IrisSkin.SkinEngine();
            se.SkinAllForm = true;//所有窗体均应用此皮肤
            se.SkinFile = "Wave.ssk";
        }

        #region 窗口加载时
        /// <summary>
        /// 窗口加载时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e) {
            Assembly asb = Assembly.GetExecutingAssembly();//得到当前的程序集
            //存储选中MenuItem
            SelectItem = SkinTool1;
            #region 初始化TabPage内容
            foreach (ToolStripItem page in ToolShow.Items) {
                if (!string.IsNullOrEmpty(page.Tag.ToString())) {
                    object c = asb.CreateInstance("Caijiqi." + page.Tag.ToString(), true);
                    if (c != null)
                    {
                        Form f = (Form) c;
                        f.Dock = DockStyle.Fill;
                        f.TopLevel = false;
                        f.FormBorderStyle = FormBorderStyle.None;
                        f.Show();
                        tabShow.AddPage(f);
                    }
                }
                else
                {
                    browser = new WebBrowser();
                    browser.Dock = DockStyle.Fill;
                    browser.ScriptErrorsSuppressed = true;
                    tabShow.AddPage(browser);
                    browser.Navigate("http://www.alimama.com/member/login.htm");
                    browser.DocumentCompleted += Browser_DocumentCompleted;
                }
            }
            tabShow.CurrentPageIndex = 0;

            #endregion
        }

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Business.LianMengLogin.CookieStr = (sender as WebBrowser).Document.Cookie;
            //loadding.Hide();
        }

        #endregion

        #region 画窗体边框
        /// <summary>
        /// 画窗体边框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Paint(object sender, PaintEventArgs e) {
            //Graphics g = e.Graphics;
            //Pen p = new Pen(Color.FromArgb(33, 40, 46), 2);
            //g.DrawRectangle(p, tabShow.Left, tabShow.Top, tabShow.Width, tabShow.Height);
        }
        #endregion

        #region 换肤菜单
        /// <summary>
        /// 选中的MenuItem
        /// </summary>
        ToolStripMenuItem SelectItem;
        private void SkinTool_Click(object sender, EventArgs e) {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            //选中当前Item
            item.Checked = true;
            //取消选中上一个Item，并存储当前Item
            SelectItem.Checked = false;
            SelectItem = item;
            //如果是0，则是默认皮肤
            if (item.Tag.ToString().Equals("0")) {
                //this.Back = global::Caijiqi.Properties.Resources.main_10;
                
            } else {
                //其他皮肤，从程序集资源中提取，并且设置透明度为不透明
                //this.Back = ImageObject.GetResBitmap(string.Format("Caijiqi.Skin.{0}.jpg", item.Tag));
            }
        }
        #endregion

        #region 自定义系统按钮事件
        //自定义系统按钮事件
        private void FrmMain_SysBottomClick(object sender, CCWin.SkinControl.SysButtonEventArgs e) {
            //获得弹出坐标
            Point l = PointToScreen(e.SysButton.Location);
            l.Y += e.SysButton.Size.Height + 1;
            //如果是皮肤菜单
            if (e.SysButton.Name == "ToolSkin") {
                SkinMenu.Show(l);
            } else if (e.SysButton.Name == "ToolSet") {
                //如果是设置菜单
                SkinToolMenu.Show(l);
            }
        }
        #endregion

        #region Tab切换时事件，用于子窗体更改了提示Lbl后的还原
        private void tabShow_SelectedIndexChanged(object sender, EventArgs e) {
            lblTs.Text = lblTs.Tag.ToString();
            
        }
        #endregion

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ToolShow_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            tabShow.CurrentPageIndex = e.ClickedItem.MergeIndex;
        }
    }
}
