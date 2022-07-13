using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio
{
    public class Cajero
    {
        /// <summary>
        /// dinero actual del cliente variable global privada.
        /// </summary>
        private decimal _dineroActual = 10000;

        private int _contador = 0;

        private const int MAXIMO = 5;

        public Cajero()
        {

        }

        public Cajero(decimal dineroActual, int contador = 0)
        {
            // _dineroActual = dineroActual;
            DineroActual = dineroActual;
            _contador = contador;
        }

        public decimal DineroActual
        {
            get { return _dineroActual; }
            set { _dineroActual = value; }
        }


        public decimal RetirarDinero(decimal montoRetiro, ref string mensaje)
        {
            try
            {

                if (montoRetiro > DineroActual)
                {
                    mensaje = "El monto de retiro: " + montoRetiro + " es mayor al diponible :( ! " + DineroActual;
                }
                else
                {
                    //Acumulador
                    DineroActual = DineroActual - montoRetiro;
                    //DineroActual -= montoRetiro;
                    _contador++;
                    mensaje = "Cuide su dinero tiene disponible " + DineroActual;
                }
                return DineroActual;
            }
            catch(Exception ex)
            {
                throw ex;
            }


        }




    }
}
