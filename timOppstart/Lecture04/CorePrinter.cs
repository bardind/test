namespace timOppstart.Lecture04
{
    public class CorePrinter
    {
        private int _counter;

        public virtual string Print(string text)
        {
            return text + " - " + ++_counter;
        }
    }
}
