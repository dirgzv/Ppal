using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1Ejercicio1
{
    class Program
    {
         static float SacarPromedio(float Nota1, float Nota2, float Nota3)
         {
            float Promedio = (Nota1 + Nota2 + Nota3) / 3;
            return Promedio;
         }

        static void Main(string[] args)
        {
            
            float Nota1, Nota2, Nota3,Promedio;

            Console.WriteLine("Ingrese la primera nota");
            Nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota");
            Nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera nota");
            Nota3 = float.Parse(Console.ReadLine());

            Promedio=SacarPromedio(Nota1, Nota2, Nota3);

            Console.WriteLine("El promedio de las notas es: " + Promedio);
            Console.ReadKey();
        }
    }

}
