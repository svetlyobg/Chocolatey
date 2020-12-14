using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chocolatey
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void btnInstBCU_Click(object sender, EventArgs e)
        {
            try
            {
                Chocolatey.PowerShellCmd.PowerShellCommand("choco install bulk-crap-uninstaller -y", ref txtMsg);
            }
            catch (Exception ex)
            {
                txtMsg.Text = ex.ToString();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }


        private void btnInstChrome_Click(object sender, EventArgs e)
        {
            try
            {
                Chocolatey.PowerShellCmd.PowerShellCommand("choco install googlechrome -y", ref txtMsg);
            }
            catch (Exception ex)
            {
                txtMsg.Text = ex.ToString();
            }
        }

        private void btnBrowsePackages_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("microsoft-edge:https://chocolatey.org/packages");
        }

        private void btnOnlineDocs_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("microsoft-edge:https://docs.chocolatey.org/en-us/");
        }

        private void btnInstallFirefox_Click(object sender, EventArgs e)
        {
            try
            {
                Chocolatey.PowerShellCmd.PowerShellCommand("choco install firefox", ref txtMsg);
            }
            catch (Exception ex)
            {
                txtMsg.Text = ex.ToString();
            }
        }

        private void btnInstallTeamViewer_Click(object sender, EventArgs e)
        {
            try
            {
                Chocolatey.PowerShellCmd.PowerShellCommand("choco install teamviewer", ref txtMsg);
            }
            catch (Exception ex)
            {
                txtMsg.Text = ex.ToString();
            }
        }

        private void btnInstAdbRdrDC_Click(object sender, EventArgs e)
        {
            try
            {
                Chocolatey.PowerShellCmd.PowerShellCommand("choco install adobereader", ref txtMsg);
            }
            catch (Exception ex)
            {
                txtMsg.Text = ex.ToString();
            }
        }

        private void btninstFoxitRdr_Click(object sender, EventArgs e)
        {
            try
            {
                Chocolatey.PowerShellCmd.PowerShellCommand("choco install foxitreader", ref txtMsg);
                System.Windows.Forms.Application.Exit();
            }
            catch (Exception ex)
            {
                txtMsg.Text = ex.ToString();
                System.Windows.Forms.Application.Exit();
            }
        }

        private void btnInst0patch_Click(object sender, EventArgs e)
        {
            try
            {
                Chocolatey.PowerShellCmd.PowerShellCommand("choco install 0patch", ref txtMsg);
            }
            catch (Exception ex)
            {
                txtMsg.Text = ex.ToString();
            }
        }

        private void btnMSOFFiceDepltool_Click(object sender, EventArgs e)
        {
            try
            {
                Chocolatey.PowerShellCmd.PowerShellCommand("choco install microsoft-office-deployment", ref txtMsg);
            }
            catch (Exception ex)
            {
                txtMsg.Text = ex.ToString();
            }
        }

        private void btnInsOfficeProPlus2013_Click(object sender, EventArgs e)
        {
            try
            {
                Chocolatey.PowerShellCmd.PowerShellCommand("choco install officeproplus2013", ref txtMsg);
            }
            catch (Exception ex)
            {
                txtMsg.Text = ex.ToString();
            }
        }

        private void btnInstOffice365HomePrem_Click(object sender, EventArgs e)
        {
            try
            {
                Chocolatey.PowerShellCmd.PowerShellCommand("choco install office365homepremium", ref txtMsg);
            }
            catch (Exception ex)
            {
                txtMsg.Text = ex.ToString();
            }
        }

        private void btnOffice2019ProPlus_Click(object sender, EventArgs e)
        {
            try
            {
                Chocolatey.PowerShellCmd.PowerShellCommand("choco install office2019proplus", ref txtMsg);
            }
            catch (Exception ex)
            {
                txtMsg.Text = ex.ToString();
            }
        }

        private void btnInst365Business_Click(object sender, EventArgs e)
        {
            try
            {
                Chocolatey.PowerShellCmd.PowerShellCommand("choco install office365business", ref txtMsg);
            }
            catch (Exception ex)
            {
                txtMsg.Text = ex.ToString();
            }
        }

        private void btnInstSkype_Click(object sender, EventArgs e)
        {
            try
            {
                Chocolatey.PowerShellCmd.PowerShellCommand("choco install skype", ref txtMsg);
            }
            catch (Exception ex)
            {
                txtMsg.Text = ex.ToString();
            }
        }

        private void btnInstVeeam_Click(object sender, EventArgs e)
        {
            try
            {
                Chocolatey.PowerShellCmd.PowerShellCommand("choco install veeam-agent", ref txtMsg);
            }
            catch (Exception ex)
            {
                txtMsg.Text = ex.ToString();
            }
        }

        private void btnInstEdge_Click(object sender, EventArgs e)
        {
            try
            {
                Chocolatey.PowerShellCmd.PowerShellCommand("choco install microsoft-edge", ref txtMsg);
            }
            catch (Exception ex)
            {
                txtMsg.Text = ex.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMsg_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
    }

