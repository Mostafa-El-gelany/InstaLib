using Library.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Context = Library.Model.Context;
using Rule = Library.Model.Rule;

namespace Library
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
            var ctn = Program.Connector.Users.Where(us => us.rule == Rule.IT).FirstOrDefault();
            if (ctn == null)
            {
                User user = new User();
                user.Username = "Admin";
                user.Password = "Admin.com";
                user.rule = Rule.IT;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            var username=textBox1.Text;
            var password = textBox3.Text;
            var user = Program.Connector.Users.FirstOrDefault(x => x.Username == username && x.Password == password);
            if (user == null)
            {
                MessageBox.Show("Invalid username or password");
                return;
            }
            else
            {
                Program.CurentUser = user;
                if (user.rule == Model.Rule.Manager)
                {
                    Manager manager = new Manager();
                    Program.next = manager;
                    this.Close();
                }
                else if(user.rule == Model.Rule.Librarian)
                {
                    Form1 form1 = new Form1(user);
                    Program.next = form1;
                    this.Close();
                }
                else if(user.rule==Model.Rule.IT)
                {
                    Support support = new Support();
                    Program.next = support;
                    this.Close();
                }
                
                else
                {
                    MessageBox.Show("Invalid username or password");
                    return;
                }



            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
