﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio14
{
    //Clase Aviones que hereda de la interfaz ITransportes
    class Aviones : ITransportes
    {
        
        //Atributos heredados
        public string marca { get; set; }
        public string modelo { get; set; }
        //Método heredado de la interfaz, que imprime información que esta acelerando.
        public void Acelerar()
        {
            Console.WriteLine("El avion {0} {1} esta acelerando", marca, modelo);
        }
        //Método heredado de la interfaz, que imprime información que esta frenando.
        public void Frenar()
        {
            Console.WriteLine("El avion {0} {1} esta frenando", marca, modelo);
        }
        //Método heredado de la interfaz, que imprime información que esta girando.
        public void Girar()
        {
            Console.WriteLine("El avion {0} {1} esta girando", marca, modelo);
        }
        //Método Constructor
        public Aviones() { }
        //Método Constructor con sobrecargo
        public Aviones(string marca, string modelo)
        {
            //Asiganción de las variables al atributo.
            this.marca = marca;
            this.modelo = modelo;
        }
    }
}
