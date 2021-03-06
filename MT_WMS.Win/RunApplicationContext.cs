﻿#region
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  Hex 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：LAPTOP-1UF0J9CM
 * 命名空间：MT_WMS.Win
 * 唯一标识：d47b8685-7360-480d-b40f-85da87e19665
 * 文件名：RunApplicationContext
 * 当前用户域：LAPTOP-1UF0J9CM
 * 
 * 创建者：52270
 * 微信:hxy15937916521
 * 创建时间：2021/01/14 9:10:51
 * 描述：
 *
 * ----------------------------------------------------------------
 */
#endregion
using CSharpWin;
using MT_WMS.Win.MT;
using MT_WMS.Win.OtherForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_WMS.Win
{
    public class RunApplicationContext: ApplicationContext
    {
        /// <summary>
        /// 程序运行执行窗口
        /// </summary>
        public RunApplicationContext()
        {
            try
            {
                StartRunFrm();
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// 第一个启动窗体
        /// </summary>
        void StartRunFrm()
        {
            //数据加载窗口
            base.MainForm= FrmLoading.Instance;
            base.MainForm.Show();
        }
        protected override void OnMainFormClosed(object sender, EventArgs e)
        {

            if (sender is FrmLoading)
            {
                if (((FrmLoading)sender).IsShow == false)
                {
                    base.MainForm = new FrmLogin();
                    base.MainForm.Show();
                }
                else
                {
                    base.OnMainFormClosed(sender, e);
                }
            }
            else if(sender is FrmLogin)
            {
                string FrmMain = ((FrmLogin)sender).OpenForm;
                var FrmMainType = GlobalSwitch.Instance.AllTypes.Where(x=>x.FullName==FrmMain).FirstOrDefault();
                var isLogin = ((FrmLogin)sender).IsLogin;
                if (isLogin)
                {
                    if (!FrmMainType.IsNullOrEmpty())
                    {
                        base.MainForm = (Form)Activator.CreateInstance(FrmMainType, null);
                        base.MainForm.Show();
                    }
                    else
                    {
                        FrmContact frmContact = new FrmContact("不支持启动的系统，请与开发商联系！");
                        frmContact.ShowDialog();
                        base.OnMainFormClosed(sender, e);
                    }
                }
                else
                {
                    base.OnMainFormClosed(sender, e);
                }
            }
            else
            {
                base.OnMainFormClosed(sender, e);
            }
        }
    }
}
