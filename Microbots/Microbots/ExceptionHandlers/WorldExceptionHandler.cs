using Microbots.View.Controllers;

namespace Microbots.View.ExceptionHandlers
{
    class WorldExceptionHandler : MicrobotsExceptionHandler, IWorldController
    {
        private readonly IWorldController _worldController;

        public WorldExceptionHandler(WorldController worldController, ErrorMessagesController errorMessagesController, MessagesCollectionController messagesCollectionController) 
            : base(errorMessagesController, messagesCollectionController)
        {
            _worldController = worldController;
        }
    }
}
