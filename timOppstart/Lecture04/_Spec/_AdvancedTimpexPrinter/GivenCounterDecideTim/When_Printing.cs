using NUnit.Framework;

namespace timOppstart.Lecture04._Spec._AdvancedTimpexPrinter.GivenCounterDecideTim
{
    [TestFixture]
    internal class When_Printing
    {
        private readonly FakeTimPrinter _timPrinter = new FakeTimPrinter();
        private readonly FakeTimpexPrinter _timpexPrinter = new FakeTimpexPrinter();
        protected FakeCounter Counter = new FakeCounter();
        protected FakeCounter NextCounter = new FakeCounter();
        private string _returnedValue;
        private readonly PexPrinter _pexPrinter = new FakePexPrinter();
        private const string ValueFromTimPrinter = "valueFromTimPrinter";

        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        private void Arrange()
        {
            StubTimPrinter();
            StubCounter();
            StubNextCounter();
        }

        private void StubTimPrinter()
        {
            _timPrinter.PrintShouldReturn(ValueFromTimPrinter);
        }

        private void StubCounter()
        {
            Counter.IncrementShouldReturn(NextCounter);
        }

        private void StubNextCounter()
        {
            NextCounter.IsTimShouldReturn(true);
        }


        private void Act()
        {
            var printer = new AdvancedTimpexPrinter(_timPrinter, _pexPrinter, _timpexPrinter, Counter);
            _returnedValue = printer.PrintLine();
        }

        [Test]
        public void It_Should_Return_Value_From_TimPrinter()
        {
            Assert.AreEqual(ValueFromTimPrinter, _returnedValue);
        }
    }
}