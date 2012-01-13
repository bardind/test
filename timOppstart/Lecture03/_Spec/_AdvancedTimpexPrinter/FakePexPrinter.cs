﻿namespace timOppstart.Lecture03._Spec._AdvancedTimpexPrinter
{
    internal class FakePexPrinter : PexPrinter
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