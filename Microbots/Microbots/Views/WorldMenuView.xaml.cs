using Microbots.View.Controllers;
using Microbots.View.ViewModels;

namespace Microbots.View.Views
{
    public partial class WorldMenuView
    {
        private IWorldMenuController WorldMenuController { get; set; }

        public WorldMenuView(IWorldMenuController worldMenuController, WorldMenuViewModel worldMenuViewModel)
        {
            WorldMenuController = worldMenuController;
            InitializeComponent();
            DataContext = worldMenuViewModel;
        }
    }
}
