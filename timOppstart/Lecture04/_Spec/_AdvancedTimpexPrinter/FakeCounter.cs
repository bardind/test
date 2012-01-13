using System;

namespace timOppstart.Lecture04._Spec._AdvancedTimpexPrinter
{
    internal class FakeCounter : Counter
    {
        private FakeCounter _nextCounter;
        private bool _isTimpexValue;
        private bool _isTimValue;
        private bool _isPexValue;
        private string _integerValue;

        public void IncrementShouldReturn(FakeCounter nextCounter)
        {
            _nextCounter = nextCounter;
        }

        public override Counter Increment()
        {
            return _nextCounter;
        }

        public void IsTimpexShouldReturn(bool value)
        {
            _isTimpexValue = value;
        }

        public override bool IsTimpex
        {
            get
            {
                return _isTimpexValue;
            }
        }

        public void IsTimShouldReturn(bool value)
        {
            _isTimValue = value;
        }

        public override bool IsTim
        {
            get
            {
                return _isTimValue;
            }
        }
        public void IsPexShouldReturn(bool value)
        {
            _isPexValue = value;
        }

        public override bool IsPex
        {
            get
            {
                return _isPexValue;
            }
        }

        public void ValueShouldReturn(string value)
        {
            _integerValue = value;
        }

        public override string IntegerValue
        {
            get
            {
                return _integerValue;
            }
        }
    }
}