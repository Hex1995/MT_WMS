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
        /// 每隔10毫秒读取秤砣数据的线程
        /// </summary>
        Thread thread;
        IProductLabelRecordBusiness _printbus= FactoryService.BulidByConfigKey<IProductLabelRecordBusiness>("MT0002");
        IProductBusiness _bus= FactoryService.BulidByConfigKey<IProductBusiness>("MT0001");
        private void BtnQuery_Click(object sender, EventArgs e)
        {
            var name = TxtName.Text;
            List<string> filter = new List<string>();
            filter.Add($"ProductName like'%{name}%'");
            Dgv.DataSource = _bus.GetProducts(filter);

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            pz = zzl;
            RefreshLabData();

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
                RefreshLabData();
                string ckId = ((ComboxItem)cbbCK.SelectedItem).Value();
                string hjd = ((ComboxItem)cbbhjd.SelectedItem).Value();

                //提交数据
                ProductLabelRecord data = new ProductLabelRecord()
                {
                    BatchId = "1",
                    CreateDate = DateTime.Now,
                    CreateUserId = "Admin",
                    CreateUserName = "何旭阳",
                    DeleteMark = 0,
                    EnableMark = 1,
                    Id = Guid.NewGuid().ToString(),
                    PrintIn_StoreId = ckId,
                    StoreId = ckId,
                    StatusMark = 0,
                    GroWeight = mz,
                    MixDegree = hjd,
                    Num = zzl,
                    InStorePlaceId = "",
                    OrignBillId = "",
                    SupplierId = "",
                    SupplierName = "",
                    StoreNum = jz,


                };

                _printbus.SaveData(data);
            }
            


        }
        /// <summary>
        /// 刷新相关数据
        /// </summary>
        private void RefreshLabData()
        {
            LabZZL.Text = zzl.ToString();
            LabJz.Text = jz.ToString();
            LabMZ.Text = mz.ToString();
            LabPZ.Text = pz.ToString();
            LabMsg.Text = msg;
        }
        
        /// <summary>
        /// 循环读取数据
        /// </summary>
        private void LoopGetZzl()
        {
            Action action = new Action(RefreshLabData);
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
            if (Dgv.DataSource==null&& Dgv.Rows.Count<=0)
            {
                msg = "系统:无数据";
            }
            else
            {
                var select = Dgv.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (select>0)
                {
                    var dr = Dgv.SelectedRows[0];
                    var tmp = new Product();
                    

                }
            }
        }
    }
}
