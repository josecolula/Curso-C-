using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        private static readonly string[] colors = { "Magenta", "Azul", "Amarillo", "Verde", "Naranja", "Morado", "Violeta" };
        private static readonly string[] removeColors = { "Azul", "Amarillo", "Verde" };
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            foreach(var color in colors)
            {
                list.Add(color);
            }

            List<string> removeList = new List<string>(removeColors);
            MostrarLista(list);
            Console.ReadKey();

        }
        public static void MostrarLista(List<string> list)
        {
            foreach(var elemento in list)
            {
                Console.Write("{0} ",elemento);
            }
        }
    }

}
