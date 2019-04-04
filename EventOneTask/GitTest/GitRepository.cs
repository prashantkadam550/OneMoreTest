using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class GitRepository
    {
        private string mGitInstalledPath = @"C:\Program Files\Git\bin\git.exe";
        ProcessStartInfo gitInfo = new ProcessStartInfo();
        public GitRepository()
        {
            gitInfo.CreateNoWindow = true;
            gitInfo.RedirectStandardError = true;
            gitInfo.RedirectStandardOutput = true;
            gitInfo.FileName = mGitInstalledPath;
            // Commented For Testing
        }

        public String gitFetchMethod()
        {
            String outputString = "";
            Process gitProcess = new Process();
            gitInfo.Arguments = "fetch"; // YOUR_GIT_COMMAND such as "fetch orign"
            gitInfo.WorkingDirectory = @"D:\TestGit\OneMoreTest"; // YOUR_GIT_REPOSITORY_PATH;
            gitProcess.StartInfo = gitInfo;
            gitProcess.StartInfo.UseShellExecute = false;
            gitProcess.OutputDataReceived += GitProcess_OutputDataReceived;
            gitProcess.ErrorDataReceived += GitProcess_ErrorDataReceived;
            gitProcess.Start();
            //gitProcess.WaitForExit();

            gitProcess.BeginOutputReadLine(); // pick up STDERR
            gitProcess.BeginErrorReadLine(); // pick up STDOUT

            gitProcess.Close();
            return "";
        }
        
        private void GitProcess_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void GitProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
           
        }
    }
}
