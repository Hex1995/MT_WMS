
namespace MT_WMS.Win.ControlLibrary.Forms.SYS
{
    partial class FrmPreviewObject
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnQuery = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSave = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvObject = new System.Windows.Forms.DataGridView();
            this.PKID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBJECTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBJECTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvObjectValue = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JZOBJECTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBJECTVALUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBJECTDESCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvObjectValue)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtName.Location = new System.Drawing.Point(68, 36);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(211, 26);
            this.TxtName.TabIndex = 8;
            // 
            // BtnQuery
            // 
            this.BtnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuery.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnQuery.IconColor = System.Drawing.Color.Black;
            this.BtnQuery.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnQuery.IconSize = 32;
            this.BtnQuery.Location = new System.Drawing.Point(338, 31);
            this.BtnQuery.Name = "BtnQuery";
            this.BtnQuery.Size = new System.Drawing.Size(114, 37);
            this.BtnQuery.TabIndex = 7;
            this.BtnQuery.Text = "查找";
            this.BtnQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnQuery.UseVisualStyleBackColor = true;
            this.BtnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "键";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.TxtName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnQuery);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 83);
            this.panel1.TabIndex = 9;
            // 
            // BtnSave
            // 
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.IconChar = FontAwesome.Sharp.IconChar.FilePowerpoint;
            this.BtnSave.IconColor = System.Drawing.Color.Black;
            this.BtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSave.IconSize = 32;
            this.BtnSave.Location = new System.Drawing.Point(520, 31);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(114, 37);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "保存当前";
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.85104F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.14896F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DgvObject, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DgvObjectValue, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 109);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 288);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(398, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(393, 47);
            this.label3.TabIndex = 8;
            this.label3.Text = "键信息";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 47);
            this.label2.TabIndex = 7;
            this.label2.Text = "键";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DgvObject
            // 
            this.DgvObject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvObject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PKID,
            this.OBJECTID,
            this.OBJECTNAME});
            this.DgvObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvObject.Location = new System.Drawing.Point(3, 50);
            this.DgvObject.Name = "DgvObject";
            this.DgvObject.RowTemplate.Height = 23;
            this.DgvObject.Size = new System.Drawing.Size(389, 235);
            this.DgvObject.TabIndex = 0;
            this.DgvObject.SelectionChanged += new System.EventHandler(this.DgvObject_SelectionChanged);
            // 
            // PKID
            // 
            this.PKID.DataPropertyName = "PKID";
            this.PKID.HeaderText = "主键";
            this.PKID.Name = "PKID";
            this.PKID.ReadOnly = true;
            this.PKID.Visible = false;
            // 
            // OBJECTID
            // 
            this.OBJECTID.DataPropertyName = "OBJECTID";
            this.OBJECTID.HeaderText = "键编号";
            this.OBJECTID.Name = "OBJECTID";
            this.OBJECTID.ReadOnly = true;
            // 
            // OBJECTNAME
            // 
            this.OBJECTNAME.DataPropertyName = "OBJECTNAME";
            this.OBJECTNAME.HeaderText = "键名称";
            this.OBJECTNAME.Name = "OBJECTNAME";
            // 
            // DgvObjectValue
            // 
            this.DgvObjectValue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvObjectValue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.JZOBJECTID,
            this.OBJECTVALUE,
            this.OBJECTDESCR});
            this.DgvObjectValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvObjectValue.Location = new System.Drawing.Point(398, 50);
            this.DgvObjectValue.Name = "DgvObjectValue";
            this.DgvObjectValue.RowTemplate.Height = 23;
            this.DgvObjectValue.Size = new System.Drawing.Size(393, 235);
            this.DgvObjectValue.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "PKID";
            this.ID.HeaderText = "键值ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // JZOBJECTID
            // 
            this.JZOBJECTID.DataPropertyName = "OBJECTID";
            this.JZOBJECTID.HeaderText = "键编号";
            this.JZOBJECTID.Name = "JZOBJECTID";
            this.JZOBJECTID.ReadOnly = true;
            this.JZOBJECTID.Visible = false;
            // 
            // OBJECTVALUE
            // 
            this.OBJECTVALUE.DataPropertyName = "OBJECTVALUE";
            this.OBJECTVALUE.HeaderText = "键值";
            this.OBJECTVALUE.Name = "OBJECTVALUE";
            this.OBJECTVALUE.ReadOnly = true;
            // 
            // OBJECTDESCR
            // 
            this.OBJECTDESCR.DataPropertyName = "OBJECTDESCR";
            this.OBJECTDESCR.HeaderText = "值描述";
            this.OBJECTDESCR.Name = "OBJECTDESCR";
            // 
            // FrmPreviewObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPreviewObject";
            this.Text = "字典浏览和编辑";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvObjectValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TxtName;
        private FontAwesome.Sharp.IconButton BtnQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvObject;
        private System.Windows.Forms.DataGridView DgvObjectValue;
        private FontAwesome.Sharp.IconButton BtnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn PKID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBJECTID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBJECTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn JZOBJECTID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBJECTVALUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBJECTDESCR;
    }
}