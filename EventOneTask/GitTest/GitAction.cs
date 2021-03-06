﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    public abstract class GitAction
    {
        protected ProcessStartInfo mGitInfo = new ProcessStartInfo();
        protected String mGitInstalledPath = @"C:\Program Files\Git\bin\git.exe";
        protected String mWorkingDirectoryPath = @"E:\Git\EventOneTesting";
        protected abstract String mCommand { get; }
        public static StringBuilder mOutputText = new StringBuilder(500);
        Process mGitProcess;
        public GitAction()
        {
            InitailizeComponents();
        }
        public void InitailizeComponents()
        {
            mGitInfo.CreateNoWindow = true;
            mGitInfo.CreateNoWindow = true;
            mGitInfo.RedirectStandardError = true;
            mGitInfo.RedirectStandardOutput = true;
            mGitInfo.FileName = mGitInstalledPath;
            mGitProcess = new Process();
            mGitInfo.WorkingDirectory = mWorkingDirectoryPath;
            mGitProcess.StartInfo = mGitInfo;
            mGitProcess.StartInfo.UseShellExecute = false;
            mGitProcess.OutputDataReceived += GitProcess_OutputDataReceived;
            mGitProcess.ErrorDataReceived += GitProcess_ErrorDataReceived;
        }
        public virtual void beginProcess()
        {
            mGitInfo.Arguments = mCommand;
            mGitProcess.Start();
            mGitProcess.BeginOutputReadLine();
            mGitProcess.BeginErrorReadLine();
            mGitProcess.WaitForExit();
            mGitProcess.Close();
        }

        private void GitProcess_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            mOutputText.Append("\n");
            mOutputText.Append(e.Data); mOutputText.Append("\n");
        }

        private void GitProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            mOutputText.Append("\n");
            mOutputText.Append(e.Data); mOutputText.Append("\n");
        }
    }
}
