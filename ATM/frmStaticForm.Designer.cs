namespace ATM
{
    partial class frmStaticForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSup = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblPoweredBy = new System.Windows.Forms.Label();
            this.lnkMujtabaIbrahim = new System.Windows.Forms.LinkLabel();
            this.pnlAccountNumber = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlSideBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.pnlSideBar.Controls.Add(this.lblWelcome);
            this.pnlSideBar.Controls.Add(this.lblSup);
            this.pnlSideBar.Controls.Add(this.lblDate);
            this.pnlSideBar.Controls.Add(this.lblClock);
            this.pnlSideBar.Controls.Add(this.lblPoweredBy);
            this.pnlSideBar.Controls.Add(this.lnkMujtabaIbrahim);
            this.pnlSideBar.Controls.Add(this.pnlAccountNumber);
            this.pnlSideBar.Location = new System.Drawing.Point(2, 2);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(237, 522);
            this.pnlSideBar.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(22, 201);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 17);
            this.lblWelcome.TabIndex = 9;
            // 
            // lblSup
            // 
            this.lblSup.AutoSize = true;
            this.lblSup.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblSup.ForeColor = System.Drawing.Color.White;
            this.lblSup.Location = new System.Drawing.Point(95, 290);
            this.lblSup.Name = "lblSup";
            this.lblSup.Size = new System.Drawing.Size(0, 17);
            this.lblSup.TabIndex = 8;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(22, 264);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 17);
            this.lblDate.TabIndex = 7;
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblClock.ForeColor = System.Drawing.Color.White;
            this.lblClock.Location = new System.Drawing.Point(22, 290);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(0, 17);
            this.lblClock.TabIndex = 1;
            // 
            // lblPoweredBy
            // 
            this.lblPoweredBy.AutoSize = true;
            this.lblPoweredBy.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoweredBy.ForeColor = System.Drawing.Color.White;
            this.lblPoweredBy.Location = new System.Drawing.Point(140, 479);
            this.lblPoweredBy.Name = "lblPoweredBy";
            this.lblPoweredBy.Size = new System.Drawing.Size(71, 16);
            this.lblPoweredBy.TabIndex = 6;
            this.lblPoweredBy.Text = "Powered By";
            // 
            // lnkMujtabaIbrahim
            // 
            this.lnkMujtabaIbrahim.AutoSize = true;
            this.lnkMujtabaIbrahim.LinkColor = System.Drawing.Color.Black;
            this.lnkMujtabaIbrahim.Location = new System.Drawing.Point(140, 495);
            this.lnkMujtabaIbrahim.Name = "lnkMujtabaIbrahim";
            this.lnkMujtabaIbrahim.Size = new System.Drawing.Size(85, 13);
            this.lnkMujtabaIbrahim.TabIndex = 4;
            this.lnkMujtabaIbrahim.TabStop = true;
            this.lnkMujtabaIbrahim.Text = "Mujtaba Ibrahim";
            this.lnkMujtabaIbrahim.Click += new System.EventHandler(this.lnkMujtabaIbrahim_LinkClicked);
            // 
            // pnlAccountNumber
            // 
            this.pnlAccountNumber.Location = new System.Drawing.Point(41, 230);
            this.pnlAccountNumber.Name = "pnlAccountNumber";
            this.pnlAccountNumber.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pnlAccountNumber.Size = new System.Drawing.Size(150, 1);
            this.pnlAccountNumber.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Magenta;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 47);
            this.panel1.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(926, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 25);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(475, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(52, 24);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "TItle";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Magenta;
            this.panel2.Location = new System.Drawing.Point(2, 527);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 10);
            this.panel2.TabIndex = 11;
            // 
            // frmStaticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(966, 536);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStaticForm";
            this.Text = "frmStaticForm";
            this.Load += new System.EventHandler(this.frmStaticForm_Load);
            this.pnlSideBar.ResumeLayout(false);
            this.pnlSideBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSup;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblPoweredBy;
        private System.Windows.Forms.LinkLabel lnkMujtabaIbrahim;
        private System.Windows.Forms.Panel pnlAccountNumber;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
    }
}