using Microbots.Helpers;

namespace Microbots.ViewModels
{
    public class WorldViewModel : Bindable
    {
        public WorldViewModel()
        {
            WorldSquares = new WorldSquareViewModel[0,0];
        }

        public WorldSquareViewModel[,] WorldSquares { get { return Get<WorldSquareViewModel[,]>(); } set { Set(value); } }

        public static WorldSquareViewModel[,] CreateWorldSquares(int rows, int columns)
        {
            var worldSquares = new WorldSquareViewModel[rows, columns];
            for (var row = 0; row < rows; row++)
            {
                for (var column = 0; column < columns; column++)
                {
                    worldSquares[row, column] = new WorldSquareViewModel();
                }
            }
            return worldSquares;
        }
    }
}
