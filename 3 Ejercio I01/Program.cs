using System;
using Entidades_Clase_3;

namespace _3_Ejercio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Pami",1000);
            Cuenta cuenta2 = new Cuenta("Osde",2000);

            Console.WriteLine(cuenta1.mostrar());
            Console.WriteLine(cuenta2.mostrar());

            Console.WriteLine("--------------------------------------------------");

            cuenta1.Ingresar(400);
            cuenta2.Retirar(800);
            Console.WriteLine(cuenta1.mostrar());
            Console.WriteLine(cuenta2.mostrar());

            Console.WriteLine("--------------------------------------------------");

            cuenta1.Ingresar(-400);
            cuenta2.Retirar(2100);
            Console.WriteLine(cuenta1.mostrar());
            Console.WriteLine(cuenta2.mostrar());

        }
    }
}
