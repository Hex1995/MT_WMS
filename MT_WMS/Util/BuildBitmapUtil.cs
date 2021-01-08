using MT_WMS.Entitys;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_WMS
{
    /// <summary>
    /// 构建Bitmap
    /// 有明泰条码打印相关的图像构造方法
    /// | 换算一下计量单位，将其换算成厘米  |
    /// |    厘米     像素     英寸         |
    /// |     1        38     0.395         |
    /// |   0.026       1      0.01         |
    /// |    2.54      96        1          |
    /// \* = = = = = = = = = = = = = = = = */
    /// </summary>
    public class BuildBitmapUtil
    {
        /// <summary>
        /// 打印普通的标签
        /// </summary>
        /// <param name="data">打印数据</param>
        /// <returns></returns>
        public static Bitmap MTLabel(ProductLabelRecord data)
        {
            //二维码
            var qrcode = data.ProductSN.ToQrCode();

            return null;
        }



    }
}
