using System;

namespace Microbots.Common.Extensions
{
    public static class ArrayExtensions
    {
        public static void SetAllTo<T>(this Array array, Func<T> value)
        {
            array.SetAllTo(index => value());
        }

        public static void SetAllTo<T>(this Array array, Func<int[], T> value)
        {
            Foreach(array, index => array.SetValue(value(index), index));
        }

        public static void Foreach(this Array array, Action<int[]> action)
        {
            var index = new int[array.Rank];
            var finished = false;
            while (!finished)
            {
                action(index);
                finished = !IncrementIndex(index, array);
            }
        }

        public static void Foreach(this Array array, int dimension, Action<int> action)
        {
            for (var i = 0; i < array.GetLength(dimension); i++) action(i);
        }

        private static bool IncrementIndex(int[] index, Array array)
        {
            for (var dim = array.Rank - 1; dim >= 0; dim--)
            {
                if (array.GetLength(dim) > index[dim] + 1)
                {
                    index[dim]++;
                    return true;
                }
                index[dim] = 0;
            }
            return false;
        }
    }
}
