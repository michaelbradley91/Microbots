using System.Collections.ObjectModel;
using Microbots.ViewModels.Helpers;

namespace Microbots.ViewModels
{
    public class ErrorMessagesViewModel : MessagesViewModel { }
    public class InfoMessagesViewModel : MessagesViewModel { }
    public class SuccessMessagesViewModel : MessagesViewModel { }

    public class MessagesViewModel : ObservableModel
    {
        public ObservableCollection<MessageViewModel> Messages { get { return Get<ObservableCollection<MessageViewModel>>(); } set { Set(value); } }

        public MessagesViewModel()
        {
            Messages = new ObservableCollection<MessageViewModel>();
        }
    }

    public class MessageViewModel : ObservableModel
    {
        public string Summary { get { return Get<string>(); } set { Set(value); } }
        public string Detail { get { return Get<string>(); } set { Set(value); } }

        public MessageViewModel()
        {
            Summary = "";
            Detail = "";
        }
    }
}
