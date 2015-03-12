using Microbots.Helpers;

namespace Microbots.ViewModels
{
    public class RunMenuViewModel : Bindable
    {
        public RunMenuViewModel()
        {
            IsStartButtonEnabled = true;
            IsStopButtonEnabled = false;
            IsPauseButtonEnabled = false;
        }

        public bool IsStartButtonEnabled { get { return Get<bool>(); } set { Set(value); } }
        public bool IsPauseButtonEnabled { get { return Get<bool>(); } set { Set(value); } }
        public bool IsStopButtonEnabled { get { return Get<bool>(); } set { Set(value); } }
    }
}
