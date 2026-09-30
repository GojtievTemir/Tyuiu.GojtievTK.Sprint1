using Tyuiu.GojtievTK.Sprint1.Task5.V3.Lib;
namespace Tyuiu.GojtievTK.Sprint1.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(ds.Calculate(1234),2);


        }
    }
}
