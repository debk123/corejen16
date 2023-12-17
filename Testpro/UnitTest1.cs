using JenPro;
namespace Testpro
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var res = Met.square(3);

            Assert.AreEqual(9, res);
        }
    }
}