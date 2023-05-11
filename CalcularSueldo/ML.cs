using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CalcularSueldo
{
    public class ML
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Sueldo { get; set;}

        public int pago { get; set; }

        public void Empleado1(int cantidad)
        {
            Nombre = "Jacobo";
            Apellido = "Agami";
            Sueldo = 500;

            pago = cantidad * Sueldo;
        }

        public void Empleado2(int cantidad)
        {
            Nombre = "Alvaro";
            Apellido = "Gonzalez";
            Sueldo = 400;

            pago = cantidad * Sueldo;
        }

        public void Empleado3(int cantidad)
        {
            Nombre = "Mario";
            Apellido = "Ramon";
            Sueldo = 300;

            pago = cantidad * Sueldo;
        }
    }
}
