using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase_3
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        { 
            return titular; 
        }

        public decimal GetCantidad()
        {
            return cantidad;
        }

        public string mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El titular es:{GetTitular()}");
            sb.AppendLine($"Cantidad:{GetCantidad()}");

            return sb.ToString();   
        }

        public void Ingresar(decimal valor) 
        {
            if(valor > 0) 
            { 
                cantidad = cantidad + valor;
            }
            else
            {
                Console.WriteLine($"No se pudo ingresar dinero en la cuenta {GetTitular()}");
            }

        }



        public void Retirar(decimal valor)
        {
                cantidad = cantidad - valor;
            if (!(cantidad >= valor))
            {
                Console.WriteLine($"Se retiro el dinero, su cuenta quedo en negativo, su cuenta es: {GetTitular()}");
            }

        }

    }
}
