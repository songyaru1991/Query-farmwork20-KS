using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using KnightsWarriorAutoupdater;
using System.Net;
using System.Xml;
using System.IO;

namespace Query
{
    public partial class FormLogin : Form
    {
        DataTable dtQuery = new DataTable();
        DataTable dtQuery2 = new DataTable();
        MySqlHelper Querydt = new MySqlHelper();

        public FormLogin()
        {
            InitializeComponent();
            
        }
        void CheckUpdate()
        {
            
            #region check and download new version program
            bool bHasError = false;
            IAutoUpdater autoUpdater = new AutoUpdater();
            try
            {
                autoUpdater.Update();
            }
            catch (WebException exp)
            {
                MessageBox.Show("服務連接失敗，不更新！");
                bHasError = true;
            }
            catch (XmlException exp)
            {
                bHasError = true;
                MessageBox.Show("下載更新文件出錯，不更新！");
            }
            catch (NotSupportedException exp)
            {
                bHasError = true;
                MessageBox.Show("更新地址配置錯誤，不更新！");
            }
            catch (ArgumentException exp)
            {
                bHasError = true;
                MessageBox.Show("下載升級文件出錯，不更新！");
            }
            catch (Exception exp)
            {
                bHasError = true;
                MessageBox.Show("升級過程中出錯，不更新！");
            }
            finally
            {
                if (bHasError == true)
                {
                    try
                    {
                        autoUpdater.RollBack();
                    }
                    catch (Exception)
                    {
                        //Log the message to your file or database
                    }
                }
            }
            #endregion
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "" || txtPassword.Text.Trim() == "") return;

            if (CheckPrivilege())
            {

                DialogResult = DialogResult.OK;
            }
            else
            {
                dtQuery.Clear();
                dtQuery2.Clear();
                GlobalString._ListBU.Clear();
            }
        }
        private bool CheckPrivilege()
        {

            string strSQL = "SELECT UserID, ChineseName, Password, CostID, chpass_time, Query_CostID  FROM swipecard.user_data where UserID='" + txtUserName.Text.Trim() + "'";
            try
            {
                dtQuery = Querydt.QueryDB(strSQL); 
                dtQuery.Columns.Add("BU", typeof(string));
                foreach (DataRow dr in dtQuery.Rows)
                { dr["BU"] = "通訊"; }
                dtQuery2 = Querydt.QueryDbAsbg(strSQL);
                dtQuery2.Columns.Add("BU", typeof(string));
                foreach (DataRow dr in dtQuery2.Rows)
                    dr["BU"] = "零組件";
                dtQuery.Merge(dtQuery2);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Query EMP Error！" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (dtQuery.Rows.Count > 0)
            {
                if (txtPassword.Text.Trim() != dtQuery.Rows[0]["Password"].ToString())
                {
                    txtPassword.Text = "";
                    MessageBox.Show("Invalid Password！", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Focus();
                    txtPassword.SelectAll();
                    return false;
                }
                else
                {
                    GlobalString._UserID = dtQuery.Rows[0]["UserID"].ToString();
                    GlobalString._ChineseName = dtQuery.Rows[0]["ChineseName"].ToString();
                    GlobalString._Password = dtQuery.Rows[0]["Password"].ToString();
                    string strCostID = "";
                    if (dtQuery.Rows[0]["CostID"].ToString() != "")
                    {
                        //List<string> lstCostID = dtQuery.Rows[0]["CostID"].ToString().Split(new char[] { '*' }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
                        string[] sArray = dtQuery.Rows[0]["CostID"].ToString().Split('*');
                        List<string> lstCostID = new List<string>(sArray);
                        GlobalString._ListCostID = lstCostID;
                        foreach (string ID in lstCostID)
                        {
                            strCostID += "'" + ID + "',";
                        }
                        GlobalString._CostID = strCostID.Substring(0, strCostID.Length - 1);
                    }
                    string strQueryCostID = "";
                    if (dtQuery.Rows[0]["Query_CostID"].ToString() != "")
                    {
                        if (dtQuery.Rows[0]["Query_CostID"].ToString().ToUpper() == "ALL")
                        {
                            GlobalString._Query_CostID = dtQuery.Rows[0]["Query_CostID"].ToString().ToUpper();
                        }
                        else
                        {
                            //List<string> lstCostID = dtQuery.Rows[0]["Query_CostID"].ToString().Split(new char[] { '*' }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
                            string[] sArray = dtQuery.Rows[0]["Query_CostID"].ToString().Split('*');
                            List<string> lstCostID = new List<string>(sArray);
                            GlobalString._ListQuery_CostID = lstCostID;
                            foreach (string ID in lstCostID)
                            {
                                strQueryCostID += "'" + ID + "',";
                            }
                            GlobalString._Query_CostID = strQueryCostID.Substring(0, strQueryCostID.Length - 1);
                        }
                    }
                    //GlobalString._BU = dtQuery.Rows[0]["BU"].ToString();
                    foreach (DataRow item in dtQuery.Rows)
                    {
                        GlobalString._ListBU.Add(item["BU"].ToString());
                    }
                    if (dtQuery.Rows[0]["chpass_time"].ToString() == "")
                    {
                        MessageBox.Show("第一次登錄，請修改密碼！", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ModifyPassword fmMP = new ModifyPassword();
                        if (fmMP.ShowDialog() == DialogResult.OK)
                        {
                            txtPassword.Focus();
                            txtPassword.SelectAll();
                            return false;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Login User Not Found！", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Text = "";
                txtUserName.Focus();
                txtUserName.SelectAll();
                return false;
            }

            return true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;  
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.Text = "Login " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            
        }

        private void FormLogin_Shown(object sender, EventArgs e)
        {
            if (!File.Exists(System.AppDomain.CurrentDomain.BaseDirectory + '\\' + "AutoUpdater.config"))
            {
                //MessageBox.Show("AutoUpdater.config不存在，不執行更新作業！！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
                XmlDocument xml = new XmlDocument();
                XmlDeclaration decl = xml.CreateXmlDeclaration("1.0", "utf-8", null);
                xml.AppendChild(decl);
                try
                {
                    XmlElement rootEle = xml.CreateElement("Config");
                    rootEle.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
                    rootEle.SetAttribute("xmlns:xsd", "http://www.w3.org/2001/XMLSchema");
                    xml.AppendChild(rootEle);
                    XmlElement EnableEle = xml.CreateElement("Enabled");
                    EnableEle.InnerText = "true";
                    rootEle.AppendChild(EnableEle);
                    XmlElement ServerUrlEle = xml.CreateElement("ServerUrl");
                    ServerUrlEle.InnerText = "http://192.168.60.31:8020/AutoupdateService.xml";
                    rootEle.AppendChild(ServerUrlEle);
                    XmlElement UpdateFileListEle = xml.CreateElement("UpdateFileList");
                    rootEle.AppendChild(UpdateFileListEle);
                    XmlElement LocalFileEle = xml.CreateElement("LocalFile");
                    LocalFileEle.SetAttribute("path", "Query.exe");
                    LocalFileEle.SetAttribute("lastver", "1.0.0.0");
                    LocalFileEle.SetAttribute("size", "100");
                    UpdateFileListEle.AppendChild(LocalFileEle);
                    xml.Save(System.AppDomain.CurrentDomain.BaseDirectory + '\\' + "AutoUpdater.config");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("生成Config出錯,不更新:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }
            CheckUpdate();
            
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
