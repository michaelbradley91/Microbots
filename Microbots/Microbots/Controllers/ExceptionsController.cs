using Microbots.ViewModels;

namespace Microbots.Controllers
{
    public interface IExceptionsController
    {
        void ClearExceptions();
    }

    public class ExceptionsController : IExceptionsController
    {
        private readonly IStartController _startController;
        private readonly ExceptionsViewModel _exceptionsViewModel;

        public ExceptionsController(ExceptionsViewModel exceptionsViewModel, IStartController startController)
        {
            _startController = startController;
            _exceptionsViewModel = exceptionsViewModel;
        }

        public void ClearExceptions()
        {
            _startController.HideExceptions();
        }

        public void AddException(ExceptionViewModel exceptionViewModel)
        {
            
        }
    }
}
