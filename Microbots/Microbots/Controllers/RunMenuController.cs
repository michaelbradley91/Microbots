using System.Windows.Media;
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
        public IWorldController WorldController { get; set; }

        public RunMenuController(RunMenuViewModel runMenuViewModel, IWorldController worldController)
        {
            RunMenuViewModel = runMenuViewModel;
            WorldController = worldController;
        }

        public void Start()
        {
            RunMenuViewModel.IsPauseButtonEnabled = true;
            RunMenuViewModel.IsStopButtonEnabled = true;
            RunMenuViewModel.IsStartButtonEnabled = false;
            WorldController.WorldViewModel.WorldSquares = WorldViewModel.CreateWorldSquares(5, 5);
            foreach (var square in WorldController.WorldViewModel.WorldSquares)
            {
                square.Colour = Brushes.Red;
            }
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
            WorldController.WorldViewModel.WorldSquares = WorldViewModel.CreateWorldSquares(3, 3);
            foreach (var square in WorldController.WorldViewModel.WorldSquares)
            {
                square.Colour = Brushes.Green;
            }
        }
    }
}
