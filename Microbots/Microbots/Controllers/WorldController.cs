using Microbots.ViewModels;

namespace Microbots.Controllers
{
    public interface IWorldController
    {
        WorldViewModel WorldViewModel { get; }
    }

    public class WorldController : IWorldController
    {
        public WorldViewModel WorldViewModel { get; private set; }

        public WorldController(WorldViewModel worldViewModel)
        {
            WorldViewModel = worldViewModel;
            WorldViewModel.WorldSquares = WorldViewModel.CreateWorldSquares(3, 3);
        }
    }
}
