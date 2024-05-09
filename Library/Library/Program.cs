using Library.Model;
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
        public static User CurentUser;
        public static Context Connector;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Connector = new Context();
            
            var ctn=Connector.Users.Where(us=>us.rule==Rule.IT).FirstOrDefault();
            if(ctn==null)
            {
                User user = new User();
                user.Username = "Admin";
                user.Password = "Admin.com";
                user.rule = Rule.IT;
                Connector.Users.Add(user);
                Connector.SaveChanges();
            }
            
            cur= new frmLogin();
            while (cur != null)
            {
                Application.Run(cur);
                cur = next;
                next = null;
            }
        }
    }
}
