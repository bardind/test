namespace timOppstart.Lecture02
{
    public class TimpexPrinter
    {
        private int _counter;
        private int _counterTim;
        private int _counterPex;
        private int _counterTimpex;
        

        public string PrintLine()
        {
            _counter++;
            return DecideValue();
        }

        private string DecideValue()
        {
            if (ErDeleligMed3Og5)
            {
                IncrementTimpexCounter();
                return "timpex - " + _counterTimpex; ;
            }
            if (ErDeleligMed3)
            {
                IncrementTimCounter();
                return "tim - " + _counterTim;
            }
            
            if (ErDeleligMed5)
            {
               IncrementPexCounter();
               return "pex - " + _counterPex; ;
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

        private void IncrementPexCounter()
        {
            _counterPex++;
        }
        private void IncrementTimCounter()
        {
            _counterTim++;
        }

        private void IncrementTimpexCounter()
        {
            _counterTimpex++;
        }

    }
}