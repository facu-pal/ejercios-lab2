using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Entidades_I02
{
    public sealed class Circulo : Figura
    {
        private float radio;

        public Circulo(float radio)
        {
            this.radio = radio;
        }

        public override string Dibujar()
        {
            return "Dibujando circulo";
        }

        public override double CalcularSuperficie()
        {
            return Math.PI + Math.Pow(radio, 2);
        }
        public override double CalcularPerimetro()
        {
            return 2* Math.PI * radio;
        }
    }
}
