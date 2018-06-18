namespace E_ATM
{
    partial class Display_Balance
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
            this.balanceLbl = new System.Windows.Forms.Label();
            this.withdrawableLBl = new System.Windows.Forms.Label();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.otherBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // balanceLbl
            // 
            this.balanceLbl.AutoSize = true;
            this.balanceLbl.Location = new System.Drawing.Point(60, 47);
            this.balanceLbl.Name = "balanceLbl";
            this.balanceLbl.Size = new System.Drawing.Size(63, 17);
            this.balanceLbl.TabIndex = 0;
            this.balanceLbl.Text = "Balance:";
            // 
            // withdrawableLBl
            // 
            this.withdrawableLBl.AutoSize = true;
            this.withdrawableLBl.Location = new System.Drawing.Point(60, 79);
            this.withdrawableLBl.Name = "withdrawableLBl";
            this.withdrawableLBl.Size = new System.Drawing.Size(148, 17);
            this.withdrawableLBl.TabIndex = 1;
            this.withdrawableLBl.Text = "Withdrawable amount:";
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.Location = new System.Drawing.Point(48, 135);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(75, 45);
            this.withdrawBtn.TabIndex = 2;
            this.withdrawBtn.Text = "Withdraw Cash";
            this.withdrawBtn.UseVisualStyleBackColor = true;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // otherBtn
            // 
            this.otherBtn.Location = new System.Drawing.Point(217, 135);
            this.otherBtn.Name = "otherBtn";
            this.otherBtn.Size = new System.Drawing.Size(86, 45);
            this.otherBtn.TabIndex = 3;
            this.otherBtn.Text = "Other Services";
            this.otherBtn.UseVisualStyleBackColor = true;
            this.otherBtn.Click += new System.EventHandler(this.otherBtn_Click);
            // 
            // Display_Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 326);
            this.Controls.Add(this.otherBtn);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.withdrawableLBl);
            this.Controls.Add(this.balanceLbl);
            this.Name = "Display_Balance";
            this.Text = "Balance";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Display_Balance_FormClosed);
            this.Load += new System.EventHandler(this.Display_Balance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label balanceLbl;
        private System.Windows.Forms.Label withdrawableLBl;
        private System.Windows.Forms.Button withdrawBtn;
        private System.Windows.Forms.Button otherBtn;
    }
}