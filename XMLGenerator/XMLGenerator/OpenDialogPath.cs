using Library;
using Microsoft.Win32;
using System.Windows;

namespace XMLGenerator
{
    public class OpenDialogPath : IOpenDialogPath
    {
        public string GetPath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                RestoreDirectory = true
            };
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName.Length == 0)
            {
                MessageBox.Show("No files selected");
                return null;
            }
            return openFileDialog.FileName;

        }
    }
}
