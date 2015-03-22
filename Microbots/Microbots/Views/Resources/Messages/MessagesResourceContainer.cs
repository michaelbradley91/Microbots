using System.Windows.Input;
using System.Windows.Media;
using Microbots.ViewModels;
using Microbots.Views.Resources.Helpers;

namespace Microbots.Views.Resources.Messages
{
    public class MessageResourceContainer : ObservableUserControl
    {
        public MessageResourceContainer()
        {
            Title = "Messages";
            MessageTextColour = Brushes.Black;
            MessageMouseOverCloseColour = Brushes.Black;
            MessageBackgroundColour = Brushes.LightGray;
            EventHandler = new MessageResourceEventHandler();
        }

        public string Title { get { return Get<string>(); } set { Set(value); } }
        public Brush MessageTextColour { get { return Get<Brush>(); } set { Set(value); } }
        public Brush MessageMouseOverCloseColour { get { return Get<Brush>(); } set { Set(value); } }
        public Brush MessageBackgroundColour { get { return Get<Brush>(); } set { Set(value); } }
        public IMessageResourceEventHandler EventHandler { get { return Get<IMessageResourceEventHandler>(); } set { Set(value); } }

        public ICommand ClearMessageCommand { get { return new AlwaysEnabledCommand<MessageViewModel>(mvm => EventHandler.ClearMessage(mvm)); } }
        public ICommand ClearAllMessagesCommand { get { return new AlwaysEnabledCommand(() => EventHandler.ClearAllMessages()); } }

        private class MessageResourceEventHandler : IMessageResourceEventHandler
        {
            public void ClearMessage(MessageViewModel messageViewModel) { }
            public void ClearAllMessages() { }
        }
    }

    public interface IMessageResourceEventHandler
    {
        void ClearMessage(MessageViewModel messageViewModel);
        void ClearAllMessages();
    }
}
