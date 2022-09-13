using System;
using Ejercicio_I02;


namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumador=0;
            int numero;

            bool tryPaso;
            string numeroString;
            do
            {
                Console.WriteLine("Ingrese un numero:");
                numeroString = Console.ReadLine();
                tryPaso = int.TryParse(numeroString, out numero);

                while (tryPaso != true)
                {
                    Console.WriteLine("Error. Ingrese un numero :");
                    numeroString = Console.ReadLine();
                    tryPaso = int.TryParse(numeroString, out numero);

                }
                sumador = sumador + numero;

            } while (Validador.ValidarRespuesta());

            Console.WriteLine($"El total es: {sumador}");

        }
    }
}
