using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using CSharpWin;

namespace MT_WMS.Win.ControlLibrary.Forms
{
    public partial class BaseFrm : DialogSkinForm
    {
        public BaseFrm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体开启双缓冲
        /// </summary>
        /// <param name="f"></param>
        public virtual void OpenFormDoubleBuffering(BaseFrm f)
        {
            f.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            f.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        /// <summary>
        /// DataGridView开启双缓存
        /// </summary>
        /// <param name="dataGrid"></param>
        public virtual void OpenDataGridViewDoubleBuffer(DataGridView dataGrid)
        {
            //设置窗体的双缓冲          
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            //利用反射设置DataGridView的双缓冲          
            Type dgvType = dataGrid.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dataGrid, true, null);
        }

        /// <summary>
        /// 退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        /// <summary>
        /// 点击控件移动鼠标，窗体跟着移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void Control_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
