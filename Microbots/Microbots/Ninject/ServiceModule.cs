using Microbots.Controllers;
using Microbots.ViewModels;
using Microbots.Views;
using Ninject.Modules;

namespace Microbots.Ninject
{
    public class ServiceModule : NinjectModule
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
            Bind<IWorldMenuController>().To<WorldMenuController>().InTransientScope();
            Bind<IWorldController>().To<WorldController>().InTransientScope();
        }

        public void LoadViewModels()
        {
            Bind<RunMenuViewModel>().ToSelf().InSingletonScope();
            Bind<WorldMenuViewModel>().ToSelf().InSingletonScope();
            Bind<WorldViewModel>().ToSelf().InSingletonScope();
        }

        public void LoadViews()
        {
            Bind<RunMenuView>().ToSelf().InTransientScope();
            Bind<WorldMenuView>().ToSelf().InTransientScope();
            Bind<WorldView>().ToSelf().InTransientScope();
            Bind<ExceptionsView>().ToSelf().InTransientScope();
        }
    }
}
