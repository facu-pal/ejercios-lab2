using System;
using System.Collections.Generic;

namespace _6_ejercio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros= new List<int>();
            Random rdn = new Random();

            for(int i=0; i<20; i++)
            {
                numeros.Add(rdn.Next(-100, 100));
            }

            Console.WriteLine("list original");
            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("List ordenado decreciente solo positivos:");
            numeros.Sort(Program.OrdenDescendente);
            foreach (int item in numeros)
            {
                if (item > 0)
                {
                     Console.WriteLine(item);
                }
            }

            Console.WriteLine("negativos ordenados en forma creciente.");
            numeros.Reverse();
            foreach (int item in numeros)
            {
                if (item < 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public static int OrdenDescendente(int n1, int n2)
        {
            return n2 - n1;
        }

    }
}
 