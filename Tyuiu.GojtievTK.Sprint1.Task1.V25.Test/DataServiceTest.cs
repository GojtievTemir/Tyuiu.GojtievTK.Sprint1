using Tyuiu.GojtievTK.Sprint1.Task0.V25.Lib;
using System;
namespace Tyuiu.GojtievTK.Sprint1.Task1.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(3, 4);
            Assert.AreEqual(3, res);





        }
    }
}
