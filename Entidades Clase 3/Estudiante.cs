using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase_3
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

       static  Estudiante()
        {
            Random random = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public void SetNotaPrimerParcial(int valor)
        {
            if (valor >= 0 && valor <= 10) 
            {
            notaPrimerParcial = valor;
            }
        }  
        
        public void SetNotaSegundoParcial(int valor)
        {
            if (valor >= 0 && valor <= 10) 
            {
                notaSegundoParcial = valor;
            }
        }
        private float CalcularPromedio()
        {
            float resultado;
            resultado = (notaPrimerParcial + notaSegundoParcial) / (float)2;

            return resultado;
        }

        public double CalcularNotaFinal()
        {
            double resultado = -1;

            if(notaPrimerParcial >=4 && notaSegundoParcial >= 4)
            {
                Random rmd = new Random();
                resultado = rmd.Next(6,11);
            }
            return resultado;
        }

        public string Mostrar()
        {
           double notaFinal = CalcularNotaFinal();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"apellido: {apellido} - nombre:{nombre} - legajo {legajo}");
            sb.AppendLine($"Nota primer parcial:{notaPrimerParcial} - Nota segundo parcial:{notaSegundoParcial}");
            sb.AppendLine($"El promedio de los 2 parciales son {CalcularPromedio()}");

           if(notaFinal== -1)
            {
                sb.AppendLine("Alumno desaprobado");

            }
            else
            {
                sb.AppendLine($"Su nota final es:{notaFinal}");
            }

            return sb.ToString();

        }



    }
}
