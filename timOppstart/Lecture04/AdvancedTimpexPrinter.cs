namespace timOppstart.Lecture04
{
    public class AdvancedTimpexPrinter
    {
        private Counter _counter;
        private readonly TimPrinter _timPrinter;
        private readonly PexPrinter _pexPrinter;
        private readonly TimpexPrinter _timpexPrinter;
        

        public AdvancedTimpexPrinter(TimPrinter timPrinter, PexPrinter pexPrinter, TimpexPrinter timpexPrinter, Counter counter)
        {
            _timPrinter = timPrinter;
            _pexPrinter = pexPrinter;
            _timpexPrinter = timpexPrinter;
            _counter = counter;
        }

        public string PrintLine()
        {
            _counter = _counter.Increment();
            return DecideValue();
        }

        private string DecideValue()
        {        
            if (_counter.IsTim)
                return _timPrinter.Print();
            if (_counter.IsPex)
                return _pexPrinter.Print(); 
            if (_counter.IsTimpex)
                return _timpexPrinter.Print();
            return _counter.IntegerValue;



        }
      
    }
}