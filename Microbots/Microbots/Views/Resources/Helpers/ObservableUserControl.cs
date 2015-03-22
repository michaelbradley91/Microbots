using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using Microbots.Annotations;
using Microbots.Common.Helpers;

namespace Microbots.Views.Resources.Helpers
{
    public abstract class ObservableUserControl<TE> : UserControl, INotifyPropertyChanged where TE : class
    {
        private readonly Dictionary<string, ICollection<Action>> _actionsByProperty;
        private readonly Dictionary<string, object> _properties;

        protected ObservableUserControl()
        {
            _properties = new Dictionary<string, object>();
            _actionsByProperty = new Dictionary<string, ICollection<Action>>();
            PropertyChanged += PropertyChangedForwarder;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public void AddChangeHandler(Action action, string propertyName, bool invokeNow = false)
        {
            if (!_actionsByProperty.ContainsKey(propertyName)) _actionsByProperty.Add(propertyName, new Collection<Action>());
            _actionsByProperty[propertyName].Add(action);
            if (invokeNow) action.Invoke();
        }

        public void RemoveChangeHandler(Action action, string propertyName)
        {
            if (!_actionsByProperty.ContainsKey(propertyName)) return;
            if (!_actionsByProperty[propertyName].Contains(action)) return;
            _actionsByProperty[propertyName].Remove(action);
        }

        private void PropertyChangedForwarder(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            if (!_actionsByProperty.ContainsKey(propertyChangedEventArgs.PropertyName)) return;
            var actionsToInvoke = _actionsByProperty[propertyChangedEventArgs.PropertyName];
            foreach (var action in actionsToInvoke) action.Invoke();
        }

        [NotifyPropertyChangedInvocator]
        protected T Get<T>([CallerMemberName] string name = null)
        {
            Debug.Assert(name != null, "name != null");
            if (!_properties.ContainsKey(name)) return default(T);
            return (T)_properties[name];
        }

        
        protected void Set<T>(T value, [CallerMemberName] string name = null)
        {
            Debug.Assert(name != null, "name != null");
            if (Equals(value, Get<T>(name))) return;
            _properties[name] = value;
            OnPropertyChanged(name);
        }

        public static readonly DependencyProperty EventHandlerProperty = DependencyProperty.Register
            (
                 "EventHandler",
                 typeof(TE),
                 typeof(ObservableUserControl<TE>),
                 new PropertyMetadata(null)
            );

        public TE EventHandler
        {
            get { return (TE)GetValue(EventHandlerProperty); }
            set { SetValue(EventHandlerProperty, value); }
        }
    }

    public static class ObservableModelExtensions
    {
        public static void AddChangeHandler<T, TE>(this T observableModel, Action action, Expression<Func<T, object>> property, bool invokeNow = false)
            where T : ObservableUserControl<TE> where TE : class
        {
            observableModel.AddChangeHandler(action, ReflectionHelper.GetPropertyName(property), invokeNow);
        }

        public static void RemoveChangeHandler<T, TE>(this T observableModel, Action action, Expression<Func<T, object>> property)
            where T : ObservableUserControl<TE> where TE : class
        {
            observableModel.RemoveChangeHandler(action, ReflectionHelper.GetPropertyName(property));
        }
    }
}
