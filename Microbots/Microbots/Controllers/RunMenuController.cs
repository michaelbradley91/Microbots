using System;
using System.Diagnostics;
using Microbots.Models.Exceptions;
using Microbots.View.ViewModels;
using Microbots.View.ViewModels.Helpers;

namespace Microbots.View.Controllers
{
    public interface IRunMenuController
    {
        void StartPlayingForwards();
        void StopPlayingForwards();
        void StartPlayingBackwards();
        void StopPlayingBackwards();
    }

    public class RunMenuController : IRunMenuController
    {
        private readonly RunMenuViewModel _runMenuViewModel;

        public RunMenuController(RunMenuViewModel runMenuViewModel)
        {
            _runMenuViewModel = runMenuViewModel;
            _runMenuViewModel.AddChangeHandler(ForwardsSpeedChanged, rvm => rvm.PlayForwardsSpeed);
            _runMenuViewModel.AddChangeHandler(BackwardsSpeedChanged, rvm => rvm.PlayBackwardsSpeed);
        }

        public void StartPlayingForwards()
        {
            Debug.WriteLine("Start playing forwards");
        }

        public void StopPlayingForwards()
        {
            Debug.WriteLine("Stop playing forwards");
        }

        public void StartPlayingBackwards()
        {
            Debug.WriteLine("Start playing backwards");
        }

        public void StopPlayingBackwards()
        {
            Debug.WriteLine("Stop playing backwards");
        }

        private void ForwardsSpeedChanged()
        {
            Debug.WriteLine("Forwards Speed is now " + _runMenuViewModel.PlayForwardsSpeed);
        }

        private void BackwardsSpeedChanged()
        {
            Debug.WriteLine("Backwards Speed is now " + _runMenuViewModel.PlayBackwardsSpeed);
        }
    }
}
