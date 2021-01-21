using MT_WMS.IBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_WMS.Win.ControlLibrary.Controls.MT.Print
{
    public partial class UCTest : UserControl
    {
        public UCTest()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            sys = FactoryService.Build<ISysObjectBusiness>("MT_WMS.Business.MT.SysObjectBusiness");
        }
        ISysObjectBusiness sys;
        private void BtnTest_Click(object sender, EventArgs e)
        {
            //var res= TestHelper.GetTest();
            //RicTxt.AppendText(res.Item1+"\r\n");
            //RicTxt.AppendText(res.Item2 + "\r\n");
            //RicTxt.AppendText(sys.GetDataList().ToJson() + "\r\n");
            RicTxt.Text = IdHelper.GetId(IdType.Base8);
            string qrcode = RicTxt.Text;
            pictureBox1.Image = qrcode.ToQrCode();
            foreach (var item in PrinterSettings.InstalledPrinters)
            {
                RicTxt.AppendText(item + "\r\n");
            }
        }
    }
}
