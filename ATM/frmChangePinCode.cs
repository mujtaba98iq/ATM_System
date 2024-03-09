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
    public partial class frmChangePinCode : frmStaticForm
    {
        public frmChangePinCode():base("Change Pin Code")
        {
            InitializeComponent();
        }

        private void frmChangePinCode_Load(object sender, EventArgs e)
        {
            lblChangePinCode.Text = "Enter New Pin Code ";
        }

        private void btnChangePinCode_Click(object sender, EventArgs e)
        {
            int NewPinCode = 0;
            if (txtChangePinCode.Text != "")
            {
                NewPinCode = Convert.ToInt32(txtChangePinCode.Text);

                if (Convert.ToInt64(clsGloabal.CurrentClient.PinCode) != NewPinCode)
                {
                    if (MessageBox.Show("Are You Show To Change Your PinCode ? Your Old PinCode is:" +
                        clsGloabal.CurrentClient.PinCode, "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (clsClient.ChangePinCode(clsGloabal.CurrentClient.AccNumber, NewPinCode))
                        {
                            clsGloabal.CurrentClient = clsClient.FindClientByID(clsGloabal.CurrentClient.ID);
                            MessageBox.Show("PinCode Changed Scessfuly");
                            txtChangePinCode.Text = "";
                        }
                        else
                            MessageBox.Show("PinCode Changed Flaid");
                    }
                    else
                        MessageBox.Show("PinCode Changed Canceld");
                }
                else
                    MessageBox.Show("Enter Another PinCode,alrady used");
            }
            else
            MessageBox.Show("Enter Value");

        }
    }
}
