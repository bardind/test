using NUnit.Framework;
using timOppstart.Lecture03._Spec._PexPrinter;

namespace timOppstart.Lecture03._Spec._CorePrinter
{
        [TestFixture]

        internal class When_Printing 
        {
            private readonly string[] _returnValues = new string[100];
            private FakeCorePrinter _corePrinter = new FakeCorePrinter();
            private string valueFromCorePrinter = "valueFromCorePrinter";

            [TestFixtureSetUp]
            public void Setup()
            {
                var printer = new CorePrinter();
                for (int i = 0; i <= 99; i++)
                {
                    _returnValues[i] = printer.Print(valueFromCorePrinter);
                }
            }

            [Test]
            public void It_Should_Return_Value_From_CorePrinter_1_FirstTime()
            {
                Assert.AreEqual(valueFromCorePrinter + " - " + 1, _returnValues[0]);
            }

            [Test]
            public void It_Should_Return_Value_From_CorePrinter_2_SecondTime()
            {
                Assert.AreEqual(valueFromCorePrinter + " - " + 2, _returnValues[1]);
            }

        }
}
