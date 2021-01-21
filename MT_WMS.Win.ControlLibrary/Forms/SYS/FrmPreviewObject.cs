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
    public partial class FrmPreviewObject : BaseFrm
    {
        ISysObjectBusiness _sys = FactoryService.BulidByConfigKey<ISysObjectBusiness>("SYS0001");
        ISysObjectValueBusiness _value = FactoryService.BulidByConfigKey<ISysObjectValueBusiness>("SYS0002");
        public FrmPreviewObject()
        {
            InitializeComponent();
            HexStyleUI.SetDataGridView(this.DgvObject);
            HexStyleUI.SetDataGridView(this.DgvObjectValue);
            DgvObject.DataSource = _sys.GetTable(new List<string>());
        }

        private void DgvObject_SelectionChanged(object sender, EventArgs e)
        {
            var select = DgvObject.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (select > 0)
            {
                var dr = DgvObject.SelectedRows[0];
                var id = dr.Cells["Objectid"].Value.ToString();
                DgvObjectValue.DataSource= _value.GetDataListByObjectid(id);
            }
            else
            {
            }
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            var query = TxtName.Text.Trim();
            List<string> filter = new List<string>();
            filter.Add($" and OBJECTNAME like '%{query}%'");
            var data = _sys.GetTable(filter);
            DgvObject.DataSource = _sys.GetTable(filter);
        }
    }
}
