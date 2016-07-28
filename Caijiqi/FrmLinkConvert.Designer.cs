namespace Caijiqi
{
    partial class FrmLinkConvert
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rTxtBefore = new CCWin.SkinControl.RtfRichTextBox();
            this.btnConvert = new CCWin.SkinControl.SkinButton();
            this.btnClear = new CCWin.SkinControl.SkinButton();
            this.btnPaste = new CCWin.SkinControl.SkinButton();
            this.skinDataGridView4 = new CCWin.SkinControl.SkinDataGridView();
            this.lName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zkRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zkPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commissionRatePercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Url = new System.Windows.Forms.DataGridViewLinkColumn();
            this.scbTuiGuang = new CCWin.SkinControl.SkinComboBox();
            this.btnCopy = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // rTxtBefore
            // 
            this.rTxtBefore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTxtBefore.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.rTxtBefore.Location = new System.Drawing.Point(21, 26);
            this.rTxtBefore.Name = "rTxtBefore";
            this.rTxtBefore.Size = new System.Drawing.Size(607, 179);
            this.rTxtBefore.TabIndex = 0;
            this.rTxtBefore.Text = "";
            this.rTxtBefore.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.Transparent;
            this.btnConvert.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnConvert.DownBack = null;
            this.btnConvert.Location = new System.Drawing.Point(356, 222);
            this.btnConvert.MouseBack = null;
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.NormlBack = null;
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "转换";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnClear.DownBack = null;
            this.btnClear.Location = new System.Drawing.Point(154, 222);
            this.btnClear.MouseBack = null;
            this.btnClear.Name = "btnClear";
            this.btnClear.NormlBack = null;
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.BackColor = System.Drawing.Color.Transparent;
            this.btnPaste.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnPaste.DownBack = null;
            this.btnPaste.Location = new System.Drawing.Point(251, 222);
            this.btnPaste.MouseBack = null;
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.NormlBack = null;
            this.btnPaste.Size = new System.Drawing.Size(75, 23);
            this.btnPaste.TabIndex = 4;
            this.btnPaste.Text = "粘贴";
            this.btnPaste.UseVisualStyleBackColor = false;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // skinDataGridView4
            // 
            this.skinDataGridView4.AllowUserToDeleteRows = false;
            this.skinDataGridView4.AllowUserToOrderColumns = true;
            this.skinDataGridView4.AlternatingCellBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            this.skinDataGridView4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.skinDataGridView4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinDataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.skinDataGridView4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.skinDataGridView4.BackgroundColor = System.Drawing.SystemColors.Window;
            this.skinDataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinDataGridView4.ColumnFont = null;
            this.skinDataGridView4.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skinDataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.skinDataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skinDataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lName,
            this.zkRate,
            this.zkPrice,
            this.commissionRatePercent,
            this.calCommission,
            this.totalNum,
            this.totalFee,
            this.Link,
            this.Url});
            this.skinDataGridView4.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.skinDataGridView4.DefaultCellStyle = dataGridViewCellStyle23;
            this.skinDataGridView4.EnableHeadersVisualStyles = false;
            this.skinDataGridView4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinDataGridView4.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.skinDataGridView4.HeadFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinDataGridView4.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView4.Location = new System.Drawing.Point(21, 282);
            this.skinDataGridView4.Margin = new System.Windows.Forms.Padding(10);
            this.skinDataGridView4.MouseCellBackColor = System.Drawing.Color.White;
            this.skinDataGridView4.MultiSelect = false;
            this.skinDataGridView4.Name = "skinDataGridView4";
            this.skinDataGridView4.ReadOnly = true;
            this.skinDataGridView4.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skinDataGridView4.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.skinDataGridView4.RowHeadersVisible = false;
            this.skinDataGridView4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView4.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.skinDataGridView4.RowTemplate.Height = 23;
            this.skinDataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.skinDataGridView4.Size = new System.Drawing.Size(607, 227);
            this.skinDataGridView4.SkinGridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.skinDataGridView4.TabIndex = 181;
            this.skinDataGridView4.TitleBack = null;
            this.skinDataGridView4.TitleBackColorBegin = System.Drawing.Color.White;
            this.skinDataGridView4.TitleBackColorEnd = System.Drawing.SystemColors.Control;
            this.skinDataGridView4.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.skinDataGridView4_CellClick);
            // 
            // lName
            // 
            this.lName.HeaderText = "商品名称";
            this.lName.Name = "lName";
            this.lName.ReadOnly = true;
            // 
            // zkRate
            // 
            this.zkRate.HeaderText = "折扣";
            this.zkRate.Name = "zkRate";
            this.zkRate.ReadOnly = true;
            // 
            // zkPrice
            // 
            this.zkPrice.HeaderText = "单价";
            this.zkPrice.Name = "zkPrice";
            this.zkPrice.ReadOnly = true;
            // 
            // commissionRatePercent
            // 
            this.commissionRatePercent.HeaderText = "收入比率";
            this.commissionRatePercent.Name = "commissionRatePercent";
            this.commissionRatePercent.ReadOnly = true;
            // 
            // calCommission
            // 
            this.calCommission.HeaderText = "佣金";
            this.calCommission.Name = "calCommission";
            this.calCommission.ReadOnly = true;
            // 
            // totalNum
            // 
            this.totalNum.HeaderText = "30天推广量";
            this.totalNum.Name = "totalNum";
            this.totalNum.ReadOnly = true;
            // 
            // totalFee
            // 
            this.totalFee.HeaderText = "30天支出佣金";
            this.totalFee.Name = "totalFee";
            this.totalFee.ReadOnly = true;
            // 
            // Link
            // 
            this.Link.HeaderText = "原链接";
            this.Link.Name = "Link";
            this.Link.ReadOnly = true;
            this.Link.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Link.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Url
            // 
            this.Url.HeaderText = "短链";
            this.Url.Name = "Url";
            this.Url.ReadOnly = true;
            this.Url.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Url.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // scbTuiGuang
            // 
            this.scbTuiGuang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.scbTuiGuang.FormattingEnabled = true;
            this.scbTuiGuang.Location = new System.Drawing.Point(21, 222);
            this.scbTuiGuang.Name = "scbTuiGuang";
            this.scbTuiGuang.Size = new System.Drawing.Size(121, 22);
            this.scbTuiGuang.TabIndex = 182;
            this.scbTuiGuang.WaterText = "";
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.Transparent;
            this.btnCopy.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCopy.DownBack = null;
            this.btnCopy.Location = new System.Drawing.Point(470, 222);
            this.btnCopy.MouseBack = null;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.NormlBack = null;
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 183;
            this.btnCopy.Text = "复制短链接";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // FrmLinkConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 549);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.scbTuiGuang);
            this.Controls.Add(this.skinDataGridView4);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.rTxtBefore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLinkConvert";
            this.Text = "FrmLinkConvert";
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.RtfRichTextBox rTxtBefore;
        private CCWin.SkinControl.SkinButton btnConvert;
        private CCWin.SkinControl.SkinButton btnClear;
        private CCWin.SkinControl.SkinButton btnPaste;
        private CCWin.SkinControl.SkinDataGridView skinDataGridView4;
        private CCWin.SkinControl.SkinComboBox scbTuiGuang;
        private System.Windows.Forms.DataGridViewTextBoxColumn lName;
        private System.Windows.Forms.DataGridViewTextBoxColumn zkRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn zkPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn commissionRatePercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn calCommission;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalFee;
        private System.Windows.Forms.DataGridViewLinkColumn Link;
        private System.Windows.Forms.DataGridViewLinkColumn Url;
        private CCWin.SkinControl.SkinButton btnCopy;
    }
}