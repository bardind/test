namespace timOppstart.Lecture03
{
    public class AdvancedTimpexPrinter
    {
        private int _counter;
        private readonly TimPrinter _timPrinter;
        private readonly PexPrinter _pexPrinter;
        private readonly TimpexPrinter _timpexPrinter;

        public AdvancedTimpexPrinter(TimPrinter timPrinter, PexPrinter pexPrinter, TimpexPrinter timpexPrinter)
        {
            _timPrinter = timPrinter;
            _pexPrinter = pexPrinter;
            _timpexPrinter = timpexPrinter;
        }

        public string PrintLine()
        {
            _counter++;
            return DecideValue();
        }

        private string DecideValue()
        {
            if (ErDeleligMed3Og5)
            {
                return _timpexPrinter.Print(); 
            }
            if (ErDeleligMed3)
            {
                return _timPrinter.Print();
            }
            
            if (ErDeleligMed5)
            {
                return _pexPrinter.Print(); 
            }
         
            return _counter.ToString();
        }

        private bool ErDeleligMed3Og5
        {
            get { return ErDeleligMed3 && ErDeleligMed5; }
            
        }

        private bool ErDeleligMed3
        {
            get
            {
                return _counter % 3 == 0;    
            }            
        }

        private bool ErDeleligMed5
        {
            get
            {
                return _counter % 5 == 0;    
            }            
        }
    }
}