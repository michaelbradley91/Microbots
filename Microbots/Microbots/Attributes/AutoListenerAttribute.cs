using System;
using System.ComponentModel;
using System.Linq.Expressions;
using Microbots.Helpers;

namespace Microbots.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    class AutoListenerAttribute : Attribute
    {
    }

    public class PropertyChangedListener<T> : AutoListener
    {
        public Func<T, PropertyListenerInfo> PropertyListenerInfo { get; set; }

        public PropertyChangedListener(Func<T, PropertyListenerInfo> propertyListenerInfo)
        {
            PropertyListenerInfo = propertyListenerInfo;
        }

        private T Instance { get; set; }

        public override void Setup(object instance)
        {
            Instance = (T)instance;
            PropertyListenerInfo(Instance).ChangeNotifier.PropertyChanged += PropertyChangedForwarder;
        }

        public void PropertyChangedForwarder(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            if (propertyChangedEventArgs.PropertyName != PropertyListenerInfo(Instance).PropertyName) return;
            PropertyListenerInfo(Instance).Action.Invoke();
        }
    }

    public class PropertyListenerInfo
    {
        public INotifyPropertyChanged ChangeNotifier { get; set; }
        public Action Action { get; set; }
        public string PropertyName { get; set; }

        public PropertyListenerInfo(Action action, INotifyPropertyChanged changeNotifier, Expression<Func<object>> property)
        {
            ChangeNotifier = changeNotifier;
            Action = action;
            PropertyName = ReflectionHelper.GetPropertyName(property);
        }
    }

    public abstract class AutoListener
    {
        public abstract void Setup(object instance);
    }
}
