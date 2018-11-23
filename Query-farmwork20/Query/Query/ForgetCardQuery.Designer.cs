namespace Query.Query
{
    partial class ForgetCardQuery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxCostID = new System.Windows.Forms.ListBox();
            this.btnSearchCostID = new System.Windows.Forms.Button();
            this.listBoxDeptID = new System.Windows.Forms.ListBox();
            this.btnSearchDeptID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comBoxBU
            // 
            this.comBoxBU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxBU.Font = new System.Drawing.Font("宋体", 12F);
            this.comBoxBU.FormattingEnabled = true;
            this.comBoxBU.Location = new System.Drawing.Point(152, 101);
            this.comBoxBU.Name = "comBoxBU";
            this.comBoxBU.Size = new System.Drawing.Size(121, 24);
            this.comBoxBU.TabIndex = 147;
            this.comBoxBU.SelectedIndexChanged += new System.EventHandler(this.comBoxBU_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(82, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 146;
            this.label4.Text = "事業群:";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("宋体", 12F);
            this.btnClear.Location = new System.Drawing.Point(632, 190);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 145;
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
            this.button5.TabIndex = 144;
            this.button5.Text = "打印";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("宋体", 12F);
            this.btnExport.Location = new System.Drawing.Point(469, 190);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 143;
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
            this.btnQuery.TabIndex = 142;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1250, 413);
            this.dataGridView1.TabIndex = 141;
            // 
            // labSum
            // 
            this.labSum.AutoSize = true;
            this.labSum.Font = new System.Drawing.Font("宋体", 12F);
            this.labSum.Location = new System.Drawing.Point(145, 190);
            this.labSum.Name = "labSum";
            this.labSum.Size = new System.Drawing.Size(16, 16);
            this.labSum.TabIndex = 140;
            this.labSum.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(83, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 139;
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
            this.cmBoxEndMinute.Location = new System.Drawing.Point(371, 66);
            this.cmBoxEndMinute.Name = "cmBoxEndMinute";
            this.cmBoxEndMinute.Size = new System.Drawing.Size(39, 24);
            this.cmBoxEndMinute.TabIndex = 138;
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
            this.cmBoxEndHour.Location = new System.Drawing.Point(318, 66);
            this.cmBoxEndHour.Name = "cmBoxEndHour";
            this.cmBoxEndHour.Size = new System.Drawing.Size(46, 24);
            this.cmBoxEndHour.TabIndex = 137;
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
            this.cmBoxStartMinute.Location = new System.Drawing.Point(370, 36);
            this.cmBoxStartMinute.Name = "cmBoxStartMinute";
            this.cmBoxStartMinute.Size = new System.Drawing.Size(40, 24);
            this.cmBoxStartMinute.TabIndex = 136;
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
            this.cmBoxStartHour.Location = new System.Drawing.Point(318, 35);
            this.cmBoxStartHour.Name = "cmBoxStartHour";
            this.cmBoxStartHour.Size = new System.Drawing.Size(46, 24);
            this.cmBoxStartHour.TabIndex = 135;
            this.cmBoxStartHour.Text = "08";
            this.cmBoxStartHour.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(119, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 12);
            this.label10.TabIndex = 132;
            this.label10.Text = "到:";
            this.label10.Visible = false;
            // 
            // dateTimePickEnd
            // 
            this.dateTimePickEnd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePickEnd.Location = new System.Drawing.Point(152, 67);
            this.dateTimePickEnd.Name = "dateTimePickEnd";
            this.dateTimePickEnd.Size = new System.Drawing.Size(150, 26);
            this.dateTimePickEnd.TabIndex = 131;
            this.dateTimePickEnd.Visible = false;
            // 
            // dateTimePickStart
            // 
            this.dateTimePickStart.CustomFormat = "yyyy年MM月dd日";
            this.dateTimePickStart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePickStart.Location = new System.Drawing.Point(152, 35);
            this.dateTimePickStart.Name = "dateTimePickStart";
            this.dateTimePickStart.Size = new System.Drawing.Size(150, 26);
            this.dateTimePickStart.TabIndex = 130;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(96, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 129;
            this.label3.Text = "日期:";
            // 
            // listBoxCostID
            // 
            this.listBoxCostID.FormattingEnabled = true;
            this.listBoxCostID.ItemHeight = 12;
            this.listBoxCostID.Location = new System.Drawing.Point(510, 41);
            this.listBoxCostID.Name = "listBoxCostID";
            this.listBoxCostID.Size = new System.Drawing.Size(162, 124);
            this.listBoxCostID.TabIndex = 149;
            // 
            // btnSearchCostID
            // 
            this.btnSearchCostID.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSearchCostID.Location = new System.Drawing.Point(510, 8);
            this.btnSearchCostID.Name = "btnSearchCostID";
            this.btnSearchCostID.Size = new System.Drawing.Size(92, 27);
            this.btnSearchCostID.TabIndex = 148;
            this.btnSearchCostID.Text = "費用代碼";
            this.btnSearchCostID.UseVisualStyleBackColor = true;
            this.btnSearchCostID.Click += new System.EventHandler(this.btnSearchCostID_Click);
            // 
            // listBoxDeptID
            // 
            this.listBoxDeptID.FormattingEnabled = true;
            this.listBoxDeptID.ItemHeight = 12;
            this.listBoxDeptID.Location = new System.Drawing.Point(741, 41);
            this.listBoxDeptID.Name = "listBoxDeptID";
            this.listBoxDeptID.Size = new System.Drawing.Size(162, 124);
            this.listBoxDeptID.TabIndex = 151;
            // 
            // btnSearchDeptID
            // 
            this.btnSearchDeptID.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSearchDeptID.Location = new System.Drawing.Point(741, 9);
            this.btnSearchDeptID.Name = "btnSearchDeptID";
            this.btnSearchDeptID.Size = new System.Drawing.Size(92, 27);
            this.btnSearchDeptID.TabIndex = 150;
            this.btnSearchDeptID.Text = "部門代碼";
            this.btnSearchDeptID.UseVisualStyleBackColor = true;
            this.btnSearchDeptID.Click += new System.EventHandler(this.btnSearchDeptID_Click);
            // 
            // ForgetCardQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 635);
            this.Controls.Add(this.listBoxDeptID);
            this.Controls.Add(this.btnSearchDeptID);
            this.Controls.Add(this.listBoxCostID);
            this.Controls.Add(this.btnSearchCostID);
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
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePickEnd);
            this.Controls.Add(this.dateTimePickStart);
            this.Controls.Add(this.label3);
            this.Name = "ForgetCardQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ForgetCardQuery";
            this.Load += new System.EventHandler(this.ForgetCardQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxCostID;
        private System.Windows.Forms.Button btnSearchCostID;
        private System.Windows.Forms.ListBox listBoxDeptID;
        private System.Windows.Forms.Button btnSearchDeptID;
    }
}