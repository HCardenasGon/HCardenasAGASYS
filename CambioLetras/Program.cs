using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CambioLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            palabra = Console.ReadLine();

            char[] letra = new char[palabra.Length];

            char[] nueva = new char[palabra.Length];
            int i = 0;
            foreach (char porl in palabra)
            {
                letra[i] = porl;
                //Console.WriteLine(letra[i]);
                i++;
            }

            for (int x = 0; x < letra.Length; x++)
            {
                int index = char.ToUpper(letra[x]) - 64;
                //Console.WriteLine(index);

                if (index == 26)
                {
                    char let = (char)('a' + 0);
                    nueva[x] = let;
                }
                else if (index == -32)
                {
                    nueva[x] = ' ';
                }
                else
                {
                    char let = (char)('a' + index);
                    nueva[x] = let;
                }
            }

            for (int z = 0; z < letra.Length; z++)
            {
                Console.Write(nueva[z]);
            }

            Console.ReadKey();
        }
    }
}
