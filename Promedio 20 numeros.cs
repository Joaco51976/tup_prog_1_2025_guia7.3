using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_20num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalnum = 21;
            int sumanum = 0;

            for (int i=1;i<totalnum; i++)
            {
                Console.WriteLine("Ingrese el número " + i + ":");
                int num = Convert.ToInt32(Console.ReadLine());
                sumanum += num;
            }
            double promedio = (sumanum / (totalnum) - 1);
            Console.WriteLine($"El promedio de los numeros es: {promedio:F2}");
        }
    }
}