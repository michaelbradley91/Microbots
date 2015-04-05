using Microbots.View.Controllers;
using Microbots.View.ViewModels;
using Microbots.View.ViewModels.Helpers;

namespace Microbots.View.Views.TestYourMicrobots
{
    public partial class RunMenuView
    {
        private readonly IRunMenuController _runMenuController;
        private readonly RunMenuViewModel _runMenuViewModel;

        public RunMenuView(IRunMenuController runMenuController, RunMenuViewModel runMenuViewModel)
        {
            _runMenuController = runMenuController;
            _runMenuViewModel = runMenuViewModel;
            InitializeComponent();
            DataContext = runMenuViewModel;

            _runMenuViewModel.AddChangeHandler(TogglePlayForwardsChanged, rvm => rvm.IsPlayForwardsPressed);
            _runMenuViewModel.AddChangeHandler(TogglePlayBackwardsChanged, rvm => rvm.IsPlayBackwardsPressed);
        }

        private void TogglePlayForwardsChanged()
        {
            if (_runMenuViewModel.IsPlayForwardsPressed)
            {
                _runMenuController.StartPlayingForwards();
            }
            else
            {
                _runMenuController.StopPlayingForwards();
            }
        }

        private void TogglePlayBackwardsChanged()
        {
            if (_runMenuViewModel.IsPlayBackwardsPressed)
            {
                _runMenuController.StartPlayingBackwards();
            }
            else
            {
                _runMenuController.StopPlayingBackwards();
            }
        }
    }
}
