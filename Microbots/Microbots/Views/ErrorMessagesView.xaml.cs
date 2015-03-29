using Microbots.View.Controllers;
using Microbots.View.ViewModels;
using Microbots.View.Views.Resources.Controls;

namespace Microbots.View.Views
{
    public partial class ErrorMessagesView : IMessagesEventHandler
    {
        private readonly IErrorMessagesController _errorMessagesController;

        public ErrorMessagesView(IErrorMessagesController errorMessagesController, ErrorMessagesViewModel errorErrorMessagesViewModel)
        {
            _errorMessagesController = errorMessagesController;

            InitializeComponent();
            DataContext = errorErrorMessagesViewModel;
        }

        public void ClearMessage(MessageViewModel message)
        {
            _errorMessagesController.RemoveMessage(message);
        }

        public void ClearAllMessages()
        {
            _errorMessagesController.ClearMessages();
        }
    }
}
