using Microbots.View.Controllers;

namespace Microbots.View.ExceptionHandlers
{
    class RunMenuExceptionHandler : MicrobotsExceptionHandler, IRunMenuController
    {
        private readonly IRunMenuController _runMenuController;

        public RunMenuExceptionHandler(RunMenuController runMenuController, ErrorMessagesController errorMessagesController, MessagesCollectionController messagesCollectionController)
            : base(errorMessagesController, messagesCollectionController)
        {
            _runMenuController = runMenuController;
        }

        public void StartPlayingForwards()
        {
            Handle(_runMenuController.StartPlayingForwards);
        }

        public void StopPlayingForwards()
        {
            Handle(_runMenuController.StopPlayingForwards);
        }

        public void StartPlayingBackwards()
        {
            Handle(_runMenuController.StartPlayingBackwards);
        }

        public void StopPlayingBackwards()
        {
            Handle(_runMenuController.StopPlayingBackwards);
        }
    }
}
