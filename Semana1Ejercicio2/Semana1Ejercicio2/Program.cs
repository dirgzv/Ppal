using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1Ejercicio2
{
    class Program
    {
        public static float CalcularNroPulsaciones(int Edad)
        {
            float NroPulsaciones;
            NroPulsaciones = (220 - Edad) / 10f;
            return NroPulsaciones;
        }
        static void Main(string[] args)
        {   
            int edad;
            float NroPulsaciones;

            Console.WriteLine("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());
            NroPulsaciones = CalcularNroPulsaciones(edad);

            Console.WriteLine("El número de pulsaciones por cada 10 segundos es: " + NroPulsaciones);
            Console.ReadKey();
        }
    }
}
