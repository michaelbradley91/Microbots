using System.Windows.Media;
using Microbots.Helpers;

namespace Microbots.ViewModels
{
    public class WorldSquareViewModel : Bindable
    {
        public WorldSquareViewModel()
        {
            Colour = Brushes.Yellow;
        }

        public SolidColorBrush Colour { get { return Get<SolidColorBrush>(); } set { Set(value); } }
    }
}