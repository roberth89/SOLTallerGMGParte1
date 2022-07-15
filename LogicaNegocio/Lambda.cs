using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio
{
    public class Lambda
    {
        public int LambdaSuma()
        {
            Func<int, int, int> suma = (a, b) => a + b;
            // Parte de la tarea.
            int resultado = suma(2, 6);

            return resultado;
        }
    }
}
