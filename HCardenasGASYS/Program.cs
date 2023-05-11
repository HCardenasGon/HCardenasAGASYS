using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HCardenasGASYS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] edad = new int[15];

            for (int i = 0; i < edad.Length; i++)
            {
                edad[i] = Convert.ToInt32(Console.ReadLine());
            }

            Edad.edad(edad);

            Console.ReadKey();
        }
        
    }
}
