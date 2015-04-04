using Microbots.View.Controllers;

namespace Microbots.View.ExceptionHandlers
{
    class WorldMenuExceptionHandler : MicrobotsExceptionHandler, IWorldMenuController
    {
        private readonly IWorldMenuController _worldMenuController;

        public WorldMenuExceptionHandler(WorldMenuController worldMenuController, ErrorMessagesController errorMessagesController, MessagesCollectionController messagesCollectionController) 
            : base(errorMessagesController, messagesCollectionController)
        {
            _worldMenuController = worldMenuController;
        }
    }
}
