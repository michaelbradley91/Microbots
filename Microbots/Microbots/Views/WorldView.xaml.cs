using System.Windows.Controls;
using Microbots.Controllers;

namespace Microbots.Views
{
    public partial class WorldView : UserControl
    {
        private IWorldController WorldController { get; set; }

        public WorldView(IWorldController worldController)
        {
            WorldController = worldController;
            InitializeComponent();
            DataContext = worldController.WorldViewModel;
        }
    }
}
