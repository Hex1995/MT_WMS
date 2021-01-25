
using DevComponents.DotNetBar;

namespace MT_WMS.Win.MT
{
    partial class FrmMTMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMTMain));
            this.Model_QRCodePrint_Print = new DevComponents.DotNetBar.ButtonItem();
            this.Model_QRCodePrint_Test = new DevComponents.DotNetBar.ButtonItem();
            this.BtnObjectAdd = new DevComponents.DotNetBar.ButtonItem();
            this.BtnObjectDelete = new DevComponents.DotNetBar.ButtonItem();
            this.BtnObject = new DevComponents.DotNetBar.ButtonItem();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.BtnExit = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.BthPrintSet = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.Model_QRCodePrint = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem2 = new DevComponents.DotNetBar.RibbonTabItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Model_QRCodePrint_Print
            // 
            this.Model_QRCodePrint_Print.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.Model_QRCodePrint_Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Model_QRCodePrint_Print.Image = ((System.Drawing.Image)(resources.GetObject("Model_QRCodePrint_Print.Image")));
            this.Model_QRCodePrint_Print.ImagePaddingHorizontal = 4;
            this.Model_QRCodePrint_Print.ImagePaddingVertical = 4;
            this.Model_QRCodePrint_Print.Name = "Model_QRCodePrint_Print";
            this.Model_QRCodePrint_Print.SubItemsExpandWidth = 14;
            this.Model_QRCodePrint_Print.Text = "条码打印";
            this.Model_QRCodePrint_Print.Click += new System.EventHandler(this.Model_QRCodePrint_Print_Click);
            // 
            // Model_QRCodePrint_Test
            // 
            this.Model_QRCodePrint_Test.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.Model_QRCodePrint_Test.Image = ((System.Drawing.Image)(resources.GetObject("Model_QRCodePrint_Test.Image")));
            this.Model_QRCodePrint_Test.Name = "Model_QRCodePrint_Test";
            this.Model_QRCodePrint_Test.SubItemsExpandWidth = 14;
            this.Model_QRCodePrint_Test.Text = "测试";
            this.Model_QRCodePrint_Test.Click += new System.EventHandler(this.Model_QRCodePrint_Test_Click);
            // 
            // BtnObjectAdd
            // 
            this.BtnObjectAdd.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnObjectAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnObjectAdd.Image")));
            this.BtnObjectAdd.Name = "BtnObjectAdd";
            this.BtnObjectAdd.SubItemsExpandWidth = 14;
            this.BtnObjectAdd.Text = "字典添加";
            this.BtnObjectAdd.Click += new System.EventHandler(this.BtnObjectAdd_Click);
            // 
            // BtnObjectDelete
            // 
            this.BtnObjectDelete.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnObjectDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnObjectDelete.Image")));
            this.BtnObjectDelete.Name = "BtnObjectDelete";
            this.BtnObjectDelete.SubItemsExpandWidth = 14;
            this.BtnObjectDelete.Text = "字典删除";
            this.BtnObjectDelete.Click += new System.EventHandler(this.BtnObjectDelete_Click);
            // 
            // BtnObject
            // 
            this.BtnObject.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnObject.Image = ((System.Drawing.Image)(resources.GetObject("BtnObject.Image")));
            this.BtnObject.Name = "BtnObject";
            this.BtnObject.SubItemsExpandWidth = 14;
            this.BtnObject.Text = "数据字典";
            this.BtnObject.Click += new System.EventHandler(this.BtnObject_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.AutoCloseTabs = true;
            this.tabControl1.BackColor = System.Drawing.Color.White;
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.CloseButtonOnTabsVisible = true;
            this.tabControl1.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right;
            this.tabControl1.CloseButtonVisible = true;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 180);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1275, 650);
            this.tabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock;
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Text = "tabControl1";
            // 
            // ribbonControl1
            // 
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.Class = "";
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.Model_QRCodePrint,
            this.ribbonTabItem2});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(3, 26);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.qatCustomizeItem1});
            this.ribbonControl1.Size = new System.Drawing.Size(1275, 154);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 26);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(1275, 126);
            // 
            // 
            // 
            this.ribbonPanel1.Style.Class = "";
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.Class = "";
            this.ribbonPanel1.TabIndex = 1;
            this.ribbonPanel1.Visible = false;
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.Class = "";
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.Model_QRCodePrint_Print,
            this.Model_QRCodePrint_Test,
            this.BtnExit});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(485, 123);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "功能模块";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.Class = "";
            // 
            // BtnExit
            // 
            this.BtnExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.SubItemsExpandWidth = 14;
            this.BtnExit.Text = "退出";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Controls.Add(this.ribbonBar3);
            this.ribbonPanel2.Controls.Add(this.ribbonBar2);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 26);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(1275, 126);
            // 
            // 
            // 
            this.ribbonPanel2.Style.Class = "";
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.Class = "";
            this.ribbonPanel2.TabIndex = 2;
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBar3.BackgroundStyle.Class = "";
            this.ribbonBar3.ContainerControlProcessDialogKey = true;
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BthPrintSet});
            this.ribbonBar3.Location = new System.Drawing.Point(315, 0);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(100, 123);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar3.TabIndex = 1;
            this.ribbonBar3.Text = "系统设置";
            // 
            // 
            // 
            this.ribbonBar3.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBar3.TitleStyleMouseOver.Class = "";
            // 
            // BthPrintSet
            // 
            this.BthPrintSet.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BthPrintSet.Image = ((System.Drawing.Image)(resources.GetObject("BthPrintSet.Image")));
            this.BthPrintSet.Name = "BthPrintSet";
            this.BthPrintSet.SubItemsExpandWidth = 14;
            this.BthPrintSet.Text = "打印机";
            this.BthPrintSet.Click += new System.EventHandler(this.BthPrintSet_Click);
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.Class = "";
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BtnObject,
            this.BtnObjectAdd,
            this.BtnObjectDelete});
            this.ribbonBar2.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(312, 123);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar2.TabIndex = 0;
            this.ribbonBar2.Text = "数据字典管理模块";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.Class = "";
            // 
            // Model_QRCodePrint
            // 
            this.Model_QRCodePrint.Name = "Model_QRCodePrint";
            this.Model_QRCodePrint.Panel = this.ribbonPanel1;
            this.Model_QRCodePrint.Text = "二维码打印";
            // 
            // ribbonTabItem2
            // 
            this.ribbonTabItem2.Checked = true;
            this.ribbonTabItem2.Name = "ribbonTabItem2";
            this.ribbonTabItem2.Panel = this.ribbonPanel2;
            this.ribbonTabItem2.Text = "系统相关";
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // FrmMTMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 833);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FrmMTMain";
            this.Text = "河南明泰铝业股份有限公司";
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RibbonControl ribbonControl1;
        private RibbonPanel ribbonPanel1;
        private RibbonBar ribbonBar1;
        private RibbonPanel ribbonPanel2;
        private RibbonTabItem Model_QRCodePrint;
        private RibbonTabItem ribbonTabItem2;
        private QatCustomizeItem qatCustomizeItem1;
        private TabControl tabControl1;
        private ButtonItem Model_QRCodePrint_Print;
        private ButtonItem Model_QRCodePrint_Test;
        private RibbonBar ribbonBar2;
        private ButtonItem BtnObjectAdd;
        private ButtonItem BtnObjectDelete;
        private ButtonItem BtnObject;
        private RibbonBar ribbonBar3;
        private ButtonItem BthPrintSet;
        private ButtonItem BtnExit;
    }
}