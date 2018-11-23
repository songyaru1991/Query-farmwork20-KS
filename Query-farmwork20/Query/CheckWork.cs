using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Query
{
    public partial class CheckWork : Form
    {
        DataTable dtQuery = new DataTable();
        MySqlHelper Querydt = new MySqlHelper();
        //暂存导入的员工工号/
        string strEmp = "";
        //暂存导入的費用代碼
        string strCost = "";
        //暂存此登錄者可查詢Cost
        string strUserDataCost = "";

        public CheckWork()
        {
            InitializeComponent();
        }

        private void Initial()
        {
            txtEmp.Text = "";
           
            txtCostID.Text = "";
            checkBoxEmp.Checked = false;
            CheckBoxCost.Checked = false;
            btnExportEmp.Enabled = false;
            btnExportCost.Enabled = false;
            dateTimePickStart.Value = DateTime.Now;
            dateTimePickEnd.Value = DateTime.Now;
            
            strEmp = "";
            strCost = "";
            dataGridView1.Rows.Clear();
            labSum.Text = "0";
            labSumEmp.Text = "0";
            labSumCost.Text = "0";
            dtQuery.Clear();
            comBoxBU.SelectedIndex = 0;
            txtEmp.Focus();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEmp.Checked)
            {
                
                CheckBoxCost.Checked = false;
                btnExportEmp.Enabled = true;
               
                strCost = "";
                
                labSumCost.Text = "0";
                txtEmp.Text = ""; txtEmp.Enabled = false;
                
                txtCostID.Text = ""; txtCostID.Enabled = false;

            }
            else
            {
                btnExportEmp.Enabled = false;
                strEmp = "";
                labSumEmp.Text = "0";
                txtEmp.Text = ""; txtEmp.Enabled = true;
               
                txtCostID.Text = ""; txtCostID.Enabled = true;
                txtEmp.Focus();

            }
        }
        private void CheckBoxCost_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxCost.Checked)
            {
                checkBoxEmp.Checked = false;
               
                btnExportCost.Enabled = true;
                strEmp = "";
                
                labSumEmp.Text = "0";
               
                txtEmp.Text = ""; txtEmp.Enabled = false;
                
                txtCostID.Text = ""; txtCostID.Enabled = false;
            }
            else
            {
                btnExportCost.Enabled = false;
                strCost = "";
                labSumCost.Text = "0";
                txtEmp.Text = ""; txtEmp.Enabled = true;
                
                txtCostID.Text = ""; txtCostID.Enabled = true;
                txtEmp.Focus();

            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            //if (comBoxBU.Text.Trim() == "") { MessageBox.Show("請選擇事業群！", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); return; };

            if (GlobalString._CostID == "" && GlobalString._Query_CostID == "")
            {
                MessageBox.Show("無查詢權限！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (GlobalString._Query_CostID != "")
            {
                if (GlobalString._Query_CostID != "ALL")
                {
                    strUserDataCost = " and costID in (" + GlobalString._Query_CostID + ") ";
                }
            }
            else if (GlobalString._Query_CostID == "")
            {
                strUserDataCost = " and costID in (" + GlobalString._CostID + ") ";
            }

            string sStartDate = "", sEndDate = "", sstarttime = "", sendtime = "";
            sStartDate = dateTimePickStart.Value.ToString("yyyy/MM/dd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            sEndDate = dateTimePickEnd.Value.ToString("yyyy/MM/dd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            //sstarttime = sStartDate + " " + cmBoxStartHour.Text.Trim() + ":" + cmBoxStartMinute.Text.Trim();
            //sendtime = sEndDate + " " + cmBoxEndHour.Text.Trim() + ":" + cmBoxEndMinute.Text.Trim();
            string strSQL = "";
            labSum.Text = "0";
            dtQuery.Clear();
            dataGridView1.Rows.Clear();
            if (checkBoxEmp.Checked && Convert.ToInt32(labSumEmp.Text) > 0)
            {
                strSQL = "select  id 員工號, name 姓名, Depid 部門代碼, costID 費用代碼, Direct 直間接, overTimeDate 日期, Shift 班別, WorkContent 加班內容, overtimeHours 加班時數, overtimeType 加班類型, overtimeInterval 加班時段, application_person 助理姓名, application_id 助理工號, case notesStates when 0 then '未生成加班單' when 1 then '已生成加班單'  when 2 then '生成加班單異常' end notes狀態, Reason NOTES回饋原因, BackTime NOTES回饋時間, Workshopno 車間 FROM swipecard.notes_overtime_state where DATE_FORMAT(overTimeDate, '%Y/%m/%d')>='" + sStartDate + "' and DATE_FORMAT(overTimeDate, '%Y/%m/%d') <='" + sEndDate + "'  and ( " + strEmp + " ) " + strUserDataCost + " order by Depid, overTimeDate, id";
                QueryBU(strSQL, comBoxBU.Text);
            }
            else if (CheckBoxCost.Checked && Convert.ToInt32(labSumCost.Text) > 0)
            {
                strSQL = "select  id 員工號, name 姓名, Depid 部門代碼, costID 費用代碼, Direct 直間接, overTimeDate 日期, Shift 班別, WorkContent 加班內容, overtimeHours 加班時數, overtimeType 加班類型, overtimeInterval 加班時段, application_person 助理姓名, application_id 助理工號, case notesStates when 0 then '未生成加班單' when 1 then '已生成加班單'  when 2 then '生成加班單異常' end notes狀態, Reason NOTES回饋原因, BackTime NOTES回饋時間, Workshopno 車間 FROM swipecard.notes_overtime_state where DATE_FORMAT(overTimeDate, '%Y/%m/%d')>='" + sStartDate + "' and DATE_FORMAT(overTimeDate, '%Y/%m/%d') <='" + sEndDate + "'  and costID in ( " + strCost + " ) " + strUserDataCost + " order by Depid, overTimeDate, id";
                QueryBU(strSQL, comBoxBU.Text);
            }
            else if (!checkBoxEmp.Checked && !CheckBoxCost.Checked)
            {
                if (txtEmp.Text.Trim() == "" && txtCostID.Text.Trim() == "") return;
                string strEmpp = txtEmp.Text.Trim() == "" ? " " : " and id='" + txtEmp.Text.Trim() + "' ";
                string strCostt = txtCostID.Text.Trim() == "" ? " " : " and costID='" + txtCostID.Text.Trim() + "' ";
                if (GlobalString._Query_CostID != "ALL")
                {
                    strSQL = "select costID FROM swipecard.testemployee emp where 1=1 " + strEmpp + strCostt;
                    DataTable dt = new DataTable();
                    try
                    {
                        if (comBoxBU.Text == "通訊")
                        {
                            dt = Querydt.QueryDB(strSQL);
                        }
                        else
                        {
                            dt = Querydt.QueryDbAsbg(strSQL);
                        }
                        if (dt != null && dt.Rows.Count > 0)
                        {
                            foreach (DataRow item in dt.Rows)
                            {
                                if (!GlobalString._ListCostID.Contains(item[0].ToString()) && !GlobalString._ListQuery_CostID.Contains(item[0].ToString()))
                                {
                                    MessageBox.Show("無此資料查詢權限！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("查詢DB出錯！" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                strSQL = "select  id 員工號, name 姓名, Depid 部門代碼, costID 費用代碼, Direct 直間接, overTimeDate 日期, Shift 班別, WorkContent 加班內容, overtimeHours 加班時數, overtimeType 加班類型, overtimeInterval 加班時段, application_person 助理姓名, application_id 助理工號, case notesStates when 0 then '未生成加班單' when 1 then '已生成加班單'  when 2 then '生成加班單異常' end notes狀態, Reason NOTES回饋原因, BackTime NOTES回饋時間, Workshopno 車間 FROM swipecard.notes_overtime_state where DATE_FORMAT(overTimeDate, '%Y/%m/%d')>='" + sStartDate + "' and DATE_FORMAT(overTimeDate, '%Y/%m/%d') <='" + sEndDate + "' " + strEmpp + strCostt + strUserDataCost + " order by Depid, overTimeDate, id";
                QueryBU(strSQL, comBoxBU.Text);
            }
        }

        private void QueryBU(string strSQL, string strBU)
        {
            try
            {
                if (strBU == "通訊")
                {
                    dtQuery = Querydt.QueryDB(strSQL);
                }
                else
                {
                    dtQuery = Querydt.QueryDbAsbg(strSQL);
                }
                if (dtQuery != null && dtQuery.Rows.Count > 0)
                {
                    labSum.Text = dtQuery.Rows.Count.ToString();

                    foreach (DataRow item in dtQuery.Rows)
                    {
                        dataGridView1.Rows.Add(item["員工號"].ToString(),
                                               item["姓名"].ToString(),
                                               item["部門代碼"].ToString(),
                                               item["費用代碼"].ToString(),
                                               item["直間接"].ToString(),
                                               item["日期"].ToString(),
                                               item["班別"].ToString(),
                                               item["加班內容"].ToString(),
                                               item["加班時數"].ToString(),
                                               item["加班類型"].ToString(),
                                               item["加班時段"].ToString(),
                                               item["助理姓名"].ToString(),
                                               item["助理工號"].ToString(),
                                               item["notes狀態"].ToString(),
                                               item["NOTES回饋原因"].ToString(),
                                               item["NOTES回饋時間"].ToString(),
                                               item["車間"].ToString());




                    }
                }
                else
                {
                    MessageBox.Show("沒有數據！", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query Data Error！" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void CheckWork_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("員工號", "員工號");
            dataGridView1.Columns.Add("姓名", "姓名");
            dataGridView1.Columns.Add("部門代碼", "部門代碼");
            dataGridView1.Columns.Add("費用代碼", "費用代碼");
            dataGridView1.Columns.Add("直間接", "直間接");
            dataGridView1.Columns.Add("日期", "日期");
            dataGridView1.Columns.Add("班別", "班別");
            dataGridView1.Columns.Add("加班內容", "加班內容");
            dataGridView1.Columns.Add("加班時數", "加班時數");
            dataGridView1.Columns.Add("加班類型", "加班類型");
            dataGridView1.Columns.Add("加班時段", "加班時段");
            dataGridView1.Columns.Add("助理姓名", "助理姓名");
            dataGridView1.Columns.Add("助理工號", "助理工號");
            dataGridView1.Columns.Add("notes狀態", "notes狀態");
            dataGridView1.Columns.Add("NOTES回饋原因", "NOTES回饋原因");
            dataGridView1.Columns.Add("NOTES回饋時間", "NOTES回饋時間");
            dataGridView1.Columns.Add("車間", "車間");
            foreach (string item in GlobalString._ListBU)
            {
                comBoxBU.Items.Add(item);
            }
            //comBoxBU.Items.Add(GlobalString._BU);
            Initial();
            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dtQuery.Rows.Count == 0) return;
            if (!File.Exists(System.AppDomain.CurrentDomain.BaseDirectory + '\\' + "NPOI.dll"))
            {
                MessageBox.Show("NPOi.dll不存在，不可導出！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            WriteExcel(dtQuery, getFilePath());
        }

        public static void WriteExcel(DataTable dt, string filePath)
        {
            if (!string.IsNullOrEmpty(filePath) && dt != null && dt.Rows.Count > 0)
            {
                NPOI.HSSF.UserModel.HSSFWorkbook book = new NPOI.HSSF.UserModel.HSSFWorkbook();
                NPOI.SS.UserModel.ISheet sheet = book.CreateSheet(dt.TableName);

                NPOI.SS.UserModel.IRow row = sheet.CreateRow(0);
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    row.CreateCell(i).SetCellValue(dt.Columns[i].ColumnName);
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NPOI.SS.UserModel.IRow row2 = sheet.CreateRow(i + 1);
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        row2.CreateCell(j).SetCellValue(Convert.ToString(dt.Rows[i][j]));
                    }
                }
                // 写入到客户端  
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                {
                    book.Write(ms);
                    using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        byte[] data = ms.ToArray();
                        fs.Write(data, 0, data.Length);
                        fs.Flush();
                    }
                    book = null;
                }
                MessageBox.Show("導出成功：" + filePath, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region 取得路徑
        private string getFilePath()
        {
            string rs = "";
            SaveFileDialog fd = new SaveFileDialog { DefaultExt = "xls", Filter = "Excel 2003 Files (*.xls)|*.xls", FilterIndex = 1 };
            if (fd.ShowDialog() == DialogResult.OK)
            {
                if (fd.CheckPathExists)
                {
                    rs = fd.FileName;
                }
            }
            return rs;
            /*
            string disk = ConfigurationManager.AppSettings["Path"];
            string path = disk + "EMES\\QueryStock\\" ;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path + "QueryStock" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xls";*/
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            Initial();
        }

        private void btnExportEmp_Click(object sender, EventArgs e)
        {
            strEmp = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.RestoreDirectory = false;
            ofd.Filter = "Text Document(*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                int i = 0;
                foreach (var item in File.ReadAllLines(ofd.FileName))
                {
                    strEmp += " id='" + item + "' OR";
                    i++;
                }
                labSumEmp.Text = i.ToString();
                strEmp = strEmp.Substring(0, strEmp.Length - 2);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnExportCost_Click(object sender, EventArgs e)
        {
            strCost = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.RestoreDirectory = false;
            ofd.Filter = "Text Document(*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                int i = 0;
                foreach (var item in File.ReadAllLines(ofd.FileName))
                {
                    strCost += "'" + item + "',";
                    i++;
                }
                labSumCost.Text = i.ToString();
                strCost = strCost.Substring(0, strCost.Length - 1);
            }
        }

        
    }
}
