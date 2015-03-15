using System.Windows;
using Microbots.ViewModels.Helpers;

namespace Microbots.ViewModels
{
    public class StartViewModel : ObservableModel
    {
        public StartViewModel()
        {
            ExceptionVisiblity = Visibility.Visible;
        }

        public Visibility ExceptionVisiblity { get { return Get<Visibility>(); } set { Set(value); } }
    }
}
