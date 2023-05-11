using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SopaLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            palabra = Console.ReadLine();

            char[] letra = new char[palabra.Length];
            int i = 0;
            foreach (char porl in palabra)
            {
                letra[i] = porl;
                //Console.WriteLine(letra[i]);
                i++;
            }
            Array.Sort(letra);

            Console.Write(String.Join(", ", letra));
           
            Console.ReadKey();
        }
    }
}
