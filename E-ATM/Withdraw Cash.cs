using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace E_ATM
{
    public partial class Withdraw_Cash : Form
    {

        SqlConnection con;
        DataTable dt;

        public Withdraw_Cash()
        {
            InitializeComponent();
        }

        private void Withdraw_Cash_Load(object sender, EventArgs e)
        {
            balanceLbl.Visible = true;
            string balance = dt.Rows[0][3].ToString();
            balanceLbl.Text = "Balance: " + balance.Insert(0, "£");

        }

      

        private void Withdraw_Cash_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }

        private void zerOptionBtn_Click(object sender, EventArgs e)
        {
            eject_cash("5");
        }


        private void firstOptionBtn_Click(object sender, EventArgs e)
        {
            eject_cash("10");
        }

        public void eject_cash(String e)
        {
            //Checks the PIN`s encrypted/hashed value.
            Console.WriteLine("Eject Card.");
            MessageBox.Show("Please take your card.");
            Console.WriteLine(e.Insert(0, "£") + " Ejected.");
        }

        private void secondOptionBtn_Click(object sender, EventArgs e)
        {
            eject_cash("20");
        }

        private void thirdOptionBtn_Click(object sender, EventArgs e)
        {
            eject_cash("30");
        }

        private void fourthOptionBtn_Click(object sender, EventArgs e)
        {
            eject_cash("40");
        }

        private void fifthOptionBtn_Click(object sender, EventArgs e)
        {
            eject_cash("50");
        }

        private void sixthOptionBtn_Click(object sender, EventArgs e)
        {
            eject_cash("100");
        }

        private void otherAmountBtn_Click(object sender, EventArgs e)
        {
            eject_cash(amountTb.Text);
        }
    }
}
