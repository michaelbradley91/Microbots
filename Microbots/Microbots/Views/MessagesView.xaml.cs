using System.Windows;
using Microbots.Controllers;
using Microbots.Extensions;
using Microbots.ViewModels;

namespace Microbots.Views
{
    public partial class MessagesView
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

        private void ClearMessages(object sender, RoutedEventArgs e)
        {
            _messagesController.ClearMessages();
        }

        private void ClearMessage(object sender, RoutedEventArgs e)
        {
            var message = sender.GetDataContext<MessageViewModel>();
            _messagesViewModel.Messages.Remove(message);
        }
    }
}
