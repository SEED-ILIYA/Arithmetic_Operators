using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seed = 6 + 8;
            Console.WriteLine(seed);

            int seed2 = seed * 3;
            Console.WriteLine(seed2);

            int seed3 = seed / 6;
            Console.WriteLine(seed3);

            int seed4 = seed - 2;
            Console.WriteLine(seed4);

            int increment = 4;

            int increment1 = increment++;
            Console.WriteLine(increment1);

            int increment2 = increment--;
            Console.WriteLine(increment2);
            Console.ReadLine();
        }
    }
}
