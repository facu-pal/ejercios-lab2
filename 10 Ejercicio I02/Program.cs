using System;
using System.Collections.Generic;
using _10_Entidades_I02;
using System.Text;

namespace _10_Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();

            figuras.Add(new Circulo(2));
            figuras.Add(new Cuadrado(3));
            figuras.Add(new Rectangulo(4, 8));

            StringBuilder sb = new StringBuilder();

            foreach (Figura figura in figuras)
            {
                sb.AppendLine();
                sb.AppendFormat("=============== FIGURA {0:0#} ==================\n", figuras.IndexOf(figura) + 1);
                sb.AppendFormat($" Tipo: {figura.GetType()}\n");
                sb.AppendFormat($" {figura.Dibujar()}\n" );
                sb.AppendFormat(" Área: {0:0.00}\n", figura.CalcularSuperficie());
                sb.AppendFormat(" Perímetro: {0:0.00}\n", figura.CalcularPerimetro());
                sb.AppendLine("============================================");
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
