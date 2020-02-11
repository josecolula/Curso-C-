using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio6
{
    //clase CuentaBancaria
    class CuentaBancaria
    {
        //Atributos de la clase privados
        string nombre;
        double saldo=0;
        //Métodos Get y Set para los atributos, para lectura y retorno de valores.
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public double Saldo
        {
            get { return saldo; }
            set
            {
                //validación que el saldo que ingrese sea mayor a 0
                if(value < 0)
                {
                    saldo = 0;
                }
                else
                {
                    saldo = value;
                }
            }
        }
        //Método que muestra información
        public void mostrarInformacion()
        {
            //Impresión del valor del saldo y el nombre de la cuenta
            Console.WriteLine("Cuenta: " + nombre);
            Console.WriteLine("Saldo: " + saldo);
        }
        //Método para depositar que aumenta el saldo
        public void Deposito(double cantidad)
        {
            //Se suma la cantidad depositada
            saldo += cantidad;
            //Se imprime lo que se ha depositado y en que cuenta.
            Console.WriteLine("Se ha depositado {0} a la cuenta {1}",cantidad,nombre);
            //Se ejecuta el método mostrar información
            mostrarInformacion();
        }
        //Método para retirar que disminuye el saldo.
        public void Retiro(double cantidad)
        {
            //Validacion que el saldo sea mayor a la cantidad, del retiro.
            if (cantidad > saldo)
            {
                Console.WriteLine("Saldo Insuficiente");
                return;
            }
            //SE resta la candidad del retiro al saldo
            saldo -= cantidad;
            Console.WriteLine("Se ha retirado {0} a la cuenta {1}", cantidad, nombre);
            //Se ejecuta el método mostrarInformacion
            mostrarInformacion();

        }
        //Método constructor con sobrecargo
        public CuentaBancaria(string nombre)
        {
            //Se asigna el nombre al atributo nombre de la clase
            this.nombre = nombre;
            //Se muestra información
            mostrarInformacion();
        }
    }
}
