using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using Query.Update;
using Query.Query;

namespace Query
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MenuItemCheckCard_Click(object sender, EventArgs e)
        {
            Form1 from1 = new Form1();
            from1.ShowDialog();
        }

        private void 補卡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            replaceCard fromReplaceCard = new replaceCard();
            fromReplaceCard.ShowDialog();
        }

        private void MenuItemCheckWork_Click(object sender, EventArgs e)
        {
            CheckWork fromCheckWork = new CheckWork();
            fromCheckWork.ShowDialog();
        }

        private void MenuItemCheckOverTime_Click(object sender, EventArgs e)
        {
            CheckOverTime fmCheckOverTime = new CheckOverTime();
            fmCheckOverTime.ShowDialog();
        }

       // private void ToolStripMenuItemGD_Click(object sender, EventArgs e)
       // {
       //     DGsubsidy fmDG = new DGsubsidy();
       //     fmDG.ShowDialog();
       // }

        private void ToolStripMenuItemForget_Click(object sender, EventArgs e)
        {
            ForgetCardQuery fmfcq = new ForgetCardQuery();
            fmfcq.ShowDialog();
        }

        private void ToolStripMenuItemRaw_Click(object sender, EventArgs e)
        {
            RawData fmRD = new RawData();
            fmRD.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (GlobalString._Query_CostID != "ALL")
            {
                ToolStripMenuItemRaw.Visible = false;
 
            }
        }

    }
}
