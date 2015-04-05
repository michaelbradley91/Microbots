using Microbots.Common.Extensions;
using Microbots.View.ViewModels.Helpers;

namespace Microbots.View.ViewModels
{
    public class LevelViewModel : ObservableModel
    {
        public LevelSquareViewModel[,] LevelSquares { get { return Get<LevelSquareViewModel[,]>(); } set { Set(value); } }

        public LevelViewModel()
        {
            LevelSquares = new LevelSquareViewModel[0, 0];
        }

        public static LevelSquareViewModel[,] CreateLevelSquares(int rows, int columns)
        {
            var levelSquares = new LevelSquareViewModel[rows, columns];
            levelSquares.SetAllTo(() => new LevelSquareViewModel());
            return levelSquares;
        }
    }
}
