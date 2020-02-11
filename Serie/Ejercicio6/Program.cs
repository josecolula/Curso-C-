using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuentas Bancarias");
            //Creación de un objeto de la clase CuentaBancaria
            CuentaBancaria c1 = new CuentaBancaria("Cuenta1");
            //Llamar al método depositar, donde se deposita la cantidad de 400
            c1.Deposito(400.00);
            //Llamar al método retirar, donde se retira la cantidad de  200
            c1.Retiro(200.00);
            //Llamar al método retirar, donde se retira la cantidad de 300
            c1.Retiro(300.00);
            Console.WriteLine();
            Console.WriteLine("\n Cuenta 2");
            //Creación de un objeto de la clase CuentaBancaria
            CuentaBancaria c2 = new CuentaBancaria("Cuenta2");
            //Llamar al método depositar, donde se deposita la cantidad de 600
            c2.Deposito(600.00);
            //Llamar al método retirar, donde se retira la cantidad de 400
            c2.Retiro(400.00);
            //Llamar al método retirar, donde se retira la cantidad de 700
            c2.Retiro(700.00);
            //c1.mostrarInformacion();
            Console.ReadKey();
        }
    }
}
