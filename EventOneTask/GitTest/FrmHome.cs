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
            //ProcessStartInfo gitInfo = new ProcessStartInfo();
            //gitInfo.CreateNoWindow = true;
            //gitInfo.RedirectStandardError = true;
            //gitInfo.RedirectStandardOutput = true;
            //gitInfo.FileName = @"C:\Program Files\Git\bin\git.exe";

            //Process gitProcess = new Process();
            //gitInfo.Arguments = "pull"; // such as "fetch orign"
            //gitInfo.WorkingDirectory = @"E:\Git\EventOneTesting";

            //gitProcess.StartInfo = gitInfo;
            //gitProcess.StartInfo.UseShellExecute = false;
            //gitProcess.OutputDataReceived += GitProcess_OutputDataReceived;
            //gitProcess.ErrorDataReceived += GitProcess_ErrorDataReceived;

            //gitProcess.Start();
            //gitProcess.WaitForExit();         


            //gitProcess.BeginOutputReadLine();
            // gitProcess.BeginErrorReadLine();

            //gitProcess.Close();
            GitFetchAction obj = new GitFetchAction();
            obj.beginProcess();
        }

        private void GitProcess_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            string str = e.Data;
        }

        private void GitProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            string str = e.Data;
        }

        private void btnPull_Click(object sender, EventArgs e)
        {
            txtOutPut.Text = "";
            GitPullAction obj = new GitPullAction();
            obj.beginProcess();
            txtOutPut.Text = GitAction.mOutputText.ToString();
        }
    }
}
