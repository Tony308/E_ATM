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
                //Sets boolean to true to show authentication accepted.
                form.setAuthentication(true);
                form.getAuthentication();
                //if pin matches against database pin then execute.
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
                
            } else
            {
                //Doesn't match PIN in the database.
                MessageBox.Show("You've entered the wrong PIN.");
                PinMTB.Text = null;
                this.Show();
            }
        }

        private void PinMTB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
