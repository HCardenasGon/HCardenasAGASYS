using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] electores = new int[160];
            Random rnd = new Random();

            for (int i = 0; i < electores.Length; i++)
            {
                electores[i] = rnd.Next(3);
            }

            Botos.Boto(electores);

            Console.ReadKey();
        }
    }
}
