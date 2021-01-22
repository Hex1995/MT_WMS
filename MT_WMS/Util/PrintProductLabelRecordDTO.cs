#region
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  Hex 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：LAPTOP-1UF0J9CM
 * 命名空间：MT_WMS.Util
 * 唯一标识：9edb5528-c146-4fa1-b013-a7b39dca0f8f
 * 文件名：PrintProductLabelRecordDTO
 * 当前用户域：LAPTOP-1UF0J9CM
 * 
 * 创建者：52270
 * 微信:hxy15937916521
 * 创建时间：2021/01/22 21:53:39
 * 描述：标签打印传送对象
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

namespace MT_WMS
{
    /// <summary>
    /// 打印对象
    /// </summary>
    public partial class PrintProductLabelRecordDTO
    {
        /// <summary>
        /// 二维码信息
        /// </summary>
        public string QrCode { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string ProjectName { get; set; }
        /// <summary>
        /// 产品型号
        /// </summary>
        public string ProductSpec { get; set; }
        /// <summary>
        /// 品名
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// 批号
        /// </summary>
        public string BatchNumber { get; set; }
        /// <summary>
        /// 物料号
        /// </summary>
        public string ProductId { get; set; }
        /// <summary>
        /// 合金度
        /// </summary>
        public string MixDegree { get; set; }
        /// <summary>
        /// 毛重
        /// </summary>
        public string GroWeight { get; set; }
        /// <summary>
        /// 净重
        /// </summary>
        public string NetWeight { get; set; }
        /// <summary>
        /// 长度
        /// </summary>
        public string Length { get; set; }
        /// <summary>
        /// 包号
        /// </summary>
        public string PackageNumber { get; set; }
        /// <summary>
        /// 车间
        /// </summary>
        public string WorkShop { get; set; }
        /// <summary>
        /// 检验员
        /// </summary>
        public string Quality { get; set; }
        /// <summary>
        /// 日期
        /// 20210122
        /// </summary>
        public string Date { get; set; }
    }
    public partial class PrintProductLabelRecordDTO
    {
        public void PrintModel()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += printDocument_PrintA4Page;
            pd.DefaultPageSettings.PrinterSettings.PrinterName = "Microsoft Print to PDF";       //打印机名称
            pd.PrintController = new System.Drawing.Printing.StandardPrintController();
            pd.Print();
        }
        private void printDocument_PrintA4Page(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            GetBitmapModel(g);
        }
        public void GetBitmapModel(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias; //使绘图质量最高，即消除锯齿
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            Pen pen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(Color.Black);
            FontFamily fontfamily = new FontFamily("宋体");
            Font titlefont = new Font("宋体", 17, FontStyle.Bold);
            Font font = new Font("宋体", 10);
            g.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, 1000, 1000));

            g.DrawString("产品合格证", titlefont, brush, new Rectangle(250, 10, 500, 100));
            g.DrawString("Product  Qualification  Certificate", titlefont, brush, new Rectangle(100, 40, 500, 100));
            g.DrawImage(QrCode.ToQrCode(), new Rectangle(0, 60, 100, 100));
            //第一行
            g.DrawString($"项目名称：{ProjectName}", font, brush, new Rectangle(100, 80, 500, 100));
            g.DrawString($"型号：{this.ProductSpec}", font, brush, new Rectangle(400, 80, 500, 100));
            //第二行
            g.DrawString($"品名：{this.ProductName}", font, brush, new Rectangle(100, 90, 500, 100));
            g.DrawString($"批号：{this.BatchNumber}", font, brush, new Rectangle(400, 90, 500, 100));
            //第三行
            g.DrawString($"物料号：{this.ProductId}", font, brush, new Rectangle(100, 110, 500, 100));
            g.DrawString($"合金状态：{this.MixDegree}", font, brush, new Rectangle(400, 110, 500, 100));
            //第四行
            g.DrawString($"毛重：{this.GroWeight}", font, brush, new Rectangle(100, 130, 500, 100));
            g.DrawString($"净重：{this.NetWeight}", font, brush, new Rectangle(400, 130, 500, 100));
            //第五行
            g.DrawString($"长度：{this.Length}", font, brush, new Rectangle(100, 150, 500, 100));
            g.DrawString($"包号：{this.PackageNumber}", font, brush, new Rectangle(400, 150, 500, 100));
            //第六行
            g.DrawString($"车间：{WorkShop}     检验员：{this.Quality}      日期：{Date}", font, brush, new Rectangle(0, 170, 500, 100));
        }
    }
}
