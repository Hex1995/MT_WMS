using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MT_WMS.Win.ControlLibrary.Forms
{
    public partial class FrmMask : Form
    {
        public FrmMask(Point point, Size size)
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.Opacity = 0.5;
            this.BackColor = Color.LightGray;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            //位置和大小跟随主界面
            this.Location = point;
            this.Size = size;
        }
        /// <summary>
        /// 释放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMask_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
