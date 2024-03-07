using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CreateEntity
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {   
            //本地数据库连接链接
            //Data Source = localhost,1433; DataBase = test01; uid = sa; pwd = 123456; Trusted_Connection = no;
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
