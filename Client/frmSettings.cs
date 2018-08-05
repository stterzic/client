using Client.Properties;
using Helper;
using Library;
using System;
using System.Collections;
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
    public partial class frmSettings : frmBase
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        public bool openedForEdit = false;
        public frmSettings(Machine parMachine)
        {
            InitializeComponent();
            uctRemoteConnectionSettings1.SetMachineSettings(parMachine);
            txtRemoteDesktopConnectionName.Text = parMachine.RemoteDesktopConnectionName;
            txtRemoteDesktopConnectionName.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Machine insMachine = new Machine();
            insMachine = uctRemoteConnectionSettings1.GetMachineSettings();
            if (insMachine != null)
            {
                if (txtRemoteDesktopConnectionName.Text != "")
                {
                    insMachine.RemoteDesktopConnectionName = txtRemoteDesktopConnectionName.Text;
                }
                else
                {
                    MessageBox.Show("Please fill in the Setting Name.");
                    return;
                }
                bool isSaved = SaveRemoteDesktop(insMachine, openedForEdit);
                if (isSaved)
                {
                    Close();
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}