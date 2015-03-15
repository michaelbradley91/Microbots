using System.Windows;

namespace Microbots.Extensions
{
    internal static class WpfExtensions
    {
        public static Style GetStyle(this FrameworkElement frameworkElement, string key)
        {
            return (Style)frameworkElement.FindResource(key);
        }
    }
}
