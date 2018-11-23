using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ShippingNote.SN_Yield
{
    public partial class FormModel : Form
    {
        private ArrayList _AryListSelect;
        public ArrayList AryListListBoxSelect
        {
            get { return _AryListSelect; }
            set { _AryListSelect = value; }
        }

        public FormModel(ListBox lstBox, DataTable dt, string ColumnName)
        {
            InitializeComponent();
            this.Text = ColumnName;//设定from的标题
            foreach (var item in lstBox.Items)
            {
                listBoxSelect.Items.Add(item);
            }
            foreach (DataRow item in dt.Rows)
            {
                listBoxNotSelect.Items.Add(item[ColumnName].ToString());
            }
            foreach (var Select in listBoxSelect.Items)
            {
                listBoxNotSelect.Items.Remove(Select);
            }
        }

        //批量向右
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxNotSelect.Items.Count == 0) return;
            if (listBoxNotSelect.SelectedIndex == -1) listBoxNotSelect.SetSelected(0, true);//如果没有选中默认选中第一行
            ArrayList list = new ArrayList();
            foreach (var item in listBoxNotSelect.SelectedItems)
            {
                list.Add(item);
                listBoxSelect.Items.Add(item);

            }
            int index = listBoxNotSelect.Items.IndexOf(list[0]);
            foreach (var item in list)
            {
                listBoxNotSelect.Items.Remove(item);
            }
            if (listBoxNotSelect.Items.Count != 0)
            {
                try { listBoxNotSelect.SetSelected(index, true); }
                catch { listBoxNotSelect.SetSelected(listBoxNotSelect.Items.Count - 1, true); }
            }

        }
        //全部向右按钮事件
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in listBoxNotSelect.Items)
            {
                listBoxSelect.Items.Add(item);
            }
            listBoxNotSelect.Items.Clear();
        }
        //全部向左按钮事件
        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var item in listBoxSelect.Items)
            {
                listBoxNotSelect.Items.Add(item);
            }
            listBoxSelect.Items.Clear();
        }
        //批量向左
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBoxSelect.Items.Count == 0) return;
            if (listBoxSelect.SelectedIndex == -1) listBoxSelect.SetSelected(0, true);
            ArrayList list = new ArrayList();
            foreach (var item in listBoxSelect.SelectedItems)
            {
                list.Add(item);
                listBoxNotSelect.Items.Add(item);
            }
            int index = listBoxSelect.Items.IndexOf(list[0]);
            foreach (var item in list)
            {
                listBoxSelect.Items.Remove(item);
            }
            if (listBoxSelect.Items.Count != 0)
            {
                try { listBoxSelect.SetSelected(index, true); }
                catch { listBoxSelect.SetSelected(listBoxSelect.Items.Count - 1, true); }
            }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            _AryListSelect = new ArrayList();
            foreach (var item in listBoxSelect.Items)
            {

                _AryListSelect.Add(item);
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        

        
    }
}
