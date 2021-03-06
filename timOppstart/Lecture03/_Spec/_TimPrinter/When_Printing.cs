using NUnit.Framework;
using timOppstart.Lecture03._Spec._AdvancedTimpexPrinter;

namespace timOppstart.Lecture03._Spec._TimPrinter
{
        [TestFixture]

        internal class When_Printing 
        {
            private readonly string[] _returnValues=new string[100];
            private readonly FakeCorePrinter _corePrinter = new FakeCorePrinter();
            private string valueFromCorePrinter = "valueFromCorePrinter";

            [TestFixtureSetUp]
            public void Setup()
            {
                var printer = new TimPrinter(_corePrinter);
                _corePrinter.PrintShouldReturn(valueFromCorePrinter);
                for (int i = 0; i <= 99; i++)
                {
                    _returnValues[i] = printer.Print();
                }
            }

            [Test]
            public void It_Should_Return_Value_From_CorePrinter_FirstTime()
            {
                Assert.AreEqual(valueFromCorePrinter, _returnValues[0]);
            }

            [Test]
            public void It_Should_Return_Value_From_CorePrinter_SecondTime()
            {
                Assert.AreEqual(valueFromCorePrinter, _returnValues[1]);
            }
        }
}
