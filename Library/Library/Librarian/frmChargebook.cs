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
    public partial class frmChargebook : Form
    {
        public frmChargebook()
        {
            InitializeComponent();
            var books = Program.Connector.Books.ToList();
            
            

            Books.DataSource = books;
            Books.DisplayMember = "Title";
            Books.ValueMember = "ISBN";
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            int quantity=0;
            try
            {

                quantity = Convert.ToInt32(Quantites.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
            if(quantity <= 0)
            {
                MessageBox.Show("Quantity cannot be negative");
                return;
            }
            if(quantity>1e4)
            {
                MessageBox.Show("Quantity cannot be more than 10000");
                return;
            }
            int x = Books.SelectedIndex;
            if(x == -1)
            {
                MessageBox.Show("Please select a book");
                return;
            }

            var book = Program.Connector.Books.Find(Books.SelectedValue);
            

                book.quantity += quantity;
            
                Program.Connector.SaveChanges();
                MessageBox.Show("Book Charged Successfully");
            


        }
    }
}
