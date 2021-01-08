using DevComponents.DotNetBar;
using MT_WMS.IBusiness;
using MT_WMS.Win.ControlLibrary.Controls.MT.Print;
using MT_WMS.Win.ControlLibrary.Forms.SYS;
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



        private void MenuBtnClick(object sender, EventArgs e)
        {
            
        }

        private void Model_QRCodePrint_Print_Click(object sender, EventArgs e)
        {
            UIHelper.Instance.AddControl("条码打印", new UCQRCodePrint(), this.tabControl1);
        }

        private void Model_QRCodePrint_Test_Click(object sender, EventArgs e)
        {
            UIHelper.Instance.AddControl("测试", new UCTest(), this.tabControl1);
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            FrmAddObject add = new FrmAddObject();
            add.ShowDialog();
        }

        private void BtnObjectAdd_Click(object sender, EventArgs e)
        {
            FrmAddObject add = new FrmAddObject();
            add.ShowDialog();
        }

        private void BtnObjectDelete_Click(object sender, EventArgs e)
        {
            FrmDeleteObject delete = new FrmDeleteObject();
            delete.ShowDialog();
        }
    }
}
