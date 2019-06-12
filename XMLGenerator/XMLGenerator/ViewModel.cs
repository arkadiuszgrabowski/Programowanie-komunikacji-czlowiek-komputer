using Logic;
using System.Windows.Input;
using XMLGenerator.MVVM;

namespace XMLGenerator
{
    public class ViewModel : ViewModelBase
    {
        public ViewModel()
        {
            Click_Browse = new RelayCommand(Browse);
            Click_Serialize = new RelayCommand(SerializeTask);
        }
        public string PathVariable { get; set; }
        public ICommand Click_Browse { get; }
        public ICommand Click_Serialize { get; }
        private void Browse()
        {
            PathVariable = OpenDialogPath.GetPath();
            //if (PathVariable != null)
            //{
            //    XmlSerialization.Deserialize(PathVariable);
            //}
        }
        private void SerializeTask()
        {

        }
    }
}
