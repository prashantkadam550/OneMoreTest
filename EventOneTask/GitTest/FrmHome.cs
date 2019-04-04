using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitTest
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            //ListViewItem lstViewItem = new ListViewItem();
            //lstViewItem.SubItems.Add("Testing..");
            //lstViewItem.SubItems.Add("Testing1..");

            //listViewRepositoryList.Items.Add(lstViewItem);
           
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            //GitRepository objRep = new GitRepository();
            // String str=objRep.gitFetchMethod();
            ProcessStartInfo gitInfo = new ProcessStartInfo();
            gitInfo.CreateNoWindow = true;
            gitInfo.RedirectStandardError = true;
            gitInfo.RedirectStandardOutput = true;
            gitInfo.FileName = @"C:\Program Files\Git\bin\git.exe";

            Process gitProcess = new Process();
            gitInfo.Arguments = "fetch"; // such as "fetch orign"
            gitInfo.WorkingDirectory = @"D:\TestGit\OneMoreTest";

            gitProcess.StartInfo = gitInfo;
            gitProcess.StartInfo.UseShellExecute = false;
            gitProcess.Start();

            string stderr_str = gitProcess.StandardError.ReadToEnd();  // pick up STDERR
            string stdout_str = gitProcess.StandardOutput.ReadToEnd(); // pick up STDOUT

            gitProcess.WaitForExit();
            gitProcess.Close();
        }
    }
}
