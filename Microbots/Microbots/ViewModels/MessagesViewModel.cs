using System.Collections.ObjectModel;
using Microbots.Helpers;

namespace Microbots.ViewModels
{
    public class MessagesViewModel : ObservableModel
    {
        public MessagesViewModel()
        {
            Messages = new ObservableCollection<MessageViewModel>();
        }

        public ObservableCollection<MessageViewModel> Messages { get { return Get<ObservableCollection<MessageViewModel>>(); } set { Set(value); } }
    }

    public class MessageViewModel : ObservableModel
    {
        public MessageViewModel()
        {
            Summary = "";
            Detail = "";
        }

        public string Summary { get { return Get<string>(); } set { Set(value);} }
        public string Detail { get { return Get<string>(); } set {Set(value);} }
    }
}
