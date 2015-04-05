using Microbots.View.ViewModels.Helpers;

namespace Microbots.View.ViewModels
{
    public class LevelDescriptionViewModel : ObservableModel
    {
        public string Name { get { return Get<string>(); } set { Set(value); } }

        public LevelDescriptionViewModel()
        {
            Name = "";
        }
    }
}
