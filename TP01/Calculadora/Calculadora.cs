using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mendoza.Gabriel.Calculadora
{
    public class CalculadoraTP

    {
        Numero numero1 = new Numero();
        Numero numero2 = new Numero();

        #region Métodos

        //Se reciben 3 parámetros dos del tipo Clase "Numero" que van a contener los numeros a operar y una variable
        //operador quien va a ser el encargado de hacer la operación. Devuelve un double.

        public double Operar(Numero numero1, Numero numero2, string operador)
        {
            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = numero1.getNumero() + numero2.getNumero();
                    break;

                case "-":
                    resultado = numero1.getNumero() - numero2.getNumero();
                    break;

                case "*":
                    resultado = numero1.getNumero() * numero2.getNumero();
                    break;

                case "/":

                    if (numero2.getNumero() == 0)
                        resultado = 0;
                    else
                        resultado = numero1.getNumero() / numero2.getNumero();
                    break; 
            }

            return resultado;  
        }

        //Se valida que el parametro String operador sea un operador válido sino se le asigna un "+" por defecto a la operacion.

        public string ValidarOperador(string operador)
        {
            string operadorAux = operador;

            if (operador != "+" && operador != "*" && operador != "/" && operador != "-")
            {
                operadorAux = "+";
            }

            return operadorAux;
        }

        #endregion

    }
}
