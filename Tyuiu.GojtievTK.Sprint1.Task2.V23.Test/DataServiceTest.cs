using Tyuiu.GojtievTK.Sprint1.Task2.V23.Lib;
using System;
namespace Tyuiu.GojtievTK.Sprint1.Task2.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.ConvertMinutesToSeconds(3);
            Assert.AreEqual(180, res);





        }
    }
}