using System.Windows.Input;
using System.Windows.Media;
using Microbots.ViewModels;
using Microbots.Views.Resources.Helpers;

namespace Microbots.Views.Resources.Controls
{
    public partial class MessagesControl
    {
        public string Title { get { return Get<string>(); } set { Set(value); } }
        public Brush MessageTextColour { get { return Get<Brush>(); } set { Set(value); } }
        public Brush MessageMouseOverCloseColour { get { return Get<Brush>(); } set { Set(value); } }
        public Brush MessageBackgroundColour { get { return Get<Brush>(); } set { Set(value); } }

        public ICommand ClearMessageCommand { get { return new Command<MessageViewModel>(mvm => EventHandler.ClearMessage(mvm)); } }
        public ICommand ClearAllMessagesCommand { get { return new Command(() => EventHandler.ClearAllMessages()); } }

        public MessagesControl()
        {
            InitializeComponent();
        }
    }

    public interface IMessagesEventHandler
    {
        void ClearMessage(MessageViewModel messageViewModel);
        void ClearAllMessages();
    }
}
