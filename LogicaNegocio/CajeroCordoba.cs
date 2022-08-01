using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio
{
    public class CajeroCordoba : Cajero
    {
        public CajeroCordoba(decimal dineroActual)
        {
            TipoCambio = 18.63M;
        }

        /// <summary>
        /// Override para indicar que vamos a cambiar la funcionalidad de este meotod, en la clase hija.
        /// Recordar en que en la clase padre, pusimos virual
        /// </summary>
        /// <param name="montoRetiro"></param>
        /// <param name="mensaje"></param>
        /// <param name="tipoCajero"></param>
        /// <returns></returns>
        public override decimal RetirarDinero(decimal montoRetiro, ref string mensaje, string tipoCajero)
        {
            montoRetiro = AsignarTipoCambio(montoRetiro);
            tipoCajero = "Cajero Cordoba";
            var ejemplo = base.RetirarDinero(montoRetiro, ref mensaje, tipoCajero);
            return ejemplo;
        }

        public decimal AsignarTipoCambio(decimal montoRetiro)
        {
            montoRetiro = montoRetiro * TipoCambio;
            return montoRetiro;
        }
    }
}
