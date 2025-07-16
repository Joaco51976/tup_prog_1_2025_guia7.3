using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, menor = 0, mayor = 0;
            int contador = 0;
            bool primerNumero = true;

            Console.WriteLine("Ingrese un número entre 0 y 100 (para terminar ingrese -1):");
            numero = int.Parse(Console.ReadLine());

            while (numero != -1)
            {
                if (numero < 0 || numero > 100)
                {
                    Console.WriteLine("Número fuera de rango. Ingrese entre 0 y 100:");
                }
                else
                {
                    if (primerNumero)
                    {
                        menor = numero;
                        mayor = numero;
                        primerNumero = false;
                    }
                    else
                    {
                        if (numero < menor)
                            menor = numero;
                        if (numero > mayor)
                            mayor = numero;
                    }

                    contador++;
                }

                Console.WriteLine("Ingrese otro número (-1 para terminar):");
                numero = int.Parse(Console.ReadLine());
            }

            if (contador > 0)
            {
                Console.WriteLine($"\nEl número menor ingresado fue: {menor}");
                Console.WriteLine($"El número mayor ingresado fue: {mayor}");
            }
            else
            {
                Console.WriteLine("\nNo se ingresaron números válidos.");
            }

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}