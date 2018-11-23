namespace Query
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labExportEmp = new System.Windows.Forms.Label();
            this.labExportDept = new System.Windows.Forms.Label();
            this.txtEmp = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.dateTimePickStart = new System.Windows.Forms.DateTimePicker();
            this.cmBoxEndMinute = new System.Windows.Forms.ComboBox();
            this.cmBoxEndHour = new System.Windows.Forms.ComboBox();
            this.cmBoxStartMinute = new System.Windows.Forms.ComboBox();
            this.cmBoxStartHour = new System.Windows.Forms.ComboBox();
            this.dateTimePickEnd = new System.Windows.Forms.DateTimePicker();
            this.btnExportEmp = new System.Windows.Forms.Button();
            this.btnExportDept = new System.Windows.Forms.Button();
            this.labSum = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.checkBoxEmp = new System.Windows.Forms.CheckBox();
            this.checkBoxDept = new System.Windows.Forms.CheckBox();
            this.labSumEmp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labSumDemp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comBoxBU = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCostID = new System.Windows.Forms.TextBox();
            this.CheckBoxCost = new System.Windows.Forms.CheckBox();
            this.btnExportCost = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.labSumCost = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(103, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "員工號:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(119, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "部門:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(87, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "開始日期:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(103, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "記錄數:";
            // 
            // labExportEmp
            // 
            this.labExportEmp.AutoSize = true;
            this.labExportEmp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labExportEmp.Location = new System.Drawing.Point(544, 8);
            this.labExportEmp.Name = "labExportEmp";
            this.labExportEmp.Size = new System.Drawing.Size(88, 16);
            this.labExportEmp.TabIndex = 7;
            this.labExportEmp.Text = "本次共導入";
            // 
            // labExportDept
            // 
            this.labExportDept.AutoSize = true;
            this.labExportDept.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labExportDept.Location = new System.Drawing.Point(544, 44);
            this.labExportDept.Name = "labExportDept";
            this.labExportDept.Size = new System.Drawing.Size(88, 16);
            this.labExportDept.TabIndex = 8;
            this.labExportDept.Text = "本次共導入";
            // 
            // txtEmp
            // 
            this.txtEmp.Location = new System.Drawing.Point(168, 6);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.Size = new System.Drawing.Size(150, 26);
            this.txtEmp.TabIndex = 9;
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(168, 36);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(150, 26);
            this.txtDept.TabIndex = 10;
            // 
            // dateTimePickStart
            // 
            this.dateTimePickStart.CustomFormat = "yyyy年MM月dd日";
            this.dateTimePickStart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePickStart.Location = new System.Drawing.Point(168, 104);
            this.dateTimePickStart.Name = "dateTimePickStart";
            this.dateTimePickStart.Size = new System.Drawing.Size(150, 26);
            this.dateTimePickStart.TabIndex = 12;
            this.dateTimePickStart.ValueChanged += new System.EventHandler(this.dateTimePickStart_ValueChanged);
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
            this.cmBoxEndMinute.Location = new System.Drawing.Point(377, 136);
            this.cmBoxEndMinute.Name = "cmBoxEndMinute";
            this.cmBoxEndMinute.Size = new System.Drawing.Size(39, 24);
            this.cmBoxEndMinute.TabIndex = 20;
            this.cmBoxEndMinute.Text = "00";
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
            this.cmBoxEndHour.Location = new System.Drawing.Point(324, 136);
            this.cmBoxEndHour.Name = "cmBoxEndHour";
            this.cmBoxEndHour.Size = new System.Drawing.Size(46, 24);
            this.cmBoxEndHour.TabIndex = 19;
            this.cmBoxEndHour.Text = "08";
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
            this.cmBoxStartMinute.Location = new System.Drawing.Point(376, 106);
            this.cmBoxStartMinute.Name = "cmBoxStartMinute";
            this.cmBoxStartMinute.Size = new System.Drawing.Size(40, 24);
            this.cmBoxStartMinute.TabIndex = 18;
            this.cmBoxStartMinute.Text = "00";
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
            this.cmBoxStartHour.Location = new System.Drawing.Point(324, 105);
            this.cmBoxStartHour.Name = "cmBoxStartHour";
            this.cmBoxStartHour.Size = new System.Drawing.Size(46, 24);
            this.cmBoxStartHour.TabIndex = 17;
            this.cmBoxStartHour.Text = "08";
            // 
            // dateTimePickEnd
            // 
            this.dateTimePickEnd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePickEnd.Location = new System.Drawing.Point(168, 136);
            this.dateTimePickEnd.Name = "dateTimePickEnd";
            this.dateTimePickEnd.Size = new System.Drawing.Size(150, 26);
            this.dateTimePickEnd.TabIndex = 21;
            // 
            // btnExportEmp
            // 
            this.btnExportEmp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExportEmp.Location = new System.Drawing.Point(345, 2);
            this.btnExportEmp.Name = "btnExportEmp";
            this.btnExportEmp.Size = new System.Drawing.Size(193, 31);
            this.btnExportEmp.TabIndex = 22;
            this.btnExportEmp.Text = "導入需查詢員工";
            this.btnExportEmp.UseVisualStyleBackColor = true;
            this.btnExportEmp.Click += new System.EventHandler(this.btnExportEmp_Click);
            // 
            // btnExportDept
            // 
            this.btnExportDept.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExportDept.Location = new System.Drawing.Point(345, 34);
            this.btnExportDept.Name = "btnExportDept";
            this.btnExportDept.Size = new System.Drawing.Size(193, 31);
            this.btnExportDept.TabIndex = 23;
            this.btnExportDept.Text = "導入部門";
            this.btnExportDept.UseVisualStyleBackColor = true;
            this.btnExportDept.Click += new System.EventHandler(this.btnExportDept_Click);
            // 
            // labSum
            // 
            this.labSum.AutoSize = true;
            this.labSum.Location = new System.Drawing.Point(165, 205);
            this.labSum.Name = "labSum";
            this.labSum.Size = new System.Drawing.Size(16, 16);
            this.labSum.TabIndex = 24;
            this.labSum.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(135, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "到:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(1, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1251, 404);
            this.dataGridView1.TabIndex = 26;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(281, 201);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 27;
            this.btnQuery.Text = "查找";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(362, 201);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 28;
            this.btnExport.Text = "導出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(443, 201);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 29;
            this.button5.Text = "打印";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(524, 201);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // checkBoxEmp
            // 
            this.checkBoxEmp.AutoSize = true;
            this.checkBoxEmp.Location = new System.Drawing.Point(324, 13);
            this.checkBoxEmp.Name = "checkBoxEmp";
            this.checkBoxEmp.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEmp.TabIndex = 31;
            this.checkBoxEmp.UseVisualStyleBackColor = true;
            this.checkBoxEmp.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxDept
            // 
            this.checkBoxDept.AutoSize = true;
            this.checkBoxDept.Location = new System.Drawing.Point(324, 43);
            this.checkBoxDept.Name = "checkBoxDept";
            this.checkBoxDept.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDept.TabIndex = 32;
            this.checkBoxDept.UseVisualStyleBackColor = true;
            this.checkBoxDept.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // labSumEmp
            // 
            this.labSumEmp.AutoSize = true;
            this.labSumEmp.Location = new System.Drawing.Point(626, 7);
            this.labSumEmp.Name = "labSumEmp";
            this.labSumEmp.Size = new System.Drawing.Size(16, 16);
            this.labSumEmp.TabIndex = 33;
            this.labSumEmp.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(693, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "條數據";
            // 
            // labSumDemp
            // 
            this.labSumDemp.AutoSize = true;
            this.labSumDemp.Location = new System.Drawing.Point(626, 44);
            this.labSumDemp.Name = "labSumDemp";
            this.labSumDemp.Size = new System.Drawing.Size(16, 16);
            this.labSumDemp.TabIndex = 35;
            this.labSumDemp.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(693, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "條數據";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "事業群:";
            this.label4.Visible = false;
            // 
            // comBoxBU
            // 
            this.comBoxBU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxBU.FormattingEnabled = true;
            this.comBoxBU.Location = new System.Drawing.Point(168, 166);
            this.comBoxBU.Name = "comBoxBU";
            this.comBoxBU.Size = new System.Drawing.Size(121, 24);
            this.comBoxBU.TabIndex = 38;
            this.comBoxBU.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "費用代碼:";
            // 
            // txtCostID
            // 
            this.txtCostID.Location = new System.Drawing.Point(168, 69);
            this.txtCostID.Name = "txtCostID";
            this.txtCostID.Size = new System.Drawing.Size(150, 26);
            this.txtCostID.TabIndex = 40;
            // 
            // CheckBoxCost
            // 
            this.CheckBoxCost.AutoSize = true;
            this.CheckBoxCost.Location = new System.Drawing.Point(324, 76);
            this.CheckBoxCost.Name = "CheckBoxCost";
            this.CheckBoxCost.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxCost.TabIndex = 41;
            this.CheckBoxCost.UseVisualStyleBackColor = true;
            this.CheckBoxCost.CheckedChanged += new System.EventHandler(this.CheckBoxCost_CheckedChanged);
            // 
            // btnExportCost
            // 
            this.btnExportCost.Font = new System.Drawing.Font("宋体", 12F);
            this.btnExportCost.Location = new System.Drawing.Point(345, 69);
            this.btnExportCost.Name = "btnExportCost";
            this.btnExportCost.Size = new System.Drawing.Size(193, 31);
            this.btnExportCost.TabIndex = 42;
            this.btnExportCost.Text = "導入費用代碼";
            this.btnExportCost.UseVisualStyleBackColor = true;
            this.btnExportCost.Click += new System.EventHandler(this.btnExportCost_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(544, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "本次共導入";
            // 
            // labSumCost
            // 
            this.labSumCost.AutoSize = true;
            this.labSumCost.Location = new System.Drawing.Point(626, 76);
            this.labSumCost.Name = "labSumCost";
            this.labSumCost.Size = new System.Drawing.Size(16, 16);
            this.labSumCost.TabIndex = 44;
            this.labSumCost.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(693, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 45;
            this.label12.Text = "條數據";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 635);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labSumCost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnExportCost);
            this.Controls.Add(this.CheckBoxCost);
            this.Controls.Add(this.txtCostID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comBoxBU);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labSumDemp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labSumEmp);
            this.Controls.Add(this.checkBoxDept);
            this.Controls.Add(this.checkBoxEmp);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labSum);
            this.Controls.Add(this.btnExportDept);
            this.Controls.Add(this.btnExportEmp);
            this.Controls.Add(this.dateTimePickEnd);
            this.Controls.Add(this.cmBoxEndMinute);
            this.Controls.Add(this.cmBoxEndHour);
            this.Controls.Add(this.cmBoxStartMinute);
            this.Controls.Add(this.cmBoxStartHour);
            this.Controls.Add(this.dateTimePickStart);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.txtEmp);
            this.Controls.Add(this.labExportDept);
            this.Controls.Add(this.labExportEmp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "查詢刷卡記錄";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labExportEmp;
        private System.Windows.Forms.Label labExportDept;
        private System.Windows.Forms.TextBox txtEmp;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.DateTimePicker dateTimePickStart;
        private System.Windows.Forms.ComboBox cmBoxEndMinute;
        private System.Windows.Forms.ComboBox cmBoxEndHour;
        private System.Windows.Forms.ComboBox cmBoxStartMinute;
        private System.Windows.Forms.ComboBox cmBoxStartHour;
        private System.Windows.Forms.DateTimePicker dateTimePickEnd;
        private System.Windows.Forms.Button btnExportEmp;
        private System.Windows.Forms.Button btnExportDept;
        private System.Windows.Forms.Label labSum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox checkBoxEmp;
        private System.Windows.Forms.CheckBox checkBoxDept;
        private System.Windows.Forms.Label labSumEmp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labSumDemp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comBoxBU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCostID;
        private System.Windows.Forms.CheckBox CheckBoxCost;
        private System.Windows.Forms.Button btnExportCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labSumCost;
        private System.Windows.Forms.Label label12;
    }
}

