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
    public partial class frmNormalWithDraw : frmStaticForm
    {
        public frmNormalWithDraw():base("Normal WithDraw")
        {
            InitializeComponent();
        }

        private void frmNormalWithDraw_Load(object sender, EventArgs e)
        {
            if(Convert.ToInt32(clsGloabal.CurrentClient.Balance)>0)
            {
                lblNormalWithDraw.Text = clsGloabal.CurrentClient.AccNumber + " Your Balance is: " + clsGloabal.CurrentClient.Balance;
            }
            else
                MessageBox.Show("You Don't Have Enugh Mony ");
        }

        private void btnQiuckWithDraw100_Click(object sender, EventArgs e)
        {
            float Amount=0;
            if (txtNormalWithDraw.Text != "")
            {
                Amount = Convert.ToInt64(txtNormalWithDraw.Text);


                if (Convert.ToInt64(clsGloabal.CurrentClient.Balance) >= Amount)
                {
                    if (MessageBox.Show("Are You Show To WithDraw: " + Amount + " From Your Account?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (clsClient.WithDraw(clsGloabal.CurrentClient.AccNumber, Amount))
                        {
                            clsGloabal.CurrentClient = clsClient.FindClientByID(clsGloabal.CurrentClient.ID);
                            MessageBox.Show("WithDraw Scessfuly");
                            txtNormalWithDraw.Text = "";
                            lblNormalWithDraw.Text = clsGloabal.CurrentClient.AccNumber + " Your Balance is: " + clsGloabal.CurrentClient.Balance;
                        }
                        else
                            MessageBox.Show("WithDraw Flaid");
                    }
                    else
                        MessageBox.Show("WithDraw Canceld");
                }
                else
                    MessageBox.Show("You Don't Have Enugh Mony ");
            }
            else
                MessageBox.Show("Please Enter Value");
        }
    }
}
