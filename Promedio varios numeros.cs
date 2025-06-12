using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                int suma = 0;
                int cantidad = 0;

                Console.WriteLine("Escriba los numeros, escriba 'fin' para terminar");

                while (true)
                {
                    Console.Write("Número: ");
                    string entrada = Console.ReadLine();

                    if (entrada.ToLower() == "fin")
                        break;

                    int numero;
                    if (int.TryParse(entrada, out numero))
                    {
                        suma += numero;
                        cantidad++;
                    }
                    else
                    {
                        Console.WriteLine("Eso no es un número, intentá otra vez.");
                    }
                }
                    if (cantidad > 0)
                    {
                    double promedio = (double)suma / cantidad;
                    Console.WriteLine("El promedio es " + promedio);
                    }

                    else
                    {
                    Console.WriteLine("No ingresaste ningún número.");
                    }
            }
        }
    }
}

