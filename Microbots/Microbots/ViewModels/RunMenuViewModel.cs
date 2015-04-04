using Microbots.View.ViewModels.Helpers;

namespace Microbots.View.ViewModels
{
    public class RunMenuViewModel : ObservableModel
    {
        public const int MaxSliderValue = 1;
        public const int MinSliderValue = 0;

        public bool IsPlayForwardsPressed { get { return Get<bool>(); } set { Set(value); } }
        public bool IsPlayBackwardsPressed { get { return Get<bool>(); } set { Set(value); } }

        public bool IsPlayForwardsEnabled { get { return Get<bool>(); } set { Set(value); } }
        public bool IsPlayBackwardsEnabled { get { return Get<bool>(); } set { Set(value); } }
        public bool IsPauseEnabled { get { return Get<bool>(); } set { Set(value); } }

        public double PlayBackwardsSpeed { get { return Get<double>(); } set { Set(value); } }
        public double PlayForwardsSpeed { get { return Get<double>(); } set { Set(value); } }

        public RunMenuViewModel()
        {
            IsPlayForwardsPressed = false;
            IsPlayBackwardsPressed = false;

            IsPlayForwardsEnabled = true;
            IsPlayBackwardsEnabled = true;
            IsPauseEnabled = false;

            PlayBackwardsSpeed = 0;
            PlayForwardsSpeed = 0;
        }
    }
}
