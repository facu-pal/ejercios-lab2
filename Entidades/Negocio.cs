using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_clase_8
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            clientes = new Queue<Cliente>();
            caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
           get { return clientes.Dequeue(); }
           set { _ = this + value; } //_ es el operador descarte
        }

        public int ClientesPendientes
        {
            get { return clientes.Count; }
        }




        public static bool operator ==(Negocio n, Cliente c)
        {
            bool retorno = false;

            foreach (Cliente item in n.clientes)
            {
                if (c == item)
                {
                    retorno =true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;
            if (n != c)
            {
                n.clientes.Enqueue(c);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ~(Negocio n)
        {
            bool retorno = false;
            if (n.clientes.Count > 0)
            {
                retorno= n.caja.Atender(n.Cliente) ;
            }
            return retorno;
        }

    }
}
