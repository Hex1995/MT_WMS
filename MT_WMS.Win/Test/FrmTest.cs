using MT_WMS.IBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

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
            foreach (Process item in Process.GetProcesses(System.Environment.MachineName))
            {
                richTextBox1.AppendText(item.ProcessName + "---"+ item.Id+"\r\n");
                Console.WriteLine(item); //string s = p.ToString ();

                if (item.MainWindowHandle != IntPtr.Zero)
                {
                    item.EnableRaisingEvents = true;
                    item.Exited += new EventHandler(myprocess_Exited);
                }
                foreach (var item1 in item.Threads)
                {
                    var t = item1.GetType();
                }
            }
        }
        private void myprocess_Exited(object sender, EventArgs e)//被触发的程序
        {
            var p = (Process)sender;
            MessageBox.Show(p.ProcessName+"关闭");
        }
    }
}
