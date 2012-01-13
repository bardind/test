using System;

namespace timOppstart.Lecture03
{
    public class TimpexPrinter
    {
        private readonly CorePrinter _corePrinter;
        
        public TimpexPrinter(CorePrinter corePrinter)
        {
            _corePrinter = corePrinter;
        }

        public  TimpexPrinter(){}

        public virtual string Print()
        {
            return _corePrinter.Print("timpex");
        }
    }
}
