using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio
{
    /// <summary>
    /// Ejemplo de lista y clase static.
    /// </summary>
    public static class Lista
    {

        public static string[] ListaArray()
        {
            string[] miArrayDeNombresDePerros = new string[4];
            miArrayDeNombresDePerros[0] = "Laika";
            miArrayDeNombresDePerros[1] = "Coco";
            miArrayDeNombresDePerros[2] = "Thor";
            miArrayDeNombresDePerros[3] = "Laika";
            return miArrayDeNombresDePerros;
        }

        public static List<string> ListEjemlo()
        {
            List<string> personaNombres = new List<string>()
            {
                "Nestor","Hazel", "Fernando", "Paco"
            };
            // personaNombres.Add("Nestor");
            // personaNombres.Add("Hazel");
            return personaNombres;
        }

    }
}
