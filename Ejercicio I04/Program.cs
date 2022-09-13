using System;
using Ejercicio_I04;

namespace Ejercicio_I04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            float resultado;
            string operador;
            string numeroString;
            bool tryPaso;
            string charString;
            char respuesta;

            do
            {
                Console.WriteLine("Ingrese un numero:");
                numeroString = Console.ReadLine();
                tryPaso = float.TryParse(numeroString, out num1);

                while (tryPaso != true)
                {
                    Console.WriteLine("Error. Ingrese un numero :");
                    numeroString = Console.ReadLine();
                    tryPaso = float.TryParse(numeroString, out num1);

                }

                Console.WriteLine("Ingrese el otro numero:");
                numeroString = Console.ReadLine();
                tryPaso = float.TryParse(numeroString, out num2);

                while (tryPaso != true)
                {
                    Console.WriteLine("Error. Ingrese el otro numero :");
                    numeroString = Console.ReadLine();
                    tryPaso = float.TryParse(numeroString, out num2);

                }
                Console.WriteLine("Ingreseel operador(+ , - , *, /):");
                operador = Console.ReadLine();
                 while (operador != "+" && operador != "-" && operador != "*" && operador != "/")
                 {
                     Console.WriteLine("Erro. Ingrese el operador(+ , - , *, /):");
                     operador = Console.ReadLine();
                 }

                resultado = Calculadora.Calcular(num1, num2, operador);

                if(num2 == 0 && operador == "/") 
                {
                    Console.WriteLine($"No se puede dividir por 0");

                }
                else 
                {
                    Console.WriteLine($"el resulatado de la operacion {num1} {operador} {num2} = {resultado}");
                
                }

                Console.WriteLine("¿Desea continuar? (S/N)");
                charString = (Console.ReadLine());
                tryPaso = char.TryParse(charString, out respuesta);

                while (tryPaso != true)
                {
                    Console.WriteLine("Error. ¿Desea continuar? (S/N)");
                    charString = Console.ReadLine();
                    tryPaso = char.TryParse(charString, out respuesta);

                }

            } while (respuesta == 's' || respuesta == 'S');
               
        }
    }
}
