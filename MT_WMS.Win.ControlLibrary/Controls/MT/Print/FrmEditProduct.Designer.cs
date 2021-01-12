
namespace MT_WMS.Win.ControlLibrary.Controls.MT.Print
{
    partial class FrmEditProduct
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
            this.cbbDw = new System.Windows.Forms.ComboBox();
            this.cbbGg = new System.Windows.Forms.ComboBox();
            this.TxtProductName = new System.Windows.Forms.TextBox();
            this.TxtProductId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSave = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // cbbDw
            // 
            this.cbbDw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbDw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDw.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbDw.FormattingEnabled = true;
            this.cbbDw.Location = new System.Drawing.Point(169, 249);
            this.cbbDw.Name = "cbbDw";
            this.cbbDw.Size = new System.Drawing.Size(225, 27);
            this.cbbDw.TabIndex = 29;
            // 
            // cbbGg
            // 
            this.cbbGg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbGg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGg.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbGg.FormattingEnabled = true;
            this.cbbGg.Location = new System.Drawing.Point(169, 198);
            this.cbbGg.Name = "cbbGg";
            this.cbbGg.Size = new System.Drawing.Size(225, 27);
            this.cbbGg.TabIndex = 28;
            // 
            // TxtProductName
            // 
            this.TxtProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtProductName.Location = new System.Drawing.Point(169, 153);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(225, 21);
            this.TxtProductName.TabIndex = 27;
            // 
            // TxtProductId
            // 
            this.TxtProductId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtProductId.Location = new System.Drawing.Point(169, 102);
            this.TxtProductId.Name = "TxtProductId";
            this.TxtProductId.Size = new System.Drawing.Size(225, 21);
            this.TxtProductId.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "产品编号";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "产品单位";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "产品规格";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "产品名称";
            // 
            // BtnSave
            // 
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.BtnSave.IconColor = System.Drawing.Color.Black;
            this.BtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSave.IconSize = 32;
            this.BtnSave.Location = new System.Drawing.Point(101, 346);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(124, 45);
            this.BtnSave.TabIndex = 30;
            this.BtnSave.Text = "确认修改";
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.Location = new System.Drawing.Point(261, 346);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(124, 45);
            this.iconButton1.TabIndex = 31;
            this.iconButton1.Text = "取消";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // FrmEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 520);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.cbbDw);
            this.Controls.Add(this.cbbGg);
            this.Controls.Add(this.TxtProductName);
            this.Controls.Add(this.TxtProductId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditProduct";
            this.Text = "编辑产品信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbDw;
        private System.Windows.Forms.ComboBox cbbGg;
        private System.Windows.Forms.TextBox TxtProductName;
        private System.Windows.Forms.TextBox TxtProductId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnSave;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}