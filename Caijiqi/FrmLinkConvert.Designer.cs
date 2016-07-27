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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rTxtBefore = new CCWin.SkinControl.RtfRichTextBox();
            this.btnConvert = new CCWin.SkinControl.SkinButton();
            this.btnClear = new CCWin.SkinControl.SkinButton();
            this.btnPaste = new CCWin.SkinControl.SkinButton();
            this.skinDataGridView4 = new CCWin.SkinControl.SkinDataGridView();
            this.Link = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Url = new System.Windows.Forms.DataGridViewLinkColumn();
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
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.skinDataGridView4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.skinDataGridView4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinDataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.skinDataGridView4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.skinDataGridView4.BackgroundColor = System.Drawing.SystemColors.Window;
            this.skinDataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinDataGridView4.ColumnFont = null;
            this.skinDataGridView4.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skinDataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.skinDataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skinDataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Link,
            this.Url});
            this.skinDataGridView4.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.skinDataGridView4.DefaultCellStyle = dataGridViewCellStyle18;
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
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skinDataGridView4.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.skinDataGridView4.RowHeadersVisible = false;
            this.skinDataGridView4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView4.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.skinDataGridView4.RowTemplate.Height = 23;
            this.skinDataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.skinDataGridView4.Size = new System.Drawing.Size(607, 227);
            this.skinDataGridView4.SkinGridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.skinDataGridView4.TabIndex = 181;
            this.skinDataGridView4.TitleBack = null;
            this.skinDataGridView4.TitleBackColorBegin = System.Drawing.Color.White;
            this.skinDataGridView4.TitleBackColorEnd = System.Drawing.SystemColors.Control;
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
            // FrmLinkConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 549);
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
        private System.Windows.Forms.DataGridViewLinkColumn Link;
        private System.Windows.Forms.DataGridViewLinkColumn Url;
    }
}