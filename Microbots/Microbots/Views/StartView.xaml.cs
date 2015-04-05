using Microbots.View.Views.TestYourMicrobots;

namespace Microbots.View.Views
{
    public partial class StartView
    {
        public StartView(TestYourMicrobotsView testYourMicrobotsView, MessagesCollectionView messagesCollectionView)
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();

            TestYourMicrobots.Child = testYourMicrobotsView;
            Messages.Child = messagesCollectionView;
        }
    }
}
