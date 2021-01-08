using MT_WMS.Entitys;
using MT_WMS.IBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_WMS.Win.ControlLibrary.Forms.SYS
{
    public partial class FrmDeleteObject : BaseFrm
    {
        
        public FrmDeleteObject()
        {
            InitializeComponent();
            RefreshObjectData();
        }
        void RefreshObjectData()
        {
            objectdata = _object.GetAllData();
            TrvObject.Nodes.Clear();

            foreach (var item in objectdata)
            {
                TreeNode t = new TreeNode()
                {
                    Name = item.OBJECTNAME,
                    Tag = item.OBJECTID,
                    Text=item.OBJECTNAME
                };
                TrvObject.Nodes.Add(t);
            }
            _object.UpdateObject();

        }
        void RefreshValueData()
        {
            TrvObjectValue.Nodes.Clear();
            var node = TrvObject.SelectedNode;
            if (node.IsNullOrEmpty())
                valuedata.Clear();
            else
            {
                valuedata = _value.GetDataListByObjectid(node.Tag.ToString());
                foreach (var item in valuedata)
                {
                    TreeNode t = new TreeNode()
                    {
                        Name = item.OBJECTVALUE,
                        Tag = item.PKID,
                        Text = item.OBJECTVALUE
                    };
                    TrvObjectValue.Nodes.Add(t);
                }
            }
            _object.UpdateObject();


        }
        List<SYSOBJECT> objectdata = new List<SYSOBJECT>();
        List<SYSOBJECTVALUE> valuedata = new List<SYSOBJECTVALUE>();
        ISysObjectBusiness _object = FactoryService.BulidByConfigKey<ISysObjectBusiness>("SYS0001");
        ISysObjectValueBusiness _value = FactoryService.BulidByConfigKey<ISysObjectValueBusiness>("SYS0002");
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshObjectData();
        }

        private void TrvObject_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }

        private void TrvObject_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var objectid = e.Node.Tag.ToString();
            if (!objectid.IsNullOrEmpty())
            {
                valuedata.Clear();
                valuedata.AddRange(_value.GetDataListByObjectid(objectid));
                RefreshValueData();
                label2.Text = $"【{e.Node.Text}】对象值";
            }
        }
        //删除对象
        private void BtnDeleteObject_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder("");
            var select = GetCheckNode(TrvObject.Nodes);
            List<string> ids = new List<string>();
            foreach (var item in select)
            {
                ids.Add((string)item.Tag);
                str.Append($"已删除对象【{item.Text}】\n\r");
            }
            var data = ids.Count > 0 ? _object.DeleteData(ids) : 0;
            if (data > 0)
            {
                RefreshObjectData();
                MessageBox.Show($"删除{data}条数据\n\r{str.ToString()}", "删除提醒");
            }
            else
                MessageBox.Show($"未删除任何数据", "删除提醒");
        }
        //删除对象值
        private void BtnDeleteObjectValue_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder("");
            var select = GetCheckNode(TrvObjectValue.Nodes);
            List<int> ids = new List<int>();
            foreach (var item in select)
            {
                ids.Add((int)item.Tag);
                str.Append($"已删除对象值【{item.Text}】\n\r");
            }
            var data =  ids.Count>0? _value.DeleteData(ids):0;
            if (data > 0)
            {
                RefreshValueData();
                MessageBox.Show($"删除{data}条数据\n\r{str.ToString()}","删除提醒");
            }
            else
                MessageBox.Show($"未删除任何数据", "删除提醒");
        }



        List<TreeNode> GetCheckNode(TreeNodeCollection nodes)
        {
            List<TreeNode> selectNodes = new List<TreeNode>();
            foreach (TreeNode item in nodes)
            {
                if (item.Checked)
                {
                    selectNodes.Add(item);
                }
            }
            return selectNodes;
        }
    }
}
