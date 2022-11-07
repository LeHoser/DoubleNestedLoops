using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleNestedLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Double Nested Loops");
            Console.WriteLine();

            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j += 2)
                {
                    for (int k = 0; k <= 9; k += 3)
                    {
                        Console.WriteLine(i + "" + j + "" + k);
                    }
                }

            }

            Console.WriteLine();
            Console.WriteLine("Press and key to exit");
            Console.ReadKey(true);
        }
    }
}
