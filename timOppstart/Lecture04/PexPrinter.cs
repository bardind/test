namespace timOppstart.Lecture04
{
    public class PexPrinter
    {
        private readonly CorePrinter _corePrinter;
        

        public PexPrinter(CorePrinter corePrinter)
        {
            _corePrinter = corePrinter;
        }

        public  PexPrinter(){}

        public virtual string Print()
        {
            return _corePrinter.Print("pex");
        }
    }
}
