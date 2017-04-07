using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mendoza.Gabriel.Calculadora
{
    public class Numero
    {
        #region Atributos
        public double numero;
        #endregion

        #region Constructores
        public Numero()
        {
            this.numero = 0;
        }

        public Numero(string numero)
        {
            this.setNumero(numero);
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }
        #endregion

        #region Metodos
        
        //Recibe un parámetro del tipo String, que va a ser el número a ser asignado al atributo numero, validando también que este
        //sea de tipo double.

        private void setNumero(string num)
        {
            this.numero = validarNumero(num);
        }

        //Devuelve un double y es el valor que tiene el atributo "numero" actualmente.

        public double getNumero()
        {
            return this.numero;
        }

        //Tranforma el tipo de dato String a double si no logra convertirlo devuelve 0.

        private double validarNumero(string num)
        {
            double numAux = 0;

            double.TryParse(num, out numAux);

            return numAux;
        }

        #endregion        
    }
}
