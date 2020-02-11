using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio13
{
    //Método Constructor CarroVW que hereda de la clase Carro
    class CarroVW : Carro
    {
        //Atributos de la clase CarroVW
        string modelo = "VW";
        //Método Constructor con base en los atributos de la clase Carro
        public CarroVW(double peso, double altura) : base(peso,altura) { }
        //Método que informa del modelo del carro
        public string ToString()
        {
            //Retorna una cadena con el modelo.
            return string.Format("El modelo es: {0}",modelo);
        }
    }
}
