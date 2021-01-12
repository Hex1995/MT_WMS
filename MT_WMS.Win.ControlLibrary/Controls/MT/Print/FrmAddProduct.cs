using MT_WMS.Entitys;
using MT_WMS.IBusiness;
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

namespace MT_WMS.Win.ControlLibrary.Controls.MT.Print
{
    public partial class FrmAddProduct : BaseFrm
    {

        public FrmAddProduct()
        {
            InitializeComponent();
            DataBind.InitialItems("产品单位", cbbDw);
            DataBind.InitialItems("产品规格",cbbGg);
        }
        public event EventHandler SaveDataHandler;
        IProductBusiness bus= FactoryService.BulidByConfigKey<IProductBusiness>("MT0001");
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var productId = TxtProductId.Text.Trim();
            var productName = TxtProductName.Text.Trim();
            if (productId.IsNullOrEmpty()||productName.IsNullOrEmpty())
            {
                MessageBox.Show("请完善必要信息","系统提示");
                return;
            }
            var productUnit = cbbDw.SelectedItem.IsNullOrEmpty() ? "" : ((ComboxItem)cbbDw.SelectedItem).ToString();
            var productSpec= cbbGg.SelectedItem.IsNullOrEmpty() ? "" : ((ComboxItem)cbbGg.SelectedItem).ToString();
            Product pro = new Product()
            {
                ProductId = productId,
                ProductName = productName,
                ProductSpec = productSpec,
                Barcode = IdHelper.GetId(IdType.Snowflake),
                CreateUserId = GlobalSwitch.Instance.UserId,
                CreateUserName = GlobalSwitch.Instance.UserName,
                CategoryId = RibCp.Checked?"1":"0",
                SimpleSpelling = productName.ToSimpleSpelling(),
                ProductUnit = productUnit,
                CreateDate = DateTime.Now,
                EnableMark = CheckEnable.Checked ? 1 : 0,
                Id = IdHelper.GetId(IdType.Guid),
                IsTrace=checkTrace.Checked?1:0,
            };
            var data= bus.SaveData(pro);
            if (data>0)
            {
                SaveDataHandler.Invoke(pro,null);
                TxtProductId.Text = "";
                TxtProductName.Text = "";
            }
            else
            {
                MessageBox.Show("编号有重复！","提示");
            }

        }

    }
}
