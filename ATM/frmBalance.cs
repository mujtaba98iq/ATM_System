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
    public partial class frmBalance : frmStaticForm
    {
        public frmBalance():base("Balance")
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void frmBalance_Load(object sender, EventArgs e)
        {
            lblBalance.Text= "Your Balance :$"+clsGloabal.CurrentClient.Balance.ToString();
        }
    }
}
