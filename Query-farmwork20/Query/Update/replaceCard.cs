using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Query.Update
{
    public partial class replaceCard : Form
    {
        DataTable dtQuery = new DataTable();
        MySqlHelper Querydt = new MySqlHelper();

        public replaceCard()
        {
            InitializeComponent();
        }

        //初始资料
        private void Initial(bool b)
        {
            if (b) txtBoxEmp.Text = "";
            txtNewCardID.Text = "";
            txtOldCardID.Text = "";
            txtName.Text = "";
            txtDept.Text = "";
            txtNewCardID.Text = "";
            if(b) comBoxBU.SelectedIndex = -1;
            dtQuery.Clear();
            txtBoxEmp.Focus();
            //txtBoxEmp.Select();
        }

        private void txtNewCardID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtNewCardID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.V))
            {
                if (Clipboard.ContainsText())
                {
                    try
                    {
                        Convert.ToInt64(Clipboard.GetText());  //检查是否数字
                        ((TextBox)sender).SelectedText = Clipboard.GetText().Trim(); //Ctrl+V 粘贴  
                        if (((TextBox)sender).TextLength > 10)
                        {
                            ((TextBox)sender).Text = ((TextBox)sender).Text.Remove(10); //TextBox最大长度为10  移除多余的
                        }
                    }
                    catch (Exception)
                    {
                        e.Handled = true;
                        //throw;
                    }
                }
            }
        }

        private void txtBoxEmp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !txtBoxEmp.Text.Trim().Equals("")&&comBoxBU.Text!="")
            {
                //清空资料。
                Initial(false);
                #region MySQL语句
                string SQL = "select  ID, Name, depid, depname,cardid from swipecard.testemployee where ID='" + txtBoxEmp.Text + "'";
                #endregion
                try
                {
                    if (comBoxBU.Text == "CSBG")
                    {
                        dtQuery = Querydt.QueryDB(SQL);
                    }
                    else
                    {
                        dtQuery = Querydt.QueryDbAsbg(SQL);
                    }
                    if (dtQuery != null && dtQuery.Rows.Count > 0)
                    {
                        txtName.Text = dtQuery.Rows[0]["Name"].ToString();
                        txtDept.Text = dtQuery.Rows[0]["depid"].ToString();
                        txtOldCardID.Text = dtQuery.Rows[0]["cardid"].ToString();
                        txtNewCardID.Focus();
                    }
                    else
                    {
                        MessageBox.Show(" No Data！", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBoxEmp.SelectAll();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Query Data Error！" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNewCardID.Text.Trim().Length < 10)
            {
                MessageBox.Show("NewCard Length Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewCardID.Focus();
                txtNewCardID.SelectAll();
                return;
            }
            if (comBoxBU.Text.Trim() == "" || txtBoxEmp.Text.Trim() == ""||txtDept.Text.Trim()==""||txtName.Text.Trim()==""||txtOldCardID.Text.Trim()==""||txtNewCardID.Text.Trim()=="") return;
          

            String connsql="";

            if (comBoxBU.Text == "CSBG")
            {
                connsql = "server=192.168.60.111;userid=hr;password=hr;database=;charset=utf8";
            }
            else
            {
                connsql = "server=192.168.60.112;userid=hr;password=hr;database=;charset=utf8";
            }
            
            MySqlConnection MySqlConn = new MySqlConnection(connsql);
            MySqlConn.Open();
            MySqlTransaction tx = MySqlConn.BeginTransaction();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = MySqlConn;
            cmd.Transaction = tx;
            string strSQL = "";
            try
            {
                strSQL = "UPDATE swipecard.testswipecardtime SET CardID = '" + txtNewCardID.Text.Trim() + "' WHERE     CardID = '" + txtOldCardID.Text.Trim() + "' AND (DATE_FORMAT(swipecardtime, '%Y%m%d') > curdate()-31 OR DATE_FORMAT(swipecardtime2, '%Y%m%d') > curdate()-31)";
                cmd.CommandText = strSQL;
                cmd.ExecuteNonQuery();
                strSQL = "UPDATE swipecard.testswipecardtime_ht SET CardID = '" + txtNewCardID.Text.Trim() + "' WHERE     CardID = '" + txtOldCardID.Text.Trim() + "' AND (DATE_FORMAT(swipecardtime, '%Y%m%d') > curdate()-31 OR DATE_FORMAT(swipecardtime2, '%Y%m%d') > curdate()-31)";
                cmd.CommandText = strSQL;
                cmd.ExecuteNonQuery();

                strSQL = "update swipecard.testemployee SET cardid = '" + txtNewCardID.Text.Trim() + "',updateDate = curdate() WHERE ID = '" + dtQuery.Rows[0]["ID"].ToString() + "'";
                cmd.CommandText = strSQL;
                cmd.ExecuteNonQuery();
                tx.Commit();
                MessageBox.Show("Update OK！" , "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Initial(true);
            }
            catch (Exception ex)
            {
                tx.Rollback();
                MessageBox.Show("Update Error！" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (MySqlConn != null)
                {
                    MySqlConn.Close();
                    MySqlConn.Dispose();
                }
                if (tx != null) tx.Dispose();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Initial(true);
            txtBoxEmp.Focus();
        }

        private void replaceCard_Load(object sender, EventArgs e)
        {
            Initial(true);
           
        }

       
    }
}
