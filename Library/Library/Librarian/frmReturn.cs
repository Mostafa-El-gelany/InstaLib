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

namespace Library
{
    public partial class frmReturn : Form
    {
        public frmReturn()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            var selectedindex = siticoneComboBox1.SelectedIndex;
            if (selectedindex == -1)
            {
                MessageBox.Show("Please select a borrow");
                return;
            }
            var id = (int)siticoneComboBox1.SelectedValue;
            var ub = Program.Connector.UserBooks.Include("book").First(x => x.ID == id);
            try
            {
                ub.IsReturned = true;
                ub.book.quantity++;
                Program.Connector.SaveChanges();
                MessageBox.Show("Book is returned");
                charge();
            }
            catch
            {
                MessageBox.Show("error");
            }


            
            
        }
        private void charge()
        {
            siticoneComboBox1.DataSource = null;
            var borrows = Program.Connector.UserBooks.Include("User").Include("Book").Where(x => x.IsReturned == false).Select(x => new
            {
                id = x.ID,
                text = "username is " + x.UserId + " book name is " + x.BookId
            });
            siticoneComboBox1.DataSource = borrows.ToList();
            siticoneComboBox1.DisplayMember = "text";
            siticoneComboBox1.ValueMember = "id";
        }
        
        private void frmReturn_Load(object sender, EventArgs e)
        {
            charge();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
