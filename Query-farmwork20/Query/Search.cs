using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShippingNote.SN_Yield
{
    public partial class Search : Form
    {
        private string _dataGridViewSelect;
        public string dataGridViewSelect
        {
            get { return _dataGridViewSelect; }
            set { _dataGridViewSelect = value; }
        }

        private DataGridViewRow _dataGridViewSelectALL;
        public DataGridViewRow dataGridViewSelectALL
        {
            get { return _dataGridViewSelectALL; }
            set { _dataGridViewSelectALL = value; }
        }
        DataTable dtSave = new DataTable();
        string columnNameSave = "";

        public Search(DataTable dt, string ColumnName)
        {
            InitializeComponent();
            columnNameSave = ColumnName;
            dtSave = dt;
            this.Text = ColumnName;
            dataGridView1.DataSource = dt;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _dataGridViewSelect = dataGridView1.CurrentRow.Cells[0].Value.ToString();//返回datagridview选中的行的第一列的值
            _dataGridViewSelectALL = dataGridView1.CurrentRow;//返回datagridview选中的行的所有值。
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = dtSave.Select(columnNameSave + " like %" + txtSeach.Text.Trim()+"%");
            DataView dv = dtSave.DefaultView;
            dv.RowFilter = columnNameSave + " like '%" + txtSeach.Text.Trim() + "%'";
            dataGridView1.DataSource = dv.ToTable();
            //dataGridView1.DataSource = dtSave.Select("MODEL_NAME like '%A%'");
        }
    }
}
