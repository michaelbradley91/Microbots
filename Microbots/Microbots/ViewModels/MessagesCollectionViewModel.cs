using System.Windows;
using Microbots.View.ViewModels.Helpers;

namespace Microbots.View.ViewModels
{
    public class MessagesCollectionViewModel : ObservableModel
    {
        public Visibility ErrorMessagesVisibility { get { return Get<Visibility>(); } set { Set(value); } }
        public Visibility InfoMessagesVisibility { get { return Get<Visibility>(); } set { Set(value); } }
        public Visibility SuccessMessagesVisibility { get { return Get<Visibility>(); } set { Set(value); } }

        public MessagesCollectionViewModel()
        {
            ErrorMessagesVisibility = Visibility.Collapsed;
            InfoMessagesVisibility = Visibility.Collapsed;
            SuccessMessagesVisibility = Visibility.Collapsed;
        }
    }
}
