using System.Windows.Media;
using Microbots.ViewModels.Helpers;

namespace Microbots.ViewModels
{
    public class WorldSquareViewModel : ObservableModel
    {
        public WorldSquareViewModel()
        {
            Colour = Brushes.Yellow;
        }

        public SolidColorBrush Colour { get { return Get<SolidColorBrush>(); } set { Set(value); } }
    }
}