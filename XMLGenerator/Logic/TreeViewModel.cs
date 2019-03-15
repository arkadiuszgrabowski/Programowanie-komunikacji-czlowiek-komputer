using System.Windows.Input;
using Library.MVVM;

namespace Library.TreeView
{
    public class TreeViewModel : ViewModelBase
    {
        public TreeViewModel()
        {
            Click_Browse = new RelayCommand(Browse);
            Click_Serialize = new RelayCommand(SerializeTask);
            Click_Deserialize = new RelayCommand(DeserializeTask);
        }
        public string PathVariable { get; set; }
        public ICommand Click_Browse { get; }
        public ICommand Click_Serialize { get; }
        public ICommand Click_Deserialize { get; }
        public IOpenDialogPath GetPath { get; set; }
        private void Browse()
        {
            PathVariable = GetPath.GetPath();
        }
        private void SerializeTask()
        {

        }
        private void DeserializeTask()
        {

        }
    }
}
