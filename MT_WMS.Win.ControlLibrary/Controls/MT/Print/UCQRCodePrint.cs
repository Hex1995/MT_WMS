using MT_WMS.IBusiness;
using MT_WMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MT_WMS.Entitys;

namespace MT_WMS.Win.ControlLibrary.Controls.MT.Print
{
    public partial class UCQRCodePrint : UserControl
    {
        public UCQRCodePrint()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            DataBind.InitialItems("车间", cbbCJ);
            DataBind.InitialItems("班组", cbbBz);
            DataBind.InitialItems("合金度", cbbhjd);
            DataBind.InitialItems("检验员", cbbJyy);
            DataBind.InitialItems("机器号", cbbJqh);
            DataBind.InitialItems("项目", cbbXM);

            DataBind.InitialIDgv(new List<string>(),_bus,Dgv);
            thread = new Thread(LoopGetZzl);
            thread.IsBackground = true;
            thread.Start();


        }
        #region 磅秤相关参数
        /// <summary>
        /// 是否读取秤砣数据
        /// </summary>
        bool readcom = true;
        /// <summary>
        /// 总重量
        /// </summary>
        decimal zzl = 0;
        /// <summary>
        /// 毛重
        /// </summary>
        decimal mz = 0;
        /// <summary>
        /// 皮重
        /// </summary>
        decimal pz = 0;
        /// <summary>
        /// 净重
        /// </summary>
        decimal jz = 0;
        /// <summary>
        /// 流水号
        /// </summary>
        string lsh = "";
        /// <summary>
        /// 系统消息
        /// </summary>
        string msg ="系统消息...";
        /// <summary>
        /// 选中的产品
        /// </summary>
        Product selectedProduct;
        #endregion
        /// <summary>
        /// 每隔10毫秒读取数据的线程
        /// </summary>
        Thread thread;
        IProductLabelRecordBusiness _printbus= FactoryService.BulidByConfigKey<IProductLabelRecordBusiness>("MT0002");
        IProductBusiness _bus= FactoryService.BulidByConfigKey<IProductBusiness>("MT0001");
        private void BtnQuery_Click(object sender, EventArgs e)
        {
            var name = TxtName.Text;
            List<string> filter = new List<string>();
            filter.Add($"and ProductName like'%{name}%'");
            DataBind.InitialIDgv(filter,_bus,Dgv);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            pz = zzl;
            RefreshData();

        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (selectedProduct.IsNullOrEmpty())
            {
                msg = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss,fff")}系统：不能打印空物料";
            }
            else
            {

                readcom = false;

                string zzlStr = TxtZZL.Text.Trim();
                string mzStr = TxtMZ.Text.Trim();
                string pzStr = TxtPZ.Text.Trim();
                string jzStr = LabJz.Text.Trim();

                mz = zzl;
                jz = zzl - pz;

                //车间
                string workshop = ((ComboxItem)cbbCJ.SelectedItem).IsNullOrEmpty()?"": ((ComboxItem)cbbCJ.SelectedItem).Value();
                //班组
                string teamId = ((ComboxItem)cbbBz.SelectedItem).IsNullOrEmpty() ? "" : ((ComboxItem)cbbBz.SelectedItem).Value();
                //班组字符
                string teamStr = ((ComboxItem)cbbBz.SelectedItem).IsNullOrEmpty() ? "" : ((ComboxItem)cbbBz.SelectedItem).ToString();
                //合金度
                string MixDegree =((ComboxItem)cbbhjd.SelectedItem).IsNullOrEmpty() ? "" : ((ComboxItem)cbbhjd.SelectedItem).ToString();
                //质检员
                string QualityId = ((ComboxItem)cbbJyy.SelectedItem).IsNullOrEmpty() ? "" : ((ComboxItem)cbbJyy.SelectedItem).Value();
                //机器号
                string MachineNumber= ((ComboxItem)cbbJqh.SelectedItem).IsNullOrEmpty() ? "" : ((ComboxItem)cbbJqh.SelectedItem).Value();

                string ProductSN = "";

                #region 获取流水号

                List<string> filter1 = new List<string>();
                filter1.Add($"and ProductId ='{selectedProduct.ProductId}'");
                filter1.Add($"and TeamId ='{teamId}'");
                filter1.Add($"and MachineNumber ='{MachineNumber}'");
                filter1.Add($"and CreateDate between '{DateTime.Now.ToShortDateString()} 0:00:00' and '{DateTime.Now.ToShortDateString()} 23:59:59'");
                filter1.Add($"order by SwiftNumber DESC");
                var ls = _printbus.GetSwiftNumber(filter1);
                lsh = IdHelper.GetId(IdType.Batch, teamStr, ls.ToString().PadLeft(3,'0'));
                //条码生成规则
                ProductSN = $"{lsh}-{IdHelper.GetId(IdType.Base8)}";
                #endregion
                //
                RefreshData();
                //构造二维码数据
                ProductLabelRecord data = new ProductLabelRecord()
                {
                    Id = IdHelper.GetId(IdType.Guid, "", ""),
                    ProductSN = ProductSN,
                    SwiftNumber = ls,
                    SwiftNumberStr = lsh,
                    //暂时用雪花ID
                    BatchId = IdHelper.GetId(IdType.Batch, teamStr, ""),
                    ProductId = selectedProduct.ProductId,
                    ProductSpec = selectedProduct.ProductSpec,
                    ProductUnit = selectedProduct.ProductUnit,
                    ProductLength = "1000",
                    ProjectName = ((ComboxItem)cbbXM.SelectedItem).IsNullOrEmpty() ? "" : ((ComboxItem)cbbXM.SelectedItem).Value(),
                    //初始状态参数
                    StatusMark = 0,
                    DeleteMark = 0,
                    EnableMark = 1,
                    
                    //重要输入参数绑定
                     PrintIn_StoreId="",
                    GroWeight = mz,
                    Num = jz,
                    StoreNum = jz,

                    WorkShop = workshop,
                    MixDegree = MixDegree,
                    TeamId =teamId,
                    QualityId=QualityId,
                    MachineNumber=MachineNumber,

                    //其他暂时不重要
                    InStorePlaceId = "",
                    OrignBillId = "",
                    SupplierId = "",
                    SupplierName = "",

                    
                    CreateDate = DateTime.Now,
                    CreateUserId = "Admin",
                    CreateUserName = "何旭阳",


                };
                if (cbAuto.Checked)
                    readcom = true;
                else
                    readcom = false;

                //打印
                PicPreview.Image = data.ProductSN.ToQrCode();
                PrintProductLabelRecordDTO printProductLabelRecordDTO = new PrintProductLabelRecordDTO()
                {
                    BatchNumber = data.BatchId,
                    QrCode = data.ProductSN,
                    WorkShop = ((ComboxItem)cbbCJ.SelectedItem).IsNullOrEmpty() ? "" : ((ComboxItem)cbbCJ.SelectedItem).ToString(),
                    GroWeight = data.GroWeight.ToString(),
                    NetWeight = data.Num.ToString(),
                    MixDegree = data.MixDegree,
                    Date = data.CreateDate.Value.Date.ToString("yyyyMMdd"),
                    ProductId = data.ProductId,
                    ProductName = selectedProduct.ProductName,
                    ProductSpec = data.ProductSpec,
                    Quality = ((ComboxItem)cbbJyy.SelectedItem).IsNullOrEmpty() ? "" : ((ComboxItem)cbbJyy.SelectedItem).ToString(),
                    ProjectName = ((ComboxItem)cbbXM.SelectedItem).IsNullOrEmpty() ? "" : ((ComboxItem)cbbXM.SelectedItem).ToString(),
                    Length = "",
                    PackageNumber= data.PackageNumber
                };
                _printbus.SaveData(data);
                printProductLabelRecordDTO.PrintModel();
                msg = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss,fff")}   系统：物料【{selectedProduct.ProductName}】流水号【{lsh}】打印成功...";
                List<string> filter = new List<string>();
                filter.Add(" order by a.CreateDate desc");
                DataBind.InitialIDgv(filter, _printbus, DgvLs);
            }
        }
        /// <summary>
        /// 刷新UI相关数据
        /// </summary>
        private void RefreshData()
        {
            if (selectedProduct.IsNullOrEmpty())
            {
                LabName.Text = "";
                LabSpec.Text = "";
            }
            else
            {
                LabName.Text = selectedProduct.ProductName;
                LabSpec.Text = selectedProduct.ProductSpec;
            }
            LabSerial.Text = lsh;
            TxtZZL.Text = zzl.ToString();
            TxtMZ.Text = mz.ToString();
            TxtPZ.Text = pz.ToString();
            if (jz<0)
            {
                LabJz.ForeColor = Color.Red;
            }
            else
            {
                LabJz.ForeColor = Color.FromArgb(0, 192, 0);
            }
            LabJz.Text = jz.ToString();
            LabMsg.Text = $"{msg}";
        }
        
