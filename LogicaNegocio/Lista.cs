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

        public static LinkedList<int> LinkedListEjemplo()
        {
            LinkedList<int> numerosLinkedList = new LinkedList<int>();
            LinkedList<int> numerosLinkedListLast = new LinkedList<int>();
            int[] array = new int[6] { 10, 7, 6, 4, 2, 0 };
            foreach (int itemNumero in array)
            {
                numerosLinkedList.AddFirst(itemNumero);
                numerosLinkedListLast.AddLast(itemNumero);
            }
            numerosLinkedList.Remove(7);
            return numerosLinkedList;
        }

        public static Queue<int> Cola()
        {
            Queue<int> numerosCola = new Queue<int>();
            int[] array = new int[6] { 10, 7, 6, 4, 2, 0 };

            foreach (int itemNumero in array)
            {
                numerosCola.Enqueue(itemNumero);
            }

            numerosCola.Dequeue();

            return numerosCola;

        }

        public static Stack<int> Pila()
        {
            Stack<int> numerosPila = new Stack<int>();
            int[] array = new int[6] { 10, 7, 6, 4, 2, 0 };

            foreach (var item in array)
            {
                numerosPila.Push(item);
            }

            if (numerosPila.Count > 0)
            {
                numerosPila.Pop();
            }      

            return numerosPila;

        }

        public static Dictionary<string, int> Diccionario()
        {
            Dictionary<string, int> edades = new Dictionary<string, int>();

            edades.Add("Roberto", 33);
            edades.Add("Juan", 18);

            edades["Maria"] = 25;
            edades["Antonio"] = 88;

            foreach (KeyValuePair<string,int> item in edades)
            {
                //item.Value
                //item.Key
            }

            return edades;
        }

    }
}
