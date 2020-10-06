using System;

namespace GrassHopperSummation
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumation(22);
            
        }

        public static int Sumation(int num) 
        {
            int i = 0;
            int var = 0;
            while ( i <= num)
            {

                var += i;
                Console.WriteLine(var);
                i++;
            }

            return var;
        }

    }
}
