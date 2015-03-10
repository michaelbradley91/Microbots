using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;

namespace Microbots.Extensions
{
    public static class DependencyPropertyExtensions
    {
        public static void SetDependencyValue<TSource, TProperty>(this TSource source, TProperty newValue, Action emptyAction)
            where TSource : DependencyObject
        {
            DependencyProperty dependencyProperty = GetDependencyProperty<TSource, TProperty>(emptyAction);
            source.SetValue(dependencyProperty, newValue);
        }

        public static TProperty GetDependencyValue<TSource, TProperty>(this TSource source, Func<TSource, TProperty> propertyExpression)
            where TSource : DependencyObject
        {
            var dependencyProperty = GetDependencyProperty<TSource, TProperty>(propertyExpression);
            return (TProperty)source.GetValue(dependencyProperty);
        }

        private static DependencyProperty GetDependencyProperty<TSource, TProperty>(Delegate emptyAction)
               where TSource : DependencyObject
        {
            var propertyName = GetPropertyName(emptyAction);
            var dependencyProperty = DependencyProperties<TSource>.Instance.Find(propertyName);
            if (dependencyProperty != null) return dependencyProperty;

            dependencyProperty = DependencyProperty.Register(propertyName, typeof(TProperty),
                typeof(TSource), new PropertyMetadata(default(TProperty)));

            DependencyProperties<TSource>.Instance.Add(propertyName, dependencyProperty);
            return dependencyProperty;
        }

        private static String GetPropertyName(Delegate emptyAction)
        {
            var methodName = emptyAction.Method.Name;
            var propertyName = methodName.Substring(5, methodName.LastIndexOf('>') - 5);

            return propertyName;
        }

        private interface IDependencyProperties
        {
            void Add(String name, DependencyProperty property);

            DependencyProperty Find(String name);
        }

        private class DependencyProperties<T> : IDependencyProperties
            where T : DependencyObject
        {

            #region Singleton

            /// <summary>
            /// Holds the singleton instance of the <see cref="DependencyProperties{T}"/>.
            /// </summary>
            private static DependencyProperties<T> _instance;

            /// <summary>
            /// Gets the singleton instance of the <see cref="DependencyProperties{T}"/>.
            /// </summary>
            public static DependencyProperties<T> Instance
            {
                get
                {
                    return _instance ?? (_instance = new DependencyProperties<T>());
                }
            }

            /// <summary>
            /// The private singleton constructor.
            /// </summary>
            private DependencyProperties()
            {
                Initialize();
            }

            #endregion Singleton

            // ReSharper disable once StaticMemberInGenericType
            private readonly static MethodInfo GetBaseDependencyPropertiesCacheInfo =
                new Func<Dictionary<String, DependencyProperty>>(GetBaseDependencyPropertiesCache<DependencyObject>).Method.GetGenericMethodDefinition();

            private static Dictionary<String, DependencyProperty> GetBaseDependencyPropertiesCache<TBase>()
             where TBase : DependencyObject
            {
                return DependencyProperties<TBase>.Instance._cache;
            }


            private readonly Dictionary<String, DependencyProperty> _cache = new Dictionary<string, DependencyProperty>();

            private readonly List<Dictionary<String, DependencyProperty>> _baseCaches = new List<Dictionary<String, DependencyProperty>>();

            private void Initialize()
            {
                var baseType = typeof(T).BaseType;
                while (baseType != null && baseType != typeof(DependencyObject))
                {
                    var getBaseDependencyPropertiesMethod = GetBaseDependencyPropertiesCacheInfo.MakeGenericMethod(baseType);
                    var baseCache = (Dictionary<String, DependencyProperty>)getBaseDependencyPropertiesMethod.Invoke(null, null);
                    _baseCaches.Add(baseCache);
                    baseType = baseType.BaseType;
                }
            }

            #region Implementation of IDependencyProperties

            public void Add(string name, DependencyProperty property)
            {
                var existingProperty = Find(name);
                if (existingProperty != null)
                {
                    throw new ArgumentException(String.Format(
                        "A dependency property with the name '{0}' does already exists.", name), "name");
                }

                _cache.Add(name, property);
            }

            public DependencyProperty Find(string name)
            {
                DependencyProperty result;

                _cache.TryGetValue(name, out result);

                if (result == null)
                {
                    foreach (var baseCache in _baseCaches)
                    {
                        baseCache.TryGetValue(name, out result);
                        if (result != null)
                        {
                            break;
                        }
                    }
                }

                return result;
            }

            #endregion
        }
    }
}
