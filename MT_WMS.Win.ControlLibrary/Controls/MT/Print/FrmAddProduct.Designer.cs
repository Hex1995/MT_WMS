
namespace MT_WMS.Win.ControlLibrary.Controls.MT.Print
{
    partial class FrmAddProduct
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
            this.BtnInput = new FontAwesome.Sharp.IconButton();
            this.RibYl = new System.Windows.Forms.RadioButton();
            this.RibCp = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkTrace = new System.Windows.Forms.CheckBox();
            this.BtnExit = new FontAwesome.Sharp.IconButton();
            this.CheckEnable = new System.Windows.Forms.CheckBox();
            this.cbbDw = new System.Windows.Forms.ComboBox();
            this.cbbGg = new System.Windows.Forms.ComboBox();
            this.TxtProductName = new System.Windows.Forms.TextBox();
            this.TxtProductId = new System.Windows.Forms.TextBox();
            this.BtnSave = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnInput
            // 
            this.BtnInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInput.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.BtnInput.IconColor = System.Drawing.Color.Black;
            this.BtnInput.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnInput.IconSize = 32;
            this.BtnInput.Location = new System.Drawing.Point(275, 397);
            this.BtnInput.Name = "BtnInput";
            this.BtnInput.Size = new System.Drawing.Size(124, 45);
            this.BtnInput.TabIndex = 29;
            this.BtnInput.Text = "导入Excel";
            this.BtnInput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInput.UseVisualStyleBackColor = true;
            // 
            // RibYl
            // 
            this.RibYl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RibYl.AutoSize = true;
            this.RibYl.Location = new System.Drawing.Point(258, 290);
            this.RibYl.Name = "RibYl";
            this.RibYl.Size = new System.Drawing.Size(47, 16);
            this.RibYl.TabIndex = 28;
            this.RibYl.Text = "原料";
            this.RibYl.UseVisualStyleBackColor = true;
            // 
            // RibCp
            // 
            this.RibCp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RibCp.AutoSize = true;
            this.RibCp.Checked = true;
            this.RibCp.Location = new System.Drawing.Point(183, 290);
            this.RibCp.Name = "RibCp";
            this.RibCp.Size = new System.Drawing.Size(47, 16);
            this.RibCp.TabIndex = 27;
            this.RibCp.TabStop = true;
            this.RibCp.Text = "产品";
            this.RibCp.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "产品or原料";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "是否追溯";
            // 
            // checkTrace
            // 
            this.checkTrace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkTrace.AutoSize = true;
            this.checkTrace.Checked = true;
            this.checkTrace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkTrace.Location = new System.Drawing.Point(188, 366);
            this.checkTrace.Name = "checkTrace";
            this.checkTrace.Size = new System.Drawing.Size(48, 16);
            this.checkTrace.TabIndex = 24;
            this.checkTrace.Text = "追溯";
            this.checkTrace.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnExit.IconColor = System.Drawing.Color.Black;
            this.BtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExit.IconSize = 32;
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExit.Location = new System.Drawing.Point(3, 472);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(494, 45);
            this.BtnExit.TabIndex = 23;
            this.BtnExit.Text = "取消";
            this.BtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // CheckEnable
            // 
            this.CheckEnable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CheckEnable.AutoSize = true;
            this.CheckEnable.Checked = true;
            this.CheckEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckEnable.Location = new System.Drawing.Point(188, 331);
            this.CheckEnable.Name = "CheckEnable";
            this.CheckEnable.Size = new System.Drawing.Size(48, 16);
            this.CheckEnable.TabIndex = 22;
            this.CheckEnable.Text = "启用";
            this.CheckEnable.UseVisualStyleBackColor = true;
            // 
            // cbbDw
            // 
            this.cbbDw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbDw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDw.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbDw.FormattingEnabled = true;
            this.cbbDw.Location = new System.Drawing.Point(174, 235);
            this.cbbDw.Name = "cbbDw";
            this.cbbDw.Size = new System.Drawing.Size(225, 27);
            this.cbbDw.TabIndex = 21;
            // 
            // cbbGg
            // 
            this.cbbGg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbGg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGg.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbGg.FormattingEnabled = true;
            this.cbbGg.Location = new System.Drawing.Point(174, 184);
            this.cbbGg.Name = "cbbGg";
            this.cbbGg.Size = new System.Drawing.Size(225, 27);
            this.cbbGg.TabIndex = 20;
            // 
            // TxtProductName
            // 
            this.TxtProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtProductName.Location = new System.Drawing.Point(174, 139);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(225, 21);
            this.TxtProductName.TabIndex = 17;
            // 
            // TxtProductId
            // 
            this.TxtProductId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtProductId.Location = new System.Drawing.Point(174, 88);
            this.TxtProductId.Name = "TxtProductId";
            this.TxtProductId.Size = new System.Drawing.Size(225, 21);
            this.TxtProductId.TabIndex = 16;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.IconChar = FontAwesome.Sharp.IconChar.FilePowerpoint;
            this.BtnSave.IconColor = System.Drawing.Color.Black;
            this.BtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSave.IconSize = 32;
            this.BtnSave.Location = new System.Drawing.Point(106, 397);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(124, 45);
            this.BtnSave.TabIndex = 15;
            this.BtnSave.Text = "保存";
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "是否启用";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "产品编号";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "产品单位";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "产品规格";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "产品名称";
            // 
            // FrmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 520);
            this.Controls.Add(this.BtnInput);
            this.Controls.Add(this.RibYl);
            this.Controls.Add(this.RibCp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkTrace);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.CheckEnable);
            this.Controls.Add(this.cbbDw);
            this.Controls.Add(this.cbbGg);
            this.Controls.Add(this.TxtProductName);
            this.Controls.Add(this.TxtProductId);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddProduct";
            this.Text = "新增产品";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton BtnSave;
        private System.Windows.Forms.TextBox TxtProductId;
        private System.Windows.Forms.TextBox TxtProductName;
        private System.Windows.Forms.ComboBox cbbGg;
        private System.Windows.Forms.ComboBox cbbDw;
        private System.Windows.Forms.CheckBox CheckEnable;
        private FontAwesome.Sharp.IconButton BtnExit;
        private System.Windows.Forms.CheckBox checkTrace;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton RibCp;
        private System.Windows.Forms.RadioButton RibYl;
        private FontAwesome.Sharp.IconButton BtnInput;
    }
}