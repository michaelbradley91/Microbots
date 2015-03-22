using System.Windows;
using Microbots.Controllers;
using Microbots.Extensions;
using Microbots.ViewModels;
using Microbots.Views.Resources;
using Microbots.Views.Resources.Controls;

namespace Microbots.Views
{
    public partial class MessagesView : IMessagesEventHandler
    {
        private readonly IMessagesController _messagesController;
        private readonly MessagesViewModel _messagesViewModel;

        public MessagesView(IMessagesController messagesController, MessagesViewModel messagesViewModel)
        {
            _messagesController = messagesController;
            _messagesViewModel = messagesViewModel;

            InitializeComponent();
            DataContext = messagesViewModel;
        }

        public void ClearMessage(MessageViewModel message)
        {
            _messagesViewModel.Messages.Remove(message);
        }

        public void ClearAllMessages()
        {
            _messagesController.ClearMessages();
        }
    }
}
