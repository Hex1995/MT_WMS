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
            Thread t = new Thread(new ThreadStart(action));
            t.IsBackground = true;
            //t.Start();
        }

        protected override void OnClosed(EventArgs e)
        {
            Instance.Dispose();
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

        public bool IsLoadAssemblyData = false;
        public bool IsNetCheck = false;
        public bool IsLoadNetData = false;
        //默认为true打开状态
        public bool IsShow = true;
        Action action;
        /// <summary>
        /// 加载程序集合
        /// 执行顺序1
        /// </summary>
        /// <returns></returns>
        public void LoadAssemblyData()
        {
            try
            {
                //先清空一下原有的程序集合和类型集合
                GlobalSwitch.Instance.AllTypes.Clear();
                GlobalSwitch.Instance.AllAssemblies.Clear();
                //反射程序集合，且解析程序集合内的类和方法
                var assembly = System.Reflection.Assembly.GetEntryAssembly();
                GlobalSwitch.Instance.AddAssembly(assembly);
                IsLoadAssemblyData = true;
            }
            catch
            {
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
                IsNetCheck = check.NetCheck();
            }
            catch 
            {

                IsNetCheck = false;
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
                sys.UpdateObject();
                IsLoadNetData = true;
            }
            catch 
            {
                IsLoadNetData = false;
            }

        }

        public void Check()
        {
            if (IsNetCheck==true&&IsLoadNetData==true)
            {
                IsShow = false;
                Action a = Close;
                Invoke(a);
            }
        }
        
    }
}
