using Tyuiu.GojtievTK.Sprint1.Task3.V15.Lib;
namespace Tyuiu.GojtievTK.Sprint1.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(ds.DistanceOverTime(60,80,20,2),300);
        }
    }
}
