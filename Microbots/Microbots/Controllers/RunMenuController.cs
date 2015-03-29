using System.Windows.Media;
using Microbots.View.ViewModels;

namespace Microbots.View.Controllers
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
        private readonly IMessagesCollectionController _messagesCollectionController;
        private readonly IErrorMessagesController _errorMessagesController;
        private readonly IInfoMessagesController _infoMessagesController;
        private readonly ISuccessMessagesController _successMessagesController;

        public RunMenuController(RunMenuViewModel runMenuViewModel, WorldViewModel worldViewModel, IMessagesCollectionController messagesCollectionController, IErrorMessagesController errorMessagesController, IInfoMessagesController infoMessagesController, ISuccessMessagesController successMessagesController)
        {
            _runMenuViewModel = runMenuViewModel;
            _worldViewModel = worldViewModel;
            _messagesCollectionController = messagesCollectionController;
            _errorMessagesController = errorMessagesController;
            _infoMessagesController = infoMessagesController;
            _successMessagesController = successMessagesController;
        }

        public void Start()
        {
            _messagesCollectionController.ShowErrorMessages();
            _errorMessagesController.AddMessage(new MessageViewModel { Summary = "New exception!!! WOWOW  WOWOWW WOWOWOW WWOOOW WWOOWOW WOWWOWOWOWOWOWOWW" });
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
            _messagesCollectionController.ShowSuccessMessages();
            _successMessagesController.AddMessage(new MessageViewModel {Summary = "You love Hannah"});
            _runMenuViewModel.IsPauseButtonEnabled = false;
            _runMenuViewModel.IsStopButtonEnabled = true;
            _runMenuViewModel.IsStartButtonEnabled = false;
        }

        public void Stop()
        {
            _runMenuViewModel.IsPauseButtonEnabled = false;
            _runMenuViewModel.IsStopButtonEnabled = false;
            _runMenuViewModel.IsStartButtonEnabled = true;
            _messagesCollectionController.ShowInfoMessages();
            _infoMessagesController.AddMessage(new MessageViewModel { Summary = "New message!!! WOWOW  WOWOWW WOWOWOW WWOOOW WWOOWOW WOWWOWOWOWOWOWOWW" });
            _worldViewModel.WorldSquares = WorldViewModel.CreateWorldSquares(3, 3);
            foreach (var square in _worldViewModel.WorldSquares)
            {
                square.Colour = Brushes.Green;
            }
        }
    }
}
