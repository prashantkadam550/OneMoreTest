using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventOneTask
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }
        string GFoxProFilePath = @"D:\Event One Training\VFPOLEDBSetup.msi";
        string GMysqlPath = @"D:\Event One Training\mysql-connector-odbc-5.1.13-win32.msi";
        string GFirebirdPath = @"D:\Event One Training\Firebird_ODBC_2.0.1.152_Win32.exe";
        
        private void chkFoxPro_CheckedChanged(object sender, EventArgs e)
        {
           if(chkMySQLODBC.Checked==true || chkFoxPro.Checked==true || chkFirebirdODBC.Checked == true) { btnInstall.Enabled = true; } else { btnInstall.Enabled = false; }
        }

        private void chkMySQLODBC_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMySQLODBC.Checked == true || chkFoxPro.Checked == true || chkFirebirdODBC.Checked == true) { btnInstall.Enabled = true; } else { btnInstall.Enabled = false; }
        }

        private void chkFirebirdODBC_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMySQLODBC.Checked == true || chkFoxPro.Checked == true || chkFirebirdODBC.Checked == true) { btnInstall.Enabled = true; } else { btnInstall.Enabled = false; }
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            if (chkFoxPro.Checked)
            {
                bool isInstalled = ClsInstall.isDriverInstalled("Microsoft Visual FoxPro OLE DB Provider");
                if (isInstalled)
                {
                    MessageBox.Show("Microsoft Visual FoxPro OLE DB Provider is Already Installed", "Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    InstallFile(GFoxProFilePath);
                    ClsStatusContainer.FillStatusContainer(lstStatus);
                    ClsStatusContainer.LoadProgressBar(prgbStatus, lblProgress);
                } 
            }
            if (chkMySQLODBC.Checked == true)  
            {
                bool isInstalled = ClsInstall.isDriverInstalled("MySQL Connector/ODBC 5.1");
                if (isInstalled == true)
                {
                    MessageBox.Show("MySQL Connector/ODBC 5.1 is Already Installed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    InstallFile(GMysqlPath);
                    ClsStatusContainer.FillStatusContainer(lstStatus);
                    ClsStatusContainer.LoadProgressBar(prgbStatus, lblProgress);
                }
            }
            if (chkFirebirdODBC.Checked==true)
            {
                bool isInstalled = ClsInstall.isDriverInstalled("Firebird/InterBase(r) ODBC driver 2.0.1.152");
                if (isInstalled == true)
                {
                    MessageBox.Show("Firebird/InterBase(r) ODBC driver 2.0.1.152 is Already Installed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    InstallFile(GFirebirdPath);
                    ClsStatusContainer.FillStatusContainer(lstStatus);
                    ClsStatusContainer.LoadProgressBar(prgbStatus, lblProgress);
                }
               
            } 
        }
        private void InstallFile(string filepath)
        {
            InstallationFileInfo obj = new InstallationFileInfo(filepath);
            switch (obj.FileType.ToString())
            {
                case "EXE":
                    ClsInstall.installEXE(filepath);
                    break;
                case "MSI":
                    ClsInstall.installMSI(filepath);
                    break;
                default:
                    MessageBox.Show("Not Supported File Type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);break;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            ClsStatusContainer.FillStatusContainer(lstStatus);
            ClsStatusContainer.LoadProgressBar(prgbStatus,lblProgress);
        }
    }
}
