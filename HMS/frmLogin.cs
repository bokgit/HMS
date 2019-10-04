using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit this application?", "Exit System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            else { Environment.Exit(0); }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbUsername.Text = tbPassword.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //User Validation
            string ErrorMessage = string.Empty;
            bool IsErrorFound = false;
            if (string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                IsErrorFound = true;
                ErrorMessage = "Error: Please provide proper credential to login the system.";
                goto isError;
            }

            frmMain MainForm = new frmMain();
            MainForm.Show();
            this.Hide();

        isError:
            if (IsErrorFound)
            {
                MessageBox.Show(ErrorMessage, "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
