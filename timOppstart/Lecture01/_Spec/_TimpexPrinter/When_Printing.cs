using NUnit.Framework;

namespace timOppstart.Lecture01._Spec._TimpexPrinter
{
        [TestFixture]

        internal class When_Printing 
        {
            private readonly string[] _returnValues=new string[101];

            [TestFixtureSetUp]
            public void Setup()
            {
                var printer=new TimpexPrinter();
                for (var i = 0; i <= 99; i++)
                {
                    _returnValues[i] = printer.PrintLine();
                }
            }

            [Test]
            public void It_Should_Return_1()
            {
                Assert.AreEqual("1", _returnValues[0]);
            }

            [Test]
            public void It_Should_Return_2_Second_Time()
            {
                Assert.AreEqual("2", _returnValues[1]);
            }

            [Test]
            public void It_Should_Return_Tim_Third_Time()
            {
                Assert.AreEqual("tim", _returnValues[2]);
            }
            [Test]
            public void It_Should_Return_Pex_Fifth()
            {
                Assert.AreEqual("pex", _returnValues[4]);
            }
            [Test]
            public void It_Should_Return_Timpex_Fiftenth_Time()
            {
                Assert.AreEqual("timpex", _returnValues[14]);
            }

        }
    }
