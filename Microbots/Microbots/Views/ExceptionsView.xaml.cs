using System.Windows;
using Microbots.Controllers;
using Microbots.Extensions;
using Microbots.ViewModels;

namespace Microbots.Views
{
    public partial class ExceptionsView
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

        private void ClearExceptions(object sender, RoutedEventArgs e)
        {
            _exceptionsController.ClearExceptions();
        }

        private void ClearException(object sender, RoutedEventArgs e)
        {
            var exception = sender.GetDataContext<ExceptionViewModel>();
            _exceptionsViewModel.Exceptions.Remove(exception);
        }
    }
}
