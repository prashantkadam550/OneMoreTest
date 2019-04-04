using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOneTask
{
    class InstallationFileInfo
    {
        public InstallationFileInfo(string filepath)
        {
            FilePath = filepath;
            FileInformation = new FileInfo(filepath);
        }
        public string FilePath { get; set; }
        public FileInfo FileInformation { get; set; }


        public InstallationType FileType
        {
            get
            {
                switch (FileInformation.Extension.ToLower())
                {
                    case ".msi": return InstallationType.MSI;
                    case ".exe": return InstallationType.EXE;
                    default: return InstallationType.Unknown;
                }
            }
        }

    }
}
