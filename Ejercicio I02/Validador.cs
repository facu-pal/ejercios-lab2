using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02
{
    internal class Validador
    {
        static public bool ValidarRespuesta()
        {
            char respuesta;
            string charString;
            bool tryPaso;


            Console.WriteLine("¿Desea continuar? (S/N)");
            charString = (Console.ReadLine());
            tryPaso = char.TryParse(charString, out respuesta);

            while (tryPaso != true)
            {
                Console.WriteLine("Error. ¿Desea continuar? (S/N)");
                charString = Console.ReadLine();
                tryPaso = char.TryParse(charString, out respuesta);

            }

            if (respuesta == 's' || respuesta == 'S') 
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

