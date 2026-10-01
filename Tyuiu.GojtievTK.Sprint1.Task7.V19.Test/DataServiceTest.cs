using Tyuiu.GojtievTK.Sprint1.Task7.V19.Lib;
namespace Tyuiu.GojtievTK.Sprint1.Task7.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(-5.159, ds.Calculate(1));

        }
    }
}
