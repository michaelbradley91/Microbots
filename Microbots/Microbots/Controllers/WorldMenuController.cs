using Microbots.View.ViewModels;

namespace Microbots.View.Controllers
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
