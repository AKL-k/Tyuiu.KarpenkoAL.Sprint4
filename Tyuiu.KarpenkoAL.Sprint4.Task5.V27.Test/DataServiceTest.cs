using Tyuiu.KarpenkoAL.Sprint4.Task5.V27.Lib;

namespace Tyuiu.KarpenkoAL.Sprint4.Task5.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { -2, -5, 1, 7, 5 },
                                          { 4, 4, 7, 4, 4 },
                                          { 7, 1, 6, -3, 8 },
                                          { 2, 1, 5, 6, 4 },
                                          { -5, 4, 1, 7, 3 } };
            int res = ds.Calculate(mas2);
            int wait = 4;

            Assert.AreEqual(wait, res);
        }
    }
}
