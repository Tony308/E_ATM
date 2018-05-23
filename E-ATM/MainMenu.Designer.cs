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
            this.cardCB.TabIndex = 0;
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
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 250);
            this.Controls.Add(this.enterCardLbl);
            this.Controls.Add(this.cardCB);
            this.Name = "MainMenu";
            this.Text = "BotW ATM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cardCB;
        private System.Windows.Forms.Label enterCardLbl;
    }
}

