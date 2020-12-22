using MT_WMS.IBusiness;
using MT_WMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_WMS.Win.ControlLibrary.Controls.MT.Print
{
    public partial class UCQRCodePrint : UserControl
    {
        public UCQRCodePrint()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            
        }
        IProductBusiness _bus= FactoryService.BulidByConfigKey<IProductBusiness>("MT0001");
        private void iconButton1_Click(object sender, EventArgs e)
        {
            Dgv.DataSource = _bus.GetTable();
        }
    }
}
