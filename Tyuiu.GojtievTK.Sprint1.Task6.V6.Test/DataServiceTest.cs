using Tyuiu.GojtievTK.Sprint1.Task6.V6.Lib;
namespace Tyuiu.GojtievTK.Sprint1.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual("ян об", ds.DeleteFirstLetter("лян лоб"));

        }
    }
}
