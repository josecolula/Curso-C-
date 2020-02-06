using System;

namespace TiposAnonimos
{
    class Porgram
    {
        static void Main()
        {
            var anonimo = new
            {
                Modelo = "Bocho",
                Precio = 8000,
                Placas = "45RT65"
            };
            Console.WriteLine("Datos del objeto anonimo");
            Console.WriteLine(anonimo.Modelo);
            Console.WriteLine(anonimo.Precio);
            Console.WriteLine(anonimo.Placas);

        }
    }
}
