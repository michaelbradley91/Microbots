using Microbots.View.Controllers;
using Microbots.View.ViewModels;
using Microbots.View.Views.Resources.Controls;

namespace Microbots.View.Views
{
    public partial class InfoMessagesView : IMessagesEventHandler
    {
        private readonly IInfoMessagesController _infoMessagesController;

        public InfoMessagesView(IInfoMessagesController infoMessagesController, InfoMessagesViewModel infoMessagesViewModel)
        {
            _infoMessagesController = infoMessagesController;

            InitializeComponent();
            DataContext = infoMessagesViewModel;
        }

        public void ClearMessage(MessageViewModel message)
        {
            _infoMessagesController.RemoveMessage(message);
        }

        public void ClearAllMessages()
        {
            _infoMessagesController.ClearMessages();
        }
    }
}
