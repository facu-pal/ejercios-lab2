using System;

namespace _10_Entidades_I02
{
    public abstract class Figura
    {


        public  virtual string  Dibujar()
        {
            return "dibujando forma..";
        }


        public abstract double CalcularSuperficie();
        public abstract double CalcularPerimetro();



    }
}
