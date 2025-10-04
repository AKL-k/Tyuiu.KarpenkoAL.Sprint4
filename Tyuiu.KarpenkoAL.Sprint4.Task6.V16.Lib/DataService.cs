using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KarpenkoAL.Sprint4.Task6.V16.Lib
{
    public class DataService : ISprint4Task6V16
    {
        public string[] Calculate(string[] array)
        {
            List<string> result = new List<string>();
            foreach (string item in array)
            {
                if (item.Length == 7)
                {
                    result.Add(item);
                }
            }
            return result.ToArray();
        }
    }
}
