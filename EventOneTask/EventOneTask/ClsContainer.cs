using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventOneTask
{
    class ClsStatusContainer
    {
        static string[] AppNames = { "Microsoft Visual FoxPro OLE DB Provider", "MySQL Connector/ODBC 5.1", "Firebird/InterBase(r) ODBC driver 2.0.1.152" };
        public ClsStatusContainer(string AppName)
        {
            Product = AppName;
            Driver = AppName + " Driver";
            string status;
            ClsInstall.isDriverInstalled(AppName, out status);
            Status = status;
            MoreInfo = "";
        }
        public string Product { get; set; }
        public string Driver { get; set; }
        public string Status { get; set; }
        public string MoreInfo { get; set; }

        public static void FillStatusContainer(ListView lstStatus)
        {
            
            lstStatus.Items.Clear();
            foreach (string strAppname in AppNames)
            {
                ClsStatusContainer obj = new ClsStatusContainer(strAppname);
                ListViewItem item1 = new ListViewItem(obj.Product);
                item1.SubItems.Add(obj.Driver);
                item1.SubItems.Add(obj.Status);
                item1.SubItems.Add(obj.MoreInfo);
                lstStatus.Items.AddRange(new ListViewItem[] { item1 });
            }
           
        }

        public static void LoadProgressBar(ProgressBar prgs,Label lblPb)
        {
            int count = 3;
            int lblCount = 0;
            foreach (string strAppname in AppNames)
            {
               bool isInstalled= ClsInstall.isDriverInstalled(strAppname);
                if(isInstalled==true)
                {
                    prgs.Value = (int)(100 / count);
                    lblPb.Text =(lblCount+1).ToString()+ " / 3";
                    lblCount++;
                    count--;
                }
            }
        }
    }


}
