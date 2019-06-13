using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLGenerator
{
    public static class SaveFilePath
    {
        public static string GetPath()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Xml File(*.xml)| *.xml",
                RestoreDirectory = true
            };
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName.Length == 0)
            {
                return null;
            }
            return saveFileDialog.FileName;

        }
    }
}
