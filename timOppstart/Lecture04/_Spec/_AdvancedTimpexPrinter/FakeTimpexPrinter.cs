namespace timOppstart.Lecture04._Spec._AdvancedTimpexPrinter
{
    internal class FakeTimpexPrinter : TimpexPrinter
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