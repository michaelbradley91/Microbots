using System.Windows;
using Microbots.Controllers;
using Microbots.Extensions;
using Microbots.ViewModels;
using Microbots.Views.Resources;
using Microbots.Views.Resources.Controls;

namespace Microbots.Views
{
    public partial class ExceptionsView : IMessagesEventHandler
    {
        private readonly IExceptionsController _exceptionsController;
        private readonly ExceptionsViewModel _exceptionsViewModel;

        public ExceptionsView(IExceptionsController exceptionsController, ExceptionsViewModel exceptionsViewModel)
        {
            _exceptionsController = exceptionsController;
            _exceptionsViewModel = exceptionsViewModel;

            InitializeComponent();
            DataContext = exceptionsViewModel;
        }

        public void ClearMessage(MessageViewModel exception)
        {
            //TODO: FIX THIS
//            _exceptionsViewModel.Exceptions.Remove(exception);
        }

        public void ClearAllMessages()
        {
            _exceptionsController.ClearExceptions();
        }
    }
}
