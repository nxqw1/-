using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace WindowsFormsApp2
{
    static class Program
    {
        public static string strCon=ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
        

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Frmlogin frm = new Frmlogin();
            if (frm.ShowDialog() == DialogResult.OK)
                Application.Run(new MainFrm());
            else
                Application.Exit();
        }
    }
}
