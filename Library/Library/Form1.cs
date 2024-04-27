using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Library
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = BtnAddbook.Height;
            PnlNav.Top = BtnAddbook.Top;
            PnlNav.Left = BtnAddbook.Left;
            PnlNav.BackColor = Color.FromArgb(46, 51, 73);



            lblTitle.Text = "Add Book";
            this.PnlFormLoader.Controls.Clear();
            frmAddbook frmLibrarian_Vrb = new frmAddbook() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmLibrarian_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmLibrarian_Vrb);
            frmLibrarian_Vrb.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnAddbook.Height;
            PnlNav.Top = BtnAddbook.Top;
            PnlNav.Left = BtnAddbook.Left;
            PnlNav.BackColor = Color.FromArgb(46, 51, 73);
            lblTitle.Text = "Add Book";
            this.PnlFormLoader.Controls.Clear();
            frmAddbook frmLibrarian_Vrb = new frmAddbook() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmLibrarian_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmLibrarian_Vrb);
            frmLibrarian_Vrb.Show();
        }

        private void BtnAnalytics_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnChargebook.Height;
            PnlNav.Top = BtnChargebook.Top;
            PnlNav.Left = BtnChargebook.Left;
            PnlNav.BackColor = Color.FromArgb(46, 51, 73);


            lblTitle.Text = "Charge Book";
            this.PnlFormLoader.Controls.Clear();
            frmChargebook frmLibrarian_Vrb = new frmChargebook() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmLibrarian_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmLibrarian_Vrb);
            frmLibrarian_Vrb.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnBorrow.Height;
            PnlNav.Top = btnBorrow.Top;
            PnlNav.Left = btnBorrow.Left;
            PnlNav.BackColor = Color.FromArgb(46, 51, 73);


            lblTitle.Text = "Borrow Book";
            this.PnlFormLoader.Controls.Clear();
            frmBorrow frmLibrarian_Vrb = new frmBorrow() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmLibrarian_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmLibrarian_Vrb);
            frmLibrarian_Vrb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnReturn.Height;
            PnlNav.Top = btnReturn.Top;
            PnlNav.Left = btnReturn.Left;
            PnlNav.BackColor = Color.FromArgb(46, 51, 73);


            lblTitle.Text = "return Book";
            this.PnlFormLoader.Controls.Clear();
            frmReturn frmLibrarian_Vrb = new frmReturn() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmLibrarian_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmLibrarian_Vrb);
            frmLibrarian_Vrb.Show();
        }

        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
            BtnAddbook.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnAnalytics_Leave(object sender, EventArgs e)
        {
            BtnChargebook.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            btnBorrow.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            btnReturn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
