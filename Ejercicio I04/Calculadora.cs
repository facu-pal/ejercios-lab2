using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I04
{
    internal class Calculadora
    {
        static public float Calcular(float num1, float num2, string operador)
        {
            float resultado = 0;
            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    if (Validar(num2))
                    {
                        resultado = num1 / num2;
                    }
                    break;
            }
            return resultado;
        }

        static public bool Validar(float num2)
        {
            bool resultado = false;
            if (num2 != 0)
            {
                resultado = true;
            }
            return resultado;
        }


    }
}
