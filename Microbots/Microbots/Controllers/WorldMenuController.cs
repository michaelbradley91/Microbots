using Microbots.ViewModels;

namespace Microbots.Controllers
{
    public interface IWorldMenuController
    {
        WorldMenuViewModel WorldMenuViewModel { get; }
    }

    public class WorldMenuController : IWorldMenuController
    {
        public WorldMenuViewModel WorldMenuViewModel { get; private set; }

        public WorldMenuController(WorldMenuViewModel worldMenuViewModel)
        {
            WorldMenuViewModel = worldMenuViewModel;
        }
    }
}
