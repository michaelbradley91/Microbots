using System.Windows;
using Microbots.View.Controllers;
using Microbots.View.ViewModels;

namespace Microbots.View.Views
{
    public partial class RunMenuView
    {
        private IRunMenuController RunMenuController { get; set; }

        public RunMenuView(IRunMenuController runMenuController, RunMenuViewModel runMenuViewModel)
        {
            RunMenuController = runMenuController;
            InitializeComponent();
            DataContext = runMenuViewModel;
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

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
