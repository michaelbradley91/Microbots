using System.Windows;
using Microbots.Ninject;
using Microbots.Views;
using Ninject;

namespace Microbots
{
    public partial class App
    {
        private IKernel _kernel;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ConfigureContainer();
            ComposeObjects();
            Current.MainWindow.Show();
        }

        private void ConfigureContainer()
        {
            _kernel = new StandardKernel();
            _kernel.Load(new ServiceModule());
        }

        private void ComposeObjects()
        {
            Current.MainWindow = _kernel.Get<MainWindow>();
        }
    }
}
