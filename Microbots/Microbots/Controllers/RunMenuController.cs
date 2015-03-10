using Microbots.ViewModels;

namespace Microbots.Controllers
{
    public interface IRunMenuController
    {
        RunMenuViewModel RunMenuViewModel { get; }
        void Start();
        void Pause();
        void Stop();
    }

    public class RunMenuController : IRunMenuController
    {
        public RunMenuViewModel RunMenuViewModel { get; private set; }

        public RunMenuController(RunMenuViewModel runMenuViewModel)
        {
            RunMenuViewModel = runMenuViewModel;
        }

        public void Start()
        {
            RunMenuViewModel.IsPauseButtonEnabled = true;
            RunMenuViewModel.IsStopButtonEnabled = true;
            RunMenuViewModel.IsStartButtonEnabled = false;
        }

        public void Pause()
        {
            RunMenuViewModel.IsPauseButtonEnabled = false;
            RunMenuViewModel.IsStopButtonEnabled = true;
            RunMenuViewModel.IsStartButtonEnabled = false;
        }

        public void Stop()
        {
            RunMenuViewModel.IsPauseButtonEnabled = false;
            RunMenuViewModel.IsStopButtonEnabled = false;
            RunMenuViewModel.IsStartButtonEnabled = true;
        }
    }
}
