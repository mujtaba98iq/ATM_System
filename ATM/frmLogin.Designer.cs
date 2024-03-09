namespace ATM
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccNumber = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAccountNumber = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlErrorAccNumber = new System.Windows.Forms.Panel();
            this.lblErrorAccNumberOrPassword = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlErrorPinCode = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtPinCode = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(310, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "AccNumber";
            // 
            // txtAccNumber
            // 
            this.txtAccNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtAccNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtAccNumber.Location = new System.Drawing.Point(15, 18);
            this.txtAccNumber.Name = "txtAccNumber";
            this.txtAccNumber.Size = new System.Drawing.Size(400, 20);
            this.txtAccNumber.TabIndex = 18;
            this.txtAccNumber.Text = "Enter Acc.Number";
            this.txtAccNumber.Click += new System.EventHandler(this.txtAccNumber_Click);
            this.txtAccNumber.TextChanged += new System.EventHandler(this.txtAccNumber_TextChanged_1);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(511, 354);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(253, 46);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.pnlAccountNumber);
            this.panel1.Controls.Add(this.txtAccNumber);
            this.panel1.Location = new System.Drawing.Point(6, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 53);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlAccountNumber
            // 
            this.pnlAccountNumber.BackColor = System.Drawing.Color.White;
            this.pnlAccountNumber.Location = new System.Drawing.Point(15, 44);
            this.pnlAccountNumber.Name = "pnlAccountNumber";
            this.pnlAccountNumber.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pnlAccountNumber.Size = new System.Drawing.Size(400, 1);
            this.pnlAccountNumber.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(251, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlErrorAccNumber);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(410, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 114);
            this.panel2.TabIndex = 21;
            // 
            // pnlErrorAccNumber
            // 
            this.pnlErrorAccNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlErrorAccNumber.Enabled = false;
            this.pnlErrorAccNumber.Location = new System.Drawing.Point(6, 73);
            this.pnlErrorAccNumber.Name = "pnlErrorAccNumber";
            this.pnlErrorAccNumber.Size = new System.Drawing.Size(438, 23);
            this.pnlErrorAccNumber.TabIndex = 21;
            // 
            // lblErrorAccNumberOrPassword
            // 
            this.lblErrorAccNumberOrPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblErrorAccNumberOrPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblErrorAccNumberOrPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrorAccNumberOrPassword.Location = new System.Drawing.Point(410, 426);
            this.lblErrorAccNumberOrPassword.Name = "lblErrorAccNumberOrPassword";
            this.lblErrorAccNumberOrPassword.Size = new System.Drawing.Size(456, 81);
            this.lblErrorAccNumberOrPassword.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnlErrorPinCode);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(410, 225);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(456, 114);
            this.panel4.TabIndex = 24;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pnlErrorPinCode
            // 
            this.pnlErrorPinCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlErrorPinCode.Enabled = false;
            this.pnlErrorPinCode.Location = new System.Drawing.Point(6, 73);
            this.pnlErrorPinCode.Name = "pnlErrorPinCode";
            this.pnlErrorPinCode.Size = new System.Drawing.Size(438, 23);
            this.pnlErrorPinCode.TabIndex = 21;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.txtPinCode);
            this.panel6.Location = new System.Drawing.Point(6, 14);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(438, 53);
            this.panel6.TabIndex = 20;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(15, 44);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel7.Size = new System.Drawing.Size(400, 1);
            this.panel7.TabIndex = 21;
            // 
            // txtPinCode
            // 
            this.txtPinCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtPinCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPinCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPinCode.ForeColor = System.Drawing.Color.Gray;
            this.txtPinCode.Location = new System.Drawing.Point(15, 18);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.Size = new System.Drawing.Size(400, 20);
            this.txtPinCode.TabIndex = 18;
            this.txtPinCode.Text = "Password";
            this.txtPinCode.Click += new System.EventHandler(this.txtPinCode_Click);
            this.txtPinCode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(251, 248);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(310, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Password";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(978, 530);
            this.Controls.Add(this.lblErrorAccNumberOrPassword);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccNumber;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlAccountNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlErrorAccNumber;
        private System.Windows.Forms.Label lblErrorAccNumberOrPassword;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlErrorPinCode;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtPinCode;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
    }
}

