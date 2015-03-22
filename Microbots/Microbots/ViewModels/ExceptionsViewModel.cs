using System.Collections.ObjectModel;
using System.Windows.Forms;
using Microbots.ViewModels.Helpers;

namespace Microbots.ViewModels
{
    public class ExceptionsViewModel : ObservableModel
    {
        public ExceptionsViewModel()
        {
            Exceptions = new ObservableCollection<ExceptionViewModel>();
        }

        public ObservableCollection<ExceptionViewModel> Exceptions { get { return Get<ObservableCollection<ExceptionViewModel>>(); } set { Set(value); } }
    }

    public class ExceptionViewModel : ObservableModel
    {
        public ExceptionViewModel()
        {
            Summary = "";
            Detail = "";
        }

        public string Summary { get { return Get<string>(); } set { Set(value);} }
        public string Detail { get { return Get<string>(); } set {Set(value);} }
    }
}
