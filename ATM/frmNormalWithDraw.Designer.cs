namespace ATM
{
    partial class frmNormalWithDraw
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
            this.btnNormalWithDraw = new System.Windows.Forms.Button();
            this.txtNormalWithDraw = new System.Windows.Forms.TextBox();
            this.lblNormalWithDraw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNormalWithDraw
            // 
            this.btnNormalWithDraw.BackColor = System.Drawing.Color.Magenta;
            this.btnNormalWithDraw.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNormalWithDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormalWithDraw.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnNormalWithDraw.ForeColor = System.Drawing.Color.White;
            this.btnNormalWithDraw.Location = new System.Drawing.Point(369, 316);
            this.btnNormalWithDraw.Name = "btnNormalWithDraw";
            this.btnNormalWithDraw.Size = new System.Drawing.Size(277, 72);
            this.btnNormalWithDraw.TabIndex = 6;
            this.btnNormalWithDraw.Text = "WithDraw";
            this.btnNormalWithDraw.UseVisualStyleBackColor = false;
            this.btnNormalWithDraw.Click += new System.EventHandler(this.btnQiuckWithDraw100_Click);
            // 
            // txtNormalWithDraw
            // 
            this.txtNormalWithDraw.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtNormalWithDraw.Location = new System.Drawing.Point(369, 167);
            this.txtNormalWithDraw.Name = "txtNormalWithDraw";
            this.txtNormalWithDraw.Size = new System.Drawing.Size(277, 32);
            this.txtNormalWithDraw.TabIndex = 7;
            // 
            // lblNormalWithDraw
            // 
            this.lblNormalWithDraw.AutoSize = true;
            this.lblNormalWithDraw.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblNormalWithDraw.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNormalWithDraw.Location = new System.Drawing.Point(365, 101);
            this.lblNormalWithDraw.Name = "lblNormalWithDraw";
            this.lblNormalWithDraw.Size = new System.Drawing.Size(0, 24);
            this.lblNormalWithDraw.TabIndex = 8;
            // 
            // frmNormalWithDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 562);
            this.Controls.Add(this.lblNormalWithDraw);
            this.Controls.Add(this.txtNormalWithDraw);
            this.Controls.Add(this.btnNormalWithDraw);
            this.Name = "frmNormalWithDraw";
            this.Text = "frmNormalWithDraw";
            this.Load += new System.EventHandler(this.frmNormalWithDraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNormalWithDraw;
        private System.Windows.Forms.TextBox txtNormalWithDraw;
        private System.Windows.Forms.Label lblNormalWithDraw;
    }
}