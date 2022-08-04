using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio
{
    public class Cajero
    {
        private int _contador = 0;

        private const int MAXIMO = 5;

        public Cajero()
        {

        }

        public Cajero(decimal dineroActual, int contador = 0)
        {
        
            DineroActual = dineroActual;
            _contador = contador;
        }

        public decimal TipoCambio { get; set; } = 0;


        public decimal DineroActual { get; set; } = 10000;


        public virtual decimal RetirarDinero(decimal montoRetiro, ref string mensaje, string tipoCajero = "Cajero Base: ")
        {
            mensaje = tipoCajero;

            if (montoRetiro > DineroActual)
            {
                mensaje += "El monto de retiro: " + montoRetiro + " es mayor al diponible :( ! " + DineroActual;
            }
            else
            {
                //Acumulador
                DineroActual = DineroActual - montoRetiro;               
                _contador++;
                mensaje += "Cuide su dinero tiene disponible " + DineroActual;
            }
            return DineroActual;


        }




    }
}
