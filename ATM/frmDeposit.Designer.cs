namespace ATM
{
    partial class frmDeposit
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
            this.lblDeposit = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblDeposit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDeposit.Location = new System.Drawing.Point(362, 96);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(0, 24);
            this.lblDeposit.TabIndex = 11;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtDeposit.Location = new System.Drawing.Point(366, 162);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(277, 32);
            this.txtDeposit.TabIndex = 10;
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.Magenta;
            this.btnDeposit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.Location = new System.Drawing.Point(366, 311);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(277, 72);
            this.btnDeposit.TabIndex = 9;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // frmDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 572);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.btnDeposit);
            this.Name = "frmDeposit";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.frmDeposit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Button btnDeposit;
    }
}