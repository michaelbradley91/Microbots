namespace Microbots.View.Views.TestYourMicrobots
{
    public partial class TestYourMicrobotsView
    {
        public TestYourMicrobotsView(RunMenuView runMenuView, LevelSelectView levelSelectView, LevelView levelView)
        {
            InitializeComponent();

            RunMenu.Child = runMenuView;
            LevelMenu.Child = levelSelectView;
            Level.Child = levelView;
        }
    }
}
