using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularSueldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dias = new int[3];

            Console.WriteLine("Escribe los dias que trabajo cada empleado");
            dias[0] = Convert.ToInt32(Console.ReadLine());
            dias[1] = Convert.ToInt32(Console.ReadLine());
            dias[2] = Convert.ToInt32(Console.ReadLine());

            BL.Calcular(dias);

            Console.ReadKey();
        }
    }
}
