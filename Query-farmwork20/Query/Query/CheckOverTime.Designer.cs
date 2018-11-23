namespace Query.Query
{
    partial class CheckOverTime
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.labSumEmp = new System.Windows.Forms.Label();
            this.checkBoxEmp = new System.Windows.Forms.CheckBox();
            this.btnExportEmp = new System.Windows.Forms.Button();
            this.labExportEmp = new System.Windows.Forms.Label();
            this.comBoxBU = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labSum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmBoxEndMinute = new System.Windows.Forms.ComboBox();
            this.cmBoxEndHour = new System.Windows.Forms.ComboBox();
            this.cmBoxStartMinute = new System.Windows.Forms.ComboBox();
            this.cmBoxStartHour = new System.Windows.Forms.ComboBox();
            this.txtCostID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labSumCost = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExportCost = new System.Windows.Forms.Button();
            this.CheckBoxCost = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(685, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 90;
            this.label5.Text = "條數據";
            // 
            // labSumEmp
            // 
            this.labSumEmp.AutoSize = true;
            this.labSumEmp.Font = new System.Drawing.Font("宋体", 12F);
            this.labSumEmp.Location = new System.Drawing.Point(619, 10);
            this.labSumEmp.Name = "labSumEmp";
            this.labSumEmp.Size = new System.Drawing.Size(16, 16);
            this.labSumEmp.TabIndex = 89;
            this.labSumEmp.Text = "0";
            // 
            // checkBoxEmp
            // 
            this.checkBoxEmp.AutoSize = true;
            this.checkBoxEmp.Location = new System.Drawing.Point(317, 16);
            this.checkBoxEmp.Name = "checkBoxEmp";
            this.checkBoxEmp.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEmp.TabIndex = 88;
            this.checkBoxEmp.UseVisualStyleBackColor = true;
            this.checkBoxEmp.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnExportEmp
            // 
            this.btnExportEmp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExportEmp.Location = new System.Drawing.Point(338, 5);
            this.btnExportEmp.Name = "btnExportEmp";
            this.btnExportEmp.Size = new System.Drawing.Size(193, 31);
            this.btnExportEmp.TabIndex = 87;
            this.btnExportEmp.Text = "導入需查詢員工";
            this.btnExportEmp.UseVisualStyleBackColor = true;
            this.btnExportEmp.Click += new System.EventHandler(this.btnExportEmp_Click);
            // 
            // labExportEmp
            // 
            this.labExportEmp.AutoSize = true;
            this.labExportEmp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labExportEmp.Location = new System.Drawing.Point(537, 11);
            this.labExportEmp.Name = "labExportEmp";
            this.labExportEmp.Size = new System.Drawing.Size(88, 16);
            this.labExportEmp.TabIndex = 86;
            this.labExportEmp.Text = "本次共導入";
            // 
            // comBoxBU
            // 
            this.comBoxBU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxBU.Font = new System.Drawing.Font("宋体", 12F);
            this.comBoxBU.FormattingEnabled = true;
            this.comBoxBU.Location = new System.Drawing.Point(153, 138);
            this.comBoxBU.Name = "comBoxBU";
            this.comBoxBU.Size = new System.Drawing.Size(121, 24);
            this.comBoxBU.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(83, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 84;
            this.label4.Text = "事業群:";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("宋体", 12F);
            this.btnClear.Location = new System.Drawing.Point(632, 190);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 83;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("宋体", 12F);
            this.button5.Location = new System.Drawing.Point(550, 190);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 82;
            this.button5.Text = "打印";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("宋体", 12F);
            this.btnExport.Location = new System.Drawing.Point(469, 190);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 81;
            this.btnExport.Text = "導出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("宋体", 12F);
            this.btnQuery.Location = new System.Drawing.Point(388, 190);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 80;
            this.btnQuery.Text = "查找";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(2, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1250, 413);
            this.dataGridView1.TabIndex = 79;
            // 
            // labSum
            // 
            this.labSum.AutoSize = true;
            this.labSum.Font = new System.Drawing.Font("宋体", 12F);
            this.labSum.Location = new System.Drawing.Point(145, 190);
            this.labSum.Name = "labSum";
            this.labSum.Size = new System.Drawing.Size(16, 16);
            this.labSum.TabIndex = 78;
            this.labSum.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(83, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 77;
            this.label7.Text = "記錄數:";
            // 
            // cmBoxEndMinute
            // 
            this.cmBoxEndMinute.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmBoxEndMinute.FormattingEnabled = true;
            this.cmBoxEndMinute.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmBoxEndMinute.Location = new System.Drawing.Point(372, 103);
            this.cmBoxEndMinute.Name = "cmBoxEndMinute";
            this.cmBoxEndMinute.Size = new System.Drawing.Size(39, 24);
            this.cmBoxEndMinute.TabIndex = 76;
            this.cmBoxEndMinute.Text = "00";
            this.cmBoxEndMinute.Visible = false;
            // 
            // cmBoxEndHour
            // 
            this.cmBoxEndHour.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmBoxEndHour.FormattingEnabled = true;
            this.cmBoxEndHour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmBoxEndHour.Location = new System.Drawing.Point(319, 103);
            this.cmBoxEndHour.Name = "cmBoxEndHour";
            this.cmBoxEndHour.Size = new System.Drawing.Size(46, 24);
            this.cmBoxEndHour.TabIndex = 75;
            this.cmBoxEndHour.Text = "08";
            this.cmBoxEndHour.Visible = false;
            // 
            // cmBoxStartMinute
            // 
            this.cmBoxStartMinute.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmBoxStartMinute.FormattingEnabled = true;
            this.cmBoxStartMinute.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmBoxStartMinute.Location = new System.Drawing.Point(371, 73);
            this.cmBoxStartMinute.Name = "cmBoxStartMinute";
            this.cmBoxStartMinute.Size = new System.Drawing.Size(40, 24);
            this.cmBoxStartMinute.TabIndex = 74;
            this.cmBoxStartMinute.Text = "00";
            this.cmBoxStartMinute.Visible = false;
            // 
            // cmBoxStartHour
            // 
            this.cmBoxStartHour.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmBoxStartHour.FormattingEnabled = true;
            this.cmBoxStartHour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmBoxStartHour.Location = new System.Drawing.Point(319, 72);
            this.cmBoxStartHour.Name = "cmBoxStartHour";
            this.cmBoxStartHour.Size = new System.Drawing.Size(46, 24);
            this.cmBoxStartHour.TabIndex = 73;
            this.cmBoxStartHour.Text = "08";
            this.cmBoxStartHour.Visible = false;
            // 
            // txtCostID
            // 
            this.txtCostID.Font = new System.Drawing.Font("宋体", 12F);
            this.txtCostID.Location = new System.Drawing.Point(153, 39);
            this.txtCostID.Name = "txtCostID";
            this.txtCostID.Size = new System.Drawing.Size(150, 26);
            this.txtCostID.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(67, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 71;
            this.label6.Text = "費用代碼:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 12);
            this.label10.TabIndex = 70;
            this.label10.Text = "到:";
            // 
            // dateTimePickEnd
            // 
            this.dateTimePickEnd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePickEnd.Location = new System.Drawing.Point(153, 104);
            this.dateTimePickEnd.Name = "dateTimePickEnd";
            this.dateTimePickEnd.Size = new System.Drawing.Size(150, 26);
            this.dateTimePickEnd.TabIndex = 69;
            // 
            // dateTimePickStart
            // 
            this.dateTimePickStart.CustomFormat = "yyyy年MM月dd日";
            this.dateTimePickStart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePickStart.Location = new System.Drawing.Point(153, 72);
            this.dateTimePickStart.Name = "dateTimePickStart";
            this.dateTimePickStart.Size = new System.Drawing.Size(150, 26);
            this.dateTimePickStart.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(72, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 67;
            this.label3.Text = "開始日期:";
            // 
            // txtEmp
            // 
            this.txtEmp.Font = new System.Drawing.Font("宋体", 12F);
            this.txtEmp.Location = new System.Drawing.Point(153, 7);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.Size = new System.Drawing.Size(150, 26);
            this.txtEmp.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(83, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 65;
            this.label1.Text = "員工號:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F);
            this.label12.Location = new System.Drawing.Point(686, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 95;
            this.label12.Text = "條數據";
            // 
            // labSumCost
            // 
            this.labSumCost.AutoSize = true;
            this.labSumCost.Font = new System.Drawing.Font("宋体", 12F);
            this.labSumCost.Location = new System.Drawing.Point(619, 45);
            this.labSumCost.Name = "labSumCost";
            this.labSumCost.Size = new System.Drawing.Size(16, 16);
            this.labSumCost.TabIndex = 94;
            this.labSumCost.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F);
            this.label9.Location = new System.Drawing.Point(537, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 93;
            this.label9.Text = "本次共導入";
            // 
            // btnExportCost
            // 
            this.btnExportCost.Font = new System.Drawing.Font("宋体", 12F);
            this.btnExportCost.Location = new System.Drawing.Point(338, 38);
            this.btnExportCost.Name = "btnExportCost";
            this.btnExportCost.Size = new System.Drawing.Size(193, 31);
            this.btnExportCost.TabIndex = 92;
            this.btnExportCost.Text = "導入費用代碼";
            this.btnExportCost.UseVisualStyleBackColor = true;
            this.btnExportCost.Click += new System.EventHandler(this.btnExportCost_Click);
            // 
            // CheckBoxCost
            // 
            this.CheckBoxCost.AutoSize = true;
            this.CheckBoxCost.Location = new System.Drawing.Point(317, 45);
            this.CheckBoxCost.Name = "CheckBoxCost";
            this.CheckBoxCost.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxCost.TabIndex = 91;
            this.CheckBoxCost.UseVisualStyleBackColor = true;
            this.CheckBoxCost.CheckedChanged += new System.EventHandler(this.CheckBoxCost_CheckedChanged);
            // 
            // CheckOverTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 635);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labSumCost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnExportCost);
            this.Controls.Add(this.CheckBoxCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labSumEmp);
            this.Controls.Add(this.checkBoxEmp);
            this.Controls.Add(this.btnExportEmp);
            this.Controls.Add(this.labExportEmp);
            this.Controls.Add(this.comBoxBU);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labSum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmBoxEndMinute);
            this.Controls.Add(this.cmBoxEndHour);
            this.Controls.Add(this.cmBoxStartMinute);
            this.Controls.Add(this.cmBoxStartHour);
            this.Controls.Add(this.txtCostID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePickEnd);
            this.Controls.Add(this.dateTimePickStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmp);
            this.Controls.Add(this.label1);
            this.Name = "CheckOverTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "查詢班別";
            this.Load += new System.EventHandler(this.CheckWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labSumEmp;
        private System.Windows.Forms.CheckBox checkBoxEmp;
        private System.Windows.Forms.Button btnExportEmp;
        private System.Windows.Forms.Label labExportEmp;
        private System.Windows.Forms.ComboBox comBoxBU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labSum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmBoxEndMinute;
        private System.Windows.Forms.ComboBox cmBoxEndHour;
        private System.Windows.Forms.ComboBox cmBoxStartMinute;
        private System.Windows.Forms.ComboBox cmBoxStartHour;
        private System.Windows.Forms.TextBox txtCostID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labSumCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExportCost;
        private System.Windows.Forms.CheckBox CheckBoxCost;
    }
}