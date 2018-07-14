namespace E_ATM
{
    partial class PIN_Update
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
            this.PIN = new System.Windows.Forms.TextBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.Lbl = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PIN
            // 
            this.PIN.Location = new System.Drawing.Point(47, 82);
            this.PIN.Name = "PIN";
            this.PIN.Size = new System.Drawing.Size(100, 22);
            this.PIN.TabIndex = 0;
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(153, 82);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(78, 23);
            this.enterBtn.TabIndex = 1;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(44, 50);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(101, 17);
            this.Lbl.TabIndex = 2;
            this.Lbl.Text = "Enter new PIN:";
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(47, 82);
            this.confirm.Name = "confirm";
            this.confirm.PasswordChar = '*';
            this.confirm.Size = new System.Drawing.Size(100, 22);
            this.confirm.TabIndex = 3;
            // 
            // PIN_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 264);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.Lbl);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.PIN);
            this.Name = "PIN_Update";
            this.Text = "Change PIN";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PIN_Update_FormClosed);
            this.Load += new System.EventHandler(this.PIN_Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PIN;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.TextBox confirm;
    }
}