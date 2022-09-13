using System;

namespace Ejercicios_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int variableEscalar;
            int max = -2147483648;
            int min = 2147483647;
            int total = 0;
            float prom;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero");
                variableEscalar = int.Parse(Console.ReadLine());

                if (variableEscalar > max)
                {
                    max = variableEscalar;
                }
                if (variableEscalar < min)
                {
                    min = variableEscalar;
                }
                total = total + variableEscalar;

            }
            prom = total / (float)5;

            Console.WriteLine($"El numero max es:{max}");
            Console.WriteLine($"El numero minimo es:{min}");
            Console.WriteLine($"El promedio es:{prom}");
        }
    }
}
