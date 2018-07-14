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
        private DataTable dt;

        public Withdraw_Cash()
        {
            InitializeComponent();
        }

        private void Withdraw_Cash_Load(object sender, EventArgs e)
        {

            balanceLbl.Visible = true;
            Encryption form = new Encryption();
            
            if (form.getAuthentication())
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString);
                SqlCommand cmd = new SqlCommand("dbo.getAuthenticatedUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RFID", "1");
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                dt = new DataTable();
                da.Fill(dt);
                con.Close();
                da.Dispose();

                string balance = dt.Rows[0][2].ToString();
                balanceLbl.Text = "Balance: " + balance.Insert(0, "£");
                Console.WriteLine(balanceLbl.Text);

            } else
            {
                Console.WriteLine("Error!");
            }
           

            
        }

        private void Withdraw_Cash_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }

        public void eject_cash(String e)
        {
            //Checks the PIN`s encrypted/hashed value.
            Console.WriteLine("Eject Card.");
            MessageBox.Show("Please take your card.");
            Console.WriteLine(e.Insert(0, "£") + " Ejected.");
        }

        private void zerOptionBtn_Click(object sender, EventArgs e)
        {
            eject_cash("5");
        }

        private void firstOptionBtn_Click(object sender, EventArgs e)
        {
            eject_cash("10");
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