        /// <summary>
        /// 循环读取数据
        /// </summary>
        private void LoopGetZzl()
        {
            Action action = new Action(RefreshData);
            while (true)
            {
                if (readcom)
                {
                    //等待10毫秒
                    if (this.IsHandleCreated)
                    {
                        //先赋值参数
                        zzl = ReadSerialPortData();
                        Invoke(action);
                        Thread.Sleep(100);

                    }
                }
                else
                {
                    readcom = true;
                    Thread.Sleep(3000);
                }

            }
        }

        /// <summary>
        /// 在此处写获取磅秤重量的方法
        /// 读取秤砣信息
        /// </summary>
        /// <returns></returns>
        public decimal ReadSerialPortData()
        {
            try
            {
                Random random = new Random();

                return (decimal)Math.Round(random.NextDouble() * (1 - 100) + 1000, 3);
            }
            catch (Exception)
            {

                return 0;
            }
            finally
            {
                GC.Collect();
            }

        }

        private void Dgv_SelectionChanged(object sender, EventArgs e)
        {
            var select = Dgv.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (select > 0)
            {
                var dr = Dgv.SelectedRows[0];
                var tmp = new Product();
                tmp.ProductId = dr.Cells["ProductId"].Value.ToString();
                tmp.ProductName= dr.Cells["ProductName"].Value.ToString();
                tmp.ProductSpec = dr.Cells["ProductSpec"].Value.ToString();
                tmp.ProductUnit = dr.Cells["ProductUnit"].Value.ToString();
                tmp.ProductTypeName = dr.Cells["ProductTypeName"].Value.ToString();
                tmp.ProductType = dr.Cells["ProductType"].Value.ToString();
                selectedProduct = tmp;
            }
            else
            {
                selectedProduct = null;
            }
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            msg = $"{DateTime.Now.ToString("yyyy - MM - dd HH: mm: ss,fff")}   历史打印...";
            FrmHistoryPrint frmHistory = new FrmHistoryPrint();
            frmHistory.ShowDialog();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {

            FrmAddProduct addProduct = new FrmAddProduct();
            addProduct.SaveDataHandler += AddProduct_SaveDataHandler;
            addProduct.ShowDialog();
        }

        private void AddProduct_SaveDataHandler(object sender, EventArgs e)
        {
            var filter = new List<string>();
            filter.Add("order by CreateDate desc");
            Dgv.DataSource = _bus.GetTable(filter);
            var data = (Product)sender;
            msg = $"{DateTime.Now.ToString("yyyy - MM - dd HH: mm: ss,fff")}   新增物料编号【{data.ProductId}】物料名称【{data.ProductName}】...";
        }

        private void cbAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAuto.Checked == true)
            {
                readcom = true;
                msg = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss,fff")}   自动获取磅秤信息...";
            }

