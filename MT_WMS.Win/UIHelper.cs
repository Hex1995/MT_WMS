using DevComponents.DotNetBar;
using MT_WMS.IBusiness;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_WMS.Win
{
    public class UIHelper
    {
        private static UIHelper instance;

        public static UIHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UIHelper();
                    
                }
                return UIHelper.instance;
            }
        }

        public bool tempbool1 = false;
        public void AddControl(string name, Control addcontrol, DevComponents.DotNetBar.TabControl tabControl1)
        {
            bool tempbool = false;
            tempbool1 = false;
            foreach (TabItem c in tabControl1.Tabs)
            {
                if (c.Text == name)
                {
                    tabControl1.SelectedTab = c;
                    tempbool = true;
                    break;
                }
            }
            if (!tempbool)
            {
                TabItem tb = CreateTab(name, addcontrol, tabControl1);
                tabControl1.Tabs.Add(tb);
                tabControl1.SelectedTab = tb;

            }

        }
        public TabItem CreateTab(string name, Control addcontrol, DevComponents.DotNetBar.TabControl tabControl1)
        {
            TabItem tbitem = new TabItem();
            CSharpWin.BorderPanel boder = new CSharpWin.BorderPanel();
            boder.Dock = System.Windows.Forms.DockStyle.Fill;
            boder.BackColor = Color.FromArgb(230, 238, 248);
            //boder.BackColor= System.Drawing.Color.Transparent;
            TabControlPanel tp = new TabControlPanel();
            tp.Controls.Add(boder);
            tp.Dock = System.Windows.Forms.DockStyle.Fill;
            tp.Location = new System.Drawing.Point(0, 23);
            tp.Name = "tp" + tabControl1.Tabs.Count.ToString();
            tp.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            tp.Size = new System.Drawing.Size(900, 463);
            tp.Style.BackColor1.Color = Color.FromArgb(230, 238, 248);// System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            tp.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            tp.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            tp.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                       | DevComponents.DotNetBar.eBorderSide.Bottom)));
            tp.Style.GradientAngle = 90;
            tp.TabIndex = tabControl1.Tabs.Count + 1;
            tp.TabItem = tbitem;
            tbitem.AttachedControl = tp;
            tbitem.Name = "tbItem" + tabControl1.Tabs.Count + 1; ;
            tbitem.Text = name;

            boder.Controls.Add(addcontrol);
            tabControl1.Controls.Add(tp);

            return tbitem;
        }
    }
}
