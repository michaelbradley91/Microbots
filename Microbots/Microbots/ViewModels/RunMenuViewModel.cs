using System.Windows;
using Microbots.Extensions;

namespace Microbots.ViewModels
{
    public class RunMenuViewModel : DependencyObject
    {
        public RunMenuViewModel()
        {
            IsStartButtonEnabled = true;
            IsStopButtonEnabled = false;
            IsPauseButtonEnabled = false;
        }

        public bool IsStartButtonEnabled {
            get { return this.GetDependencyValue(s => s.IsStartButtonEnabled); }
            set { this.SetDependencyValue(value, () => IsStartButtonEnabled = value); } 
        }

        public bool IsPauseButtonEnabled
        {
            get { return this.GetDependencyValue(s => s.IsPauseButtonEnabled); }
            set { this.SetDependencyValue(value, () => IsPauseButtonEnabled = value); }
        }

        public bool IsStopButtonEnabled
        {
            get { return this.GetDependencyValue(s => s.IsStopButtonEnabled); }
            set { this.SetDependencyValue(value, () => IsStopButtonEnabled = value); }
        }
    }
}
