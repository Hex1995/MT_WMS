using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_WMS
{
    /// <summary>
    /// 二维码
    /// </summary>
    public class QRCodeHelper
    {
        /// <summary>
        /// 生成白底黑码的二维码
        /// </summary>
        /// <param name="str">字符穿</param>
        /// <param name="level">等级L、M、Q、H</param>
        /// <returns>生成二维码</returns>
        public static Bitmap RenderQrCode(string str, string level="L")
        {
            Bitmap tmp;
            QRCodeGenerator.ECCLevel eccLevel = (QRCodeGenerator.ECCLevel)(level == "L" ? 0 : level == "M" ? 1 : level == "Q" ? 2 : 3);
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(str, eccLevel))
                {
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {
                        tmp= qrCode.GetGraphic(20, Color.Black, Color.White,null, 0);
                    }
                }
            }
            return tmp;
        }
    }
}
