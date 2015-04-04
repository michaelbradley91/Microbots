using System;
using Microbots.Models.Exceptions;
using Microbots.View.Controllers;
using Microbots.View.ViewModels;

namespace Microbots.View.ExceptionHandlers
{
    abstract class MicrobotsExceptionHandler
    {
        private readonly IMessagesCollectionController _messagesCollectionController;
        private readonly IErrorMessagesController _errorMessagesController;

        protected MicrobotsExceptionHandler(ErrorMessagesController errorMessagesController, MessagesCollectionController messagesCollectionController)
        {
            _errorMessagesController = errorMessagesController;
            _messagesCollectionController = messagesCollectionController;
        }

        public void HandleException(MicrobotsException microbotsException)
        {
            _errorMessagesController.AddMessage(new MessageViewModel
            {
                Detail = microbotsException.Detail,
                Summary = microbotsException.Summary
            });
            _messagesCollectionController.ShowErrorMessages();
        }

        public void Handle(Action action)
        {
            try
            {
                action();
            }
            catch (MicrobotsException microbotsException)
            {
                HandleException(microbotsException);
            }
        }
    }
}
