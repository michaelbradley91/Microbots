using System.Windows.Media;
using Microbots.View.ViewModels.Helpers;

namespace Microbots.View.ViewModels
{
    public class LevelSquareViewModel : ObservableModel
    {
        //TODO: make this an enum converter. Colours are strictly a part of the view.
        public Brush Colour { get { return Get<Brush>(); } set { Set(value); } }

        public LevelSquareViewModel()
        {
            Colour = Brushes.Yellow;
        }
    }
}