            else
            {
                readcom = false;
                msg = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss,fff")}   手动录入重量...";
            }

        }
        private void BtnEditProduct_Click(object sender, EventArgs e)
        {
            var select = Dgv.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (select > 0)
            {
                var dr = Dgv.SelectedRows[0];
                var tmp = dr.Cells["ProductId"].Value.ToString();
                FrmEditProduct frmEdit = new FrmEditProduct(tmp);
                frmEdit.EditDataHandler += EditProduct_SaveDataHandler;
                frmEdit.ShowDialog();
            }
        }
        private void EditProduct_SaveDataHandler(object sender, EventArgs e)
        {
            var filter = new List<string>();
            filter.Add("order by ModifyDate desc");
            Dgv.DataSource = _bus.GetTable(filter);
            var data = (Product)sender;
            msg = $"{DateTime.Now.ToString("yyyy - MM - dd HH: mm: ss,fff")}   物料编号【{data.ProductId}】修改成功 物料名称【{data.ProductName}】物料规格【{data.ProductSpec}】物料单位【{data.ProductUnit}】...";
        }

        private void BtnDelProduct_Click(object sender, EventArgs e)
        {
            var select = Dgv.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (select > 0)
            {
                var dr = Dgv.SelectedRows[0];
                var tmp = dr.Cells["ProductId"].Value.ToString();
                List<string> ids = new List<string>();
                ids.Add(tmp);
                if (_bus.DeleteData(ids)>0)
                {
                    Dgv.DataSource = _bus.GetTable(new List<string>());
                }
            }
        }
    }
}
