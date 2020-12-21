using MT_WMS.Business.MS;
using MT_WMS.IBusiness;
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
            Bus = new ProductBusiness();
        }
        IProductBusiness Bus;
        private void iconButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(Bus.GetTheData("").ToJson());
        }
    }
}
