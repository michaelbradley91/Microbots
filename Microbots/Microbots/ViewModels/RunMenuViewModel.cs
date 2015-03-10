using System;
using System.Windows;

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
            get { return (bool) GetValue(IsStartButtonEnabledProperty); }
            set { SetValue(IsStartButtonEnabledProperty, value); } 
        }

        public bool IsStopButtonEnabled
        {
            get { return (bool)GetValue(IsStopButtonEnabledProperty); }
            set { SetValue(IsStopButtonEnabledProperty, value); }
        }

        public bool IsPauseButtonEnabled
        {
            get { return (bool)GetValue(IsPauseButtonEnabledProperty); }
            set { SetValue(IsPauseButtonEnabledProperty, value); }
        }

        public static readonly DependencyProperty IsStartButtonEnabledProperty = DependencyProperty.Register(
            "IsStartButtonEnabled", typeof(Boolean), typeof(RunMenuViewModel), new PropertyMetadata(false));
        public static readonly DependencyProperty IsStopButtonEnabledProperty = DependencyProperty.Register(
            "IsStopButtonEnabled", typeof(Boolean), typeof(RunMenuViewModel), new PropertyMetadata(false));
        public static readonly DependencyProperty IsPauseButtonEnabledProperty = DependencyProperty.Register(
            "IsPauseButtonEnabled", typeof(Boolean), typeof(RunMenuViewModel), new PropertyMetadata(false));
    }
}
