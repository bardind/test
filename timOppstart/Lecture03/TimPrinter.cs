using System;

namespace timOppstart.Lecture03
{
    public class TimPrinter
    {
        private readonly CorePrinter _corePrinter;

        public TimPrinter(CorePrinter corePrinter)
        {
            _corePrinter = corePrinter;
        }

        public  TimPrinter(){}

        public virtual string Print()
        {
            return _corePrinter.Print("tim");
        }
    }
}
