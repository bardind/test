namespace timOppstart.Lecture01
{
    public class TimpexPrinter
    {
        private int _counter;

        public string PrintLine()
        {
            _counter++;
            return DecideValue();
        }

        private string DecideValue()
        {
            if (ErDeleligMed3Og5)
                return "timpex";
            if (ErDeleligMed3)
                return "tim";
            if (ErDeleligMed5)
                return "pex";
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