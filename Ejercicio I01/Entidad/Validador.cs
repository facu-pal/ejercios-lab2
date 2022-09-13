using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01.Entidad
{
    internal class Validador
    {
        static public bool Validar(int valor, int min, int max)
        {
            if (valor >= min && valor <= max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
