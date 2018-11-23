using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ShippingNote.SN_Yield;
using System.IO;

namespace Query.Query
{
    public partial class ForgetCardQuery : Form
    {
        DataTable dtQuery = new DataTable();
        MySqlHelper Querydt = new MySqlHelper();
        //暂存此登錄者可查詢Cost..
        string strUserDataCost = "";


        public ForgetCardQuery()
        {
            InitializeComponent();
        }
        private void Initial()
        {
            dateTimePickStart.Value = dateTimePickStart.MaxDate;
            dateTimePickEnd.Value = dateTimePickEnd.MaxDate;
            dateTimePickStart.MaxDate = DateTime.Now.AddDays(-1);
            dateTimePickEnd.MaxDate = DateTime.Now.AddDays(-1);
            comBoxBU.SelectedIndex = 0;
            listBoxCostID.Items.Clear();
            listBoxDeptID.Items.Clear();
            strUserDataCost = "";
            dtQuery.Clear();
            dataGridView1.Rows.Clear();
        }

        private void btnSearchCostID_Click(object sender, EventArgs e)
        {
            if (GlobalString._Query_CostID != "")
            {
                if (GlobalString._Query_CostID != "ALL")
                {
                    strUserDataCost = " where costID in (" + GlobalString._Query_CostID + ") ";
                }
            }
            else if (GlobalString._Query_CostID == "")
            {
                strUserDataCost = " where costID in (" + GlobalString._CostID + ") ";
            }

            string strSQL = "SELECT DISTINCT costID FROM swipecard.testemployee " + strUserDataCost + " order by costID ";
            try
            {
                DataTable DT = new DataTable();
                if (comBoxBU.Text == "通訊")
                {
                    DT = Querydt.QueryDB(strSQL);
                }
                else
                {
                    DT = Querydt.QueryDbAsbg(strSQL);
                }
                using (FormModel fmModel = new FormModel(this.listBoxCostID, DT, "CostID"))
                {
                    if (fmModel.ShowDialog() == DialogResult.OK)
                    {
                        listBoxCostID.Items.Clear();
                        foreach (var item in fmModel.AryListListBoxSelect)
                        {

                            listBoxCostID.Items.Add(item);
                            listBoxDeptID.Items.Clear();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("查詢CostID出錯！" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchDeptID_Click(object sender, EventArgs e)
        {
            if (listBoxCostID.Items.Count == 0)
            {

                MessageBox.Show("請先選擇費用代碼", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string strSQL = "SELECT DISTINCT depid FROM swipecard.testemployee where 1=1 "+FormatListBox("costid",listBoxCostID);
            try
            {
                DataTable DT = new DataTable();
                if (comBoxBU.Text == "通訊")
                {
                    DT = Querydt.QueryDB(strSQL);
                }
                else
                {
                    DT = Querydt.QueryDbAsbg(strSQL);
                }
                using (FormModel fmModel = new FormModel(this.listBoxDeptID, DT, "depid"))
                {
                    if (fmModel.ShowDialog() == DialogResult.OK)
                    {
                        listBoxDeptID.Items.Clear();
                        foreach (var item in fmModel.AryListListBoxSelect)
                        {

                            listBoxDeptID.Items.Add(item);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("查詢DeptID出錯！" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ForgetCardQuery_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("員工號", "員工號");
            dataGridView1.Columns.Add("姓名", "姓名");
            dataGridView1.Columns.Add("部門代碼", "部門代碼");
            dataGridView1.Columns.Add("費用代碼", "費用代碼");
            dataGridView1.Columns.Add("狀態", "狀態");
            dataGridView1.Columns.Add("忘卡日期", "忘卡日期");
            
            //dataGridView1.Columns.Add("下刷", "下刷");
            foreach (string item in GlobalString._ListBU)
            {
                comBoxBU.Items.Add(item);
            }
            Initial();
        }

        private void comBoxBU_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxCostID.Items.Clear();
            listBoxDeptID.Items.Clear();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (listBoxCostID.Items.Count == 0)
            {

                MessageBox.Show("請先選擇費用代碼", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sStartDate = "", sEndDate = "", sstarttime = "", sendtime = "";
            sStartDate = dateTimePickStart.Value.ToString("yyyy/MM/dd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            sEndDate = dateTimePickEnd.Value.ToString("yyyy/MM/dd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            //sstarttime = sStartDate + " " + cmBoxStartHour.Text.Trim() + ":" + cmBoxStartMinute.Text.Trim();
            //sendtime = sEndDate + " " + cmBoxEndHour.Text.Trim() + ":" + cmBoxEndMinute.Text.Trim();
            string strSQL = "";
            //string strSQL2 = "";
            labSum.Text = "0";
            //int sumi = 0;
            dtQuery.Clear();
            DataTable dtcard = new DataTable();
            dataGridView1.Rows.Clear();

//            strSQL = "select  ID 員工號, name 姓名, depid 部門代碼, costID 費用代碼 from swipecard.testemployee where 1=1 " + FormatListBox("costID", listBoxCostID) + " order by depid, ID";
//            strSQL2 = @"SELECT emp.ID id,DATE_FORMAT(wipcard.SwipeCardTime,'%Y/%m/%d %H:%i') wipcardtime,DATE_FORMAT(wipcard.SwipeCardTime2,'%Y/%m/%d %H:%i') wipcardtime2 
//  FROM swipecard.testswipecardtime wipcard, swipecard.testemployee emp
// WHERE     wipcard.CardID = emp.cardid
//       AND (   (    DATE_FORMAT(wipcard.SwipeCardTime,'%Y/%m/%d') >= '" + sStartDate + @"'
//                AND DATE_FORMAT(wipcard.SwipeCardTime,'%Y/%m/%d') <= '" + sEndDate + @"'
//                )
//            OR     (    
//                     DATE_FORMAT(wipcard.SwipeCardTime2,'%Y/%m/%d') >= '" + sStartDate + @"'
//               AND DATE_FORMAT(wipcard.SwipeCardTime2,'%Y/%m/%d') <= '" + sStartDate + "')) " + FormatListBox("emp.costID", listBoxCostID);
//            try
//            {
//                if (comBoxBU.Text == "通訊")
//                {
//                    dtQuery = Querydt.QueryDB(strSQL);
//                    dtcard = Querydt.QueryDB(strSQL2);
//                }
//                else
//                {
//                    dtQuery = Querydt.QueryDbAsbg(strSQL);
//                    dtcard = Querydt.QueryDbAsbg(strSQL2);
//                }
//                foreach (DataRow item in dtQuery.Rows)
//                {
//                    for (int i = 0; i <= (dateTimePickEnd.Value - dateTimePickStart.Value).Days; i++)
//                    {
//                        string strDataTime = dateTimePickStart.Value.AddDays(i).ToString("yyyy/MM/dd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
//                        DataRow[] CardTimedr = dtcard.Select("id='" + item["員工號"].ToString() + "' and wipcardtime=#" + strDataTime + "#");
//                        DataRow[] CardTime2dr = dtcard.Select("id='" + item["員工號"].ToString() + "' and wipcardtime2=#" + strDataTime + "#");
//                        if (CardTimedr.Length > 0 && CardTime2dr.Length > 0) break;
//                        dataGridView1.Rows.Add(item["員工號"].ToString(),
//                                               item["姓名"].ToString(),
//                                               item["部門代碼"].ToString(),
//                                               item["費用代碼"].ToString(),
//                                               strDataTime,
//                                               CardTimedr.Length > 0 ? CardTimedr[0]["wipcardtime"].ToString() : "?",
//                                               CardTime2dr.Length > 0 ? CardTime2dr[0]["wipcardtime2"].ToString() : "?");
                        
                       
                                              
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("查詢testemployee出錯！" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
            //for (int i = 0; i <= (dateTimePickEnd.Value - dateTimePickStart.Value).Days; i++)
            //{
                string strDataTime = dateTimePickStart.Value.AddDays(0).ToString("yyyy/MM/dd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
//                strSQL = @"SELECT ID 員工號, name 姓名,depid 部門代碼,costID 費用代碼,case isOnWork when 0 then '在職' when 1 then '離職' end 狀態,'" + strDataTime
//  + @"' 忘卡日期 FROM swipecard.testemployee
// WHERE 1=1 " + FormatListBox("costid", listBoxCostID)
//            + FormatListBox("depid", listBoxDeptID)
//       + @" AND isOnWork=0 AND id NOT IN
//              (SELECT id
//                 FROM swipecard.testswipecardtime
//                WHERE 1=1 " + FormatListBox("costid", listBoxCostID)
//            + FormatListBox("depid", listBoxDeptID)
//       + @" AND  DATE_FORMAT(testswipecardtime.SwipeCardTime,
//                                      '%Y/%m/%d') = '" + strDataTime
//                                                      + "' AND testswipecardtime.SwipeCardTime2 IS NOT NULL) order by isOnWork,depid, ID";

                strSQL = @"SELECT ID 員工號, name 姓名,depid 部門代碼,costID 費用代碼,case isOnWork when 0 then '在職' when 1 then '離職' end 狀態,'" + strDataTime
  + @"' 忘卡日期 FROM swipecard.testemployee 
WHERE 1=1 " + FormatListBox("costid", listBoxCostID)
            + FormatListBox("depid", listBoxDeptID)
       + @" AND  isOnWork = 0 
  AND id NOT IN 
  (SELECT 
    id 
  FROM
    swipecard.testswipecardtime 
  WHERE id IN 
    (SELECT 
      id 
    FROM
      swipecard.`testemployee` 
    WHERE 1=1 " + FormatListBox("costid", listBoxCostID)
            + FormatListBox("depid", listBoxDeptID)
       + @") AND DATE_FORMAT(
      testswipecardtime.SwipeCardTime,
      '%Y/%m/%d'
    ) = '" + strDataTime + "' AND testswipecardtime.SwipeCardTime2 IS NOT NULL) and ((isOnWork = 0 and DATE_FORMAT(testemployee.updateDate,'%Y/%m/%d') <= '" + strDataTime + "') or (isOnWork = 1  and  DATE_FORMAT(testemployee.updateDate, '%Y/%m/%d') > '" + strDataTime + "')) ORDER BY isOnWork,  depid, ID ";

                try
                {
                    if (comBoxBU.Text == "通訊")
                    {
                        dtQuery = Querydt.QueryDB(strSQL);

                    }
                    else
                    {
                        dtQuery = Querydt.QueryDbAsbg(strSQL);

                    }
                    if (dtQuery != null && dtQuery.Rows.Count > 0)
                    {
                        dtcard.Merge(dtQuery);
                        //dtQuery.DefaultView.Sort = "員工號 asc";
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("查詢testemployee出錯！" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView1.Rows.Clear();
                    return;
                }
            //}
            if (dtcard.Rows.Count > 0 && dtcard != null)
            {
                DataView dv = dtcard.DefaultView;
                dv.Sort = "狀態 desc,部門代碼 asc,員工號 asc";
                dtQuery.Clear();
                dtQuery = dv.ToTable();
                foreach (DataRow item in dtQuery.Rows)
                {
                    dataGridView1.Rows.Add(item["員工號"].ToString(),
                                           item["姓名"].ToString(),
                                           item["部門代碼"].ToString(),
                                           item["費用代碼"].ToString(),
                                           item["狀態"].ToString(),
                                           item["忘卡日期"].ToString());

                }
                labSum.Text = dtcard.Rows.Count.ToString();
            }
            
        }

        private string FormatListBox(string ColumnName, ListBox TListBox)
        {
            if (TListBox.Items.Count != 0)
            {
                string Result = " AND ( ";

                for (int i = 0; i < TListBox.Items.Count; i++)
                {
                    if (i == 0)
                    {
                        Result = Result + ColumnName + " = '" + TListBox.Items[i].ToString() + "'";
                    }
                    else
                    {
                        Result = Result + " OR " + ColumnName + " = '" + TListBox.Items[i].ToString() + "'";
                    }
                }

                return Result + " ) ";
            }
            else
            {
                return " ";
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
            WriteExcel(dtQuery, getFilePath());
        }
        public static void WriteExcel(DataTable dt, string filePath)
        {
            if (!string.IsNullOrEmpty(filePath) && dt != null && dt.Rows.Count > 0)
            {
                NPOI.HSSF.UserModel.HSSFWorkbook book = new NPOI.HSSF.UserModel.HSSFWorkbook();
                NPOI.SS.UserModel.ISheet sheet = book.CreateSheet("ForgetCard");

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

        


    }
}
