namespace timOppstart.Lecture03._Spec._AdvancedTimpexPrinter
{
    internal class FakeTimPrinter : TimPrinter
    {
        private string _value;

        public void PrintShouldReturn(string value)
        {
            _value = value;
        }

        public override string Print()
        {
            return _value;
        }
    }
}