using Microsoft.Win32;
using System.Windows;

namespace XMLGenerator
{
    public static class OpenDialogPath
    {
        public static string GetPath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Xml File(*.xml)| *.xml",
                RestoreDirectory = true
            };
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName.Length == 0)
            {
                return null;
            }
            return openFileDialog.FileName;

        }
    }
}
