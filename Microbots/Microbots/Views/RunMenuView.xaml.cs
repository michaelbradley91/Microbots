using System.Windows;
using Microbots.Controllers;

namespace Microbots.Views
{
    public partial class RunMenuView
    {
        private IRunMenuController RunMenuController { get; set; }

        public RunMenuView(IRunMenuController runMenuController)
        {
            RunMenuController = runMenuController;
            InitializeComponent();
            DataContext = runMenuController.RunMenuViewModel;
        }

        private void StartMenuButtonClick(object sender, RoutedEventArgs e)
        {
            RunMenuController.Start();
        }

        private void PauseMenuButtonClick(object sender, RoutedEventArgs e)
        {
            RunMenuController.Pause();
        }

        private void StopMenuButtonClick(object sender, RoutedEventArgs e)
        {
            RunMenuController.Stop();
        }
    }
}
