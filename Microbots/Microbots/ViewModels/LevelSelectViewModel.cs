using System.Collections.ObjectModel;
using Microbots.View.ViewModels.Helpers;

namespace Microbots.View.ViewModels
{
    public class LevelSelectViewModel : ObservableModel
    {
        public ObservableCollection<LevelDescriptionViewModel> Levels { get { return Get<ObservableCollection<LevelDescriptionViewModel>>(); } set { Set(value); } }
        public LevelDescriptionViewModel SelectedLevel { get { return Get<LevelDescriptionViewModel>(); } set { Set(value); } }

        public LevelSelectViewModel()
        {
            Levels = new ObservableCollection<LevelDescriptionViewModel>();
        }
    }
}
