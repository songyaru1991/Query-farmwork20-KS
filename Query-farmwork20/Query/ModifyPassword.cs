using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Query
{
    public partial class ModifyPassword : Form
    {
        MySqlHelper Querydt = new MySqlHelper();

        public ModifyPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Trim() == "" || txtNewPasswordConfirm.Text.Trim() == "") return;
            if (txtNewPassword.Text.Trim().Length <= 4)
            {
                MessageBox.Show("新密碼長度不符！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
 
            }
            if (txtNewPassword.Text.Trim() != txtNewPasswordConfirm.Text.Trim())
            {
                MessageBox.Show("兩密碼不相同，重新輸入！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtNewPasswordConfirm.Text.Trim() == GlobalString._Password)
            {
                MessageBox.Show("新舊密碼不可相同！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            string connsql = "";
            //if (GlobalString._BU == "通訊")
            //{
            //    connsql = "server=192.168.60.111;userid=qr;password=realtime_qr;database=;charset=utf8";
            //}
            //else
            //{
            //    connsql = "server=192.168.60.112;userid=qr;password=realtime_qr;database=;charset=utf8";
            //}
            foreach (string item in GlobalString._ListBU)
            {
                if (item == "通訊")
                {
                    connsql = "server=192.168.78.152;userid=root;password=foxlink;database=;charset=utf8";
                }
                else if (item == "零組件")
                {
                    connsql = "server=192.168.78.153;userid=root;password=foxlink;database=;charset=utf8";

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
                    strSQL = "update swipecard.user_data set Password='" + txtNewPasswordConfirm.Text.Trim() + "', chpass_time=NOW() where UserID='" + GlobalString._UserID + "'";
                    cmd.CommandText = strSQL;
                    cmd.ExecuteNonQuery();
                    tx.Commit();
                    MessageBox.Show("更改密碼成功,請用新密碼登錄", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    MessageBox.Show("更改密碼失敗！" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }
            
            

        

        private void txtNewPasswordConfirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
