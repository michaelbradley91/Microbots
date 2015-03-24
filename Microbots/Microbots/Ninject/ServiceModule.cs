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
            Bind<IStartController>().To<StartController>().InTransientScope();
            Bind<IRunMenuController>().To<RunMenuController>().InTransientScope();
            Bind<IWorldMenuController>().To<WorldMenuController>().InTransientScope();
            Bind<IWorldController>().To<WorldController>().InTransientScope();
            Bind<IErrorMessagesController>().To<ErrorMessagesController>().InTransientScope();
            Bind<IInfoMessagesController>().To<InfoMessagesController>().InTransientScope();
            Bind<ISuccessMessagesController>().To<SuccessMessagesController>().InTransientScope();
            Bind<IMessagesCollectionController>().To<MessagesCollectionController>().InTransientScope();
        }

        public void LoadViewModels()
        {
            Bind<StartViewModel>().ToSelf().InSingletonScope();
            Bind<RunMenuViewModel>().ToSelf().InSingletonScope();
            Bind<WorldMenuViewModel>().ToSelf().InSingletonScope();
            Bind<WorldViewModel>().ToSelf().InSingletonScope();
            Bind<ErrorMessagesViewModel>().ToSelf().InSingletonScope();
            Bind<InfoMessagesViewModel>().ToSelf().InSingletonScope();
            Bind<SuccessMessagesViewModel>().ToSelf().InSingletonScope();
            Bind<MessagesCollectionViewModel>().ToSelf().InSingletonScope();
        }

        public void LoadViews()
        {
            Bind<StartView>().ToSelf().InTransientScope();
            Bind<RunMenuView>().ToSelf().InTransientScope();
            Bind<WorldMenuView>().ToSelf().InTransientScope();
            Bind<WorldView>().ToSelf().InTransientScope();
            Bind<ErrorMessagesView>().ToSelf().InTransientScope();
            Bind<InfoMessagesView>().ToSelf().InTransientScope();
            Bind<SuccessMessagesView>().ToSelf().InTransientScope();
            Bind<MessagesCollectionView>().ToSelf().InTransientScope();
        }
    }
}
