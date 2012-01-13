using NUnit.Framework;

namespace timOppstart.Lecture04._Spec._TimpexPrinter
{
        [TestFixture]

        internal class When_Printing 
        {
            private readonly string[] _returnValues = new string[100];
            private readonly FakeCorePrinter _corePrinter = new FakeCorePrinter();
            private const string ValueFromCorePrinter = "valueFromCorePrinter";

            [TestFixtureSetUp]
            public void Setup()
            {
                var printer = new TimpexPrinter(_corePrinter);
                _corePrinter.PrintShouldReturn(ValueFromCorePrinter);
                for (int i = 0; i <= 99; i++)
                {
                    _returnValues[i] = printer.Print();
                }
            }

            [Test]
            public void It_Should_Return_Value_From_CorePrinter_FirstTime()
            {
                Assert.AreEqual(ValueFromCorePrinter, _returnValues[0]);
            }

            [Test]
            public void It_Should_Value_From_CorePrinter_SecondTime()
            {
                Assert.AreEqual(ValueFromCorePrinter, _returnValues[1]);
            }
        }
}
