using NUnit.Framework;
using NUnit;
using JenPro;

namespace Test2Pro
{
    [TestFixture]
    public class Ntest
    {

        [Test]
        public void Test1()
        {
            var res = Met.square(4);

            Assert.That(res,Is.EqualTo(16));
        }

        [Test]
        public void Test2()
        {
            var res = Met.IsNan(4);

            Assert.That(res,Is.False);
        }

    }
}