using MT_WMS.Win.ControlLibrary.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MT_WMS.IBusiness;
using MT_WMS.Entitys;

namespace MT_WMS.Win.ControlLibrary.Controls.MT.Print
{
    public partial class FrmEditProduct : BaseFrm
    {
        public FrmEditProduct(string Id)
        {
            InitializeComponent();
            oldData = bus.GetTheData(Id);
            TxtProductId.Text = oldData.ProductId;
            TxtProductName.Text = oldData.ProductName;
            DataBind.InitialItems("产品规格", cbbGg,oldData.ProductSpec);
            DataBind.InitialItems("产品单位", cbbDw,oldData.ProductUnit);
        }
        IProductBusiness bus = FactoryService.BulidByConfigKey<IProductBusiness>("MT0001");
        Product oldData;
        public event EventHandler EditDataHandler;
        private void BtnSave_Click(object sender, EventArgs e)
        {
             
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
