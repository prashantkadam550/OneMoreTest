using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            GitRepository objRep = new GitRepository();
            String str=objRep.gitFetchMethod();
        }
    }
}
