using System;
using System.Collections.Generic;

namespace _6_ejercio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listNumeros = new List<int>();
            Queue<int> colaNumeros = new Queue<int>();
            Stack<int> pilaNumeros = new Stack<int>();
            Random rdn = new Random();

            for (int i = 0; i < 20; i++)
            {
                listNumeros.Add(rdn.Next(-100, 100));

                colaNumeros.Enqueue(rdn.Next(-100, 100));

                pilaNumeros.Push(rdn.Next(-100, 100));
            }

            Console.WriteLine("list original");
            foreach (int item in listNumeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("cola original");
            foreach (int item in colaNumeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("pila original");
            foreach (int item in pilaNumeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------------------");




        }

        public static int OrdenDescendente(int n1, int n2)
        {
            return n2 - n1;
        }
    }
}
