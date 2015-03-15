namespace Microbots.Views
{
    public partial class MainWindow
    {
        public MainWindow(
            RunMenuView runMenuView, 
            WorldMenuView worldMenuView,
            WorldView worldView,
            ExceptionsView exceptionsView)
        {
            InitializeComponent();
            RunMenu.Child = runMenuView;
            WorldMenu.Child = worldMenuView;
            World.Child = worldView;
            Exceptions.Child = exceptionsView;
        }
    }
}
