using Microbots.ViewModels;

namespace Microbots.Views
{
    public partial class StartView
    {
        public StartView(
            RunMenuView runMenuView, 
            WorldMenuView worldMenuView,
            WorldView worldView,
            ExceptionsView exceptionsView,
            MessagesView messagesView,
            StartViewModel startViewModel)
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();

            RunMenu.Child = runMenuView;
            WorldMenu.Child = worldMenuView;
            World.Child = worldView;
            Exceptions.Child = exceptionsView;
            Messages.Child = messagesView;

            DataContext = startViewModel;
        }
    }
}
