using System.Windows;
using Microbots.ViewModels.Helpers;

namespace Microbots.ViewModels
{
    public class MessagesCollectionViewModel : ObservableModel
    {
        public Visibility ErrorMessagesVisibility { get { return Get<Visibility>(); } set { Set(value); } }
        public Visibility InfoMessagesVisibility { get { return Get<Visibility>(); } set { Set(value); } }
        public Visibility SuccessMessagesVisibility { get { return Get<Visibility>(); } set { Set(value); } }

        public MessagesCollectionViewModel()
        {
            ErrorMessagesVisibility = Visibility.Visible;
            InfoMessagesVisibility = Visibility.Visible;
            SuccessMessagesVisibility = Visibility.Visible;
        }
    }
}
