using System.Windows.Controls;
using Microbots.Helpers;

namespace Microbots.Views
{
    public partial class MainWindow
    {
        public MainWindow(RunMenuView runMenuView, WorldMenuView worldMenuView, WorldView worldView)
        {
            InitializeComponent();
            this.FindByName<Border>("RunMenu").Child = runMenuView;
            this.FindByName<Border>("WorldMenu").Child = worldMenuView;
            this.FindByName<Border>("World").Child = worldView;
        }
    }
}
