using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_WMS.Win.ControlLibrary.Forms.SYS
{
    public partial class FrmPrintSet : BaseFrm
    {
        public FrmPrintSet()
        {
            InitializeComponent();
            InitialPrint();
        }
        void InitialPrint()
        {
            List<TreeNode> printList = new List<TreeNode>();
            foreach (var item in PrinterSettings.InstalledPrinters)
            {
                printList.Add(new TreeNode() { Name = item.ToString(), Text = item.ToString(), Tag = item.ToString() });
            }
            TrvPrintList.Nodes.Clear();
            TrvPrintList.Nodes.AddRange(printList.ToArray());
            TxtPrintNow.Text = ConfigHelper.GetKeyValue("PrintName");
        }

        private void BtnPrintRefresh_Click(object sender, EventArgs e)
        {
            InitialPrint();
        }
    }
}
