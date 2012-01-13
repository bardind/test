namespace timOppstart.Lecture03._Spec
{
    internal class FakeCorePrinter : CorePrinter
    {
        private string _value;

        public void PrintShouldReturn(string value)
        {
            _value = value;
        }

        public override string Print(string text)
        {
            return _value;
        }
    }
}