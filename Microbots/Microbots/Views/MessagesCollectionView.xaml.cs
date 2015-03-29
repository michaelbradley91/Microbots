using Microbots.View.ViewModels;

namespace Microbots.View.Views
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
