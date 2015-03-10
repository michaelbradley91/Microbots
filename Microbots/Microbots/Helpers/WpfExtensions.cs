using System.Runtime.InteropServices.ComTypes;
using System.Windows;

namespace Microbots.Helpers
{
    internal static class WpfExtensions
    {
        public static T FindByName<T>(this FrameworkElement frameworkElement, string name)
        {
            return (T)frameworkElement.FindName(name);
        }
    }
}
