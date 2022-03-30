using System;
using System.Management.Automation;
using System.Threading;
using System.Windows.Forms;

namespace WindowsEmailAppReset
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            PowerShell powerShell = PowerShell.Create();
            powerShell.AddScript("Get-AppxPackage microsoft.windowscommunicationsapps  | Remove-AppxPackage");
            powerShell.Invoke();
            Thread.Sleep(3000);
            powerShell.AddScript("Get-AppXPackage -AllUsers microsoft.windowscommunicationsapps | Foreach {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\" }");
            powerShell.Invoke();
            hideIt();
        }

        private void hideIt()
        {
            Width = 0;
            Height = 0;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            ShowIcon = false;
            Opacity = 0;
            MaximizeBox = false;
            MinimizeBox = false;
            Text = null;
            Visible = false;
            ControlBox = false;
            Hide();
            Close();
        }



    }
}
