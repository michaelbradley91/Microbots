using Microbots.Controllers;
using Microbots.ViewModels;
using Microbots.Views;
using Ninject.Modules;

namespace Microbots.Ninject
{
    class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            LoadControllers();
            LoadViewModels();
            LoadViews();
        }

        public void LoadControllers()
        {
            Bind<IRunMenuController>().To<RunMenuController>().InTransientScope();
        }

        public void LoadViewModels()
        {
            Bind<RunMenuViewModel>().To<RunMenuViewModel>().InTransientScope();
        }

        public void LoadViews()
        {
            Bind<RunMenuView>().To<RunMenuView>().InTransientScope();
        }
    }
}
