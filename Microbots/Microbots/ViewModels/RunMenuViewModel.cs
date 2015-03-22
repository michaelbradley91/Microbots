using Microbots.ViewModels.Helpers;

namespace Microbots.ViewModels
{
    public class RunMenuViewModel : ObservableModel
    {
        public bool IsStartButtonEnabled { get { return Get<bool>(); } set { Set(value); } }
        public bool IsPauseButtonEnabled { get { return Get<bool>(); } set { Set(value); } }
        public bool IsStopButtonEnabled { get { return Get<bool>(); } set { Set(value); } }

        public RunMenuViewModel()
        {
            IsStartButtonEnabled = true;
            IsStopButtonEnabled = false;
            IsPauseButtonEnabled = false;
        }
    }
}
