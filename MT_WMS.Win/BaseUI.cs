using MT_WMS.Win.ControlLibrary.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MT_WMS.Win
{
    public partial class BaseUI : BaseFrm
    {

        public BaseUI()
        {
            InitializeComponent();
        }

        #region 遮挡体
        /// <summary>
        /// 遮挡层
        /// </summary>
        FrmMask Mask;
        /// <summary>
        /// 遮挡默认窗体
        /// </summary>
        public virtual void ShowMask()
        {
            if (Mask == null || Mask.IsDisposed)
            {
                ShowMask(this.Location, this.Size);
            }
        }
        /// <summary>
        /// 遮挡指定窗体
        /// </summary>
        /// <param name="bf"></param>
        public virtual void ShowMask(BaseFrm bf)
        {
            ShowMask(bf.Location, bf.Size);
        }
        /// <summary>
        /// 遮挡指定位置指定大小
        /// </summary>
        /// <param name="point">指定坐标</param>
        /// <param name="size">指定位置</param>
        public virtual void ShowMask(Point point, Size size)
        {
            if (Mask == null || Mask.IsDisposed)
            {
                Mask = new FrmMask(point, size);
                Mask.ShowDialog();
            }
            else
            {
                Mask.Size = size;
                Mask.Location = point;
            }
        }
        #endregion


        /// <summary>
        /// 绘制一个矩形渐变图像
        /// </summary>
        /// <param name="rectangle">矩形</param>
        /// <param name="start">开始颜色</param>
        /// <param name="end">结束颜色</param>
        /// <param name="f">方向角度 0-360 f</param>
        public virtual Bitmap GetBitmap(Rectangle rectangle, Color start, Color end, float f)
        {
            try
            {
                Bitmap bmp = new Bitmap(rectangle.Width, rectangle.Height);
                Graphics g;
                g = Graphics.FromImage(bmp);
                LinearGradientBrush br = new LinearGradientBrush(rectangle, start, end, f);
                g.FillRectangle(br, rectangle);
                GC.Collect();
                return bmp;
            }
            catch (Exception)
            {
                GC.Collect();
                return null;
            }

        }
        /// <summary>
        /// 最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void Min_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else
                WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// 最大化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void Max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowMask();
        }
    }
}
