using Tyuiu.KarpenkoAL.Sprint4.Task7.V16.Lib;

namespace Tyuiu.KarpenkoAL.Sprint4.Task7.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            
            int rows = 5;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            string str = "382976421897948";

            int res = ds.Calculate(rows, columns, str);
            int wait = 196608;
            Assert.AreEqual(wait, res);


        }
    }
}
