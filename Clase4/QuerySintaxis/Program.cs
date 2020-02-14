using System;
using System.Linq;
using System.Collections.Generic;

namespace QuerySintaxis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 2, 9, 5, 0, 3, 7, 4, 8, 5 };
            Console.WriteLine("Arreglo Original");
            Imprime(numeros);
            //query que obtiene los numeos mayores  a 4
            var filtered =
                from n in numeros
                where n > 4
                select n;
            Console.WriteLine("Arreglo Filtrado");
            Imprime(filtered);

            //Ordena arreglo 
            var sorted =
                from n in numeros
                orderby n
                select n;
            Console.WriteLine("Arreglo ordenado ascendente");
            Imprime(sorted);

            //Arreglo Descendiente
            var sorDesc =
                from n in numeros
                orderby n descending
                select n;
            Console.WriteLine("Arreglo ordenado descendente");
            Imprime(sorDesc);

            //Arreglo 
            var sorFiltered =
                from n in filtered
                orderby n
                select n;
            Console.WriteLine("Arreglo ordenado y filtrado");
            Imprime(sorFiltered);

            //Arreglo de paises
            string[] paises = { "México", "Rusia", "Chile", "Peru" };

            //paises cuyo nombre contiene a, ordendos por 

            IEnumerable<string> query =
                from p in paises
                where p.Contains("a")
                orderby p.Length
                select p.ToUpper();
            Console.WriteLine("Paises ordenados que contienen a");
            Imprime(query);

            //paises cuya longitud del nombre sea mayor a 5 ordenados
            IEnumerable<string> query2 =
                from p in paises
                where p.Length > 5
                orderby p
                select p;
            Console.WriteLine("Paises cuya longitud del nombre sea mayor a 5 ordenados");
            Imprime(query2);

            //Las iniciales de los paises
            IEnumerable<char> query3 =
                from p in paises
                orderby p.Length
                select p[0];
            Imprime(query3);

            Console.ReadKey();
        }

        static void Imprime<T>(IEnumerable<T> arreglo)
        {
            foreach (var elemento in arreglo)
            {
                Console.WriteLine("{0}", elemento);
            }
        }
    }
}
