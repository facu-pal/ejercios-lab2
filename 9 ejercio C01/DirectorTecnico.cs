using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_entidad_C01
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        public DirectorTecnico(string nombre) : base(nombre)
        {
        }

        public DirectorTecnico(string nombre,DateTime fechaNacimiento) : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            //sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Nombre "+Nombre);
            sb.AppendLine("fecha de nacimiento: " + this.fechaNacimiento.ToString());
            return sb.ToString();
        }


        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }




        public static bool operator ==(DirectorTecnico t1, DirectorTecnico t2)
        {
            return t1.FechaNacimiento == t2.FechaNacimiento && t1.Nombre == t2.Nombre;
        }

        public static bool operator !=(DirectorTecnico t1, DirectorTecnico t2)
        {
            return !(t1 == t2);
        }




    }
}
