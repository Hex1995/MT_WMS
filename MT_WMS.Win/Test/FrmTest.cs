using MT_WMS.IBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MT_WMS.Win.Test
{
    public partial class FrmTest : BaseUI
    {
        public FrmTest()
        {
            InitializeComponent();
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(ConfigHelper.GetKeyValue("MT0001"));
        }

    }
}
