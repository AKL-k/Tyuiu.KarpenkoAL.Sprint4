using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KarpenkoAL.Sprint4.Task3.V22.Lib
{
    public class DataService : ISprint4Task3V22
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            int s = int.MinValue;

                for (int j = 0; j < columns; j++) 
                {
                if (array[0, j] > s)
                    s = array[0, j]; ;
                }
            return s;
        }
    }
}
