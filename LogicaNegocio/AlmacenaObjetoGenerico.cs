using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio
{
    public class AlmacenaObjetoGenerico<T>
    {
        private readonly T[] _datosElemento;
        private int _contador = 0;

        public AlmacenaObjetoGenerico(int tamanno)
        {
            _datosElemento = new T[tamanno];
        }

        public void Agregar(T obj)
        {
            _datosElemento[_contador] = obj;
            _contador++;
        }

        public T GetElemento(int posicion)
        {
            return _datosElemento[posicion];
        }

    }
}
