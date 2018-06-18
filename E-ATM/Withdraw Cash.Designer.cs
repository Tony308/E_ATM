namespace E_ATM
{
    partial class Withdraw_Cash
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
            this.firstOptionBtn = new System.Windows.Forms.Button();
            this.secondOptionBtn = new System.Windows.Forms.Button();
            this.thirdOptionBtn = new System.Windows.Forms.Button();
            this.fourthOptionBtn = new System.Windows.Forms.Button();
            this.fifthOptionBtn = new System.Windows.Forms.Button();
            this.sixthOptionBtn = new System.Windows.Forms.Button();
            this.dis = new System.Windows.Forms.Label();
            this.zerOptionBtn = new System.Windows.Forms.Button();
            this.amountTb = new System.Windows.Forms.TextBox();
            this.balanceLbl = new System.Windows.Forms.Label();
            this.otherAmountBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstOptionBtn
            // 
            this.firstOptionBtn.Location = new System.Drawing.Point(244, 108);
            this.firstOptionBtn.Name = "firstOptionBtn";
            this.firstOptionBtn.Size = new System.Drawing.Size(75, 23);
            this.firstOptionBtn.TabIndex = 0;
            this.firstOptionBtn.Text = "10";
            this.firstOptionBtn.UseVisualStyleBackColor = true;
            this.firstOptionBtn.Click += new System.EventHandler(this.firstOptionBtn_Click);
            // 
            // secondOptionBtn
            // 
            this.secondOptionBtn.Location = new System.Drawing.Point(46, 146);
            this.secondOptionBtn.Name = "secondOptionBtn";
            this.secondOptionBtn.Size = new System.Drawing.Size(75, 23);
            this.secondOptionBtn.TabIndex = 1;
            this.secondOptionBtn.Text = "20";
            this.secondOptionBtn.UseVisualStyleBackColor = true;
            this.secondOptionBtn.Click += new System.EventHandler(this.secondOptionBtn_Click);
            // 
            // thirdOptionBtn
            // 
            this.thirdOptionBtn.Location = new System.Drawing.Point(244, 146);
            this.thirdOptionBtn.Name = "thirdOptionBtn";
            this.thirdOptionBtn.Size = new System.Drawing.Size(75, 23);
            this.thirdOptionBtn.TabIndex = 2;
            this.thirdOptionBtn.Text = "30";
            this.thirdOptionBtn.UseVisualStyleBackColor = true;
            this.thirdOptionBtn.Click += new System.EventHandler(this.thirdOptionBtn_Click);
            // 
            // fourthOptionBtn
            // 
            this.fourthOptionBtn.Location = new System.Drawing.Point(46, 184);
            this.fourthOptionBtn.Name = "fourthOptionBtn";
            this.fourthOptionBtn.Size = new System.Drawing.Size(75, 23);
            this.fourthOptionBtn.TabIndex = 3;
            this.fourthOptionBtn.Text = "40";
            this.fourthOptionBtn.UseVisualStyleBackColor = true;
            this.fourthOptionBtn.Click += new System.EventHandler(this.fourthOptionBtn_Click);
            // 
            // fifthOptionBtn
            // 
            this.fifthOptionBtn.Location = new System.Drawing.Point(244, 184);
            this.fifthOptionBtn.Name = "fifthOptionBtn";
            this.fifthOptionBtn.Size = new System.Drawing.Size(75, 23);
            this.fifthOptionBtn.TabIndex = 4;
            this.fifthOptionBtn.Text = "50";
            this.fifthOptionBtn.UseVisualStyleBackColor = true;
            this.fifthOptionBtn.Click += new System.EventHandler(this.fifthOptionBtn_Click);
            // 
            // sixthOptionBtn
            // 
            this.sixthOptionBtn.Location = new System.Drawing.Point(46, 222);
            this.sixthOptionBtn.Name = "sixthOptionBtn";
            this.sixthOptionBtn.Size = new System.Drawing.Size(75, 23);
            this.sixthOptionBtn.TabIndex = 5;
            this.sixthOptionBtn.Text = "100";
            this.sixthOptionBtn.UseVisualStyleBackColor = true;
            this.sixthOptionBtn.Click += new System.EventHandler(this.sixthOptionBtn_Click);
            // 
            // dis
            // 
            this.dis.AutoSize = true;
            this.dis.Location = new System.Drawing.Point(43, 71);
            this.dis.Name = "dis";
            this.dis.Size = new System.Drawing.Size(176, 17);
            this.dis.TabIndex = 6;
            this.dis.Text = "Select amount to withdraw:";
            // 
            // zerOptionBtn
            // 
            this.zerOptionBtn.Location = new System.Drawing.Point(46, 108);
            this.zerOptionBtn.Name = "zerOptionBtn";
            this.zerOptionBtn.Size = new System.Drawing.Size(75, 23);
            this.zerOptionBtn.TabIndex = 0;
            this.zerOptionBtn.Text = "5";
            this.zerOptionBtn.UseVisualStyleBackColor = true;
            this.zerOptionBtn.Click += new System.EventHandler(this.zerOptionBtn_Click);
            // 
            // amountTb
            // 
            this.amountTb.Location = new System.Drawing.Point(244, 223);
            this.amountTb.Name = "amountTb";
            this.amountTb.Size = new System.Drawing.Size(75, 22);
            this.amountTb.TabIndex = 7;
            // 
            // balanceLbl
            // 
            this.balanceLbl.AutoSize = true;
            this.balanceLbl.Location = new System.Drawing.Point(43, 44);
            this.balanceLbl.Name = "balanceLbl";
            this.balanceLbl.Size = new System.Drawing.Size(0, 17);
            this.balanceLbl.TabIndex = 9;
            // 
            // otherAmountBtn
            // 
            this.otherAmountBtn.Location = new System.Drawing.Point(325, 223);
            this.otherAmountBtn.Name = "otherAmountBtn";
            this.otherAmountBtn.Size = new System.Drawing.Size(75, 23);
            this.otherAmountBtn.TabIndex = 8;
            this.otherAmountBtn.Text = "Enter";
            this.otherAmountBtn.UseVisualStyleBackColor = true;
            this.otherAmountBtn.Click += new System.EventHandler(this.otherAmountBtn_Click);
            // 
            // Withdraw_Cash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 333);
            this.Controls.Add(this.otherAmountBtn);
            this.Controls.Add(this.balanceLbl);
            this.Controls.Add(this.amountTb);
            this.Controls.Add(this.zerOptionBtn);
            this.Controls.Add(this.dis);
            this.Controls.Add(this.sixthOptionBtn);
            this.Controls.Add(this.fifthOptionBtn);
            this.Controls.Add(this.fourthOptionBtn);
            this.Controls.Add(this.thirdOptionBtn);
            this.Controls.Add(this.secondOptionBtn);
            this.Controls.Add(this.firstOptionBtn);
            this.Name = "Withdraw_Cash";
            this.Text = "WIthdraw Cash";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Withdraw_Cash_FormClosed);
            this.Load += new System.EventHandler(this.Withdraw_Cash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button firstOptionBtn;
        private System.Windows.Forms.Button secondOptionBtn;
        private System.Windows.Forms.Button thirdOptionBtn;
        private System.Windows.Forms.Button fourthOptionBtn;
        private System.Windows.Forms.Button fifthOptionBtn;
        private System.Windows.Forms.Button sixthOptionBtn;
        private System.Windows.Forms.Label dis;
        private System.Windows.Forms.Button zerOptionBtn;
        private System.Windows.Forms.TextBox amountTb;
        private System.Windows.Forms.Label balanceLbl;
        private System.Windows.Forms.Button otherAmountBtn;
    }
}