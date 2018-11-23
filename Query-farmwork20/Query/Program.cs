using System;
using System.Collections.Generic;
//using System.Linq;
using System.Windows.Forms;

namespace Query
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool ret;

            System.Threading.Mutex mutex = new System.Threading.Mutex(true, Application.ProductName, out ret);
            if (ret)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                FormLogin flogin = new FormLogin();
                if (flogin.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new MainForm());
                }  
                //Application.Run(new MainForm());
            }
        }
    }
}
