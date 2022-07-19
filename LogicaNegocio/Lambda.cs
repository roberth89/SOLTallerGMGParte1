using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LogicaNegocio
{
    public class Lambda
    {
        public int LambdaSuma(int numero1, int numero2)
        {
            Func<int, int, int> suma = (a, b) => a + b;
            // Parte de la tarea.
            int resultado = suma(numero1, numero2);

            return resultado;
        }

        public int LambdaMayorNumeros()
        {
            Func<int, int, int> mayor = (a, b) =>
            {
                if (a > b)
                {
                    return a;
                }
                else
                {
                    return b;
                }
            };

            int resultado = mayor(2, 6);
            return resultado;
        }

        public IEnumerable<int> ObtenerPares()
        {
            int[] colas = LogicaNegocio.Lista.Cola().ToArray();

            Func<int, bool> GetPares = (numero) => numero % 2 == 0;

            var pares = colas.Where(GetPares);

            // Modo ejemplo de otra forma de hacerlo sin una funcion anonima
            var paresSinEncapsular = colas.Where((numero) => numero % 2 == 0);

            return pares;
        }
    }
}
