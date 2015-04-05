using Microbots.View.Controllers;
using Microbots.View.ExceptionHandlers;
using Microbots.View.ViewModels;
using Microbots.View.Views;
using Microbots.View.Views.TestYourMicrobots;
using Ninject.Modules;

namespace Microbots.View.Ninject
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
            Bind<IRunMenuController>().To<RunMenuExceptionHandler>().InTransientScope();
            Bind<ILevelSelectController>().To<LevelSelectExceptionHandler>().InTransientScope();
            Bind<ILevelController>().To<LevelExceptionHandler>().InTransientScope();

            Bind<IErrorMessagesController>().To<ErrorMessagesController>().InTransientScope();
            Bind<IInfoMessagesController>().To<InfoMessagesController>().InTransientScope();
            Bind<ISuccessMessagesController>().To<SuccessMessagesController>().InTransientScope();
            Bind<IMessagesCollectionController>().To<MessagesCollectionController>().InTransientScope();
        }

        public void LoadViewModels()
        {
            Bind<RunMenuViewModel>().ToSelf().InSingletonScope();
            Bind<LevelSelectViewModel>().ToSelf().InSingletonScope();
            Bind<LevelViewModel>().ToSelf().InSingletonScope();
            Bind<ErrorMessagesViewModel>().ToSelf().InSingletonScope();
            Bind<InfoMessagesViewModel>().ToSelf().InSingletonScope();
            Bind<SuccessMessagesViewModel>().ToSelf().InSingletonScope();
            Bind<MessagesCollectionViewModel>().ToSelf().InSingletonScope();
        }

        public void LoadViews()
        {
            Bind<StartView>().ToSelf().InTransientScope();
            Bind<TestYourMicrobotsView>().ToSelf().InTransientScope();
            Bind<RunMenuView>().ToSelf().InTransientScope();
            Bind<LevelSelectView>().ToSelf().InTransientScope();
            Bind<LevelView>().ToSelf().InTransientScope();
            Bind<ErrorMessagesView>().ToSelf().InTransientScope();
            Bind<InfoMessagesView>().ToSelf().InTransientScope();
            Bind<SuccessMessagesView>().ToSelf().InTransientScope();
            Bind<MessagesCollectionView>().ToSelf().InTransientScope();
        }
    }
}
