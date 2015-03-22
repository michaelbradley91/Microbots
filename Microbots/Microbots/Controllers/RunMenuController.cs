using System.Windows;
using System.Windows.Media;
using Microbots.ViewModels;

namespace Microbots.Controllers
{
    public interface IRunMenuController
    {
        void Start();
        void Pause();
        void Stop();
    }

    public class RunMenuController : IRunMenuController
    {
        private readonly RunMenuViewModel _runMenuViewModel;
        private readonly WorldViewModel _worldViewModel;
        private readonly StartViewModel _startViewModel;
        private readonly ExceptionsViewModel _exceptionsViewModel;
        private readonly MessagesViewModel _messagesViewModel;

        public RunMenuController(RunMenuViewModel runMenuViewModel, WorldViewModel worldViewModel, StartViewModel startViewModel, ExceptionsViewModel exceptionsViewModel, MessagesViewModel messagesViewModel)
        {
            _runMenuViewModel = runMenuViewModel;
            _worldViewModel = worldViewModel;
            _startViewModel = startViewModel;
            _exceptionsViewModel = exceptionsViewModel;
            _messagesViewModel = messagesViewModel;
        }

        public void Start()
        {
            _startViewModel.ExceptionVisiblity = Visibility.Visible;
            _exceptionsViewModel.Exceptions.Add(new ExceptionViewModel {Summary = "New exception!!! WOWOW  WOWOWW WOWOWOW WWOOOW WWOOWOW WOWWOWOWOWOWOWOWW"});
            _runMenuViewModel.IsPauseButtonEnabled = true;
            _runMenuViewModel.IsStopButtonEnabled = true;
            _runMenuViewModel.IsStartButtonEnabled = false;
            _worldViewModel.WorldSquares = WorldViewModel.CreateWorldSquares(5, 5);
            foreach (var square in _worldViewModel.WorldSquares)
            {
                square.Colour = Brushes.Red;
            }
        }

        public void Pause()
        {
            _runMenuViewModel.IsPauseButtonEnabled = false;
            _runMenuViewModel.IsStopButtonEnabled = true;
            _runMenuViewModel.IsStartButtonEnabled = false;
        }

        public void Stop()
        {
            _runMenuViewModel.IsPauseButtonEnabled = false;
            _runMenuViewModel.IsStopButtonEnabled = false;
            _runMenuViewModel.IsStartButtonEnabled = true;
            _startViewModel.MessageVisibility = Visibility.Visible;
            _messagesViewModel.Messages.Add(new MessageViewModel { Summary = "New message!!! WOWOW  WOWOWW WOWOWOW WWOOOW WWOOWOW WOWWOWOWOWOWOWOWW" });
            _worldViewModel.WorldSquares = WorldViewModel.CreateWorldSquares(3, 3);
            foreach (var square in _worldViewModel.WorldSquares)
            {
                square.Colour = Brushes.Green;
            }
        }
    }
}
