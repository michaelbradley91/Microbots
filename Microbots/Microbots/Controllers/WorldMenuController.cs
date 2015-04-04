using Microbots.View.ViewModels;

namespace Microbots.View.Controllers
{
    public interface IWorldMenuController
    {
    }

    public class WorldMenuController : IWorldMenuController
    {
        private WorldMenuViewModel _worldMenuViewModel;

        public WorldMenuController(WorldMenuViewModel worldMenuViewModel)
        {
            _worldMenuViewModel = worldMenuViewModel;
        }
    }
}
