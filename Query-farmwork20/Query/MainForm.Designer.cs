namespace Query
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCheckCard = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCheckWork = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCheckOverTime = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGD = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemForget = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRaw = new System.Windows.Forms.ToolStripMenuItem();
            this.更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.補卡ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem,
            this.更新ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCheckCard,
            this.MenuItemCheckWork,
            this.MenuItemCheckOverTime,
            this.ToolStripMenuItemGD,
            this.ToolStripMenuItemForget,
            this.ToolStripMenuItemRaw});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItem.Text = "查詢";
            // 
            // MenuItemCheckCard
            // 
            this.MenuItemCheckCard.Name = "MenuItemCheckCard";
            this.MenuItemCheckCard.Size = new System.Drawing.Size(172, 22);
            this.MenuItemCheckCard.Text = "查詢刷卡記錄";
            this.MenuItemCheckCard.Click += new System.EventHandler(this.MenuItemCheckCard_Click);
            // 
            // MenuItemCheckWork
            // 
            this.MenuItemCheckWork.Name = "MenuItemCheckWork";
            this.MenuItemCheckWork.Size = new System.Drawing.Size(172, 22);
            this.MenuItemCheckWork.Text = "查詢加班信息";
            this.MenuItemCheckWork.Click += new System.EventHandler(this.MenuItemCheckWork_Click);
            // 
            // MenuItemCheckOverTime
            // 
            this.MenuItemCheckOverTime.Name = "MenuItemCheckOverTime";
            this.MenuItemCheckOverTime.Size = new System.Drawing.Size(172, 22);
            this.MenuItemCheckOverTime.Text = "查詢班別信息";
            this.MenuItemCheckOverTime.Click += new System.EventHandler(this.MenuItemCheckOverTime_Click);
            // 
            // ToolStripMenuItemGD
            // 
          //  this.ToolStripMenuItemGD.Name = "ToolStripMenuItemGD";
           // this.ToolStripMenuItemGD.Size = new System.Drawing.Size(172, 22);
           // this.ToolStripMenuItemGD.Text = "頂崗津貼";
           // this.ToolStripMenuItemGD.Click += new System.EventHandler(this.ToolStripMenuItemGD_Click);
            // 
            // ToolStripMenuItemForget
            // 
            this.ToolStripMenuItemForget.Name = "ToolStripMenuItemForget";
            this.ToolStripMenuItemForget.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItemForget.Text = "忘卡人員查詢";
            this.ToolStripMenuItemForget.Click += new System.EventHandler(this.ToolStripMenuItemForget_Click);
            // 
            // ToolStripMenuItemRaw
            // 
            this.ToolStripMenuItemRaw.Name = "ToolStripMenuItemRaw";
            this.ToolStripMenuItemRaw.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItemRaw.Text = "查詢原始刷卡記錄";
            this.ToolStripMenuItemRaw.Click += new System.EventHandler(this.ToolStripMenuItemRaw_Click);
            // 
            // 更新ToolStripMenuItem
            // 
            this.更新ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.補卡ToolStripMenuItem});
            this.更新ToolStripMenuItem.Name = "更新ToolStripMenuItem";
            this.更新ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.更新ToolStripMenuItem.Text = "更新";
            this.更新ToolStripMenuItem.Visible = false;
            // 
            // 補卡ToolStripMenuItem
            // 
            this.補卡ToolStripMenuItem.Name = "補卡ToolStripMenuItem";
            this.補卡ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.補卡ToolStripMenuItem.Text = "補卡";
            this.補卡ToolStripMenuItem.Visible = false;
            this.補卡ToolStripMenuItem.Click += new System.EventHandler(this.補卡ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 443);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "實時工時系統查詢";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCheckCard;
        private System.Windows.Forms.ToolStripMenuItem 更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 補卡ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCheckWork;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCheckOverTime;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGD;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemForget;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRaw;
    }
}