using Tyuiu.KarpenkoAL.Sprint4.Task6.V16.Lib;

namespace Tyuiu.KarpenkoAL.Sprint4.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var array = new string[] { "Автомобиль", "Велосипед", "Самолет", "Поезд", "Трамвай", "Троллейбус", "Метро" };
            string[] res = ds.Calculate(array);
            string[] wait = new string[] { "Самолет", "Трамвай" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
