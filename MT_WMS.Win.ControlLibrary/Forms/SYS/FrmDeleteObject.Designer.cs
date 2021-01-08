
namespace MT_WMS.Win.ControlLibrary.Forms.SYS
{
    partial class FrmDeleteObject
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
            this.BtnDeleteObjectValue = new FontAwesome.Sharp.IconButton();
            this.BtnDeleteObject = new FontAwesome.Sharp.IconButton();
            this.BtnRefresh = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.TrvObject = new System.Windows.Forms.TreeView();
            this.TrvObjectValue = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnDeleteObjectValue);
            this.panel1.Controls.Add(this.BtnDeleteObject);
            this.panel1.Controls.Add(this.BtnRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 65);
            this.panel1.TabIndex = 1;
            // 
            // BtnDeleteObjectValue
            // 
            this.BtnDeleteObjectValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDeleteObjectValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteObjectValue.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.BtnDeleteObjectValue.IconColor = System.Drawing.Color.Black;
            this.BtnDeleteObjectValue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDeleteObjectValue.Location = new System.Drawing.Point(501, 6);
            this.BtnDeleteObjectValue.Name = "BtnDeleteObjectValue";
            this.BtnDeleteObjectValue.Size = new System.Drawing.Size(147, 56);
            this.BtnDeleteObjectValue.TabIndex = 2;
            this.BtnDeleteObjectValue.Text = "删除对象值";
            this.BtnDeleteObjectValue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDeleteObjectValue.UseVisualStyleBackColor = true;
            this.BtnDeleteObjectValue.Click += new System.EventHandler(this.BtnDeleteObjectValue_Click);
            // 
            // BtnDeleteObject
            // 
            this.BtnDeleteObject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDeleteObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteObject.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.BtnDeleteObject.IconColor = System.Drawing.Color.Black;
            this.BtnDeleteObject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDeleteObject.Location = new System.Drawing.Point(325, 6);
            this.BtnDeleteObject.Name = "BtnDeleteObject";
            this.BtnDeleteObject.Size = new System.Drawing.Size(147, 56);
            this.BtnDeleteObject.TabIndex = 1;
            this.BtnDeleteObject.Text = "删除对象";
            this.BtnDeleteObject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDeleteObject.UseVisualStyleBackColor = true;
            this.BtnDeleteObject.Click += new System.EventHandler(this.BtnDeleteObject_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.BtnRefresh.IconColor = System.Drawing.Color.Black;
            this.BtnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRefresh.Location = new System.Drawing.Point(149, 6);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(147, 56);
            this.BtnRefresh.TabIndex = 0;
            this.BtnRefresh.Text = "刷新";
            this.BtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TrvObject, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TrvObjectValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(799, 340);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(402, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 30);
            this.label2.TabIndex = 11;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TrvObject
            // 
            this.TrvObject.CheckBoxes = true;
            this.TrvObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrvObject.Location = new System.Drawing.Point(3, 33);
            this.TrvObject.Name = "TrvObject";
            this.TrvObject.Size = new System.Drawing.Size(393, 304);
            this.TrvObject.TabIndex = 8;
            this.TrvObject.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrvObject_AfterSelect);
            this.TrvObject.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TrvObject_NodeMouseClick);
            // 
            // TrvObjectValue
            // 
            this.TrvObjectValue.CheckBoxes = true;
            this.TrvObjectValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrvObjectValue.Location = new System.Drawing.Point(402, 33);
            this.TrvObjectValue.Name = "TrvObjectValue";
            this.TrvObjectValue.Size = new System.Drawing.Size(394, 304);
            this.TrvObjectValue.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "对象";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmDeleteObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 434);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDeleteObject";
            this.Text = "字典删除";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton BtnDeleteObjectValue;
        private FontAwesome.Sharp.IconButton BtnDeleteObject;
        private FontAwesome.Sharp.IconButton BtnRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView TrvObject;
        private System.Windows.Forms.TreeView TrvObjectValue;
        private System.Windows.Forms.Label label1;
    }
}