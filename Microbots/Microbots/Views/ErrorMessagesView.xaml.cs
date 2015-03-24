using Microbots.Controllers;
using Microbots.ViewModels;
using Microbots.Views.Resources.Controls;

namespace Microbots.Views
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
