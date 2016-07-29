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
 * * 说明：FrmWebSpy.cs
 * *
********************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Caijiqi
{
    delegate void AddDataGridRowInvoke(DataGridView gridView,Label txtTotal, object[] row);
    public partial class FrmWebSpy : Form
    {
        private static List<string> filterKeys = new List<string>();

        public FrmWebSpy() {
            InitializeComponent();
            SetStyles();
            InitComBoxData();
        }
        #region 减少闪烁
        //减少闪烁
        private void SetStyles() {
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

        private void InitComBoxData()
        {
            skinComboBox1.Items.AddRange(new object[]
            {
                "默认排序", "收入比率", "人气", "价格从高到低", "价格从低到高", "月推广量", "", "月支出佣金", "", "销量"
            });
            skinComboBox1.SelectedIndex = 0;
        }


        private void btnCaiji_Click(object sender, EventArgs e)
        {
            if (filterKeys.Count == 0&&chbFilter.Checked)
            {
                string keys = Business.Common.GetJson(Business.Common.AuthUrl + "key/getKeys", Encoding.UTF8);
                filterKeys.AddRange(JsonConvert.DeserializeObject<IEnumerable<string>>(keys));
            }
            string key = skinTextBox1.Text;
           
            List<string> param = new List<string>()
            {
                "q=" + System.Web.HttpUtility.UrlEncode(key),
                "sortType=" + skinComboBox1.SelectedIndex,
                "perPageSize=40"
            };
            if (skinCheckBox1.Checked)
            {
                param.Add("hPayRate30=1");
            }
            if (skinCheckBox2.Checked)
            {
                param.Add("b2c=1");
            }
            if (!string.IsNullOrEmpty(startBiz30day.Text))
            {
                param.Add("startBiz30day=" + startBiz30day.Text);
            }
            if (!string.IsNullOrEmpty(startTkRate.Text))
            {
                param.Add("startTkRate=" + startTkRate.Text);
            }

            if (!string.IsNullOrEmpty(startPrice.Text))
            {
                param.Add("startPrice=" + startPrice.Text);
            }
            if (!string.IsNullOrEmpty(endPrice.Text))
            {
                param.Add("endPrice=" + endPrice.Text);
            }
            int page = !string.IsNullOrEmpty(pageSize.Text) ? int.Parse(pageSize.Text) : 1;
            string url = "http://pub.alimama.com/items/search.json?queryType=0&auctionTag=&shopTag=&_tb_token_=test&";
            int m = !string.IsNullOrEmpty(month.Text) ? int.Parse(month.Text) : 0;
            skinDataGridView4.Rows.Clear();
            ThreadPool.QueueUserWorkItem(delegate(object state)
            {
                string getUrl;
                for (int i = 0; i < page; i++)
                {
                    string time = (DateTime.Now.Ticks/1000).ToString();
                    getUrl = url + string.Join("&", param.ToArray()) + "&toPage=" + (i + 1) + "&_t=" +DateTime.Now.Ticks/1000+
                             "&t=" + time +
                             "&pvid=10_" + Business.Common.IP + "_403_"+ DateTime.Now.Ticks / 1000;
                    string response = Business.Common.GetJson(getUrl, Encoding.UTF8);
                    JObject json = JsonConvert.DeserializeObject<JObject>(response);

                    JArray pageList = (json["data"] as JObject)["pageList"] as JArray;

                    foreach (JObject item in pageList)
                    {
                        int totalNum = 0;
                        int.TryParse(item["totalNum"].ToString(), out totalNum);
                        if (totalNum > m)
                        {
                            string title = item["title"].ToString();
                            string strText = System.Text.RegularExpressions.Regex.Replace(title, "<[^>]+>", "");
                            strText = System.Text.RegularExpressions.Regex.Replace(strText, "&[^;]+;", "");
                            if (chbFilter.Checked)
                            {
                                var next = true;
                                foreach (var filterKey in filterKeys)
                                {
                                    if (strText.Contains(filterKey))
                                    {
                                        next = false;
                                        break;
                                    }
                                }
                                if (!next) continue;
                            }
                            AddDataGridRow(skinDataGridView4, txtTotal, new object[]
                            {
                                strText,
                                (double.Parse(item["zkPrice"].ToString())/double.Parse(item["reservePrice"].ToString())*
                                 10).ToString("0.0"),
                                item["zkPrice"].ToString(),
                                item["tkRate"].ToString() + "%",
                                item["tkCommFee"].ToString(),
                                item["totalNum"].ToString(),
                                item["totalFee"].ToString(),
                                item["auctionUrl"].ToString(),
                                item["nick"].ToString()
                            });
                        }
                        
                    }
                    Thread.Sleep(1000);
                }
                AddDataGridRow(skinDataGridView4, txtTotal, null);
                MessageBox.Show("采集完成");
            });
        }

        private void AddDataGridRow(DataGridView gridView,Label txtTotal, object[] row)
        {
            if (gridView.InvokeRequired)
            {
                AddDataGridRowInvoke invoke = AddDataGridRow;
                gridView.Invoke(invoke, new object[] {gridView, txtTotal, row});
            }
            else
            {
                if (row == null)
                {
                    txtTotal.Text = "采集完成 ， 采集到" + gridView.Rows.Count + "条结果";
                }
                else
                {
                    gridView.Rows.Add(row);
                    txtTotal.Text = "正在采集 ， 已经采集到" + gridView.Rows.Count + "条结果";
                }
                
            }
        }

        private void Number_SkinTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void skinDataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell is DataGridViewLinkCell)
            {
                System.Diagnostics.Process.Start(cell.Value.ToString());
            }
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "请选择要导出到的文件夹";
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                int rows = skinDataGridView4.Rows.Count;
                int rowIndex = 0;
                while (rowIndex < rows)
                {
                    string folderPath = folderDialog.SelectedPath;
                    string fileName = @"\维达科技-采集结果";
                    int index = 0;
                    string outputFileName = folderPath + fileName + ".txt";
                    while (File.Exists(outputFileName))
                    {
                        index++;
                        outputFileName = folderPath + fileName + "(" + index + ").txt";
                    }
                    FileStream fs = File.Create(fileName);
                    fs.Close();
                    fs.Dispose();
                    
                        using (
                       System.IO.StreamWriter sw = new System.IO.StreamWriter(outputFileName, true,
                           System.Text.Encoding.GetEncoding("utf-8")))
                        {
                            int outputSize = int.Parse(txtOutPutSize.Text);
                            for (var i = 0; rowIndex < rows && i < outputSize; rowIndex++,i++)
                            {
                                sw.WriteLine(skinDataGridView4.Rows[rowIndex].Cells["Url"].Value);
                            }
                        }
                   
                    MessageBox.Show("导出完毕");
                    System.Diagnostics.Process.Start(outputFileName);
                }

            }

        }
    }
}
