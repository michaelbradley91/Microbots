using Microbots.View.ViewModels;

namespace Microbots.View.Views
{
    public partial class StartView
    {
        public StartView(RunMenuView runMenuView, WorldMenuView worldMenuView, WorldView worldView, MessagesCollectionView messagesCollectionView, StartViewModel startViewModel)
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();

            RunMenu.Child = runMenuView;
            WorldMenu.Child = worldMenuView;
            World.Child = worldView;
            Messages.Child = messagesCollectionView;

            DataContext = startViewModel;
        }
    }
}
