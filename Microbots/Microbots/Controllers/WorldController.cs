using Microbots.ViewModels;

namespace Microbots.Controllers
{
    public interface IWorldController { }

    public class WorldController : IWorldController
    {
        private readonly WorldViewModel _worldViewModel;

        public WorldController(WorldViewModel worldViewModel)
        {
            _worldViewModel = worldViewModel;
            _worldViewModel.WorldSquares = WorldViewModel.CreateWorldSquares(3, 3);
        }
    }
}
