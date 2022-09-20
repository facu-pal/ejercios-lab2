using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad_9
{
    public class VehiculoTerrestre
    {
        public short cantRuedas;
        public short cantPuertas;
        public eColores color;

        public VehiculoTerrestre(short cantRuedas, short cantPuertas, eColores color)
        {
            this.cantRuedas = cantRuedas;
            this.cantPuertas = cantPuertas;
            this.color = color;
        }
    }
}
