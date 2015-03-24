using Microbots.Controllers;
using Microbots.ViewModels;
using Microbots.Views.Resources.Controls;

namespace Microbots.Views
{
    public partial class SuccessMessagesView : IMessagesEventHandler
    {
        private readonly ISuccessMessagesController _successMessagesController;

        public SuccessMessagesView(ISuccessMessagesController successMessagesController, SuccessMessagesViewModel successMessagesViewModel)
        {
            _successMessagesController = successMessagesController;

            InitializeComponent();
            DataContext = successMessagesViewModel;
        }

        public void ClearMessage(MessageViewModel message)
        {
            _successMessagesController.RemoveMessage(message);
        }

        public void ClearAllMessages()
        {
            _successMessagesController.ClearMessages();
        }
    }
}
