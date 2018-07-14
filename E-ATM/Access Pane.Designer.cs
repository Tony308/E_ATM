namespace E_ATM
{
    partial class MainMenu
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
            this.cardCB = new System.Windows.Forms.ComboBox();
            this.enterCardLbl = new System.Windows.Forms.Label();
            this.PINLbl = new System.Windows.Forms.Label();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.PinMTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cardCB
            // 
            this.cardCB.FormattingEnabled = true;
            this.cardCB.Items.AddRange(new object[] {
            "Credit Card",
            "Debit Card"});
            this.cardCB.Location = new System.Drawing.Point(40, 47);
            this.cardCB.Name = "cardCB";
            this.cardCB.Size = new System.Drawing.Size(121, 24);
            this.cardCB.TabIndex = 1;
            // 
            // enterCardLbl
            // 
            this.enterCardLbl.AutoSize = true;
            this.enterCardLbl.Location = new System.Drawing.Point(37, 27);
            this.enterCardLbl.Name = "enterCardLbl";
            this.enterCardLbl.Size = new System.Drawing.Size(81, 17);
            this.enterCardLbl.TabIndex = 1;
            this.enterCardLbl.Text = "Insert Card:";
            // 
            // PINLbl
            // 
            this.PINLbl.AutoSize = true;
            this.PINLbl.Location = new System.Drawing.Point(37, 76);
            this.PINLbl.Name = "PINLbl";
            this.PINLbl.Size = new System.Drawing.Size(72, 17);
            this.PINLbl.TabIndex = 3;
            this.PINLbl.Text = "Enter PIN:";
            // 
            // EnterBtn
            // 
            this.EnterBtn.Location = new System.Drawing.Point(43, 136);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(75, 23);
            this.EnterBtn.TabIndex = 3;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // PinMTB
            // 
            this.PinMTB.Location = new System.Drawing.Point(40, 97);
            this.PinMTB.Name = "PinMTB";
            this.PinMTB.PasswordChar = '*';
            this.PinMTB.Size = new System.Drawing.Size(100, 22);
            this.PinMTB.TabIndex = 2;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 250);
            this.Controls.Add(this.PinMTB);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.PINLbl);
            this.Controls.Add(this.enterCardLbl);
            this.Controls.Add(this.cardCB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainMenu";
            this.Text = "BotW ATM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cardCB;
        public System.Windows.Forms.Label enterCardLbl;
        public System.Windows.Forms.Label PINLbl;
        public System.Windows.Forms.Button EnterBtn;
        public System.Windows.Forms.TextBox PinMTB;
    }
}

