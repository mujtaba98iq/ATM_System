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
    public partial class frmQuickWithDraw : frmStaticForm
    {
        public frmQuickWithDraw():base("Quick WithDraw")
        {
            InitializeComponent();
        }

        private void frmQuickWithDraw_Load(object sender, EventArgs e)
        {
            lblQuickWithDraw.Text = clsGloabal.CurrentClient.AccNumber + " Your Balance is: " + clsGloabal.CurrentClient.Balance;
        }


        private void btnQiuckWithDraw_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt64(clsGloabal.CurrentClient.Balance) >= 100)
            {
                if (MessageBox.Show("Are You Show To WithDraw: 100$ From Your Account?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (clsClient.WithDraw(clsGloabal.CurrentClient.AccNumber, 100))
                    {
                        clsGloabal.CurrentClient = clsClient.FindClientByID(clsGloabal.CurrentClient.ID);
                        MessageBox.Show("WithDraw Scessfuly");
                        lblQuickWithDraw.Text = clsGloabal.CurrentClient.AccNumber + " Your Balance is: " + clsGloabal.CurrentClient.Balance;
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
        


        private void btnNormalWithDraw_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt64(clsGloabal.CurrentClient.Balance) >= 200)
            {
                if (MessageBox.Show("Are You Show To WithDraw: 200$ From Your Account?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (clsClient.WithDraw(clsGloabal.CurrentClient.AccNumber, 200))
                    {
                        clsGloabal.CurrentClient = clsClient.FindClientByID(clsGloabal.CurrentClient.ID);

                        MessageBox.Show("WithDraw Scessfuly");
                        lblQuickWithDraw.Text = clsGloabal.CurrentClient.AccNumber + " Your Balance is: " + clsGloabal.CurrentClient.Balance;

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

        private void btnDeposit_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt64(clsGloabal.CurrentClient.Balance) >= 400)
            {
                if (MessageBox.Show("Are You Show To WithDraw: 400$ From Your Account?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (clsClient.WithDraw(clsGloabal.CurrentClient.AccNumber, 400))
                    {
                        clsGloabal.CurrentClient = clsClient.FindClientByID(clsGloabal.CurrentClient.ID);

                        MessageBox.Show("WithDraw Scessfuly");
                        lblQuickWithDraw.Text = clsGloabal.CurrentClient.AccNumber + " Your Balance is: " + clsGloabal.CurrentClient.Balance;

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

        private void btnBalance_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt64(clsGloabal.CurrentClient.Balance) >= 600)
            {
                if (MessageBox.Show("Are You Show To WithDraw: 600$ From Your Account?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (clsClient.WithDraw(clsGloabal.CurrentClient.AccNumber, 600))
                    {
                        clsGloabal.CurrentClient = clsClient.FindClientByID(clsGloabal.CurrentClient.ID);

                        MessageBox.Show("WithDraw Scessfuly");
                        lblQuickWithDraw.Text = clsGloabal.CurrentClient.AccNumber + " Your Balance is: " + clsGloabal.CurrentClient.Balance;

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

    private void button3_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt64(clsGloabal.CurrentClient.Balance) >= 800)
            {
                if (MessageBox.Show("Are You Show To WithDraw: 800$ From Your Account?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (clsClient.WithDraw(clsGloabal.CurrentClient.AccNumber, 800))
                    {
                        clsGloabal.CurrentClient = clsClient.FindClientByID(clsGloabal.CurrentClient.ID);

                        MessageBox.Show("WithDraw Scessfuly");
                        lblQuickWithDraw.Text = clsGloabal.CurrentClient.AccNumber + " Your Balance is: " + clsGloabal.CurrentClient.Balance;

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

        private void button4_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt64(clsGloabal.CurrentClient.Balance) >= 1000)
            {
                if (MessageBox.Show("Are You Show To WithDraw: 1000$ From Your Account?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (clsClient.WithDraw(clsGloabal.CurrentClient.AccNumber, 1000))
                    {
                        clsGloabal.CurrentClient = clsClient.FindClientByID(clsGloabal.CurrentClient.ID);

                        MessageBox.Show("WithDraw Scessfuly");
                        lblQuickWithDraw.Text = clsGloabal.CurrentClient.AccNumber + " Your Balance is: " + clsGloabal.CurrentClient.Balance;

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt64(clsGloabal.CurrentClient.Balance) >= 1500)
            {
                if (MessageBox.Show("Are You Show To WithDraw: 1500$ From Your Account?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (clsClient.WithDraw(clsGloabal.CurrentClient.AccNumber, 1500))
                    {
                        clsGloabal.CurrentClient = clsClient.FindClientByID(clsGloabal.CurrentClient.ID);

                        MessageBox.Show("WithDraw Scessfuly");
                        lblQuickWithDraw.Text = clsGloabal.CurrentClient.AccNumber + " Your Balance is: " + clsGloabal.CurrentClient.Balance;

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt64(clsGloabal.CurrentClient.Balance) >= 2000)
            {
                if (MessageBox.Show("Are You Show To WithDraw: 2000$ From Your Account?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (clsClient.WithDraw(clsGloabal.CurrentClient.AccNumber, 2000))

                    {
                        clsGloabal.CurrentClient = clsClient.FindClientByID(clsGloabal.CurrentClient.ID);

                        MessageBox.Show("WithDraw Scessfuly");
                        lblQuickWithDraw.Text = clsGloabal.CurrentClient.AccNumber + " Your Balance is: " + clsGloabal.CurrentClient.Balance;

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
    }
}
