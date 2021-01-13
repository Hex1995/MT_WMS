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
            data = bus.GetTheData(Id);
            TxtProductId.Text = data.ProductId;
            TxtProductName.Text = data.ProductName;
            DataBind.InitialItems("产品规格", cbbGg, data.ProductSpec);
            DataBind.InitialItems("产品单位", cbbDw, data.ProductUnit);
        }
        IProductBusiness bus = FactoryService.BulidByConfigKey<IProductBusiness>("MT0001");
        Product data;
        public event EventHandler EditDataHandler;
        private void BtnSave_Click(object sender, EventArgs e)
        {
            //目前仅仅做简单的修改，后期根据实际要求进行调整和完善
            var productName = TxtProductName.Text.Trim();
            var productSpec = cbbGg.SelectedItem.ToString();
            var productUnit = cbbDw.SelectedItem.ToString();
            var productSimpleSpelling = productName.ToSimpleSpelling();
            data.ProductSpec = productSpec;
            data.ProductName = productName;
            data.SimpleSpelling = productSimpleSpelling;
            data.ProductUnit = productUnit;
            data.ModifyDate = DateTime.Now;
            data.ModifyUserId = GlobalSwitch.Instance.UserId;
            data.ModifyUserName = GlobalSwitch.Instance.UserName;
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
