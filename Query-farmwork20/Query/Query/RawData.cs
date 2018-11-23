using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace Query.Query
{
    public partial class RawData : Form
    {
        //暂存导入的员工工号
        string strEmp = "";
        //暂存导入的部门
        string strDemp = "";
        //暂存导入的費用代碼
        string strCost = "";
        //暂存此登錄者可查詢Cost。..
        string strUserDataCost = "";

        DataTable dtQuery = new DataTable();
        MySqlHelper Querydt = new MySqlHelper();

        public RawData()
        {
            InitializeComponent();
        }

        private void Initial()
        {
            foreach (Control cl in this.Controls)
            {
                if (cl is CheckBox)
                {
                    CheckBox ck = cl as CheckBox;
                    ck.Checked = true;
                }
            }
            txtEmp.Text = "";
            txtDept.Text = "";
            txtCostID.Text = "";
            checkBoxEmp.Checked = false;
            checkBoxDept.Checked = false;
            CheckBoxCost.Checked = false;
            btnExportEmp.Enabled = false;
            btnExportDept.Enabled = false;
            btnExportCost.Enabled = false;
            dateTimePickStart.Value = DateTime.Now;
            dateTimePickEnd.Value = DateTime.Now;
            cmBoxStartHour.Text = "08";
            cmBoxStartMinute.Text = "00";
            cmBoxEndHour.Text = "08";
            cmBoxEndMinute.Text = "00";
            strEmp = "";
            strDemp = "";
            strCost = "";
            dataGridView1.Rows.Clear();
            labSum.Text = "0";
            labSumEmp.Text = "0";
            labSumDemp.Text = "0";
            labSumCost.Text = "0";
            dtQuery.Clear();
            comBoxBU.SelectedIndex = 0;
            txtEmp.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("工號", "工號");
            dataGridView1.Columns.Add("姓名", "姓名");
            dataGridView1.Columns.Add("部門", "部門");
            dataGridView1.Columns.Add("費用代碼", "費用代碼");
            dataGridView1.Columns.Add("刷卡記錄", "刷卡記錄");
            //dataGridView1.Columns.Add("上班時間", "上班時間");
            //dataGridView1.Columns.Add("下班時間", "下班時間");
            //dataGridView1.Columns.Add("車間", "車間");
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
                checkBoxDept.Checked = false;
                CheckBoxCost.Checked = false;
                btnExportEmp.Enabled = true;
                strDemp = "";
                strCost = "";
                labSumDemp.Text = "0";
                labSumCost.Text = "0";
                txtEmp.Text = ""; txtEmp.Enabled = false;
                txtDept.Text = ""; txtDept.Enabled = false;
                txtCostID.Text = ""; txtCostID.Enabled = false;

            }
            else
            {
                btnExportEmp.Enabled = false;
                strEmp = "";
                labSumEmp.Text = "0";
                txtEmp.Text = ""; txtEmp.Enabled = true;
                txtDept.Text = ""; txtDept.Enabled = true;
                txtCostID.Text = ""; txtCostID.Enabled = true;
                txtEmp.Focus();

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDept.Checked)
            {
                checkBoxEmp.Checked = false;
                CheckBoxCost.Checked = false;
                btnExportDept.Enabled = true;
                strEmp = "";
                strCost = "";
                labSumEmp.Text = "0";
                labSumCost.Text = "0";
                txtEmp.Text = ""; txtEmp.Enabled = false;
                txtDept.Text = ""; txtDept.Enabled = false;
                txtCostID.Text = ""; txtCostID.Enabled = false;
            }
            else
            {
                btnExportDept.Enabled = false;
                strDemp = "";
                labSumDemp.Text = "0";
                txtEmp.Text = ""; txtEmp.Enabled = true;
                txtDept.Text = ""; txtDept.Enabled = true;
                txtCostID.Text = ""; txtCostID.Enabled = true;
                txtEmp.Focus();
            }
        }

        private void CheckBoxCost_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxCost.Checked)
            {
                checkBoxEmp.Checked = false;
                checkBoxDept.Checked = false;
                btnExportCost.Enabled = true;
                strEmp = "";
                strDemp = "";
                labSumEmp.Text = "0";
                labSumDemp.Text = "0";
                txtEmp.Text = ""; txtEmp.Enabled = false;
                txtDept.Text = ""; txtDept.Enabled = false;
                txtCostID.Text = ""; txtCostID.Enabled = false;
            }
            else
            {
                btnExportCost.Enabled = false;
                strCost = "";
                labSumCost.Text = "0";
                txtEmp.Text = ""; txtEmp.Enabled = true;
                txtDept.Text = ""; txtDept.Enabled = true;
                txtCostID.Text = ""; txtCostID.Enabled = true;
                txtEmp.Focus();

            }
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
                    //strEmp += "'" + item + "',";
                    strEmp += " emp.ID='" + item + "' OR";
                    i++;
                }
                labSumEmp.Text = i.ToString();
                //strEmp = strEmp.Substring(0, strEmp.Length - 1);
                strEmp = strEmp.Substring(0, strEmp.Length - 2);
            }
        }

        private void btnExportDept_Click(object sender, EventArgs e)
        {
            strDemp = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.RestoreDirectory = false;
            ofd.Filter = "Text Document(*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                int i = 0;
                foreach (var item in File.ReadAllLines(ofd.FileName))
                {
                    strDemp += "'" + item + "',";
                    i++;
                }
                labSumDemp.Text = i.ToString();
                strDemp = strDemp.Substring(0, strDemp.Length - 1);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            Initial();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
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

            //刷卡狀態
            string strStatus = "";
            foreach (Control cl in this.Controls)
            {
                if (cl is CheckBox)
                {
                    CheckBox ck = cl as CheckBox;
                    if (ck.Checked)
                    {
                        switch (ck.Text)
                        {
                            case "正常刷卡": strStatus += "'0',";
                                break;
                            case "無人員資料": strStatus += "'1',";
                                break;
                            case "無班別資料": strStatus += "'2',";
                                break;
                            case "上班提前超15分鐘": strStatus += "'3',";
                                break;
                            case "不符合七休一": strStatus += "'4',";
                                break;
                            case "刷卡重復": strStatus += "'5',";
                                break;
                            case "上下班卡已刷": strStatus += "'6',";
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            strStatus = strStatus.Substring(0, strStatus.Length - 1);

            string sStartDate = "", sEndDate = "", sstarttime = "", sendtime = "";
            sStartDate = dateTimePickStart.Value.ToString("yyyy/MM/dd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            sEndDate = dateTimePickEnd.Value.ToString("yyyy/MM/dd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            sstarttime = sStartDate + " " + cmBoxStartHour.Text.Trim() + ":" + cmBoxStartMinute.Text.Trim();
            sendtime = sEndDate + " " + cmBoxEndHour.Text.Trim() + ":" + cmBoxEndMinute.Text.Trim();
            string strSQL = "";
            labSum.Text = "0";
            dtQuery.Clear();
            dataGridView1.Rows.Clear();
            if (checkBoxEmp.Checked && Convert.ToInt32(labSumEmp.Text) > 0)
            {
                strSQL = "SELECT raw.id 工號,emp.name 姓名,emp.depid 部門,emp.costID 費用代碼, date_format(raw.SwipeCardTime, '%Y/%m/%d %H:%i') 刷卡記錄 FROM SWIPECARD.raw_record raw, swipecard.testemployee emp WHERE raw.id = emp.ID and raw.SwipeCardTime >= str_to_date('" + sstarttime + "', '%Y/%m/%d %H:%i') and raw.SwipeCardTime < str_to_date('" + sendtime + "', '%Y/%m/%d %H:%i') and raw.record_status in ( " + strStatus + " ) and ( " + strEmp + " ) " + strUserDataCost + "  order by emp.costID,emp.depid,raw.id,raw.swipecardtime";
                //QueryBU(strSQL, comBoxBU.Text);
                QueryBU(strSQL);

            }
            else if (checkBoxDept.Checked && Convert.ToInt32(labSumDemp.Text) > 0)
            {
                strSQL = "SELECT raw.id 工號,emp.name 姓名,emp.depid 部門,emp.costID 費用代碼, date_format(raw.SwipeCardTime, '%Y/%m/%d %H:%i') 刷卡記錄 FROM SWIPECARD.raw_record raw, swipecard.testemployee emp WHERE raw.id = emp.ID and raw.SwipeCardTime >= str_to_date('" + sstarttime + "', '%Y/%m/%d %H:%i') and raw.SwipeCardTime < str_to_date('" + sendtime + "', '%Y/%m/%d %H:%i') and raw.record_status in ( " + strStatus + " ) and emp.depid in ( " + strDemp + " ) " + strUserDataCost + " order by emp.costID,emp.depid,raw.id,raw.swipecardtime";
                //QueryBU(strSQL, comBoxBU.Text);
                QueryBU(strSQL);
            }
            else if (CheckBoxCost.Checked && Convert.ToInt32(labSumCost.Text) > 0)
            {
                strSQL = "SELECT raw.id 工號,emp.name 姓名,emp.depid 部門,emp.costID 費用代碼, date_format(raw.SwipeCardTime, '%Y/%m/%d %H:%i') 刷卡記錄 FROM SWIPECARD.raw_record raw, swipecard.testemployee emp WHERE raw.id = emp.ID and raw.SwipeCardTime >= str_to_date('" + sstarttime + "', '%Y/%m/%d %H:%i') and raw.SwipeCardTime < str_to_date('" + sendtime + "', '%Y/%m/%d %H:%i') and raw.record_status in ( " + strStatus + " ) and emp.costID in ( " + strCost + " ) " + strUserDataCost + " order by emp.costID,emp.depid,raw.id,raw.swipecardtime";
                //QueryBU(strSQL, comBoxBU.Text);
                QueryBU(strSQL);

            }
            else if (!checkBoxEmp.Checked && !checkBoxDept.Checked && !CheckBoxCost.Checked)
            {
                //if (txtEmp.Text.Trim() == "" && txtDept.Text.Trim() == "" && txtCostID.Text.Trim() == "") return;
                string strEmpp = txtEmp.Text.Trim() == "" ? " " : " and emp.ID='" + txtEmp.Text.Trim() + "' ";
                string strDeptt = txtDept.Text.Trim() == "" ? " " : " and emp.depid='" + txtDept.Text.Trim() + "' ";
                string strCostt = txtCostID.Text.Trim() == "" ? " " : " and emp.costID='" + txtCostID.Text.Trim() + "' ";
                if (GlobalString._Query_CostID != "ALL")
                {
                    strSQL = "select costID FROM swipecard.testemployee emp where 1=1 " + strEmpp + strDeptt + strCostt;
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

                strSQL = "SELECT raw.id 工號,emp.name 姓名,emp.depid 部門,emp.costID 費用代碼, date_format(raw.SwipeCardTime, '%Y/%m/%d %H:%i') 刷卡記錄 FROM SWIPECARD.raw_record raw, swipecard.testemployee emp WHERE raw.id = emp.ID and raw.SwipeCardTime >= str_to_date('" + sstarttime + "', '%Y/%m/%d %H:%i') and raw.SwipeCardTime < str_to_date('" + sendtime + "', '%Y/%m/%d %H:%i') and raw.record_status in ( " + strStatus + " ) " + strEmpp + strDeptt + strCostt + strUserDataCost + " order by emp.costID,emp.depid,raw.id,raw.swipecardtime";
                //QueryBU(strSQL, comBoxBU.Text);
                QueryBU(strSQL);
            }
            //else if (txtEmp.Text.Trim() != "" || txtDept.Text.Trim() != ""||txtCostID.Text.Trim()!="")
            //{
            //    string strEmpp = txtEmp.Text.Trim() == "" ? " " : " and emp.ID='" + txtEmp.Text.Trim() + "' ";
            //    string strDeptt = txtDept.Text.Trim() == "" ? " " : " and emp.depid='" + txtDept.Text.Trim() + "' ";
            //    string strCostt = txtCostID.Text.Trim() == "" ? " " : " and emp.costID='" + txtCostID.Text.Trim() + "' ";
            //    strSQL = "select emp.ID 員工號,cardtime.Name 姓名, cardtime.CardID 卡號, date_format(cardtime.SwipeCardTime,'%Y/%m/%d %H:%i') 上班時間, date_format(cardtime.SwipeCardTime2,'%Y/%m/%d %H:%i') 下班時間, cardtime.WorkshopNo 車間 from swipecard.testemployee emp,swipecard.testswipecardtime cardtime where emp.cardid=cardtime.CardID AND cardtime.SwipeCardTime>='" + sstarttime + "' AND cardtime.SwipeCardTime<'" + sendtime + "' " + strEmpp + strDeptt + strCostt + " order by emp.depid, emp.ID, cardtime.SwipeCardTime,cardtime.Shift";
            //    QueryBU(strSQL, comBoxBU.Text);
            //}
            //else if (txtEmp.Text.Trim() != "" && txtDept.Text.Trim() != "")
            //{
            //    strSQL = "select emp.ID 員工號,cardtime.Name 姓名, cardtime.CardID 卡號, date_format(cardtime.SwipeCardTime,'%Y/%m/%d %H:%i') 上班時間, date_format(cardtime.SwipeCardTime2,'%Y/%m/%d %H:%i') 下班時間, cardtime.WorkshopNo 車間 from swipecard.testemployee emp,swipecard.testswipecardtime cardtime where emp.cardid=cardtime.CardID AND cardtime.SwipeCardTime>='" + sstarttime + "' AND cardtime.SwipeCardTime<'" + sendtime + "' and emp.ID='" + txtEmp.Text.Trim() + "' and emp.depid='" + txtDept.Text.Trim() + "' order by emp.depid, emp.ID, cardtime.SwipeCardTime,cardtime.Shift";
            //    QueryBU(strSQL, comBoxBU.Text);
            //}
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

        private void QueryBU(string strSQL)
        {
            try
            {
                //if (strBU == "通訊")
                //{
                //    dtQuery = Querydt.QueryDB(strSQL);
                //}
                //else
                //{
                //    dtQuery = Querydt.QueryDbAsbg(strSQL);
                //}
                DataTable dtQuery2 = new DataTable();
                dtQuery = Querydt.QueryDB(strSQL);
                dtQuery2 = Querydt.QueryDbAsbg(strSQL);
                dtQuery.Merge(dtQuery2);
                dtQuery2.Clear();

                if (dtQuery != null && dtQuery.Rows.Count > 0)
                {
                    labSum.Text = dtQuery.Rows.Count.ToString();

                    foreach (DataRow item in dtQuery.Rows)
                    {
                        dataGridView1.Rows.Add(item["工號"].ToString(),
                                               item["姓名"].ToString(),
                            ////item["卡號"].ToString(),
                                               item["部門"].ToString(),
                                               item["費用代碼"].ToString(),
                            //                   item["上班時間"].ToString(),
                            //                   item["下班時間"].ToString(),
                                               item["刷卡記錄"].ToString());




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
    }
}
