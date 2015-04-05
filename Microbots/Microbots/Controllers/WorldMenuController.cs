using Microbots.View.ViewModels;

namespace Microbots.View.Controllers
{
    public interface ILevelSelectController
    {
    }

    public class LevelSelectController : ILevelSelectController
    {
        private LevelSelectViewModel _levelSelectViewModel;

        public LevelSelectController(LevelSelectViewModel levelSelectViewModel)
        {
            _levelSelectViewModel = levelSelectViewModel;
        }
    }
}
