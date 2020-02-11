using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio13
{   
    //Clase CarroBWM que hereda de la clase Carro
    class CarroBWM : Carro
    {
        //Atributos de la clase CarroBWM
        string modelo = "BWM";
        //Método Constructor con base en los atributos de la clase Carro
        public CarroBWM(double peso,double altura) : base(peso,altura) { }
        //Método de información del modelo del carro.
        public string ToString()
        {
            //Retorna una cadena con el modelo.
            return string.Format("El modelo es: {0}", modelo);
        }
    }
}
