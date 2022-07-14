using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Persona
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaTransaccion { get; set; }
        public decimal MontoTransaccion { get; set; }
        public string Mensaje { get; set; }

    }
}
