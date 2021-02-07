using MT_WMS.IBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_WMS.Win.OtherForm
{
    /// <summary>
    /// 网络通讯检测、基础数据加载窗体
    /// </summary>
    public partial class FrmLoading : BaseUI
    {

        public FrmLoading()
        {
            InitializeComponent();
            action += LoadAssemblyData;
            action += NetCheck;
            action += LoadNetData;
            action += Check;
            msg = SendMsg;
            Exit += ExitForm;
            t = new Thread(new ThreadStart(action));
            t.IsBackground = true;
            t.Start();
        }

        protected override void OnClosed(EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        ISysObjectBusiness sys = FactoryService.Build<ISysObjectBusiness>("MT_WMS.Business.MT.SysObjectBusiness");
        IBaseBusiness check = FactoryService.Build<IBaseBusiness>("MT_WMS.Business.MT.SysObjectValueBusiness");
        private static FrmLoading instance;
        public static FrmLoading Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new FrmLoading();
                return instance;
            }
        }
        Thread t;
        public bool IsLoadAssemblyData = false;
        public bool IsNetCheck = false;
        public bool IsLoadNetData = false;
        //默认为true打开状态
        public bool IsShow = true;

        Action action;

        Action Exit;

        Action<string> msg;




        /// <summary>
        /// 加载程序集合
        /// 执行顺序1
        /// </summary>
        /// <returns></returns>
        public void LoadAssemblyData()
        {
            try
            {
                Invoke(msg, "加载本地程序集...");
                //先清空一下原有的程序集合和类型集合
                GlobalSwitch.Instance.AllTypes.Clear();
                GlobalSwitch.Instance.AllAssemblies.Clear();
                //反射程序集合，且解析程序集合内的类和方法
                var assembly = System.Reflection.Assembly.GetEntryAssembly();
                GlobalSwitch.Instance.AddAssembly(assembly);
                IsLoadAssemblyData = true;
                Invoke(msg, "程序集完成...");
            }
            catch
            {
                
                Invoke(msg, "程序集加载失败...");
                IsLoadAssemblyData = false;

            }

        }
        /// <summary>
        /// 网络检测
        /// 执行顺序2
        /// </summary>
        /// <returns></returns>
        public void NetCheck()
        {
            try
            {
                Invoke(msg, "网络检测...");
                IsNetCheck = check.NetCheck();
                Invoke(msg, "网络检测通过...");
            }
            catch 
            {

                Invoke(msg, "网络检测不通过...");
                IsNetCheck = false;
                ShowMsg("网络检测不通过");
            }
        }
        /// <summary>
        /// 加载网络基础数据
        /// 执行顺序3
        /// </summary>
        /// <returns></returns>
        public void LoadNetData()
        {
            try
            {
                Invoke(msg, "加载服务器数据中...");
                sys.UpdateObject();
                IsLoadNetData = true;
                Invoke(msg, "加载服务器数据完成...");
                Invoke(msg, "加载完毕！");
                Thread.Sleep(100);
            }
            catch 
            {
                Invoke(msg, "服务器数据加载失败...");

                IsLoadNetData = false;
            }

        }

        public void Check()
        {
            if (IsNetCheck==true&&IsLoadNetData==true)
            {
                IsShow = false;
            }
            else
            {
                IsShow = true;
            }
            this.Invoke(Exit);
        }

        public void ExitForm()
        {
            this.Close();
        }
        public void SendMsg(string msg)
        {
            Msg.Text = msg;
        }

    }
}
