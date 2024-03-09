namespace ATM
{
    partial class frmChangePinCode
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
            this.lblChangePinCode = new System.Windows.Forms.Label();
            this.txtChangePinCode = new System.Windows.Forms.TextBox();
            this.btnChangePinCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChangePinCode
            // 
            this.lblChangePinCode.AutoSize = true;
            this.lblChangePinCode.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblChangePinCode.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblChangePinCode.Location = new System.Drawing.Point(367, 122);
            this.lblChangePinCode.Name = "lblChangePinCode";
            this.lblChangePinCode.Size = new System.Drawing.Size(0, 24);
            this.lblChangePinCode.TabIndex = 14;
            // 
            // txtChangePinCode
            // 
            this.txtChangePinCode.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtChangePinCode.Location = new System.Drawing.Point(371, 188);
            this.txtChangePinCode.Name = "txtChangePinCode";
            this.txtChangePinCode.Size = new System.Drawing.Size(277, 32);
            this.txtChangePinCode.TabIndex = 13;
            // 
            // btnChangePinCode
            // 
            this.btnChangePinCode.BackColor = System.Drawing.Color.Magenta;
            this.btnChangePinCode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnChangePinCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePinCode.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnChangePinCode.ForeColor = System.Drawing.Color.White;
            this.btnChangePinCode.Location = new System.Drawing.Point(371, 337);
            this.btnChangePinCode.Name = "btnChangePinCode";
            this.btnChangePinCode.Size = new System.Drawing.Size(277, 72);
            this.btnChangePinCode.TabIndex = 12;
            this.btnChangePinCode.Text = "Change";
            this.btnChangePinCode.UseVisualStyleBackColor = false;
            this.btnChangePinCode.Click += new System.EventHandler(this.btnChangePinCode_Click);
            // 
            // frmChangePinCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 580);
            this.Controls.Add(this.lblChangePinCode);
            this.Controls.Add(this.txtChangePinCode);
            this.Controls.Add(this.btnChangePinCode);
            this.Name = "frmChangePinCode";
            this.Text = "frmChangePinCode";
            this.Load += new System.EventHandler(this.frmChangePinCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChangePinCode;
        private System.Windows.Forms.TextBox txtChangePinCode;
        private System.Windows.Forms.Button btnChangePinCode;
    }
}