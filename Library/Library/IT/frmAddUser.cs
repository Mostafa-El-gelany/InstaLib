using Library.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rule = Library.Model.Rule;

namespace Library
{
    public partial class FrmAddUser : Form
    {
        private List<dynamic> rules;
        public FrmAddUser()
        {
            InitializeComponent();
             rules=new List<dynamic>();
            rules.Add(new { rule = Rule.Manager, Name = "Admin" });
            rules.Add(new { rule = Rule.Librarian, Name = "Librarian" });
            rules.Add(new { rule = Rule.Customer, Name = "Customer" });
            rules.Add(new { rule = Rule.IT, Name = "IT" });
            siticoneComboBox1.DataSource = rules;
            siticoneComboBox1.DisplayMember = "Name";
            siticoneComboBox1.ValueMember = "rule";
            siticoneComboBox1.SelectedIndex = 0;

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            var username =textBox1.Text;
            if(Program.CurentUser== null || Program.CurentUser.rule!=Rule.IT)
            {
                MessageBox.Show("You arr not allowed to use this Page,Please Login");
                this.Close();
                return;
            }
            if(username.Length<8)
            {
                MessageBox.Show("Username must be at least 8 characters long");
                return;
            }
            var password = textBox3.Text;
            //password must be at least 8 characters long and contain at least one number and one small letter and one capital letter and special character
            if (password.Length < 8 || !password.Any(char.IsDigit) || !password.Any(char.IsLower) || !password.Any(char.IsUpper) || !password.Any(char.IsPunctuation))
            {
                MessageBox.Show("Password must be at least 8 characters long and contain at least one number and one small letter and one capital letter and special character");
                return;
            }
            var check = Program.Connector.Users.Where(w => w.Username == username).FirstOrDefault();
            if (check != null)
            {
                MessageBox.Show("this username is not avaliable");
                return;
            }
            var role = (Rule)siticoneComboBox1.SelectedValue;
            var user = new User()
            {
                Username = username,
                Password = password,
                rule = role
            };
            try
            {

                Program.Connector.Users.Add(user);
                Program.Connector.SaveChanges();
                MessageBox.Show("User added successfully");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


        }
    }
}
