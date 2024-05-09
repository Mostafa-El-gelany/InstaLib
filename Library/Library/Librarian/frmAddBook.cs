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
    public partial class frmAddbook : Form
    {
        public frmAddbook()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            var book = new Model.Book();
            book.Title = textBox1.Text;
            book.author = textBox3.Text;
            book.Publisher = textBox2.Text;
            book.ISBN =Convert.ToInt64( textBox4.Text);
            if(book.ISBN<1e12 || book.ISBN>=1e13)
            {
                MessageBox.Show("invalid ISBN");
                return;
            }
            var IsFound = Program.Connector.Books.FirstOrDefault(b => b.ISBN == book.ISBN) == null;
            if(!IsFound)
            {
                MessageBox.Show("this book is added already");
                return;
            }

            
                Program.Connector.Books.Add(book);
                Program.Connector.SaveChanges();
                MessageBox.Show("Book Added Successfully");
            



        }
    }
}
