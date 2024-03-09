﻿using System;
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
    public partial class frmStaticForm : Form
    {
     
        private frmStaticForm()
        {

        }

        public frmStaticForm(string Text)
        {
            InitializeComponent();
            this.Text = Text;
            lblTitle.Text = Text;
            if (clsGloabal.CurrentClient!=null)
                lblWelcome.Text = "Welcome: " + clsGloabal.CurrentClient.AccNumber.ToUpper();

        }

        private void pnlSideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM yyyy");
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss");
            lblSup.Text = DateTime.Now.ToString("tt");

            timer1.Start();
        }

        private void frmStaticForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            timer1.Start();
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM yyyy");
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss");
            lblSup.Text = DateTime.Now.ToString("tt"); //AM PM
        }

        private void lnkMujtabaIbrahim_LinkClicked(object sender, EventArgs e)
        {
            lnkMujtabaIbrahim.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/mujtaba-ibrahim-670229280/");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
