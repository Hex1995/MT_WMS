﻿
namespace MT_WMS.Win.OtherForm
{
    partial class FrmLoading
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
            this.Msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Msg
            // 
            this.Msg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Msg.Font = new System.Drawing.Font("宋体", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Msg.Location = new System.Drawing.Point(3, 353);
            this.Msg.Name = "Msg";
            this.Msg.Size = new System.Drawing.Size(627, 24);
            this.Msg.TabIndex = 0;
            this.Msg.Text = "启动中...";
            // 
            // FrmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 380);
            this.Controls.Add(this.Msg);
            this.Name = "FrmLoading";
            this.Text = "基础数据加载...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Msg;
    }
}