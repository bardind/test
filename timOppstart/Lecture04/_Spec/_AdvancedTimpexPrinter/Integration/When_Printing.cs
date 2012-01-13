using NUnit.Framework;
using Timpex;

namespace timOppstart.Lecture04._Spec._AdvancedTimpexPrinter.Integration
{
        [TestFixture]

        internal class When_Printing 
        {
            private readonly string[] _returnValues = new string[100];
            private readonly Ioc _ioc = new InversionOfControlContainer();

            [TestFixtureSetUp]
            public void Setup()
            {
                var printer = _ioc.Resolve<AdvancedTimpexPrinter>();
                for (int i = 0; i <= 99; i++)
                {
                    _returnValues[i] = printer.PrintLine();
                }
            }

            [Test]
            public void It_Should_Return_1_First()
            {
                Assert.AreEqual("1", _returnValues[0]);
            }

            [Test]
            public void It_Should_Return_2_Second_Time()
            {
                Assert.AreEqual("2", _returnValues[1]);
            }

            [Test]
            public void It_Should_Return_Tim1_Third_Time()
            {
                Assert.AreEqual("tim - 1", _returnValues[2]);
            }
            [Test]
            public void It_Should_Return_Pex1_Fifth()
            {
                Assert.AreEqual("pex - 1", _returnValues[4]);
            }
            [Test]
            public void It_Should_Return_Tim2_Sixth_Time()
            {
                Assert.AreEqual("tim - 2", _returnValues[5]);
            }
            [Test]
            public void It_Should_Return_Pex2_Tenth()
            {
                Assert.AreEqual("pex - 2", _returnValues[9]);
            }
            [Test]
            public void It_Should_Return_Timpex_Fiftenth_Time()
            {
                Assert.AreEqual("timpex - 1", _returnValues[14]);
            }
            [Test]
            public void It_Should_Return_Timpex_30th_Time()
            {
                Assert.AreEqual("timpex - 2", _returnValues[29]);
            }
            [Test]
            public void It_Should_Return_98_98th_Time()
            {
                Assert.AreEqual("98", _returnValues[97]);
            }

        }
}
