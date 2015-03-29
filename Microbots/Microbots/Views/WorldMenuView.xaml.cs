using Microbots.View.Controllers;

namespace Microbots.View.Views
{
    public partial class WorldMenuView
    {
        private IWorldMenuController WorldMenuController { get; set; }

        public WorldMenuView(IWorldMenuController worldMenuController)
        {
            WorldMenuController = worldMenuController;
            InitializeComponent();
            DataContext = worldMenuController.WorldMenuViewModel;
        }
    }
}
