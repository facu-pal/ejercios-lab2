using System;
using Ejercicio_I01.Entidad;

namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int max = -101;
            int min = 101;
            int sumador = 0;

            float promedio;

            bool vali;
            bool tryPaso;

            string numeroString;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero:");
                numeroString = Console.ReadLine();
                tryPaso = int.TryParse(numeroString, out numero);

                vali = Validador.Validar(numero, -100, 100);

                while (!vali  || !tryPaso )
                {
                    Console.WriteLine("Error. Ingrese un numero valido (-100 a 100):");
                    numeroString = Console.ReadLine();
                    tryPaso = int.TryParse(numeroString, out numero);
                    vali = Validador.Validar(numero, -100, 100);
                }
                sumador += numero;
                if (i == 0 || numero > max)
                {
                    max = numero;
                }
                if (i == 0 || numero < min)
                {
                    min = numero;
                }

            }
            promedio = sumador / (float)10;

            Console.WriteLine($"el valor minimo es:{min}");
            Console.WriteLine($"el valor maximo es:{max}");
            Console.WriteLine($"el promedio es:{promedio}");

        }
    }
    
}
