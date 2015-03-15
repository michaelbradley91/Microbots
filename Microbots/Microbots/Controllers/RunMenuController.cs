using System.Windows.Media;
using Microbots.ViewModels;

namespace Microbots.Controllers
{
    public interface IRunMenuController
    {
        void Start();
        void Pause();
        void Stop();
    }

    public class RunMenuController : IRunMenuController
    {
        private readonly RunMenuViewModel _runMenuViewModel;
        private readonly WorldViewModel _worldViewModel; 

        public RunMenuController(RunMenuViewModel runMenuViewModel, WorldViewModel worldViewModel)
        {
            _runMenuViewModel = runMenuViewModel;
            _worldViewModel = worldViewModel;
        }

        public void Start()
        {
            _runMenuViewModel.IsPauseButtonEnabled = true;
            _runMenuViewModel.IsStopButtonEnabled = true;
            _runMenuViewModel.IsStartButtonEnabled = false;
            _worldViewModel.WorldSquares = WorldViewModel.CreateWorldSquares(5, 5);
            foreach (var square in _worldViewModel.WorldSquares)
            {
                square.Colour = Brushes.Red;
            }
        }

        public void Pause()
        {
            _runMenuViewModel.IsPauseButtonEnabled = false;
            _runMenuViewModel.IsStopButtonEnabled = true;
            _runMenuViewModel.IsStartButtonEnabled = false;
        }

        public void Stop()
        {
            _runMenuViewModel.IsPauseButtonEnabled = false;
            _runMenuViewModel.IsStopButtonEnabled = false;
            _runMenuViewModel.IsStartButtonEnabled = true;
            _worldViewModel.WorldSquares = WorldViewModel.CreateWorldSquares(3, 3);
            foreach (var square in _worldViewModel.WorldSquares)
            {
                square.Colour = Brushes.Green;
            }
        }
    }
}
