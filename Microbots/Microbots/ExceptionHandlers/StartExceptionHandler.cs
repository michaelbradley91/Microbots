using Microbots.View.Controllers;

namespace Microbots.View.ExceptionHandlers
{
    class StartExceptionHandler : MicrobotsExceptionHandler, IStartController
    {
        private readonly IStartController _startController;

        public StartExceptionHandler(StartController startController, ErrorMessagesController errorMessagesController, MessagesCollectionController messagesCollectionController)
            : base(errorMessagesController, messagesCollectionController)
        {
            _startController = startController;
        }
    }
}
