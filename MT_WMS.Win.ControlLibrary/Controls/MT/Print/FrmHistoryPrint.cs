﻿using MT_WMS.IBusiness;
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
    /// <summary>
    /// 历史打印
    /// </summary>
    public partial class FrmHistoryPrint : BaseFrm
    {
        public FrmHistoryPrint()
        {
            InitializeComponent();

        }
        private void FrmHistoryPrint_Shown(object sender, EventArgs e)
        {
            StartTime.CurrentTime = DateTime.Now.AddHours(-1);
            EndTime.CurrentTime = DateTime.Now;
        }
        IProductLabelRecordBusiness _printbus = FactoryService.BulidByConfigKey<IProductLabelRecordBusiness>("MT0002");
        private void BtnQuery_Click(object sender, EventArgs e)
        {
            List<string> filter = new List<string>();
            if (StartTime.CurrentTime<EndTime.CurrentTime)
            {
                filter.Add($" and  a.CreateDate between  '{StartTime.CurrentTime}' and  '{EndTime.CurrentTime}' ");
                filter.Add($" order by a.CreateDate desc");
                DataBind.InitialIDgv(filter, _printbus, Dgv);
            }

        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {

        }
        PrintProductLabelRecordDTO selectedProduct;
        private void DgvLs_SelectionChanged(object sender, EventArgs e)
        {
            var select = Dgv.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (select > 0)
            {
                var dr = Dgv.SelectedRows[0];
                var tmp = new PrintProductLabelRecordDTO();
                tmp.ProductId = dr.Cells["ProductId"].Value.ToString();
                tmp.ProductName = dr.Cells["ProductName"].Value.ToString();
                tmp.ProductSpec = dr.Cells["ProductSpec"].Value.ToString();
                selectedProduct = tmp;
            }
            else
            {
                selectedProduct = null;
            }
        }
    }
}
