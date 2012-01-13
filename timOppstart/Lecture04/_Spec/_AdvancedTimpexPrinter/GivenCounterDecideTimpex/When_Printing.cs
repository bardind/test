using NUnit.Framework;

namespace timOppstart.Lecture04._Spec._AdvancedTimpexPrinter.GivenCounterDecideTimpex
{
    [TestFixture]
    internal class When_Printing
    {
        private readonly FakeTimPrinter _timPrinter = null;
        private readonly FakeTimpexPrinter _timpexPrinter = new FakeTimpexPrinter();
        protected FakeCounter Counter = new FakeCounter();
        protected FakeCounter NextCounter = new FakeCounter();
        private string _returnedValue;
        private readonly PexPrinter _pexPrinter = null;
        private const string ValueFromTimpexPrinter = "valueFromTimPrinter";

        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        private void Arrange()
        {
            StubTimpexPrinter();
            StubCounter();
            StubNextCounter();
        }

        private void StubTimpexPrinter()
        {
            _timpexPrinter.PrintShouldReturn(ValueFromTimpexPrinter);
        }

        private void StubCounter()
        {
            Counter.IncrementShouldReturn(NextCounter);
        }

        private void StubNextCounter()
        {
            NextCounter.IsTimpexShouldReturn(true);
        }


        private void Act()
        {
            var printer = new AdvancedTimpexPrinter(_timPrinter, _pexPrinter, _timpexPrinter, Counter);
            _returnedValue = printer.PrintLine();
        }

        [Test]
        public void It_Should_Return_Value_From_TimpexPrinter()
        {
            Assert.AreEqual(ValueFromTimpexPrinter, _returnedValue);
        }
    }
}
