using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio
{
    public static class Cuenta
    {
        private static decimal _dineroActual = 10000;
        public static decimal DineroActual
        {
            get { return _dineroActual; }
            set { _dineroActual = value; }
        }

    }
}
