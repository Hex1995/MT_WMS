using CSharpWin;
using MT_WMS.Win.ControlLibrary.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_WMS.Win.OtherForm
{
    /// <summary>
    /// 河南万和科技 登录窗口
    /// </summary>
    public partial class FrmLogin : BaseUI
    {
        public FrmLogin()
        {
            InitializeComponent();
            InitialItems("系统", cbbSystem);
            var types = GlobalSwitch.Instance.AllTypes.Where(x => x.IsSubclassOf(typeof(BaseUI)) || x.IsSubclassOf(typeof(BaseFrm))).ToList();
#if DEBUG
            txtAccount.Text = "Admin";
            txtPwd.Text = "Admin";
            List<ComboxItem> data = new List<ComboxItem>();
            foreach (var item in types)
            {
                data.Add(new ComboxItem(item.FullName, item.Name));
            }
            cbbSystem.Items.AddRange(data.ToArray());
#endif
        }
        /// <summary>
        /// 是否登录成功
        /// </summary>
        public bool IsLogin = false;
        /// <summary>
        /// 要开启的窗口
        /// </summary>
        public string OpenForm = "";

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text.Trim();
            string pwd = txtPwd.Text.Trim();
            OpenForm = ((ComboxItem)cbbSystem.SelectedItem).IsNullOrEmpty() ? "" : ((ComboxItem)cbbSystem.SelectedItem).Value();
            if (account.IsNullOrEmpty())
            {
                MessageBoxEx.Show("请输入账号");
                return;
            }
            if (pwd.IsNullOrEmpty())
            {
                MessageBoxEx.Show("请输入密码");
                return;
            }
            if (OpenForm.IsNullOrEmpty())
            {
                MessageBoxEx.Show("请选择登录系统");
            }
            else
            {
                //登录代码在这写
                IsLogin = true;
                this.Close();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            try
            {
                if (keyData == Keys.Enter)
                {
                    BtnLogin_Click(null, null);
                    return true;
                }
                else if (keyData ==Keys.Escape)
                {
                    BtnExit_Click(null, null);
                    return true;
                }
            }
            catch
            {
                return false;
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }
        /// <summary>
        /// 初始化ComboBox的值
        /// 指定
        /// </summary>
        /// <param name="obj">权限对象</param>
        /// <param name="ctr"></param>
        /// <param name="defaultSelect">默认选择项的值</param>
        private static void InitialItems(string obj, ComboBox ctr, string defaultSelect = "")
        {
            ctr.Items.Clear();
            if (GlobalSwitch.Instance.objValues != null && GlobalSwitch.Instance.objValues.Count > 0)
            {
                if (GlobalSwitch.Instance.objValues.Keys.Contains(obj))
                {
                    List<ComboxItem> data = new List<ComboxItem>();
                    foreach (KeyValuePair<string, string> dic in GlobalSwitch.Instance.objValues[obj])
                    {
                        if (!string.IsNullOrEmpty(dic.Key))
                        {
                            data.Add(new ComboxItem(dic.Key, dic.Value));

                        }
                    }
                    ctr.Items.AddRange(data.ToArray());
                    if (!defaultSelect.IsNullOrEmpty())
                    {
                        var tmp = data.Where(x => x.Value() == defaultSelect || x.ToString() == defaultSelect).FirstOrDefault();
                        if (!tmp.IsNullOrEmpty())
                        {
                            ctr.SelectedIndex = ctr.Items.IndexOf(tmp);
                        }
                    }
                    else
                    {
                        if (ctr.Items.Count > 0)
                        {
                            ctr.SelectedIndex = 0;
                        }
                    }

                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
