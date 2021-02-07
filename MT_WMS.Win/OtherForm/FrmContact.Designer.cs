
namespace MT_WMS.Win.OtherForm
{
    partial class FrmContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContact));
            this.picContact = new System.Windows.Forms.PictureBox();
            this.ricMsg = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).BeginInit();
            this.SuspendLayout();
            // 
            // picContact
            // 
            this.picContact.Image = ((System.Drawing.Image)(resources.GetObject("picContact.Image")));
            this.picContact.Location = new System.Drawing.Point(40, 108);
            this.picContact.Name = "picContact";
            this.picContact.Size = new System.Drawing.Size(240, 240);
            this.picContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picContact.TabIndex = 0;
            this.picContact.TabStop = false;
            // 
            // ricMsg
            // 
            this.ricMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.ricMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ricMsg.Location = new System.Drawing.Point(286, 108);
            this.ricMsg.Name = "ricMsg";
            this.ricMsg.Size = new System.Drawing.Size(499, 240);
            this.ricMsg.TabIndex = 1;
            this.ricMsg.Text = "";
            // 
            // FrmContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ricMsg);
            this.Controls.Add(this.picContact);
            this.Name = "FrmContact";
            this.Text = "联系开发商";
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picContact;
        private System.Windows.Forms.RichTextBox ricMsg;
    }
}