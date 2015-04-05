using Microbots.View.ViewModels;

namespace Microbots.View.Controllers
{
    public interface ILevelController { }

    public class LevelController : ILevelController
    {
        private readonly LevelViewModel _levelViewModel;

        public LevelController(LevelViewModel levelViewModel)
        {
            _levelViewModel = levelViewModel;
            _levelViewModel.LevelSquares = LevelViewModel.CreateLevelSquares(10, 10);
        }
    }
}
