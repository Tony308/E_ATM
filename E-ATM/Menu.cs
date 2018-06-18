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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            Withdraw_Cash form = new Withdraw_Cash();
            form.Show();
            this.Hide();
        }

        private void balanceBtn_Click(object sender, EventArgs e)
        {
            Display_Balance form = new Display_Balance();

            form.Show();
            this.Hide();

        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void balanceWithdrawBtn_Click(object sender, EventArgs e)
        {
            Withdraw_Cash form = new Withdraw_Cash();
            form.Show();
            this.Hide();
        }

        private void pinChangeBtn_Click(object sender, EventArgs e)
        {
            PIN_Update form = new PIN_Update();
            form.Show();
            this.Hide();
        }
    }
}
