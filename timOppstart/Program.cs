using System;

namespace timOppstart
{
    class Program
    {
        static void Main()
        {   
            StartUtskrift();
        }

        static void StartUtskrift()
        {
            for (int i = 1; i <= 100;i++)
            {
                Console.WriteLine(FinnUtskriftLinje(i));
            }
            Console.ReadKey();
        }

        static string FinnUtskriftLinje(int i)
        {
            if(i % 3 ==0 & i % 5 ==0)
                return "timpex";
            if (i % 3 ==0)
                 return "tim";
            if (i % 5 ==0)
                return "pex";
            return i.ToString();
        }
    }
}
