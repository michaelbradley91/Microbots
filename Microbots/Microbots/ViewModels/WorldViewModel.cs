using Microbots.Common.Extensions;
using Microbots.ViewModels.Helpers;

namespace Microbots.ViewModels
{
    public class WorldViewModel : ObservableModel
    {
        public WorldViewModel()
        {
            WorldSquares = new WorldSquareViewModel[0,0];
        }

        public WorldSquareViewModel[,] WorldSquares { get { return Get<WorldSquareViewModel[,]>(); } set { Set(value); } }

        public static WorldSquareViewModel[,] CreateWorldSquares(int rows, int columns)
        {
            var worldSquares = new WorldSquareViewModel[rows, columns];
            worldSquares.SetAllTo(() => new WorldSquareViewModel());
            return worldSquares;
        }
    }
}
