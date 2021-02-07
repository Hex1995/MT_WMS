using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_WMS.Win.OtherForm
{
    public partial class FrmContact : BaseUI
    {
        public FrmContact()
        {
            InitializeComponent();
            ricMsg.AppendText(_msg);
        }
        public FrmContact(string Msg)
        {
            InitializeComponent();

                ricMsg.AppendText(Msg);
            
        }
        string _msg= "欢迎联系我们!";
    }
}
