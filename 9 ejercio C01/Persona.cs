using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_entidad_C01
{
    public class Persona
    {
        private long dni;
        private string nombre;


        public long Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public Persona(long dni, string nombre):this(nombre)
        {
            this.dni = dni;

        }

        public virtual string MostrarDatos()
        { 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Dni: " + this.dni.ToString());

            return sb.ToString();
        }





    }
}
