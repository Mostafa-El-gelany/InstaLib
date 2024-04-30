using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public static class Program
    {
        public static Form cur=null, next=null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            cur = new frmLogin();
            while(cur != null)
            {
                Application.Run(cur);
                cur = next;
                next = null;
            }
        }
    }
}
