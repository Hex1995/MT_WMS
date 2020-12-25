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
            DataBind.InitialItems("仓库", cbbCK);
            DataBind.InitialItems("班组", cbbBz);
            DataBind.InitialItems("机器号", cbbJqh);
            DataBind.InitialItems("检验员", cbbJyy);
            Dgv.DataSource = _bus.GetProducts(new List<string>());
        }
        IProductBusiness _bus= FactoryService.BulidByConfigKey<IProductBusiness>("MT0001");
        private void iconButton1_Click(object sender, EventArgs e)
        {
            var name = TxtName.Text;
            List<string> filter = new List<string>();
            filter.Add($"ProductName like'%{name}%'");
            Dgv.DataSource = _bus.GetProducts(filter);
        }

    }
}
