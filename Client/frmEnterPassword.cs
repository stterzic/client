using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class frmEnterPassword : Form
    {
        public frmEnterPassword()
        {
            InitializeComponent();
        }

        private string _password = "";

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                _password = txtPassword.Text;
                Close();
            }
            else
            {
                MessageBox.Show("Please specify a password.");
                return;
            }
        }
    }
}