using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio8
{
    //Clase Auto
    class Auto
    {
        //Atrbutos de la clase Auto
        string marca;
        string modelo;
        string placas;
        double precio;
        int cap_gasolina;
        int cap_pasajeros;
        //Métodos get y set para cada uno de los atributos.
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string Placas
        {
            get { return placas; }
            set { placas = value; }
        }
        public double Precio
        {
            get { return precio; }
            //Validación de precio mayor a 0
            set
            {
                if(value <= 0)
                {
                    Console.WriteLine("El precio es invalido");
                }
                else
                {
                    precio = value;
                }
            }
        }
        public int CapacidadGasolina
        {
            get { return cap_gasolina; }
            //Validación de la capacidad de la gasolina mayor a 0
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Capacidad de Gasolina Invalida");
                }
                else
                {
                    cap_gasolina = value;
                }
            }
        }
        public int CapacidadPasajero
        {
            get { return cap_pasajeros; }
            //Validaciín de la capacidad de pasajeros mayor a 0
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Capacidad de Pasajeros Invalida");
                }
                else
                {
                    cap_pasajeros = value;
                }
            }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        //Método Constructor
        public Auto() { }
        //Método Constructor con sobre cargo
        public Auto(string marca, string modelo, string placas, double precio, int cap_gasolina, int cap_pasajeros)
        {
            //Asigancion de lectura a los atributos de la clase
            this.marca = marca;
            this.modelo = modelo;
            this.placas = placas;
            this.precio = precio;
            this.cap_gasolina = cap_gasolina;
            this.cap_pasajeros = cap_pasajeros;
        }
        //Método que indica que el auto esta avanzando
        public void Avanza()
        {
            Console.WriteLine("El auto {0} {1} con placas {2} esta avanzando.", marca, modelo, placas);
        }
        //Método que indica que el auto esta estacionado
        public void Estaciona()
        {
            Console.WriteLine("El auto {0} {1} con placas {2} se esta estacionando",marca, modelo, placas);
        }
        //Método que indica que el auto esta cargado pasajeros
        public void CargaPasajeros()
        {
            Console.WriteLine("El auto {0} {1} con placas {2} y capacidad de {3} esta cargando personas",marca,modelo,placas,cap_pasajeros);
        }
        //Método que indica que el auto esta cargando gasolina
        public void CargaGasolina()
        {
            Console.WriteLine("El auto {0} {1} con placas {2} y capacidad para gasolina de {3}",marca, modelo, placas, cap_gasolina);
        }
    }
}
