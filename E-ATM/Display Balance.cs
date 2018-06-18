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
    public partial class Display_Balance : Form
    {
        public Display_Balance()
        {
            InitializeComponent();
        }

        private void Display_Balance_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            Withdraw_Cash form = new Withdraw_Cash();
            form.Show();
            this.Hide();
        }

        private void Display_Balance_Load(object sender, EventArgs e)
        {

        }

        private void otherBtn_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }
    }
}
