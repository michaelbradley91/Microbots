using System.Collections.ObjectModel;
using System.Windows.Forms;
using Microbots.ViewModels.Helpers;

namespace Microbots.ViewModels
{
    public class ExceptionsViewModel : ObservableModel
    {
        public ObservableCollection<ExceptionViewModel> Exceptions { get { return Get<ObservableCollection<ExceptionViewModel>>(); } set { Set(value); } }

        public ExceptionsViewModel()
        {
            Exceptions = new ObservableCollection<ExceptionViewModel>();
        }
    }

    public class ExceptionViewModel : ObservableModel
    {
        public string Summary { get { return Get<string>(); } set { Set(value); } }
        public string Detail { get { return Get<string>(); } set { Set(value); } }

        public ExceptionViewModel()
        {
            Summary = "";
            Detail = "";
        }
    }
}
