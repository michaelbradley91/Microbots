using Microbots.Common.Extensions;
using Microbots.View.ViewModels.Helpers;

namespace Microbots.View.ViewModels
{
    public class WorldViewModel : ObservableModel
    {
        public WorldSquareViewModel[,] WorldSquares { get { return Get<WorldSquareViewModel[,]>(); } set { Set(value); } }

        public WorldViewModel()
        {
            WorldSquares = new WorldSquareViewModel[0,0];
        }

        public static WorldSquareViewModel[,] CreateWorldSquares(int rows, int columns)
        {
            var worldSquares = new WorldSquareViewModel[rows, columns];
            worldSquares.SetAllTo(() => new WorldSquareViewModel());
            return worldSquares;
        }
    }
}
