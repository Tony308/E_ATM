using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace E_ATM
{
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            
            InitializeComponent();

        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            PinMTB.Text = null;
            PinMTB.MaxLength = 4;
            Encryption form = new Encryption();
            form.unhashPIN();
        }

        
        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            Encryption form = new Encryption();
            if (form.getClient(PinMTB.Text))
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("You've entered the wrong PIN.");
            }
        }

        private void PinMTB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
