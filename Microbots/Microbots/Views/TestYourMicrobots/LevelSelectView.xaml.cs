using Microbots.View.Controllers;
using Microbots.View.ViewModels;

namespace Microbots.View.Views.TestYourMicrobots
{
    public partial class LevelSelectView
    {
        private ILevelSelectController LevelSelectController { get; set; }

        public LevelSelectView(ILevelSelectController levelSelectController, LevelSelectViewModel levelSelectViewModel)
        {
            LevelSelectController = levelSelectController;
            InitializeComponent();
            DataContext = levelSelectViewModel;
        }
    }
}
