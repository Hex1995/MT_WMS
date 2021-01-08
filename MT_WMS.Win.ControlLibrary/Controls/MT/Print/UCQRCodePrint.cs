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
            DataBind.InitialItems("仓库", cbbCK);
            DataBind.InitialItems("班组", cbbBz);
            DataBind.InitialItems("合金度", cbbhjd);
            DataBind.InitialItems("检验员", cbbJyy);
            Dgv.DataSource = _bus.GetProducts(new List<string>());
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
        string msg = "系统消息....";
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
            Dgv.DataSource = _bus.GetProducts(filter);

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
                msg = "系统：不能打印空物料";
            }
            else
            {
                readcom = false;
                mz = zzl;
                jz = zzl - pz;
                RefreshData();
                string ckId = ((ComboxItem)cbbCK.SelectedItem).Value();
                string hjd = ((ComboxItem)cbbhjd.SelectedItem).Value();

                //构造二维码数据
                ProductLabelRecord data = new ProductLabelRecord()
                {
                    Id = IdHelper.GetId(IdType.Guid,"",""),
                    ProductId = selectedProduct.ProductId,
                    //暂时用雪花ID
                    ProductSN = IdHelper.GetId(IdType.Snowflake).ToString(),
                    ProductSpec = selectedProduct.ProductSpec,
                    ProductUnit = selectedProduct.ProductUnit,
                    ProductLength = "1000",
                    BatchId = IdHelper.GetId(IdType.Batch,"",""),
                    //初始状态参数
                    StatusMark = 0,
                    DeleteMark = 0,
                    EnableMark = 1,

                    //重要输入参数绑定
                    PrintIn_StoreId = ckId,
                    StoreId = ckId,
                    MixDegree = hjd,
                    GroWeight = mz,
                    Num = jz,
                    StoreNum = jz,


                    //其他暂时不重要
                    InStorePlaceId = "",
                    OrignBillId = "",
                    SupplierId = "",
                    SupplierName = "",

                    
                    CreateDate = DateTime.Now,
                    CreateUserId = "Admin",
                    CreateUserName = "何旭阳",

                };
                _printbus.SaveData(data);
                //打印
                PicPreview.Image = data.ProductSN.ToQrCode();
                List<string> filter = new List<string>();
                filter.Add(" order by a.CreateDate desc");
                DgvLs.DataSource= _printbus.GetTableTop10(filter);
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
            LabJz.Text = jz.ToString();
            LabMsg.Text = msg;
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
    }
}
