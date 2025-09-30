using Tyuiu.KarpenkoAL.Sprint4.Task1.V5.Lib;

namespace Tyuiu.KarpenkoAL.Sprint4.Task1.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 9, 6, 6, 9, 7, 8, 5, 9, 6, 6, 8, 6, 8, 6, 7 };

            int res = ds.Calculate(numsArray);
            int wait = 60;

            Assert.AreEqual(wait, res);
        }
    }
}
