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
    public partial class frmDeposit : frmStaticForm
    {
        public frmDeposit():base("Deposit")
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            float Amount =Convert.ToInt64( txtDeposit.Text);
            if (MessageBox.Show("Are You Show To Deposit: " +Amount+" From Your Account?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsClient.Deposit(clsGloabal.CurrentClient.AccNumber, Amount))
                {
                    clsGloabal.CurrentClient = clsClient.FindClientByID(clsGloabal.CurrentClient.ID);
                    MessageBox.Show("Deposit Scessfuly");
                    lblDeposit.Text = clsGloabal.CurrentClient.AccNumber + " Your Balance is: " + clsGloabal.CurrentClient.Balance;
                }
                else
                    MessageBox.Show("Deposit Flaid");
            }
            else
                MessageBox.Show("Deposit Canceld");
        }

        private void frmDeposit_Load(object sender, EventArgs e)
        {
            lblDeposit.Text = clsGloabal.CurrentClient.AccNumber + " Your Balance is: " + clsGloabal.CurrentClient.Balance;
        }
    }
}
