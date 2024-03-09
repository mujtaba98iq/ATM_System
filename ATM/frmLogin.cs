using clsClientBisnessForATM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class frmLogin :frmStaticForm
    {
        public frmLogin():base("Login")
        {
            InitializeComponent();
        }
        clsClient _Client;
        void restFormLogin()
        {
            txtAccNumber.Text = "Enter Acc.Number";
            txtPinCode.Text = "Password";
            lblErrorAccNumberOrPassword.Text = string.Empty;
        }
      

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _AccNumber = txtAccNumber.Text;
            string _PinCode = txtPinCode.Text;
            if (txtAccNumber.Text== "Enter Acc.Number" || txtPinCode.Text == "Password" ||
              string.IsNullOrWhiteSpace(txtAccNumber.Text) || string.IsNullOrWhiteSpace(txtPinCode.Text))
            {
                lblErrorAccNumberOrPassword.Text = "The UserName or Password Is Null!," +
                    " please Enter The UserName And Password Correct";
            }

            else if (clsGloabal.NumberOfFlaidLogin > 0 && !clsClient.Login(_AccNumber, _PinCode))
            {
                clsGloabal.NumberOfFlaidLogin--;

                if (clsGloabal.NumberOfFlaidLogin == 0)
                {
                    btnLogin.Enabled = false;
                    lblErrorAccNumberOrPassword.Text = "The System Has Locked !";
                }
                else
                {
                    lblErrorAccNumberOrPassword.Text = "The UserName And Password Isn't Correct! ," +
                    "You Have " + clsGloabal.NumberOfFlaidLogin + " Try after system Locked ";
                }

            }
            else
            {
                
               int ID=clsClient.FindIDByAccNumber(txtAccNumber.Text);
               clsGloabal.CurrentClient = clsClient.FindClientByID(ID);              
                MessageBox.Show("Add Login Client " + ID);
                MessageBox.Show("Balance " + clsGloabal.CurrentClient.Balance);
                restFormLogin();
                Form frm = new frmHome();
                frm.ShowDialog();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAccNumber_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                txtAccNumber.ForeColor = Color.White;
            }
            catch
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtPinCode.ForeColor = Color.White;
                txtPinCode.PasswordChar = '*';
            }
            catch
            {

            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAccNumber_Click(object sender, EventArgs e)
        {
            txtAccNumber.SelectAll();

        }

        private void txtPinCode_Click(object sender, EventArgs e)
        {
            txtPinCode.SelectAll();

        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor= Color.Black;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Lime;
        }
    }
}
