using System.Windows;
using Microbots.ViewModels;

namespace Microbots.Controllers
{
    public interface IStartController
    {
        void HideExceptions();
        void ShowExceptions();
        void HideMessages();
        void ShowMessages();
    }

    public class StartController : IStartController
    {
        private readonly StartViewModel _startViewModel;

        public StartController(StartViewModel startViewModel)
        {
            _startViewModel = startViewModel;
        }

        public void HideExceptions()
        {
            _startViewModel.ExceptionVisiblity = Visibility.Collapsed;
        }

        public void ShowExceptions()
        {
            _startViewModel.ExceptionVisiblity = Visibility.Visible;
        }

        public void HideMessages()
        {
            _startViewModel.MessageVisibility = Visibility.Collapsed;
        }

        public void ShowMessages()
        {
            _startViewModel.MessageVisibility = Visibility.Visible;
        }
    }
}
