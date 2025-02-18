using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1Ejercicio3
{
    class Cliente
    {
        public string Nombre { get; set; }
        public string NroCuenta { get; set; }
        public double Saldo { get; set; }
    }
    class Program
    {
        static Cliente CrearCliente()
        {
            Cliente cliente = new Cliente();
            Console.WriteLine("Ingrese el nombre del cliente: ");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el número de cuenta: ");
            cliente.NroCuenta = Console.ReadLine();
            Console.WriteLine("Ingrese el saldo del cliente: ");
            cliente.Saldo = double.Parse(Console.ReadLine());
            return cliente;
        }


        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();
            String seguir = "s";

            Console.WriteLine("Crear cliente");
            cliente1 = CrearCliente();

            do
            {
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("bienvenido señor " + cliente1.Nombre + " que desea hacer hoy?");
                Console.WriteLine("1. Depositar");
                Console.WriteLine("2. Retirar");
                Console.WriteLine("3. Consultar Saldo");
                Console.WriteLine("4. Salir");

                int opcion = int.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el monto a depositar: ");
                        double monto = double.Parse(Console.ReadLine());
                        cliente1.Saldo += monto;
                        Console.WriteLine("Depósito realizado con éxito");
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el monto a retirar: ");
                        monto = double.Parse(Console.ReadLine());
                        if (monto > cliente1.Saldo)
                        {
                            Console.WriteLine("Saldo insuficiente");
                        }
                        else
                        {
                            cliente1.Saldo -= monto;
                            Console.WriteLine("Retiro realizado con éxito");
                        }
                        break;
                    case 3:
                        Console.WriteLine("El saldo de la cuenta es: " + cliente1.Saldo);
                        break;
                    case 4:
                        Console.WriteLine("Gracias por usar nuestros servicios");
                        seguir = "n";
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

                if (seguir != "n") 
                { 
                    Console.WriteLine("¿Desea realizar otra operación? (S/N)");
                    seguir = Console.ReadLine().ToUpper(); 
                }
            } while (seguir == "S");
        }
    }
}
