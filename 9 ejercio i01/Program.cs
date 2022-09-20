using System;
using Entidad_9;
namespace _9_ejercio_i01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camion camioncito = new Camion(8, 2, eColores.Azul, 8, 5000);
            Console.WriteLine("Camion camioncito \nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCantidad Marchas: {3}\nPeso Carga {4}", camioncito.cantRuedas, camioncito.cantPuertas, camioncito.color, camioncito.cantMarchas, camioncito.pesoDeCarga);
            Console.WriteLine("--------------");
            Automovil autito = new Automovil(4, 5, eColores.Blanco, 5, 3);
            Console.WriteLine("Automovil autito\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCantidad Marchas: {3}\nCantidad Pasajeros: {4}", autito.cantRuedas, autito.cantPuertas, autito.color, autito.cantMarchas, autito.cantPasajeros);
            Console.WriteLine("-----------");
            Moto motito = new Moto(2, 0, eColores.Rojo, 1000);
            Console.WriteLine("Moto motito\nCantidad Ruedas: {0}\nCantidad Puertas: {1}\nColor: {2}\nCilindrada: {3}", motito.cantRuedas, motito.cantPuertas, motito.color, motito.cilindradas);
        }
    }
}
