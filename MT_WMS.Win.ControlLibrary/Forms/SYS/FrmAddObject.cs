using MT_WMS.Entitys;
using MT_WMS.IBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_WMS.Win.ControlLibrary.Forms.SYS
{
    public partial class FrmAddObject : BaseFrm
    {
        public FrmAddObject()
        {
            InitializeComponent();
            var data = _sys.GetAllData();
            cbbObject.Items.Clear();

            foreach (var item in data)
            {
                cbbObject.Items.Add(new ComboxItem(item.OBJECTID,item.OBJECTNAME));
            }
            if (data.Count>0)
            {
                cbbObject.SelectedIndex = 0;
            }
        }
        ISysObjectBusiness _sys= FactoryService.BulidByConfigKey<ISysObjectBusiness>("SYS0001");

        private void BtnAddObject_Click(object sender, EventArgs e)
        {
            var name = TxtObjectName.Text.Trim();
            if (!name.IsNullOrEmpty())
            {
                var tf = _sys.UserObjectsExistsByName(name);
                if (tf==true)
                    MessageBox.Show($"已存在：{name}","值对象添加");
                else
                {
                    SYSOBJECT sys = new SYSOBJECT()
                    {
                        OBJECTID = IdHelper.GetId(IdType.Base16),
                        OBJECTNAME = name
                    };
                    _sys.SaveData(sys);
                    _sys.UpdateObject();
                }
            }

        }

        private void BtnObjectValueSave_Click(object sender, EventArgs e)
        {
            var Select = (ComboxItem)cbbObject.SelectedItem;
            var objectvalue = TxtObjectValue.Text.Trim();
            var objectdescr = TxtObjectDescr.Text.Trim();
            if (!objectvalue.IsNullOrEmpty())
            {
                SYSOBJECTVALUE values = new SYSOBJECTVALUE()
                {
                    OBJECTID = Select.Value(),
                    OBJECTVALUE = objectvalue,
                    OBJECTDESCR = objectdescr
                };
            }

        }
    }
}
