using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad_9
{
    public class Automovil : VehiculoTerrestre
    {

        public short cantMarchas;
        public int cantPasajeros;

        public Automovil(short cantRuedas, short cantPuertas, eColores color, short cantMarchas, int cantPasajeros) : base(cantRuedas, cantPuertas, color)
        {
            this.cantMarchas = cantMarchas;
            this.cantPasajeros = cantPasajeros;
        }
    }
}
