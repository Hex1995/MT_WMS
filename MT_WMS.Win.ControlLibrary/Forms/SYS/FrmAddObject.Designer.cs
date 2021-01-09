
namespace MT_WMS.Win.ControlLibrary.Forms.SYS
{
    partial class FrmAddObject
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TxtObjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAddObject = new FontAwesome.Sharp.IconButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnObjectValueSave = new FontAwesome.Sharp.IconButton();
            this.TxtObjectDescr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbObject = new System.Windows.Forms.ComboBox();
            this.labObjectValue = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(394, 371);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TxtObjectName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.BtnAddObject);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(386, 345);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "对象";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TxtObjectName
            // 
            this.TxtObjectName.Location = new System.Drawing.Point(154, 102);
            this.TxtObjectName.Name = "TxtObjectName";
            this.TxtObjectName.Size = new System.Drawing.Size(174, 21);
            this.TxtObjectName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(78, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "对象名称";
            // 
            // BtnAddObject
            // 
            this.BtnAddObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddObject.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnAddObject.IconColor = System.Drawing.Color.Black;
            this.BtnAddObject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddObject.IconSize = 32;
            this.BtnAddObject.Location = new System.Drawing.Point(154, 168);
            this.BtnAddObject.Name = "BtnAddObject";
            this.BtnAddObject.Size = new System.Drawing.Size(94, 46);
            this.BtnAddObject.TabIndex = 3;
            this.BtnAddObject.Text = "新增";
            this.BtnAddObject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddObject.UseVisualStyleBackColor = true;
            this.BtnAddObject.Click += new System.EventHandler(this.BtnAddObject_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labObjectValue);
            this.tabPage2.Controls.Add(this.BtnObjectValueSave);
            this.tabPage2.Controls.Add(this.TxtObjectDescr);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cbbObject);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(386, 345);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "对象值";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnObjectValueSave
            // 
            this.BtnObjectValueSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnObjectValueSave.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BtnObjectValueSave.IconColor = System.Drawing.Color.Black;
            this.BtnObjectValueSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnObjectValueSave.IconSize = 32;
            this.BtnObjectValueSave.Location = new System.Drawing.Point(163, 260);
            this.BtnObjectValueSave.Name = "BtnObjectValueSave";
            this.BtnObjectValueSave.Size = new System.Drawing.Size(94, 46);
            this.BtnObjectValueSave.TabIndex = 26;
            this.BtnObjectValueSave.Text = "保存";
            this.BtnObjectValueSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnObjectValueSave.UseVisualStyleBackColor = true;
            this.BtnObjectValueSave.Click += new System.EventHandler(this.BtnObjectValueSave_Click);
            // 
            // TxtObjectDescr
            // 
            this.TxtObjectDescr.Location = new System.Drawing.Point(163, 203);
            this.TxtObjectDescr.Name = "TxtObjectDescr";
            this.TxtObjectDescr.Size = new System.Drawing.Size(193, 21);
            this.TxtObjectDescr.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(73, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 23;
            this.label4.Text = "对象描述";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(73, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 22;
            this.label3.Text = "对象值";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(73, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 21;
            this.label2.Text = "对象名称";
            // 
            // cbbObject
            // 
            this.cbbObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbObject.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbObject.FormattingEnabled = true;
            this.cbbObject.Location = new System.Drawing.Point(163, 58);
            this.cbbObject.Name = "cbbObject";
            this.cbbObject.Size = new System.Drawing.Size(193, 27);
            this.cbbObject.TabIndex = 20;
            // 
            // labObjectValue
            // 
            this.labObjectValue.AutoSize = true;
            this.labObjectValue.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labObjectValue.Location = new System.Drawing.Point(160, 140);
            this.labObjectValue.Name = "labObjectValue";
            this.labObjectValue.Size = new System.Drawing.Size(0, 14);
            this.labObjectValue.TabIndex = 27;
            // 
            // FrmAddObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmAddObject";
            this.Text = "增加字典对象";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private FontAwesome.Sharp.IconButton BtnAddObject;
        private System.Windows.Forms.TextBox TxtObjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbObject;
        private FontAwesome.Sharp.IconButton BtnObjectValueSave;
        private System.Windows.Forms.TextBox TxtObjectDescr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labObjectValue;
    }
}