using Microbots.ViewModels;

namespace Microbots.Controllers
{
    public interface IErrorMessagesController : IMessagesController { }

    public class ErrorMessagesController : MessagesController, IErrorMessagesController
    {
        public ErrorMessagesController(ErrorMessagesViewModel messagesViewModel, IMessagesCollectionController messagesCollectionController)
            : base(messagesViewModel, messagesCollectionController) { }

        public override void HideMessages()
        {
            MessagesCollectionController.HideErrorMessages();
        }
    }

    public interface IInfoMessagesController : IMessagesController { }

    public class InfoMessagesController : MessagesController, IInfoMessagesController
    {
        public InfoMessagesController(InfoMessagesViewModel messagesViewModel, IMessagesCollectionController messagesCollectionController)
            : base(messagesViewModel, messagesCollectionController) { }

        public override void HideMessages()
        {
            MessagesCollectionController.HideInfoMessages();
        }
    }

    public interface ISuccessMessagesController : IMessagesController { }

    public class SuccessMessagesController : MessagesController, ISuccessMessagesController
    {
        public SuccessMessagesController(SuccessMessagesViewModel messagesViewModel, IMessagesCollectionController messagesCollectionController)
            : base(messagesViewModel, messagesCollectionController) { }

        public override void HideMessages()
        {
            MessagesCollectionController.HideSuccessMessages();
        }
    }

    public interface IMessagesController
    {
        void ClearMessages();
        void AddMessage(MessageViewModel messageViewModel);
        void RemoveMessage(MessageViewModel messageViewModel);
    }

    public abstract class MessagesController : IMessagesController
    {
        protected readonly MessagesViewModel MessagesViewModel;
        protected readonly IMessagesCollectionController MessagesCollectionController;

        protected MessagesController(MessagesViewModel messagesViewModel, IMessagesCollectionController messagesCollectionController)
        {
            MessagesViewModel = messagesViewModel;
            MessagesCollectionController = messagesCollectionController;
        }

        public abstract void HideMessages();

        public void ClearMessages()
        {
            MessagesViewModel.Messages.Clear();
            HideMessages();
        }

        public void AddMessage(MessageViewModel messageViewModel)
        {
            MessagesViewModel.Messages.Add(messageViewModel);
        }

        public void RemoveMessage(MessageViewModel messageViewModel)
        {
            MessagesViewModel.Messages.Remove(messageViewModel);
        }
    }
}
