using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Escriba un numero");

            num = Convert.ToInt32(Console.ReadLine());

            int[] fact = new int[num];

            for (int i = 0; i < num; i++)
            {
                fact[i] = i+1;
            }

            int mul = 1;

            Array.ForEach(fact, i => mul *= i);
            Console.WriteLine(mul);

            Console.WriteLine(fact.Aggregate((x, y) => x * y));

            Console.ReadKey();
        }
    }
}
