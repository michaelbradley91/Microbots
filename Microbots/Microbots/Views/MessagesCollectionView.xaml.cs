using Microbots.ViewModels;

namespace Microbots.Views
{
    public partial class MessagesCollectionView
    {
        public MessagesCollectionView(ErrorMessagesView errorMessagesView, InfoMessagesView infoMessagesView, SuccessMessagesView successMessagesView, MessagesCollectionViewModel messagesCollectionViewModel)
        {
            InitializeComponent();
            
            ErrorMessages.Child = errorMessagesView;
            InfoMessages.Child = infoMessagesView;
            SuccessMessages.Child = successMessagesView;

            DataContext = messagesCollectionViewModel;
        }
    }
}
