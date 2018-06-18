using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_ATM
{
    public partial class PIN_Update : Form
    {
        public PIN_Update()
        {
            InitializeComponent();
        }

        private void PIN_Update_Load(object sender, EventArgs e)
        {
            confirm.Visible = false;
            confirm.MaxLength = 4;
            
        }

        public void confirmPIN(string e)
        {
            if (e == "")//if it's empty.
            {
                MessageBox.Show("You haven't entered a PIN.");
                PIN.Text = null;
                confirm.Text = null;

            }
            if (e != "")//if its not empty
            {
                Lbl.Text = "Enter again to confirm.";
                confirm.Visible = true;
                PIN.Visible = false;

                if (confirm.Text == PIN.Text) //confirms pin again.
                {
                    Encryption form = new Encryption();
                    form.updatePIN(confirm.Text);
                    Console.WriteLine("PIN Updated");

                    MessageBox.Show("PIN has been updated.");
                    Menu main = new Menu();
                    main.Show();
                    this.Hide();

                }
                else
                {
                    Console.WriteLine("PIN does not match.");
                }

            }

        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            confirmPIN(PIN.Text);
        }

        private void PIN_Update_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu main = new Menu();
            main.Show();
            this.Hide();
        }
    }
}
