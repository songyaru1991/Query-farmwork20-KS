using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace Query.Query
{
    public partial class CheckOverTime : Form
    {
        DataTable dtQuery = new DataTable();
        MySqlHelper Querydt = new MySqlHelper();
        //暂存导入的员工工号/
        string strEmp = "";
        //暂存导入的費用代碼
        string strCost = "";
        //暂存此登錄者可查詢Cost..
        string strUserDataCost = "";

        public CheckOverTime()
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
            //if (comBoxBU.Text.Trim() == "") { MessageBox.Show("請選擇事業群！,", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); return; };

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
       emp.Name 姓名,
       emp.depid 部門代碼,
       emp.costID 費用代碼,
       date_format(emp_class.emp_date,'%Y/%m/%d') 日期,
       emp_class.class_no 班別,
       date_format(emp_class.update_time,'%Y/%m/%d') 更新時間,
       class_no.class_start 上班,
       class_no.class_end 下班
  FROM swipecard.testemployee emp,
       swipecard.classno class_no,
       swipecard.emp_class emp_class
 WHERE emp.ID = emp_class.ID AND emp_class.class_no = class_no.class_no
       and emp_class.emp_date>=str_to_date('" + sStartDate + "','%Y/%m/%d') and emp_class.emp_date<=str_to_date('" + sEndDate + "','%Y/%m/%d')  and ( " + strEmp + " ) " + strUserDataCost + " order by emp.costID,emp.depid,emp.ID,emp_class.emp_date";
                QueryBU(strSQL, comBoxBU.Text);
            }
            else if (CheckBoxCost.Checked && Convert.ToInt32(labSumCost.Text) > 0)
            {
                strSQL = @"SELECT emp.ID 員工號,
       emp.Name 姓名,
       emp.depid 部門代碼,
       emp.costID 費用代碼,
       date_format(emp_class.emp_date,'%Y/%m/%d') 日期,
       emp_class.class_no 班別,
       date_format(emp_class.update_time,'%Y/%m/%d') 更新時間,
       class_no.class_start 上班,
       class_no.class_end 下班
  FROM swipecard.testemployee emp,
       swipecard.classno class_no,
       swipecard.emp_class emp_class
 WHERE emp.ID = emp_class.ID AND emp_class.class_no = class_no.class_no
       and emp_class.emp_date>=str_to_date('" + sStartDate + "','%Y/%m/%d') and emp_class.emp_date<=str_to_date('" + sEndDate + "','%Y/%m/%d')  and costID in ( " + strCost + " ) " + strUserDataCost + " order by emp.costID,emp.depid,emp.ID,emp_class.emp_date";
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
       emp.Name 姓名,
       emp.depid 部門代碼,
       emp.costID 費用代碼,
       date_format(emp_class.emp_date,'%Y/%m/%d') 日期,
       emp_class.class_no 班別,
       date_format(emp_class.update_time,'%Y/%m/%d') 更新時間,
       class_no.class_start 上班,
       class_no.class_end 下班
  FROM swipecard.testemployee emp,
       swipecard.classno class_no,
       swipecard.emp_class emp_class
 WHERE emp.ID = emp_class.ID and emp.isonwork='0' AND emp_class.class_no = class_no.class_no
       and emp_class.emp_date>=str_to_date('" + sStartDate + "','%Y/%m/%d') and emp_class.emp_date<=str_to_date('" + sEndDate + "','%Y/%m/%d') " + strEmpp + strCostt + strUserDataCost + " order by emp.costID,emp.depid,emp.ID,emp_class.emp_date";
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
                            //item["直間接"].ToString(),
                                               item["日期"].ToString(),
                                               item["班別"].ToString(),
                                               item["更新時間"].ToString(),
                            //item["加班時間"].ToString(),
                            //item["狀態"].ToString(),
                            //item["加班時間段"].ToString(),
                            //item["申請人員"].ToString(),
                            //item["申請人員工號"].ToString(),
                            //item["notes狀態"].ToString(),
                            //item["notes原因"].ToString(),
                                               item["上班"].ToString(),
                                               item["下班"].ToString());
                        //item["測試功能1"].ToString(),
                        //item["測試功能2"].ToString());




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
            //dataGridView1.Columns.Add("直間接", "直間接");
            dataGridView1.Columns.Add("日期", "日期");
            dataGridView1.Columns.Add("班別", "班別");
            //dataGridView1.Columns.Add("加班內容", "加班內容");
            //dataGridView1.Columns.Add("加班時間", "加班時間");
            //dataGridView1.Columns.Add("狀態", "狀態");
            //dataGridView1.Columns.Add("加班時間段", "加班時間段");
            //dataGridView1.Columns.Add("申請人員", "申請人員");
            //dataGridView1.Columns.Add("申請人員工號", "申請人員工號");
            //dataGridView1.Columns.Add("notes狀態", "notes狀態");
            //dataGridView1.Columns.Add("notes原因", "notes原因");
            dataGridView1.Columns.Add("更新時間", "更新時間");
            dataGridView1.Columns.Add("上班", "上班");
            dataGridView1.Columns.Add("下班", "下班");
            //dataGridView1.Columns.Add("測試功能1", "測試功能1");
            //dataGridView1.Columns.Add("測試功能1", "測試功能1");

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
                //NPOI.HSSF.UserModel.HSSFWorkbook book = new NPOI.HSSF.UserModel.HSSFWorkbook();
                //NPOI.SS.UserModel.ISheet sheet = book.CreateSheet(dt.TableName);

                //NPOI.SS.UserModel.IRow row = sheet.CreateRow(0);
                //for (int i = 0; i < dt.Columns.Count; i++)
                //{
                //    row.CreateCell(i).SetCellValue(dt.Columns[i].ColumnName);
                //}
                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                //    NPOI.SS.UserModel.IRow row2 = sheet.CreateRow(i + 1);
                //    for (int j = 0; j < dt.Columns.Count; j++)
                //    {
                //        row2.CreateCell(j).SetCellValue(Convert.ToString(dt.Rows[i][j]));
                //    }
                //}
                //// 写入到客户端  
                //using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                //{
                //    book.Write(ms);
                //    using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                //    {
                //        byte[] data = ms.ToArray();
                //        fs.Write(data, 0, data.Length);
                //        fs.Flush();
                //    }
                //    book = null;
                //}
                //MessageBox.Show("導出成功：" + filePath, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HSSFWorkbook workbook = new HSSFWorkbook();
                //MemoryStream ms = new MemoryStream();
                int dtRowsCount = dt.Rows.Count;
                int SheetCount = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(dtRowsCount) / 65536));
                int SheetNum = 1;
                int rowIndex = 1;
                int tempIndex = 1; //标示 
                ISheet sheet = workbook.CreateSheet("sheet1" + SheetNum);
                for (int i = 0; i < dtRowsCount; i++)
                {
                    if (i == 0 || tempIndex == 1)
                    {
                        IRow headerRow = sheet.CreateRow(0);
                        foreach (DataColumn column in dt.Columns)
                            headerRow.CreateCell(column.Ordinal).SetCellValue(column.ColumnName);
                    }
                    HSSFRow dataRow = (HSSFRow)sheet.CreateRow(tempIndex);
                    foreach (DataColumn column in dt.Columns)
                    {
                        dataRow.CreateCell(column.Ordinal).SetCellValue(dt.Rows[i][column].ToString());
                    }
                    if (tempIndex == 65535)
                    {
                        SheetNum++;
                        sheet = workbook.CreateSheet("sheet" + SheetNum);//
                        tempIndex = 0;
                    }
                    rowIndex++;
                    tempIndex++;
                    //AutoSizeColumns(sheet);
                }

                // 写入到客户端  
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                {
                    workbook.Write(ms);
                    using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        byte[] data = ms.ToArray();
                        fs.Write(data, 0, data.Length);
                        fs.Flush();
                    }
                    workbook = null;
                }
                MessageBox.Show("導出成功：" + filePath, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //workbook.Write(ms);
                //ms.Flush();
                //ms.Position = 0;
                //sheet = null;
                //headerRow = null;
                //workbook = null;
                //return ms;
            }
        }

        //public static void WriteExcel(DataTable dt, string filePath)
        //{
        //    if (!string.IsNullOrEmpty(filePath) && dt != null && dt.Rows.Count > 0)
        //    {
        //        NPOI.HSSF.UserModel.HSSFWorkbook book = new NPOI.HSSF.UserModel.HSSFWorkbook();
        //        NPOI.SS.UserModel.ISheet sheet = book.CreateSheet(dt.TableName);

        //        NPOI.SS.UserModel.IRow row = sheet.CreateRow(0);
        //        for (int i = 0; i < dt.Columns.Count; i++)
        //        {
        //            row.CreateCell(i).SetCellValue(dt.Columns[i].ColumnName);
        //        }
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            NPOI.SS.UserModel.IRow row2 = sheet.CreateRow(i + 1);
        //            for (int j = 0; j < dt.Columns.Count; j++)
        //            {
        //                row2.CreateCell(j).SetCellValue(Convert.ToString(dt.Rows[i][j]));
        //            }
        //        }
        //        // 写入到客户端  
        //        using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
        //        {
        //            book.Write(ms);
        //            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        //            {
        //                byte[] data = ms.ToArray();
        //                fs.Write(data, 0, data.Length);
        //                fs.Flush();
        //            }
        //            book = null;
        //        }
        //        MessageBox.Show("導出成功：" + filePath, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

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
                    strEmp += " emp.id='" + item + "' OR";
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
