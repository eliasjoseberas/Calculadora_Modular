using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Modular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal valor1 = 0;
            decimal valor2 = 0;
            byte opcion;

            do
            {
                Console.WriteLine("=================================");
                Console.WriteLine("No.--- CALCULADORA MODULAR ---");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                Console.WriteLine("=================================");

                Console.WriteLine("Elija su opción: ");

                while (!byte.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Favor de ingresar un opcion dentro del menú");
                }

                if (opcion == 5)
                {
                    break;
                }

                if (opcion >= 1 && opcion <= 4)
                {

                    Console.WriteLine("Ingresar el primer valor");
                    while (!decimal.TryParse(Console.ReadLine(), out valor1))
                    {
                        Console.WriteLine("Favor de ingresar un valor valido");
                    }

                    Console.WriteLine("Ingresar el segundo valor");
                    while (!decimal.TryParse(Console.ReadLine(), out valor2))
                    {
                        Console.WriteLine("Favor de ingresar un valor valido");
                    }


                    switch (opcion)
                    {
                        case 1:
                            Sumar(valor1, valor2);
                            break;

                        case 2:
                            Resta(valor1, valor2);
                            break;

                        case 3:
                            Multiplicacion(valor1, valor2);
                            break;

                        case 4:
                            Division(valor1, valor2);
                            break;
                    }


                }
                else
                {
                    Console.WriteLine("Ingrese una opcion valida");
                }
            } while (opcion != 5);
            Console.WriteLine("Gracias por utilizar nuestros servicios");

        }

        private static void Sumar(decimal valor1, decimal valor2)
        {
            decimal resultado = valor1 + valor2;

            Console.WriteLine($"El resultado es: {resultado}");
        }

        private static void Resta(decimal valor1, decimal valor2)
        {
            decimal resultado = valor1 - valor2;

            Console.WriteLine($"El resultado es: {resultado}");
        }

        private static void Multiplicacion(decimal valor1, decimal valor2)
        {
            decimal resultado = valor1 * valor2;

            Console.WriteLine($"El resultado es: {resultado}");
        }

        private static void Division(decimal valor1, decimal valor2)
        {
            if (valor1 == 0)
            {
                Console.WriteLine("No se puede dividir entre cero");
            }
            else
            {
                decimal resultado = valor1 / valor2;

                Console.WriteLine($"El resultado es: {resultado}");

            }
        }
    } 
}