
namespace MT_WMS.Win.ControlLibrary.Controls.MT.Print
{
    partial class FrmHistoryPrint
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StartTime = new HZH_Controls.Controls.UCDatePickerExt();
            this.BtnQuery = new FontAwesome.Sharp.IconButton();
            this.EndTime = new HZH_Controls.Controls.UCDatePickerExt();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnPrint = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvLs = new System.Windows.Forms.DataGridView();
            this.PId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MixDegree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jzl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLs)).BeginInit();
            this.SuspendLayout();
            // 
            // StartTime
            // 
            this.StartTime.BackColor = System.Drawing.Color.White;
            this.StartTime.ConerRadius = 5;
            this.StartTime.CurrentTime = new System.DateTime(2021, 1, 9, 11, 49, 50, 0);
            this.StartTime.FillColor = System.Drawing.Color.Transparent;
            this.StartTime.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StartTime.IsRadius = true;
            this.StartTime.IsShowRect = true;
            this.StartTime.Location = new System.Drawing.Point(94, 27);
            this.StartTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartTime.Name = "StartTime";
            this.StartTime.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.StartTime.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.StartTime.RectWidth = 1;
            this.StartTime.Size = new System.Drawing.Size(339, 45);
            this.StartTime.TabIndex = 0;
            this.StartTime.TimeFontSize = 20;
            this.StartTime.TimeType = HZH_Controls.Controls.DateTimePickerType.DateTime;
            // 
            // BtnQuery
            // 
            this.BtnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuery.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnQuery.IconColor = System.Drawing.Color.Black;
            this.BtnQuery.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnQuery.Location = new System.Drawing.Point(787, 27);
            this.BtnQuery.Name = "BtnQuery";
            this.BtnQuery.Size = new System.Drawing.Size(98, 45);
            this.BtnQuery.TabIndex = 32;
            this.BtnQuery.Text = "查询";
            this.BtnQuery.UseVisualStyleBackColor = true;
            this.BtnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // EndTime
            // 
            this.EndTime.BackColor = System.Drawing.Color.White;
            this.EndTime.ConerRadius = 5;
            this.EndTime.CurrentTime = new System.DateTime(2021, 1, 9, 11, 49, 50, 0);
            this.EndTime.FillColor = System.Drawing.Color.Transparent;
            this.EndTime.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EndTime.IsRadius = true;
            this.EndTime.IsShowRect = true;
            this.EndTime.Location = new System.Drawing.Point(441, 27);
            this.EndTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EndTime.Name = "EndTime";
            this.EndTime.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.EndTime.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.EndTime.RectWidth = 1;
            this.EndTime.Size = new System.Drawing.Size(339, 45);
            this.EndTime.TabIndex = 10;
            this.EndTime.TimeFontSize = 20;
            this.EndTime.TimeType = HZH_Controls.Controls.DateTimePickerType.DateTime;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnPrint);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.StartTime);
            this.panel1.Controls.Add(this.EndTime);
            this.panel1.Controls.Add(this.BtnQuery);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 100);
            this.panel1.TabIndex = 33;
            // 
            // BtnPrint
            // 
            this.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrint.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnPrint.IconColor = System.Drawing.Color.Black;
            this.BtnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPrint.Location = new System.Drawing.Point(927, 27);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(98, 45);
            this.BtnPrint.TabIndex = 34;
            this.BtnPrint.Text = "打印";
            this.BtnPrint.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 33;
            this.label1.Text = "起-止：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgvLs);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1239, 673);
            this.panel2.TabIndex = 34;
            // 
            // DgvLs
            // 
            this.DgvLs.AllowUserToAddRows = false;
            this.DgvLs.AllowUserToDeleteRows = false;
            this.DgvLs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvLs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(238)))), ((int)(((byte)(248)))));
            this.DgvLs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvLs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PId,
            this.tm,
            this.Team,
            this.pm,
            this.gg,
            this.MixDegree,
            this.quality,
            this.zl,
            this.jzl});
            this.DgvLs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvLs.GridColor = System.Drawing.Color.MediumSpringGreen;
            this.DgvLs.Location = new System.Drawing.Point(0, 0);
            this.DgvLs.Name = "DgvLs";
            this.DgvLs.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvLs.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvLs.RowTemplate.Height = 23;
            this.DgvLs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLs.Size = new System.Drawing.Size(1239, 673);
            this.DgvLs.TabIndex = 32;
            // 
            // PId
            // 
            this.PId.DataPropertyName = "ProductId";
            this.PId.HeaderText = "物料编号";
            this.PId.Name = "PId";
            this.PId.ReadOnly = true;
            // 
            // tm
            // 
            this.tm.DataPropertyName = "ProductSN";
            this.tm.HeaderText = "条码";
            this.tm.Name = "tm";
            this.tm.ReadOnly = true;
            // 
            // Team
            // 
            this.Team.DataPropertyName = "Team";
            this.Team.HeaderText = "班组";
            this.Team.Name = "Team";
            this.Team.ReadOnly = true;
            // 
            // pm
            // 
            this.pm.DataPropertyName = "ProductName";
            this.pm.HeaderText = "品名";
            this.pm.Name = "pm";
            this.pm.ReadOnly = true;
            // 
            // gg
            // 
            this.gg.DataPropertyName = "ProductSpec";
            this.gg.HeaderText = "规格";
            this.gg.Name = "gg";
            this.gg.ReadOnly = true;
            // 
            // MixDegree
            // 
            this.MixDegree.DataPropertyName = "MixDegree";
            this.MixDegree.HeaderText = "合金度";
            this.MixDegree.Name = "MixDegree";
            this.MixDegree.ReadOnly = true;
            // 
            // quality
            // 
            this.quality.DataPropertyName = "Quality";
            this.quality.HeaderText = "质检";
            this.quality.Name = "quality";
            this.quality.ReadOnly = true;
            // 
            // zl
            // 
            this.zl.DataPropertyName = "GroWeight";
            this.zl.HeaderText = "毛重";
            this.zl.Name = "zl";
            this.zl.ReadOnly = true;
            // 
            // jzl
            // 
            this.jzl.DataPropertyName = "Num";
            this.jzl.HeaderText = "净重";
            this.jzl.Name = "jzl";
            this.jzl.ReadOnly = true;
            // 
            // FrmHistoryPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 802);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmHistoryPrint";
            this.Text = "历史补打";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCDatePickerExt StartTime;
        private FontAwesome.Sharp.IconButton BtnQuery;
        private HZH_Controls.Controls.UCDatePickerExt EndTime;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton BtnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgvLs;
        private System.Windows.Forms.DataGridViewTextBoxColumn PId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team;
        private System.Windows.Forms.DataGridViewTextBoxColumn pm;
        private System.Windows.Forms.DataGridViewTextBoxColumn gg;
        private System.Windows.Forms.DataGridViewTextBoxColumn MixDegree;
        private System.Windows.Forms.DataGridViewTextBoxColumn quality;
        private System.Windows.Forms.DataGridViewTextBoxColumn zl;
        private System.Windows.Forms.DataGridViewTextBoxColumn jzl;
    }
}