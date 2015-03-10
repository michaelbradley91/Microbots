using System.Windows.Controls;
using Microbots.Helpers;

namespace Microbots.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow(RunMenuView runMenuView)
        {
            InitializeComponent();
            var border = this.FindByName<Border>("RunMenu");
            border.Child = runMenuView;
        }
    }
}
