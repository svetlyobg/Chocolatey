using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Chocolatey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPowerShell_Click(object sender, EventArgs e)
        {
            try
            {
                Chocolatey.PowerShellCmd.PowerShellCommand("Get-ExecutionPolicy", ref txtMsg);
            }
            catch (Exception ex)
            {
                txtMsg.Text = ex.ToString();
            }
        }

        private void btnSetExecPolicy_Click(object sender, EventArgs e)
        {
            try
            {
                Chocolatey.PowerShellCmd.PowerShellCommand("Set-ExecutionPolicy AllSigned", ref txtMsg);
            }
            catch (Exception ex)
            {
                txtMsg.Text = ex.ToString();
            }
        }

        private void btnSetExecPolByPass_Click(object sender, EventArgs e)
        {
            try
            {
                Chocolatey.PowerShellCmd.PowerShellCommand("Set-ExecutionPolicy Bypass -Scope Process", ref txtMsg);
            }
            catch (Exception ex)
            {
                txtMsg.Text = ex.ToString();
            }
        }
        private void btnChocoListLO_Click(object sender, EventArgs e)
        {
            try
            {
                Chocolatey.PowerShellCmd.PowerShellCommand("choco list -lo", ref txtMsg);
            }
            catch (Exception ex)
            {
                txtMsg.Text = ex.ToString();
            }
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            try
            {
                Chocolatey.PowerShellCmd.PowerShellCommand("choco list all", ref txtMsg);
            }
            catch (Exception ex)
            {
                txtMsg.Text = ex.ToString();
            }
        }
        public void lockForm(bool lockIt)
        {
            btnChocoListLO.Enabled = !lockIt;
            btnGetExecPolicy.Enabled = !lockIt;
            btnListAll.Enabled = !lockIt;
            btnSetExecPolByPass.Enabled = !lockIt;
            btnSetExecPolicy.Enabled = !lockIt;
            btnUpgradeOutdated.Enabled = !lockIt;
            btnListOutdated.Enabled = !lockIt;
            bntInstallNoAV.Enabled = !lockIt;
            Application.DoEvents();
            if (lockIt)
            {
                Cursor.Current = Cursors.WaitCursor;
            }
            else
            {
                Cursor.Current = Cursors.Default;
            }
            Application.DoEvents();
        }
        

        private void btnListOutdated_Click(object sender, EventArgs e)
        {
            try
            {
                //Chocolatey.PowerShellCmd.PowerShellCommand("choco outdated", ref txtMsg);
                Chocolatey.PowerShellCmd.txtMsgClear(ref txtMsg);
                lockForm(true);
                var sb = new StringBuilder();
                using (RunspaceInvoke invoker = new RunspaceInvoke())
                {
                    var someResult = invoker.Invoke("choco outdated");
                    var i = 1;
                    char[] splitParam = { '|' };
                    var total = someResult.ToList().Count;
                    foreach (var c in someResult.ToList())
                    {
                        if (i > 4 && i < (total - 1))
                        {
                            var soft = c.ToString().Split(splitParam, StringSplitOptions.RemoveEmptyEntries)[0];
                            txtMsg.Text = "Upgrading " + (i - 4).ToString() + " from " + (total - 6).ToString();
                            Application.DoEvents();
                            using (RunspaceInvoke upgrading = new RunspaceInvoke())
                            {
                                var uResult = upgrading.Invoke("choco upgrade " + soft + " -y");
                                Application.DoEvents();
                                uResult.ToList().ForEach(u => sb.AppendLine(u.ToString()));
                                Application.DoEvents();
                            }
                        }
                        i++;
                    }
                }
                txtMsg.Text = sb.ToString();
                lockForm(false);
            }
            catch (Exception ex)
            {
                txtMsg.Text = ex.ToString();
            }
        }

        private void btnListOutdated_Click_1(object sender, EventArgs e)
        {
            try
            {
                Chocolatey.PowerShellCmd.PowerShellCommand("choco outdated", ref txtMsg);
            }
            catch (Exception ex)
            {
                txtMsg.Text = ex.ToString();
            }
        }

        private void bntInstallNoAV_Click(object sender, EventArgs e)
        {
            try
            {
                Chocolatey.PowerShellCmd.PowerShellCommand("Set-ExecutionPolicy Bypass -Scope Process -Force; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))", ref txtMsg);
            }
            catch (Exception ex)
            {
                txtMsg.Text = ex.ToString();
            }
        }

        private void btnLightInstall_Click(object sender, EventArgs e)
        {
            try
            {
                Chocolatey.PowerShellCmd.PowerShellCommand("Set - ExecutionPolicy Bypass - Scope Process - Force; iwr https://chocolatey.org/install.ps1 -UseBasicParsing | iex", ref txtMsg);
            }
            catch (Exception ex)
            {
                txtMsg.Text = ex.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
        }
    
      
        private void BtnInstChocoGUI_Click(object sender, EventArgs e)
        {
            try
            {
                Chocolatey.PowerShellCmd.PowerShellCommand("choco install chocolateygui -y", ref txtMsg);
            }
            catch (Exception ex)
            {
                txtMsg.Text = ex.ToString();
            }
        }

        private void btnBrowsePackages_Click(object sender, EventArgs e)
        {
            private void btnBrowsePackages_Click(object sender, EventArgs e)
            {
                System.Diagnostics.Process.Start("microsoft-edge:https://chocolatey.org/packages");
            }
        }

        private void btnOnlineDocs_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("microsoft-edge:https://docs.chocolatey.org/en-us/");
        }
    }
}
