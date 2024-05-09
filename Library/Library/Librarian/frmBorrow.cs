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
    public partial class frmBorrow : Form
    {
        public frmBorrow()
        {
            InitializeComponent();
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if(siticoneComboBox1.SelectedItem == null || siticoneComboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select a book and a customer");
                return;
            }
            var isbn = (long)siticoneComboBox1.SelectedValue;
            var username = (string)siticoneComboBox2.SelectedValue;
            var user = Program.Connector.Users.Where(x => x.Username == username).FirstOrDefault();

            var IsUserFree = Program.Connector.UserBooks.Where(us=>us.UserId==username && us.IsReturned==false).FirstOrDefault();

            if (IsUserFree!=null)
            {
                MessageBox.Show("This user has already borrowed a book");
                return;
            }
            var book = Program.Connector.Books.Where(x => x.ISBN == isbn).FirstOrDefault();

            var NewBorrow = new Model.UserBook()
            {
                BookId = isbn,
                UserId = username,
                DateOfBorrowing = DateTime.Now,
                IsReturned = false
            };
            try
            {
                Program.Connector.UserBooks.Add(NewBorrow);
                book.quantity--;

                Program.Connector.SaveChanges();
                MessageBox.Show("Book borrowed successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured");
            }

        }

        private void frmBorrow_Load(object sender, EventArgs e)
        {
            var customers=Program.Connector.Users.Where(x => x.rule == Model.Rule.Customer).ToList();
            siticoneComboBox2.DataSource = customers;
            siticoneComboBox2.DisplayMember = "Username";
            siticoneComboBox2.ValueMember = "Username";
            var books = Program.Connector.Books.Where(w=>w.quantity>5).ToList();
            siticoneComboBox1.DataSource = books;
            siticoneComboBox1.DisplayMember = "Title";
            siticoneComboBox1.ValueMember = "ISBN";

        }
    }
}
