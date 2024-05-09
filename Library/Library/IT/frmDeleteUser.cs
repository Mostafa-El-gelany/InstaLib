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
    public partial class frmDeleteUser : Form
    {
        public frmDeleteUser()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (Program.CurentUser == null || Program.CurentUser.rule != Model.Rule.IT)
            {
                MessageBox.Show("You arr not allowed to use this Page,Please Login");
                this.Close();
                return;
            }
            var username = textBox1.Text;
            if (username == "")
            {
                MessageBox.Show("Please Enter Username");
                return;
            }
            if(username.ToLower() =="admin")
            {
                MessageBox.Show("this User Can't be deleted");
                return;
            }
            var user = Program.Connector.Users.FirstOrDefault(x => x.Username == username);
            if (user == null)
            {
                MessageBox.Show("User Not Found");
                return;
            }
            if(user.rule == Model.Rule.Customer) 
            {
                MessageBox.Show("Customer account can't be deleted");
                return;
            }
            try
            {
                Program.Connector.Users.Remove(user);
                Program.Connector.SaveChanges();
                MessageBox.Show("User Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Delete");
            }

        }
    }
}
