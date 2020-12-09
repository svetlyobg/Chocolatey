using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chocolatey
{
    public static class PowerShellCmd
    {
        public static void PowerShellCommand(string cmd, ref TextBox txtMsg)
        {
            txtMsgClear(ref txtMsg);

            lockForm(true);
            var sb = new StringBuilder();
            using (RunspaceInvoke invoker = new RunspaceInvoke())
            {
                var someResult = invoker.Invoke(cmd);
                someResult.ToList().ForEach(c => sb.AppendLine(c.ToString()));
            }
            txtMsg.Text = sb.ToString();
            lockForm(false);
        }
        public static void txtMsgClear(ref TextBox txtMsg)
        {
            txtMsg.Text = "";
            Application.DoEvents();
        }
        public static void lockForm(bool lockIt)
        {
            var f = new Form1();
            foreach (var c in f.Controls)
            {
                if (c is Button)
                {
                    ((Button)c).Enabled = lockIt;
                }
            }
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
    }
}
