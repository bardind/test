using NUnit.Framework;

namespace timOppstart.Lecture04._Spec._AdvancedTimpexPrinter.GivenCounterDecideOther
{
    [TestFixture]
    internal class When_Printing
    {
        private readonly FakePexPrinter _pexPrinter = new FakePexPrinter(); 
        private readonly FakeTimPrinter _timPrinter = new FakeTimPrinter();
        private readonly FakeTimpexPrinter _timpexPrinter = new FakeTimpexPrinter();
        protected FakeCounter Counter = new FakeCounter();
        protected FakeCounter NextCounter = new FakeCounter();
        private string _returnedValue;
        private const string ValueFromCounter = "ValueFromCounter";

        [TestFixtureSetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        private void Arrange()
        {
            StubCounter();
            StubNextCounter();
        }

        private void StubCounter()
        {            
            Counter.IncrementShouldReturn(NextCounter);
        }

        private void StubNextCounter()
        {
            NextCounter.ValueShouldReturn(ValueFromCounter);
        }

        private void Act()
        {
            var printer = new AdvancedTimpexPrinter(_timPrinter, _pexPrinter, _timpexPrinter, Counter);
            _returnedValue = printer.PrintLine();
        }

        [Test]
        public void It_Should_Return_Value_From_PexPrinter()
        {
            Assert.AreEqual(ValueFromCounter, _returnedValue);
        }
    }
}