
namespace MT_WMS.Win.ControlLibrary.Forms.SYS
{
    partial class FrmPrintSet
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
            this.BtnPrintRefresh = new FontAwesome.Sharp.IconButton();
            this.BtnPrintSave = new FontAwesome.Sharp.IconButton();
            this.TxtPrintNow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TrvPrintList = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnPrintRefresh);
            this.panel1.Controls.Add(this.BtnPrintSave);
            this.panel1.Controls.Add(this.TxtPrintNow);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 58);
            this.panel1.TabIndex = 0;
            // 
            // BtnPrintRefresh
            // 
            this.BtnPrintRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrintRefresh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnPrintRefresh.IconColor = System.Drawing.Color.Black;
            this.BtnPrintRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPrintRefresh.Location = new System.Drawing.Point(584, 13);
            this.BtnPrintRefresh.Name = "BtnPrintRefresh";
            this.BtnPrintRefresh.Size = new System.Drawing.Size(110, 31);
            this.BtnPrintRefresh.TabIndex = 3;
            this.BtnPrintRefresh.Text = "刷新打印机列表";
            this.BtnPrintRefresh.UseVisualStyleBackColor = true;
            this.BtnPrintRefresh.Click += new System.EventHandler(this.BtnPrintRefresh_Click);
            // 
            // BtnPrintSave
            // 
            this.BtnPrintSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrintSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnPrintSave.IconColor = System.Drawing.Color.Black;
            this.BtnPrintSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPrintSave.Location = new System.Drawing.Point(458, 13);
            this.BtnPrintSave.Name = "BtnPrintSave";
            this.BtnPrintSave.Size = new System.Drawing.Size(110, 31);
            this.BtnPrintSave.TabIndex = 2;
            this.BtnPrintSave.Text = "设置当前打印机";
            this.BtnPrintSave.UseVisualStyleBackColor = true;
            // 
            // TxtPrintNow
            // 
            this.TxtPrintNow.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtPrintNow.Location = new System.Drawing.Point(147, 13);
            this.TxtPrintNow.Name = "TxtPrintNow";
            this.TxtPrintNow.ReadOnly = true;
            this.TxtPrintNow.Size = new System.Drawing.Size(305, 31);
            this.TxtPrintNow.TabIndex = 1;
            this.TxtPrintNow.Text = "Microsoft Print to PDF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前打印机：";
            // 
            // TrvPrintList
            // 
            this.TrvPrintList.CheckBoxes = true;
            this.TrvPrintList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrvPrintList.Location = new System.Drawing.Point(3, 84);
            this.TrvPrintList.Name = "TrvPrintList";
            this.TrvPrintList.Size = new System.Drawing.Size(794, 313);
            this.TrvPrintList.TabIndex = 9;
            // 
            // FrmPrintSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.TrvPrintList);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPrintSet";
            this.Text = "打印机设置";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView TrvPrintList;
        private FontAwesome.Sharp.IconButton BtnPrintSave;
        private System.Windows.Forms.TextBox TxtPrintNow;
        private FontAwesome.Sharp.IconButton BtnPrintRefresh;
    }
}