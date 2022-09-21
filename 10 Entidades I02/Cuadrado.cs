using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Entidades_I02
{
    public sealed class Cuadrado : Rectangulo
    {
        public Cuadrado(float longitudLado) : base(longitudLado, longitudLado)
        {

        }
        public override string Dibujar()
        {
            return "Dibujando cuadrado";
        }



    }
}
