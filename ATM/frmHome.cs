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
    public partial class frmHome :frmStaticForm
    {

        public frmHome() : base("Select Your Transaction Please")

        {
            InitializeComponent();
          
         
        }
        private void lnkMujtabaIbrahim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

           
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
          
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form= new frmNormalWithDraw();
            form.ShowDialog();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new frmQuickWithDraw();
            frm.ShowDialog();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Form frm= new frmDeposit();
            frm.ShowDialog();

        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            Form frm=new frmBalance();
            frm.ShowDialog();
        }

        private void btnChangePinCode_Click(object sender, EventArgs e)
        {
            Form frm=new frmChangePinCode();
            frm.ShowDialog();
        }
    }
}
