using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularSueldo
{
    internal class BL
    {
        public static void Calcular(int[] dias)
        {
            ML Empleados = new ML();

            Empleados.Empleado1(dias[0]);
            Console.WriteLine("Empleado 1");
            Console.WriteLine("Nombre " + Empleados.Nombre);
            Console.WriteLine("Apellido " + Empleados.Apellido);
            Console.WriteLine("Sueldo por dia " + Empleados.Sueldo);
            Console.WriteLine("Sueldo pagado " + Empleados.pago);

            Empleados.Empleado2(dias[1]);
            Console.WriteLine("Empleado 2");
            Console.WriteLine("Nombre " + Empleados.Nombre);
            Console.WriteLine("Apellido " + Empleados.Apellido);
            Console.WriteLine("Sueldo por dia " + Empleados.Sueldo);
            Console.WriteLine("Sueldo pagado " + Empleados.pago);

            Empleados.Empleado3(dias[2]);
            Console.WriteLine("Empleado 3");
            Console.WriteLine("Nombre " + Empleados.Nombre);
            Console.WriteLine("Apellido " + Empleados.Apellido);
            Console.WriteLine("Sueldo por dia " + Empleados.Sueldo);
            Console.WriteLine("Sueldo pagado " + Empleados.pago);
        }
    }
}
