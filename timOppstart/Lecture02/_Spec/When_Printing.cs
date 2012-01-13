using NUnit.Framework;

namespace timOppstart.Lecture02._Spec
{
        [TestFixture]

        internal class When_Printing 
        {
            private readonly string[] _returnValues=new string[100];

            [TestFixtureSetUp]
            public void Setup()
            {
                var printer=new TimpexPrinter();
                for (int i = 0; i <= 99; i++)
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
                Assert.AreEqual("tim - 1", _returnValues[2]);
            }
            [Test]
            public void It_Should_Return_Pex_Fifth_Time()
            {
                Assert.AreEqual("pex - 1", _returnValues[4]);
            }
            [Test]
            public void It_Should_Return_Timpex_Fiftenth_Time()
            {
                Assert.AreEqual("timpex - 1", _returnValues[14]);
            }

            [Test]
            public void It_Should_Return_Tim_2__Sixth_Time()
            {
                Assert.AreEqual("tim - 2", _returnValues[5]);
            }
            [Test]
            public void It_Should_Return_Pex_2_Tenth_Time()
            {
                Assert.AreEqual("pex - 2", _returnValues[9]);
            }
            [Test]
            public void It_Should_Return_Timpex_2_30_Time()
            {
                Assert.AreEqual("timpex - 2", _returnValues[29]);
            }


        }
    }
