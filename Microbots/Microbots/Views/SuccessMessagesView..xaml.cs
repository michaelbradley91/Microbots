using Microbots.View.Controllers;
using Microbots.View.ViewModels;
using Microbots.View.Views.Resources.Controls;

namespace Microbots.View.Views
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
