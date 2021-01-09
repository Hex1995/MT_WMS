
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
            this.ucDatePickerExt1 = new HZH_Controls.Controls.UCDatePickerExt();
            this.SuspendLayout();
            // 
            // ucDatePickerExt1
            // 
            this.ucDatePickerExt1.BackColor = System.Drawing.Color.White;
            this.ucDatePickerExt1.ConerRadius = 5;
            this.ucDatePickerExt1.CurrentTime = new System.DateTime(2021, 1, 9, 11, 49, 50, 0);
            this.ucDatePickerExt1.FillColor = System.Drawing.Color.Transparent;
            this.ucDatePickerExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucDatePickerExt1.IsRadius = true;
            this.ucDatePickerExt1.IsShowRect = true;
            this.ucDatePickerExt1.Location = new System.Drawing.Point(106, 40);
            this.ucDatePickerExt1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucDatePickerExt1.Name = "ucDatePickerExt1";
            this.ucDatePickerExt1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.ucDatePickerExt1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ucDatePickerExt1.RectWidth = 1;
            this.ucDatePickerExt1.Size = new System.Drawing.Size(339, 45);
            this.ucDatePickerExt1.TabIndex = 0;
            this.ucDatePickerExt1.TimeFontSize = 20;
            this.ucDatePickerExt1.TimeType = HZH_Controls.Controls.DateTimePickerType.DateTime;
            // 
            // FrmHistoryPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 829);
            this.Controls.Add(this.ucDatePickerExt1);
            this.Name = "FrmHistoryPrint";
            this.Text = "历史补打";
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCDatePickerExt ucDatePickerExt1;
    }
}