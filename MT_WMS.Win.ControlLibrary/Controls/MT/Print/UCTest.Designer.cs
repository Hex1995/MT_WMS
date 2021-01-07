
namespace MT_WMS.Win.ControlLibrary.Controls.MT.Print
{
    partial class UCTest
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnTest = new FontAwesome.Sharp.IconButton();
            this.RicTxt = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnTest
            // 
            this.BtnTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTest.FlatAppearance.BorderSize = 0;
            this.BtnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTest.IconChar = FontAwesome.Sharp.IconChar.MugHot;
            this.BtnTest.IconColor = System.Drawing.Color.Black;
            this.BtnTest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnTest.Location = new System.Drawing.Point(0, 0);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(771, 89);
            this.BtnTest.TabIndex = 0;
            this.BtnTest.Text = "测试";
            this.BtnTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // RicTxt
            // 
            this.RicTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RicTxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.RicTxt.Location = new System.Drawing.Point(0, 89);
            this.RicTxt.Name = "RicTxt";
            this.RicTxt.Size = new System.Drawing.Size(771, 153);
            this.RicTxt.TabIndex = 1;
            this.RicTxt.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(240, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // UCTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RicTxt);
            this.Controls.Add(this.BtnTest);
            this.Name = "UCTest";
            this.Size = new System.Drawing.Size(771, 551);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnTest;
        private System.Windows.Forms.RichTextBox RicTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
