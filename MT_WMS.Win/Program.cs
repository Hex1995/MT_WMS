using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MT_WMS;
using MT_WMS.IBusiness;
using MT_WMS.Win.MT;
using MT_WMS.Win.OtherForm;
using MT_WMS.Win.Test;

namespace MT_WMS.Win
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            //UI线程全局捕获
            Application.ThreadException += Application_ThreadException;
            //线程内部错误全局捕获
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //new FrmMTMain()
            Application.Run(new RunApplicationContext());
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            string str = GetExceptionMsg((Exception)e.ExceptionObject, e.ToString());
            //log
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            string str = GetExceptionMsg(e.Exception, e.ToString());
            //log

        }
        /// <summary>
        /// 获取错误消息
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="backStr"></param>
        /// <returns></returns>
        static string GetExceptionMsg(Exception ex, string backStr)
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("****************************异常消息****************************");
            str.AppendLine("【出现时间】：" + DateTime.Now.ToString());
            if (ex != null)
            {
                str.AppendLine("【异常类型】：" + ex.GetType().Name);
                str.AppendLine("【异常信息】：" + ex.Message);
                str.AppendLine("【堆栈调用】：" + ex.StackTrace);
                //FrmTips.ShowTipsError(null, ex.Message);
            }
            else
            {
                str.AppendLine("【未处理异常】：" + backStr);
            }
            str.AppendLine("***************************************************************");
            return str.ToString();
        }
    }
}
