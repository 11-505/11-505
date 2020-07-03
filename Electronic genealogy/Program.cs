using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_genealogy
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());

            MainForm mainform = new MainForm();

            mainform.ShowDialog();//界面转换
            if (mainform.DialogResult == DialogResult.OK && MainForm.loginin == 1)
            {
                mainform.Dispose();
                Application.Run(new Users());
            }
            else if (mainform.DialogResult == DialogResult.OK && MainForm.loginin == 2)
            {
                mainform.Dispose();
                Application.Run(new Geadmins());
            }
            else if (mainform.DialogResult == DialogResult.OK && MainForm.loginin == 3)
            {
                mainform.Dispose();
                Application.Run(new Systemadmins());
            }
            else
            {
                mainform.Dispose();
                return;
            }
        }
    }
}
