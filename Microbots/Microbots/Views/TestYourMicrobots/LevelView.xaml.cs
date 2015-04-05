using System.Windows;
using System.Windows.Controls;
using Microbots.Common.Extensions;
using Microbots.Common.Helpers;
using Microbots.View.Controllers;
using Microbots.View.Extensions;
using Microbots.View.ViewModels;
using Microbots.View.ViewModels.Helpers;

namespace Microbots.View.Views.TestYourMicrobots
{
    public partial class LevelView
    {
        private Grid LevelGrid { get { return LevelGridElement; } }
        private Style LevelSquareStyle { get { return _cacheHelper.Get("LevelSquareStyle", () => this.GetStyle("LevelSquareStyle")); } }

        private readonly ILevelController _levelController;
        private readonly LevelViewModel _levelViewModel;
        private readonly ICacheHelper _cacheHelper;

        public LevelView(ILevelController levelController, LevelViewModel levelViewModel, ICacheHelper cacheHelper)
        {
            _levelController = levelController;
            _levelViewModel = levelViewModel;
            _cacheHelper = cacheHelper;

            InitializeComponent();
            DataContext = _levelViewModel;

            _levelViewModel.AddChangeHandler(LevelSquaresChanged, wm => wm.LevelSquares, true);
        }

        private const int RowDimension = 0;
        private const int ColumnDimension = 1;

        private void LevelSquaresChanged()
        {
            LevelGrid.ColumnDefinitions.Clear();
            LevelGrid.RowDefinitions.Clear();
            LevelGrid.Children.Clear();

            _levelViewModel.LevelSquares.Foreach(RowDimension, _ => LevelGrid.RowDefinitions.Add(new RowDefinition()));
            _levelViewModel.LevelSquares.Foreach(ColumnDimension, _ => LevelGrid.ColumnDefinitions.Add(new ColumnDefinition()));
            _levelViewModel.LevelSquares.Foreach(index => LevelGrid.Children.Add(CreateControlFor(index[RowDimension], index[ColumnDimension])));
        }

        private FrameworkElement CreateControlFor(int row, int column)
        {
            
            var label = new Label();
            label.SetValue(Grid.ColumnProperty, column);
            label.SetValue(Grid.RowProperty, row);
            label.DataContext = _levelViewModel.LevelSquares[row, column];
            label.Style = LevelSquareStyle;
            return label;
        }
    }
}
