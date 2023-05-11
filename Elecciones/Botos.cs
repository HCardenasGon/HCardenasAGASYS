using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elecciones
{
    internal class Botos
    {
        public static void Boto(int[] electores)
        {
            int Candidato1 = 0, Candidato2 = 0, Candidato3 = 0;

            for (int i = 0; i < electores.Length; i++)
            {
                if (electores[i] == 0)
                {
                    Candidato1++;
                }
                else if (electores[i] == 1)
                {
                    Candidato2++;
                }
                else if (electores[i] == 2)
                {
                    Candidato3++;
                }
            }

            if (Candidato1 >= Candidato2)
            {
                if (Candidato2 >= Candidato3)
                {
                    Console.WriteLine("El candidato 1 tubo la mayor cantidad de botos " + Candidato1);

                    Console.WriteLine("El candidato 2 tubo el segundo lugar en cantidad de botos " + Candidato2);

                    Console.WriteLine("El candidato 3 tubo el tercer lugar en cantidad de botos " + Candidato3);
                }
                else if (Candidato3 >= Candidato1)
                {
                    Console.WriteLine("El candidato 3 tubo la mayor cantidad de botos " + Candidato3);

                    Console.WriteLine("El candidato 1 tubo el segundo lugar en cantidad de botos " + Candidato1);

                    Console.WriteLine("El candidato 2 tubo el tercer lugar en cantidad de botos " + Candidato2);
                }
                else
                {
                    Console.WriteLine("El candidato 1 tubo la mayor cantidad de botos " + Candidato1);

                    Console.WriteLine("El candidato 3 tubo el segundo lugar en cantidad de botos " + Candidato3);

                    Console.WriteLine("El candidato 2 tubo el tercer lugar en cantidad de botos " + Candidato2);
                }
            }
            else if (Candidato2 >= Candidato3)
            {
                
                if (Candidato3 >= Candidato1)
                {
                    Console.WriteLine("El candidato 2 tubo la mayor cantidad de botos " + Candidato2);

                    Console.WriteLine("El candidato 3 tubo el segundo lugar en cantidad de botos " + Candidato3);

                    Console.WriteLine("El candidato 1 tubo el tercer lugar en cantidad de botos " + Candidato1);
                }
                else
                {
                    Console.WriteLine("El candidato 2 tubo la mayor cantidad de botos " + Candidato2);

                    Console.WriteLine("El candidato 1 tubo el segundo lugar en cantidad de botos " + Candidato1);

                    Console.WriteLine("El candidato 3 tubo el tercer lugar en cantidad de botos " + Candidato3);
                }
            }
        }
    }
}
