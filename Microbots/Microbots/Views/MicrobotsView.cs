using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using Microbots.Attributes;
using Microbots.Helpers;

namespace Microbots.Views
{
    public abstract class MicrobotsView : UserControl
    {
        protected void InitializePostConstructor()
        {
            GetType().GetMethod("InitializeComponent").Invoke(this, null);
            InitializeViewElements();
            InitializeStyles();
            InitializeListeners();
            RunInitializationMethods();
        }

        private void InitializeViewElements()
        {
            foreach (var field in GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                var viewElementAttribute = (ControlElementAttribute)Attribute.GetCustomAttribute(field, typeof(ControlElementAttribute));
                if (viewElementAttribute != null) field.SetValue(this, this.FindByName<Grid>(viewElementAttribute.Name));
            }
        }

        private void InitializeStyles()
        {
            foreach (var field in GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                var viewStyleAttribute = (StyleElementAttribute)Attribute.GetCustomAttribute(field, typeof(StyleElementAttribute));
                if (viewStyleAttribute == null) continue;
                field.SetValue(this, FindResource(viewStyleAttribute.Key) as Style);
            }
        }

        public void InitializeListeners()
        {
            foreach (var field in GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                var viewStyleAttribute = (AutoListenerAttribute)Attribute.GetCustomAttribute(field, typeof(AutoListenerAttribute));
                if (viewStyleAttribute == null) continue;
                var autoListener = (AutoListener) field.GetValue(this);
                autoListener.Setup(this);
            }
        }

        public void RunInitializationMethods()
        {
            foreach (var method in GetType().GetMethods(BindingFlags.NonPublic | BindingFlags.Instance).Where(m => Attribute.GetCustomAttribute(m, typeof(InitializationMethodAttribute)) != null))
            {
                if (method.GetParameters().Count() != 0) throw new InvalidCastException("Cannot run initialization method " + method.Name + " which requires more than one parameter.");
                method.Invoke(this, null);
            }
        }
    }
}
