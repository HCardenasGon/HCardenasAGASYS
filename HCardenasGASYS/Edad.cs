using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCardenasGASYS
{
    internal class Edad
    {
        public static void edad(int[] edad)
        {
            for (int i = 0; i < edad.Length; i++)
            {
                if (edad[i] >= 18)
                {
                    Console.WriteLine("Es mayor de edad " + i + "edad " + edad[i]);
                }
                else
                {
                    Console.WriteLine("Es menor de edad " + i + "edad " + edad[i]);
                }
            }
        }
    }
}
