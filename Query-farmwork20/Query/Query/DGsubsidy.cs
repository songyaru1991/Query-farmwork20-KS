using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Query.Query
{
    public partial class DGsubsidy : Form
    {
        DataTable dtQuery = new DataTable();
        MySqlHelper Querydt = new MySqlHelper();
        //暂存导入的员工工号/
        string strEmp = "";
        string strClassEmp = "";
        //暂存导入的費用代碼
        string strCost = "";
        //暂存此登錄者可查詢Cost
        string strUserDataCost = "";

        public DGsubsidy()
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

        private void DGsubsidy_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("員工號", "員工號");
            dataGridView1.Columns.Add("姓名", "姓名");
            dataGridView1.Columns.Add("線別代碼", "線別代碼");
            dataGridView1.Columns.Add("部門代碼", "部門代碼");
            //dataGridView1.Columns.Add("直間接", "直間接");
            dataGridView1.Columns.Add("上刷", "上刷");
            dataGridView1.Columns.Add("下刷", "下刷");
            dataGridView1.Columns.Add("總上班時間", "總上班時間");
            //dataGridView1.Columns.Add("加班內容", "加班內容");
            //dataGridView1.Columns.Add("加班時間", "加班時間");
            //dataGridView1.Columns.Add("狀態", "狀態");
            //dataGridView1.Columns.Add("加班時間段", "加班時間段");
            //dataGridView1.Columns.Add("申請人員", "申請人員");
            //dataGridView1.Columns.Add("申請人員工號", "申請人員工號");
            //dataGridView1.Columns.Add("notes狀態", "notes狀態");
            //dataGridView1.Columns.Add("notes原因", "notes原因");
            //dataGridView1.Columns.Add("上班", "上班");
            //dataGridView1.Columns.Add("下班", "下班");
            foreach (string item in GlobalString._ListBU)
            {
                comBoxBU.Items.Add(item);
            }
            //comBoxBU.Items.Add(GlobalString._BU);
            Initial();
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
                    strUserDataCost = " and emp.costID in (" + GlobalString._Query_CostID + ") ";
                }
            }
            else if (GlobalString._Query_CostID == "")
            {
                strUserDataCost = " and emp.costID in (" + GlobalString._CostID + ") ";
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
                strSQL = @"SELECT emp.ID 員工號,
       cardtime.Name 姓名,
       emp.depid 線別代碼,emp.costID 部門代碼,
       date_format(cardtime.SwipeCardTime, '%Y/%m/%d %H:%i') 上刷,
       date_format(cardtime.SwipeCardTime2, '%Y/%m/%d %H:%i') 下刷,
       (select  classno.class_start from swipecard.emp_class empclass,swipecard.classno classno where empclass.class_no= classno.class_no AND  empclass.emp_date=date_format(cardtime.SwipeCardTime, '%Y/%m/%d') AND empclass.ID=emp.ID ) SB 
  FROM swipecard.testemployee emp, swipecard.testswipecardtime cardtime
 WHERE     emp.id = cardtime.id
       and cardtime.SwipeCardTime is not null and cardtime.SwipeCardTime2 is not null 
       and date_format(cardtime.SwipeCardTime,'%Y/%m/%d')>='" + sStartDate + "' and date_format(cardtime.SwipeCardTime,'%Y/%m/%d')<='" + sEndDate + "'  and ( " + strEmp + " ) " + strUserDataCost + "  order by emp.depid, emp.ID";
                QueryBU(strSQL, comBoxBU.Text);
            }
            else if (CheckBoxCost.Checked && Convert.ToInt32(labSumCost.Text) > 0)
            {
                strSQL = @"SELECT emp.ID 員工號,
       cardtime.Name 姓名,
       emp.depid 線別代碼,emp.costID 部門代碼,
       date_format(cardtime.SwipeCardTime, '%Y/%m/%d %H:%i') 上刷,
       date_format(cardtime.SwipeCardTime2, '%Y/%m/%d %H:%i') 下刷,
       (select  classno.class_start from swipecard.emp_class empclass,swipecard.classno classno where empclass.class_no= classno.class_no AND  empclass.emp_date=date_format(cardtime.SwipeCardTime, '%Y/%m/%d') AND empclass.ID=emp.ID ) SB 
  FROM swipecard.testemployee emp, swipecard.testswipecardtime cardtime
 WHERE     emp.id = cardtime.id
       and cardtime.SwipeCardTime is not null and cardtime.SwipeCardTime2 is not null 
       and date_format(cardtime.SwipeCardTime,'%Y/%m/%d')>='" + sStartDate + "' and date_format(cardtime.SwipeCardTime,'%Y/%m/%d')<='" + sEndDate + "'  and costID in ( " + strCost + " ) " + strUserDataCost + " order by emp.depid, emp.ID";
                QueryBU(strSQL, comBoxBU.Text);
            }
            else if (!checkBoxEmp.Checked && !CheckBoxCost.Checked)
            {
                if (txtEmp.Text.Trim() == "" && txtCostID.Text.Trim() == "") return;
                string strEmpp = txtEmp.Text.Trim() == "" ? " " : " and emp.id='" + txtEmp.Text.Trim() + "' ";
                string strCostt = txtCostID.Text.Trim() == "" ? " " : " and emp.costID='" + txtCostID.Text.Trim() + "' ";
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
                strSQL = @"SELECT emp.ID 員工號,
       cardtime.Name 姓名,
       emp.depid 線別代碼,emp.costID 部門代碼,
       date_format(cardtime.SwipeCardTime, '%Y/%m/%d %H:%i') 上刷,
       date_format(cardtime.SwipeCardTime2, '%Y/%m/%d %H:%i') 下刷,
       (select  classno.class_start from swipecard.emp_class empclass,swipecard.classno classno where empclass.class_no= classno.class_no AND  empclass.emp_date=date_format(cardtime.SwipeCardTime, '%Y/%m/%d') AND empclass.ID=emp.ID ) SB 
  FROM swipecard.testemployee emp, swipecard.testswipecardtime cardtime
 WHERE     emp.id = cardtime.id
       and cardtime.SwipeCardTime is not null and cardtime.SwipeCardTime2 is not null 
       and date_format(cardtime.SwipeCardTime,'%Y/%m/%d')>='" + sStartDate + "' and date_format(cardtime.SwipeCardTime,'%Y/%m/%d')<='" + sEndDate + "' " + strEmpp + strCostt + strUserDataCost + " order by emp.depid, emp.ID";
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
                    double dsum = 0;
                    string sTempID = "";
                    foreach (DataRow item in dtQuery.Rows)
                    {
                        //DateTime TimeStart = Convert.ToDateTime(item["上刷"].ToString());
                        //string startdata = TimeStart.Date.ToString("yyyy/MM/dd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                        //int startHours = TimeStart.Hour;
                        //int startMin = TimeStart.Minute;
                        //if (startMin > 0 && startMin < 15)
                        //{ startMin = 15; }
                        //else if (startMin > 15 && startMin < 30)
                        //{ startMin = 30; }
                        //else if (startMin > 30 && startMin < 45)
                        //{ startMin = 45; }
                        //else if (startMin > 45)
                        //{ startMin = 0; startHours = startHours + 1; }
                        //DateTime TimeEnd = Convert.ToDateTime(item["下刷"].ToString());
                        //string enddata = TimeEnd.Date.ToString("yyyy/MM/dd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                        //int endHours = TimeEnd.Hour;
                        //int endMin = TimeEnd.Minute;
                        //if (endMin < 15)
                        //{ endMin = 0; }
                        //else if (endMin > 15 && endMin < 30)
                        //{ endMin = 15; }
                        //else if (endMin > 30 && endMin < 45)
                        //{ endMin = 30; }
                        //else if (endMin > 45)
                        //{ endMin = 45; }
                        //double i = (Convert.ToDateTime(enddata + " " + endHours + ":" + endMin) - Convert.ToDateTime(startdata + " " + startHours + ":" + startMin)).TotalMinutes / 60;
                        if (item["SB"].ToString() != string.Empty)
                        {
                            if (sTempID != item["員工號"].ToString())
                            {
                                if (sTempID != "") dataGridView1.Rows.Add("", "", "", "", "", "", dsum);
                                sTempID = item["員工號"].ToString();
                                dsum = 0;
                            }
                            DateTime TimeStart = Convert.ToDateTime(item["上刷"].ToString());
                            DateTime TimeEnd = Convert.ToDateTime(item["下刷"].ToString());
                            DateTime TimeWork = Convert.ToDateTime(TimeStart.Date.ToString("yyyy/MM/dd", System.Globalization.DateTimeFormatInfo.InvariantInfo) + " " + item["SB"].ToString().Substring(0, 2) + ":" + item["SB"].ToString().Substring(2, 2));
                            //1.上刷如果在上班時間之前的，以標準上班時間為准。
                            if (TimeStart < TimeWork)
                            { TimeStart = TimeWork; }
                            //用下刷減上刷算出總時間，然後不足15分鐘的部分不要。
                            //比如說減出來是12小時20分，那就是12.25小是。12小時31分，就是12.5小時。
                            //減出來是11小時59分，那就是11.75小時。
                            int iMin = (int)(TimeEnd - TimeStart).Minutes;
                            if (iMin > 0 && iMin < 15)
                            { iMin = 0; }
                            else if (iMin > 15 && iMin < 30)
                            { iMin = 15; }
                            else if (iMin > 30 && iMin < 45)
                            { iMin = 30; }
                            else if (iMin > 45)
                            { iMin = 45; }
                            double i = ((TimeEnd - TimeStart).Hours * 60 + iMin) / 60.0;
                            dsum += i;
                            dataGridView1.Rows.Add(item["員工號"].ToString(),
                                                   item["姓名"].ToString(),
                                                   item["線別代碼"].ToString(),
                                                   item["部門代碼"].ToString(),
                                //item["直間接"].ToString(),
                                                   item["上刷"].ToString(),
                                                   item["下刷"].ToString(),
                                //item["加班內容"].ToString(),
                                //item["加班時間"].ToString(),
                                //item["狀態"].ToString(),
                                //item["加班時間段"].ToString(),
                                //item["申請人員"].ToString(),
                                //item["申請人員工號"].ToString(),
                                //item["notes狀態"].ToString(),
                                //item["notes原因"].ToString(),
                                                  i);

                        }
                        else
                        {
                            if (sTempID != item["員工號"].ToString())
                            {
                                if (sTempID != "") dataGridView1.Rows.Add("", "", "", "", "", "", dsum);
                                sTempID = item["員工號"].ToString();
                                dsum = 0;
                            }
                            dataGridView1.Rows.Add(item["員工號"].ToString(),
                                                   item["姓名"].ToString(),
                                                   item["線別代碼"].ToString(),
                                                   item["部門代碼"].ToString(),
                                //item["直間接"].ToString(),
                                                   item["上刷"].ToString(),
                                                   item["下刷"].ToString(),
                                //item["加班內容"].ToString(),
                                //item["加班時間"].ToString(),
                                //item["狀態"].ToString(),
                                //item["加班時間段"].ToString(),
                                //item["申請人員"].ToString(),
                                //item["申請人員工號"].ToString(),
                                //item["notes狀態"].ToString(),
                                //item["notes原因"].ToString(),
                                                  "當天無班別資料");
 
                        }


                    }
                    dataGridView1.Rows.Add("", "", "", "", "", "", dsum);
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dtQuery.Rows.Count == 0) return;
            if (!File.Exists(System.AppDomain.CurrentDomain.BaseDirectory + '\\' + "NPOI.dll"))
            {
                MessageBox.Show("NPOi.dll不存在，不可導出！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            WriteExcel(dataGridView1, getFilePath());
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

        public static void WriteExcel(DataGridView dg, string filePath)
        {
            if (!string.IsNullOrEmpty(filePath) && dg != null && dg.Rows.Count > 0)
            {
                NPOI.HSSF.UserModel.HSSFWorkbook book = new NPOI.HSSF.UserModel.HSSFWorkbook();
                NPOI.SS.UserModel.ISheet sheet = book.CreateSheet("DG");

                NPOI.SS.UserModel.IRow row = sheet.CreateRow(0);
                for (int i = 0; i < dg.Columns.Count; i++)
                {
                    row.CreateCell(i).SetCellValue(dg.Columns[i].HeaderText);
                }
                for (int i = 0; i < dg.Rows.Count; i++)
                {
                    NPOI.SS.UserModel.IRow row2 = sheet.CreateRow(i + 1);
                    for (int j = 0; j < dg.Columns.Count; j++)
                    {
                        row2.CreateCell(j).SetCellValue(Convert.ToString(dg[j,i].Value));
                    }
                }
                // 写入到客户端.  
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
