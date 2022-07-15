using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio
{
    public class AlmacenaObjetoNormal
    {
        private readonly Object[] _datosElemento;
        private int _contador = 0;

        
        /// <summary>
        /// Contructor que recibe por parametro el tamaño del arreglo
        /// </summary>
        /// <param name="tamanno">entero para inicializar el arreglo</param>
        public AlmacenaObjetoNormal(int tamanno)
        {
            _datosElemento = new Object[tamanno];
        }

        public void Agregar(Object obj)
        {
            _datosElemento[_contador] = obj;
            _contador++;
        }

        public Object GetElemento(int posicion)
        {
            return _datosElemento[posicion];
        }

    }
}
