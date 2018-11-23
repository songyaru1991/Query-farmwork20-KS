namespace Query.Update
{
    partial class replaceCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(replaceCard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNewCardID = new System.Windows.Forms.TextBox();
            this.txtOldCardID = new System.Windows.Forms.TextBox();
            this.txtBoxEmp = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comBoxBU = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 58);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(227, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 39);
            this.label1.TabIndex = 32;
            this.label1.Text = "補卡后更新實時工時資料";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDept);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comBoxBU);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNewCardID);
            this.panel1.Controls.Add(this.txtOldCardID);
            this.panel1.Controls.Add(this.txtBoxEmp);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(4, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 503);
            this.panel1.TabIndex = 33;
            // 
            // txtNewCardID
            // 
            this.txtNewCardID.BackColor = System.Drawing.Color.Linen;
            this.txtNewCardID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNewCardID.Location = new System.Drawing.Point(243, 290);
            this.txtNewCardID.MaxLength = 10;
            this.txtNewCardID.Name = "txtNewCardID";
            this.txtNewCardID.Size = new System.Drawing.Size(154, 26);
            this.txtNewCardID.TabIndex = 63;
            this.txtNewCardID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewCardID_KeyPress);
            this.txtNewCardID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNewCardID_KeyUp);
            // 
            // txtOldCardID
            // 
            this.txtOldCardID.BackColor = System.Drawing.Color.Linen;
            this.txtOldCardID.Enabled = false;
            this.txtOldCardID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOldCardID.Location = new System.Drawing.Point(243, 241);
            this.txtOldCardID.Name = "txtOldCardID";
            this.txtOldCardID.Size = new System.Drawing.Size(154, 26);
            this.txtOldCardID.TabIndex = 62;
            // 
            // txtBoxEmp
            // 
            this.txtBoxEmp.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtBoxEmp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBoxEmp.Location = new System.Drawing.Point(243, 106);
            this.txtBoxEmp.Name = "txtBoxEmp";
            this.txtBoxEmp.Size = new System.Drawing.Size(108, 26);
            this.txtBoxEmp.TabIndex = 59;
            this.txtBoxEmp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxEmp_KeyDown);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(362, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 23);
            this.button2.TabIndex = 58;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOK
            // 
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(163, 396);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(52, 23);
            this.btnOK.TabIndex = 57;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(149, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "新CardID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(149, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "舊CardID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(173, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "工號:";
            // 
            // comBoxBU
            // 
            this.comBoxBU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxBU.Font = new System.Drawing.Font("宋体", 12F);
            this.comBoxBU.FormattingEnabled = true;
            this.comBoxBU.Items.AddRange(new object[] {
            "CSBG",
            "ASBG"});
            this.comBoxBU.Location = new System.Drawing.Point(243, 59);
            this.comBoxBU.Name = "comBoxBU";
            this.comBoxBU.Size = new System.Drawing.Size(108, 24);
            this.comBoxBU.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(157, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 62;
            this.label5.Text = "事業群:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(173, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 64;
            this.label6.Text = "姓名:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.Location = new System.Drawing.Point(173, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 65;
            this.label7.Text = "部門:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Linen;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("宋体", 12F);
            this.txtName.Location = new System.Drawing.Point(243, 149);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(108, 26);
            this.txtName.TabIndex = 60;
            // 
            // txtDept
            // 
            this.txtDept.BackColor = System.Drawing.Color.Linen;
            this.txtDept.Enabled = false;
            this.txtDept.Font = new System.Drawing.Font("宋体", 12F);
            this.txtDept.Location = new System.Drawing.Point(243, 196);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(108, 26);
            this.txtDept.TabIndex = 61;
            // 
            // replaceCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 590);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "replaceCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "replaceCard";
            this.Load += new System.EventHandler(this.replaceCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNewCardID;
        private System.Windows.Forms.TextBox txtOldCardID;
        private System.Windows.Forms.TextBox txtBoxEmp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comBoxBU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}