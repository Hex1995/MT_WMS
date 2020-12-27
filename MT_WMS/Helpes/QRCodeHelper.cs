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
        public static Bitmap RenderQrCode(string str)
        {
            Bitmap tmp;
            string level = "L";
            QRCodeGenerator.ECCLevel eccLevel = (QRCodeGenerator.ECCLevel)(level == "L" ? 0 : level == "M" ? 1 : level == "Q" ? 2 : 3);
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(str, eccLevel))
                {
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {
                        tmp= qrCode.GetGraphic(20, Color.Black, Color.White,null, (int)0);
                    }
                }
            }
            return tmp;
        }
    }
}
