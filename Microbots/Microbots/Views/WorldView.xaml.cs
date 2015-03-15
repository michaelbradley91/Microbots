using System.Windows;
using System.Windows.Controls;
using Microbots.Common.Extensions;
using Microbots.Common.Helpers;
using Microbots.Controllers;
using Microbots.Extensions;
using Microbots.ViewModels;
using Microbots.ViewModels.Helpers;

namespace Microbots.Views
{
    public partial class WorldView
    {
        private Grid WorldGrid { get { return WorldGridElement; } }
        private Style WorldSquareStyle { get { return _cacheHelper.Get("WorldSquareStyle", () => this.GetStyle("WorldSquareStyle")); } }

        private readonly IWorldController _worldController;
        private readonly WorldViewModel _worldViewModel;
        private readonly ICacheHelper _cacheHelper;

        public WorldView(IWorldController worldController, WorldViewModel worldViewModel, ICacheHelper cacheHelper)
        {
            _worldController = worldController;
            _worldViewModel = worldViewModel;
            _cacheHelper = cacheHelper;

            InitializeComponent();
            DataContext = _worldViewModel;

            _worldViewModel.AddChangeHandler(WorldSquaresChanged, wm => wm.WorldSquares, true);
        }

        private const int RowDimension = 0;
        private const int ColumnDimension = 1;

        private void WorldSquaresChanged()
        {
            WorldGrid.ColumnDefinitions.Clear();
            WorldGrid.RowDefinitions.Clear();
            WorldGrid.Children.Clear();

            _worldViewModel.WorldSquares.Foreach(RowDimension, _ => WorldGrid.RowDefinitions.Add(new RowDefinition()));
            _worldViewModel.WorldSquares.Foreach(ColumnDimension, _ => WorldGrid.ColumnDefinitions.Add(new ColumnDefinition()));
            _worldViewModel.WorldSquares.Foreach(index => WorldGrid.Children.Add(CreateLabelFor(index[RowDimension], index[ColumnDimension])));
        }

        private Label CreateLabelFor(int row, int column)
        {
            var label = new Label();
            label.SetValue(Grid.ColumnProperty, column);
            label.SetValue(Grid.RowProperty, row);
            label.DataContext = _worldViewModel.WorldSquares[row, column];
            label.Style = WorldSquareStyle;
            return label;
        }
    }
}
