using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad_9
{
    public class Camion : VehiculoTerrestre
    {

        public short cantMarchas;
        public int pesoDeCarga;

        public Camion(short cantRuedas, short cantPuertas, eColores color, short cantMarchas, int pesoDeCarga):base(cantRuedas,cantPuertas,color)
        {

            this.cantMarchas = cantMarchas;
            this.pesoDeCarga = pesoDeCarga;
        }

    }
}
