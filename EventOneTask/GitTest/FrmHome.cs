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
           
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            txtOutPut.Text = "";
            GitFetchAction obj = new GitFetchAction();
            obj.beginProcess();
            txtOutPut.Text = GitAction.mOutputText.ToString();
        }

        private void btnPull_Click(object sender, EventArgs e)
        {
            txtOutPut.Text = "";
            GitFetchAction obj = new GitFetchAction();
            obj.beginProcess();
            GitPullAction objPull = new GitPullAction();
            objPull.beginProcess();
            txtOutPut.Text = GitAction.mOutputText.ToString();
        }
    }
}
