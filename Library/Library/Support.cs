using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Support : Form
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

        public Support()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = BtnAddUser.Height;
            PnlNav.Top = BtnAddUser.Top;
            PnlNav.Left = BtnAddUser.Left;
            PnlNav.BackColor = Color.FromArgb(46, 51, 73);



            lblTitle.Text = "Add User";
            this.panel3.Controls.Clear();
            frmAddUser frmLibrarian_Vrb = new frmAddUser() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmLibrarian_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel3.Controls.Add(frmLibrarian_Vrb);
            frmLibrarian_Vrb.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnUpdateUser.Height;
            PnlNav.Top = btnUpdateUser.Top;
            PnlNav.Left = btnUpdateUser.Left;
            PnlNav.BackColor = Color.FromArgb(46, 51, 73);
            lblTitle.Text = "Change Password";
            this.panel3.Controls.Clear();
            frmUpdateUser frmLibrarian_Vrb = new frmUpdateUser() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmLibrarian_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel3.Controls.Add(frmLibrarian_Vrb);
            frmLibrarian_Vrb.Show();
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnAddUser.Height;
            PnlNav.Top = BtnAddUser.Top;
            PnlNav.Left = BtnAddUser.Left;
            PnlNav.BackColor = Color.FromArgb(46, 51, 73);
            lblTitle.Text = "Add User";
            this.panel3.Controls.Clear();
            frmAddUser frmLibrarian_Vrb = new frmAddUser() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmLibrarian_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel3.Controls.Add(frmLibrarian_Vrb);
            frmLibrarian_Vrb.Show();
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnDeleteUser.Height;
            PnlNav.Top = BtnDeleteUser.Top;
            PnlNav.Left = BtnDeleteUser.Left;
            PnlNav.BackColor = Color.FromArgb(46, 51, 73);
            lblTitle.Text = "Delete User";
            this.panel3.Controls.Clear();
            frmDeleteUser frmLibrarian_Vrb = new frmDeleteUser() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmLibrarian_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panel3.Controls.Add(frmLibrarian_Vrb);
            frmLibrarian_Vrb.Show();
        }

        private void BtnAddUser_Leave(object sender, EventArgs e)
        {
            BtnAddUser.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnDeleteUser_Leave(object sender, EventArgs e)
        {
            BtnDeleteUser.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnUpdateUser_Leave(object sender, EventArgs e)
        {
            btnUpdateUser.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.next = new frmLogin();
            this.Close();
        }
    }
}
