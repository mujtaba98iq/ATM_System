namespace ATM
{
    partial class frmHome
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblLogout = new System.Windows.Forms.Label();
            this.btnChangePinCode = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnQiuckWithDraw = new System.Windows.Forms.Button();
            this.btnNormalWithDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.BackColor = System.Drawing.Color.Transparent;
            this.lblLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblLogout.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.Magenta;
            this.lblLogout.Location = new System.Drawing.Point(601, 448);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(80, 25);
            this.lblLogout.TabIndex = 5;
            this.lblLogout.Text = "Logout";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // btnChangePinCode
            // 
            this.btnChangePinCode.BackColor = System.Drawing.Color.Magenta;
            this.btnChangePinCode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnChangePinCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePinCode.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnChangePinCode.ForeColor = System.Drawing.Color.White;
            this.btnChangePinCode.Location = new System.Drawing.Point(463, 333);
            this.btnChangePinCode.Name = "btnChangePinCode";
            this.btnChangePinCode.Size = new System.Drawing.Size(341, 72);
            this.btnChangePinCode.TabIndex = 4;
            this.btnChangePinCode.Text = "Change PinCode";
            this.btnChangePinCode.UseVisualStyleBackColor = false;
            this.btnChangePinCode.Click += new System.EventHandler(this.btnChangePinCode_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.BackColor = System.Drawing.Color.Magenta;
            this.btnBalance.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnBalance.ForeColor = System.Drawing.Color.White;
            this.btnBalance.Location = new System.Drawing.Point(646, 237);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(277, 72);
            this.btnBalance.TabIndex = 3;
            this.btnBalance.Text = "Balance";
            this.btnBalance.UseVisualStyleBackColor = false;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.Magenta;
            this.btnDeposit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.Location = new System.Drawing.Point(336, 237);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(277, 72);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnQiuckWithDraw
            // 
            this.btnQiuckWithDraw.BackColor = System.Drawing.Color.Magenta;
            this.btnQiuckWithDraw.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQiuckWithDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQiuckWithDraw.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnQiuckWithDraw.ForeColor = System.Drawing.Color.White;
            this.btnQiuckWithDraw.Location = new System.Drawing.Point(336, 117);
            this.btnQiuckWithDraw.Name = "btnQiuckWithDraw";
            this.btnQiuckWithDraw.Size = new System.Drawing.Size(277, 72);
            this.btnQiuckWithDraw.TabIndex = 1;
            this.btnQiuckWithDraw.Text = "Quick WithDraw";
            this.btnQiuckWithDraw.UseVisualStyleBackColor = false;
            this.btnQiuckWithDraw.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNormalWithDraw
            // 
            this.btnNormalWithDraw.BackColor = System.Drawing.Color.Magenta;
            this.btnNormalWithDraw.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNormalWithDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormalWithDraw.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnNormalWithDraw.ForeColor = System.Drawing.Color.White;
            this.btnNormalWithDraw.Location = new System.Drawing.Point(646, 117);
            this.btnNormalWithDraw.Name = "btnNormalWithDraw";
            this.btnNormalWithDraw.Size = new System.Drawing.Size(277, 72);
            this.btnNormalWithDraw.TabIndex = 0;
            this.btnNormalWithDraw.Text = "Normal WithDraw";
            this.btnNormalWithDraw.UseVisualStyleBackColor = false;
            this.btnNormalWithDraw.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 558);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.btnChangePinCode);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnQiuckWithDraw);
            this.Controls.Add(this.btnNormalWithDraw);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnNormalWithDraw;
        private System.Windows.Forms.Button btnQiuckWithDraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnChangePinCode;
        private System.Windows.Forms.Label lblLogout;
    }
}