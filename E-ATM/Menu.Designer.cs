namespace E_ATM
{
    partial class Menu
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
            this.balanceBtn = new System.Windows.Forms.Button();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.balanceWithdrawBtn = new System.Windows.Forms.Button();
            this.pinChangeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // balanceBtn
            // 
            this.balanceBtn.Location = new System.Drawing.Point(54, 49);
            this.balanceBtn.Name = "balanceBtn";
            this.balanceBtn.Size = new System.Drawing.Size(91, 46);
            this.balanceBtn.TabIndex = 0;
            this.balanceBtn.Text = "Display Balance";
            this.balanceBtn.UseVisualStyleBackColor = true;
            this.balanceBtn.Click += new System.EventHandler(this.balanceBtn_Click);
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.Location = new System.Drawing.Point(216, 49);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(91, 46);
            this.withdrawBtn.TabIndex = 1;
            this.withdrawBtn.Text = "Withdraw Cash";
            this.withdrawBtn.UseVisualStyleBackColor = true;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // balanceWithdrawBtn
            // 
            this.balanceWithdrawBtn.Location = new System.Drawing.Point(54, 101);
            this.balanceWithdrawBtn.Name = "balanceWithdrawBtn";
            this.balanceWithdrawBtn.Size = new System.Drawing.Size(91, 67);
            this.balanceWithdrawBtn.TabIndex = 2;
            this.balanceWithdrawBtn.Text = "Withdraw and Display Balance";
            this.balanceWithdrawBtn.UseVisualStyleBackColor = true;
            this.balanceWithdrawBtn.Click += new System.EventHandler(this.balanceWithdrawBtn_Click);
            // 
            // pinChangeBtn
            // 
            this.pinChangeBtn.Location = new System.Drawing.Point(216, 101);
            this.pinChangeBtn.Name = "pinChangeBtn";
            this.pinChangeBtn.Size = new System.Drawing.Size(91, 45);
            this.pinChangeBtn.TabIndex = 3;
            this.pinChangeBtn.Text = "Change PIN";
            this.pinChangeBtn.UseVisualStyleBackColor = true;
            this.pinChangeBtn.Click += new System.EventHandler(this.pinChangeBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 247);
            this.Controls.Add(this.pinChangeBtn);
            this.Controls.Add(this.balanceWithdrawBtn);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.balanceBtn);
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button balanceBtn;
        private System.Windows.Forms.Button withdrawBtn;
        private System.Windows.Forms.Button balanceWithdrawBtn;
        private System.Windows.Forms.Button pinChangeBtn;
    }
}