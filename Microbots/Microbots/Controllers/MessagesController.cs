using Microbots.ViewModels;

namespace Microbots.Controllers
{
    public interface IMessagesController
    {
        void ClearMessages();
        void AddMessage(MessageViewModel messageViewModel);
    }

    public class MessagesController : IMessagesController
    {
        private readonly IStartController _startController;
        private readonly MessagesViewModel _messagesViewModel;

        public MessagesController(MessagesViewModel messagesViewModel, IStartController startController)
        {
            _startController = startController;
            _messagesViewModel = messagesViewModel;
        }

        public void ClearMessages()
        {
            _startController.HideMessages();
        }

        public void AddMessage(MessageViewModel messageViewModel)
        {
            
        }
    }
}
