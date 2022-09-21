using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Entidades_I02
{
    public class Rectangulo : Figura
    {

        private float longitudBase;
        private float longitudAltura;




        public Rectangulo(float longitudBase, float longitudAltura)
        {
            this.longitudBase = longitudBase;
            this.longitudAltura = longitudAltura;
        }


        public override string Dibujar()
        {
           return "Dibujando rectangulo";
        }
        public override double CalcularSuperficie()
        {
            return longitudBase * longitudAltura;
        }
        public override double CalcularPerimetro()
        {
            return longitudBase + longitudBase + longitudAltura + longitudAltura;
        }



    }
}
