using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalabraMasLarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra;

            palabra = Console.ReadLine();
            
            string[] div = palabra.Split(' ');

            var consulta = from dato in div
                    orderby dato.Length descending
                    select dato;

            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
