namespace timOppstart.Lecture04
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
