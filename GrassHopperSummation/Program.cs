using System;

namespace GrassHopperSummation
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumation(22);
            Summation2(22);
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

        public static int Summation2(int num) 
        {
            Console.WriteLine(num * (num + 1) / 2);
            return num * (num + 1) / 2;   
        }

    }
}
