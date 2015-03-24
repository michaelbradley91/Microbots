using System.Windows;
using Microbots.ViewModels;

namespace Microbots.Controllers
{
    public interface IMessagesCollectionController
    {
        void HideErrorMessages();
        void ShowErrorMessages();
        void HideInfoMessages();
        void ShowInfoMessages();
        void HideSuccessMessages();
        void ShowSuccessMessages();
    }

    public class MessagesCollectionController : IMessagesCollectionController
    {
        private readonly MessagesCollectionViewModel _messagesCollectionViewModel;

        public MessagesCollectionController(MessagesCollectionViewModel messagesCollectionViewModel)
        {
            _messagesCollectionViewModel = messagesCollectionViewModel;
        }

        public void HideErrorMessages()
        {
            _messagesCollectionViewModel.ErrorMessagesVisibility = Visibility.Collapsed;
        }

        public void ShowErrorMessages()
        {
            _messagesCollectionViewModel.ErrorMessagesVisibility = Visibility.Visible;
        }

        public void HideInfoMessages()
        {
            _messagesCollectionViewModel.InfoMessagesVisibility = Visibility.Collapsed;
        }

        public void ShowInfoMessages()
        {
            _messagesCollectionViewModel.InfoMessagesVisibility = Visibility.Visible;
        }

        public void HideSuccessMessages()
        {
            _messagesCollectionViewModel.SuccessMessagesVisibility = Visibility.Collapsed;
        }

        public void ShowSuccessMessages()
        {
            _messagesCollectionViewModel.SuccessMessagesVisibility = Visibility.Visible;
        }
    }
}
