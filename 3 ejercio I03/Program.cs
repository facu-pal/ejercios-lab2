using System;
using Entidades_Clase_3;
namespace _3_ejercio_I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("Palmieri", "111011", "Facundo");
            Estudiante estudiante2 = new Estudiante("Elbey", "115122", "Facundo");
            Estudiante estudiante3 = new Estudiante("Anton", "342311", "Kevin");

            estudiante1.SetNotaPrimerParcial(10);
            estudiante1.SetNotaSegundoParcial(8);

            estudiante2.SetNotaPrimerParcial(2);
            estudiante2.SetNotaSegundoParcial(3);

            estudiante3.SetNotaPrimerParcial(9);
            estudiante3.SetNotaSegundoParcial(7);

            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine(estudiante3.Mostrar());


        }
    }
}
