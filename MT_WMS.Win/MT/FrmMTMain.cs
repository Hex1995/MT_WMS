using MT_WMS.IBusiness;
using MT_WMS.Win.ControlLibrary.Controls.MT.Print;
using MT_WMS.Win.Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MT_WMS.Win.MT
{
    public partial class FrmMTMain : BaseUI
    {
        public FrmMTMain()
        {
            InitializeComponent();
        }

        private void Model_QRCodePrint_Print_Click(object sender, EventArgs e)
        {
            UIHelper.Instance.AddControl("打印条码", new UCQRCodePrint(), this.tabControl1);
        }
    }
}
