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
            Click_Deserialize = new RelayCommand(DeserializeTask);
        }
        public string PathVariable { get; set; }
        public ICommand Click_Browse { get; }
        public ICommand Click_Serialize { get; }
        public ICommand Click_Deserialize { get; }
        private void Browse()
        {
            PathVariable = OpenDialogPath.GetPath();
        }
        private void SerializeTask()
        {

        }
        private void DeserializeTask()
        {

        }
    }
}
