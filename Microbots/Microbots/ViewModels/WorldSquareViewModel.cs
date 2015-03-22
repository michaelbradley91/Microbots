using System.Windows.Media;
using Microbots.ViewModels.Helpers;

namespace Microbots.ViewModels
{
    public class WorldSquareViewModel : ObservableModel
    {
        public Brush Colour { get { return Get<Brush>(); } set { Set(value); } }

        public WorldSquareViewModel()
        {
            Colour = Brushes.Yellow;
        }
    }
}