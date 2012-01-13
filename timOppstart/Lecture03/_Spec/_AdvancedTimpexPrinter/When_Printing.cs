using NUnit.Framework;

namespace timOppstart.Lecture03._Spec._AdvancedTimpexPrinter
{
        [TestFixture]

        internal class When_Printing 
        {
            private readonly string[] _returnValues=new string[100];
            private FakeTimPrinter _timPrinter = new FakeTimPrinter();
            private FakePexPrinter _pexPrinter = new FakePexPrinter();
            private FakeTimpexPrinter _timpexPrinter = new FakeTimpexPrinter();
            private string valueFromTimPrinter="valueFromTimPrinter";
            private string valueFromPexPrinter = "valueFromPexPrinter";
            private string valueFromTimpexPrinter = "valueFromTimPrinter";

            [TestFixtureSetUp]
            public void Setup()
            {
                _timPrinter.PrintShouldReturn(valueFromTimPrinter);
                _pexPrinter.PrintShouldReturn(valueFromPexPrinter);
                _timpexPrinter.PrintShouldReturn(valueFromTimpexPrinter);

                var printer=new AdvancedTimpexPrinter(_timPrinter,_pexPrinter,_timpexPrinter);
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
            public void It_Should_Return_Value_From_TimPrinter_Third_Time()
            {
                Assert.AreEqual(valueFromTimPrinter, _returnValues[2]);
            }

            [Test]
            public void It_Should_Return_Value_From_PexPrinter_Fifth_Time()
            {
                Assert.AreEqual(valueFromPexPrinter, _returnValues[4]);
            }

            [Test]
            public void It_Should_Return_Value_From_TimpexPrinter_Fiftenth_Time()
            {
                Assert.AreEqual(valueFromTimpexPrinter, _returnValues[14]);
            }

            [Test]
            public void It_Should_Return_Value_From_TimPrinter_Sixth_Time()
            {
                Assert.AreEqual(valueFromTimPrinter, _returnValues[5]);
            }

            [Test]
            public void It_Should_Return_Value_From_PexPrinter__Tenth_Time()
            {
                Assert.AreEqual(valueFromPexPrinter, _returnValues[9]);
            }

            [Test]
            public void It_Should_Return_Value_From_TimpexPrinter__30_Time()
            {
                Assert.AreEqual(valueFromTimpexPrinter, _returnValues[29]);
            }


        }
}
