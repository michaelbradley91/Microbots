using System.Windows;

namespace Microbots.View.Extensions
{
    internal static class WpfExtensions
    {
        public static Style GetStyle(this FrameworkElement frameworkElement, string key)
        {
            return (Style)frameworkElement.FindResource(key);
        }

        public static T GetDataContext<T>(this object sender)
        {
            return (T)((FrameworkElement) sender).DataContext;
        }
    }
}
