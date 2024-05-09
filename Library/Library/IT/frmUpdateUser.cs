using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class frmUpdateUser : Form
    {
        public frmUpdateUser()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if(Program.CurentUser ==null || Program.CurentUser.rule!=Model.Rule.IT)
            {
                MessageBox.Show("You are not allowed to access this page");
                this.Close();
                return;
            }
            var username=textBox1.Text;
            var Oldpassword = textBox3.Text;
            var Newpassword = textBox2.Text;
            var Tuser=Program.Connector.Users.FirstOrDefault(x => x.Username == username);
            if (Tuser == null)
            {
                MessageBox.Show("User not found");
                return;
            }
            if (Tuser.Password != Oldpassword)
            {
                MessageBox.Show("Old password is incorrect");
                return;
            }
            Tuser.Password = Newpassword;
            Program.Connector.SaveChanges();
            MessageBox.Show("Password updated successfully");


        }
    }
}
