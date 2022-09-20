using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad_9
{
    public class Moto :VehiculoTerrestre
    {
        public short cilindradas;

        public Moto(short cantRuedas, short cantPuertas, eColores color, short cilindradas) : base(cantRuedas, cantPuertas, color)
        {

            this.cilindradas = cilindradas;
        }

    }
}
