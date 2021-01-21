#region
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  Hex 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：LAPTOP-1UF0J9CM
 * 命名空间：MT_WMS.Util
 * 唯一标识：5da2d95d-37ca-4ad5-b395-2603932b228c
 * 文件名：ProductLabelRecord
 * 当前用户域：LAPTOP-1UF0J9CM
 * 
 * 创建者：52270
 * 微信:hxy15937916521
 * 创建时间：2021/01/21 17:31:49
 * 描述：
 *
 * ----------------------------------------------------------------
 */
#endregion
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MT_WMS.Entitys
{
    /// <summary>
    /// 打印方法
    /// </summary>
    public partial  class ProductLabelRecord
    {
        public void PrintModel()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printDocument_PrintA4Page);
            pd.DefaultPageSettings.PrinterSettings.PrinterName = "Microsoft Print to PDF";       //打印机名称
            pd.PrintController = new System.Drawing.Printing.StandardPrintController();
            pd.Print();
        }
        private void printDocument_PrintA4Page(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(GetBitmapModel(), new Point(0, 0));
        }
        public Bitmap GetBitmapModel()
        {
            Bitmap bit = new Bitmap(1000, 1000);
            Graphics g = Graphics.FromImage(bit);
            g.SmoothingMode = SmoothingMode.AntiAlias; //使绘图质量最高，即消除锯齿
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            Pen pen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(Color.Black);
            FontFamily fontfamily = new FontFamily("宋体");
            Font titlefont = new Font("宋体", 17, FontStyle.Bold);
            Font font = new Font("宋体", 10);
            g.FillRectangle(new SolidBrush(Color.White),new Rectangle(0,0,1000,1000));

            g.DrawString("产品合格证", titlefont, brush, new Rectangle(0, 0, 500, 100));
            g.DrawString("Product  Qualification  Certificate", titlefont, brush, new Rectangle(0, 10, 500, 100));
            g.DrawImage(ProductSN.ToQrCode(), new Rectangle(0, 20, 100, 100));
            g.DrawString($"项目名称：*******             型号：{ProductSpec}", titlefont, brush, new Rectangle(100, 30, 500, 100));
            g.DrawString($"品名：             批号：{BatchId}", titlefont, brush, new Rectangle(100, 50, 500, 100));
            g.DrawString($"物料号：{this.ProductId}             合金状态：{this.MixDegree}", titlefont, brush, new Rectangle(100, 70, 500, 100));
            g.DrawString($"毛重：{this.GroWeight}             净重：{this.Num}", titlefont, brush, new Rectangle(100, 90, 500, 100));
            g.DrawString($"长度：{this.ProductLength}             包号：{this.Num}", titlefont, brush, new Rectangle(100, 110, 500, 100));
            g.DrawString($"车间：**             检验员：{this.QualityId}           日期：{DateTime.Now.ToString("yyyyMMdd")}", titlefont, brush, new Rectangle(0, 120, 500, 100));
            return bit;
        }
    }
}
