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
            Bind<IRunMenuController>().To<RunMenuController>().InSingletonScope();
            Bind<IWorldMenuController>().To<WorldMenuController>().InSingletonScope();
            Bind<IWorldController>().To<WorldController>().InSingletonScope();
        }

        public void LoadViewModels()
        {
            Bind<RunMenuViewModel>().ToSelf().InSingletonScope();
            Bind<WorldMenuViewModel>().ToSelf().InSingletonScope();
            Bind<WorldViewModel>().ToSelf().InSingletonScope();
        }

        public void LoadViews()
        {
            Bind<RunMenuView>().ToSelf().InSingletonScope();
            Bind<WorldMenuView>().ToSelf().InSingletonScope();
            Bind<WorldView>().ToSelf().InSingletonScope();
        }
    }
}
