using Tyuiu.KarpenkoAL.Sprint4.Task2.V16.Lib;

namespace Tyuiu.KarpenkoAL.Sprint4.Task2.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 9, 6, 6, 9, 7 };

            int res = ds.Calculate(numsArray);
            int wait = 25;

            Assert.AreEqual(wait, res);
        }
    }
}
