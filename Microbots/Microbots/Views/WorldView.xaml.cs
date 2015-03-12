using System.Windows;
using System.Windows.Controls;
using Microbots.Attributes;
using Microbots.Controllers;

// ReSharper disable UnusedMember.Local
#pragma warning disable 649

namespace Microbots.Views
{
    public partial class WorldView
    {
        private IWorldController WorldController { get; set; }

        [ControlElement("WorldGridElement")] private Grid _worldGrid;
        [StyleElement("WorldSquareStyle")] private Style _worldSquareStyle;

        public WorldView(IWorldController worldController)
        {
            WorldController = worldController;
            InitializePostConstructor();
        }

        [AutoListener] private PropertyChangedListener<WorldView> _worldSquaresListener =
            new PropertyChangedListener<WorldView>(w => new PropertyListenerInfo(
                w.WorldSquaresChanged,
                w.WorldController.WorldViewModel,
                () => w.WorldController.WorldViewModel.WorldSquares));
        
        [InitializationMethod]
        private void WorldSquaresChanged()
        {
            var squares = WorldController.WorldViewModel.WorldSquares;
            _worldGrid.ColumnDefinitions.Clear();
            _worldGrid.RowDefinitions.Clear();
            _worldGrid.Children.Clear();
            for (var row = 0; row < squares.GetLength(0); row++)
            {
                _worldGrid.RowDefinitions.Add(new RowDefinition());
            }
            for (var column = 0; column < squares.GetLength(1); column++)
            {
                _worldGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (var column = 0; column < _worldGrid.ColumnDefinitions.Count; column++)
            {
                for (var row = 0; row < _worldGrid.RowDefinitions.Count; row++)
                {
                    var label = new Label { Content = row + ":" + column };
                    label.SetValue(Grid.ColumnProperty, column);
                    label.SetValue(Grid.RowProperty, row);
                    label.DataContext = squares[row, column];
                    label.Style = _worldSquareStyle;
                    _worldGrid.Children.Add(label);
                }
            }
        }
    }

}
