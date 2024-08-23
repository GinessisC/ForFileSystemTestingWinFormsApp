using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForFileSystemTestingWinFormsApp
{
    class KatalogInfo
    {
        
        public string Path { get; private set; }
        public static string GetPath(FolderBrowserDialog folderBrowserDialog)
        {

            KatalogInfo katalogInfo = new KatalogInfo();
            string readyPath;
            string selectedpath = folderBrowserDialog.SelectedPath;
            katalogInfo.Path = selectedpath;

            if (!selectedpath.Contains("\\"))
            {
                readyPath = selectedpath.Replace(@"\", "\\");
            }

            else
            {
                readyPath = selectedpath;
            }
            return readyPath;
        }

    }
}
