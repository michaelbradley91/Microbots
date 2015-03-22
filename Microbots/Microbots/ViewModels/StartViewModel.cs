using System.Windows;
using Microbots.Helpers;

namespace Microbots.ViewModels
{
    public class StartViewModel : ObservableModel
    {
        public StartViewModel()
        {
            ExceptionVisiblity = Visibility.Visible;
            MessageVisibility = Visibility.Visible;
        }

        public Visibility ExceptionVisiblity { get { return Get<Visibility>(); } set { Set(value); } }
        public Visibility MessageVisibility { get { return Get<Visibility>(); } set { Set(value); } }
    }
}
