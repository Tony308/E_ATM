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

namespace E_ATM
{
    public partial class MainMenu : Form
    {
        private Encryption hash;

        public object ConfigurationManager { get; private set; }

        public MainMenu()
        {
            
            InitializeComponent();

        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            hash = new Encryption();
            hash.GenKey_SaveinContainer("PIN1");
            hash.GetKeyFromContainer("PIN1");
            hash.encrypt();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
