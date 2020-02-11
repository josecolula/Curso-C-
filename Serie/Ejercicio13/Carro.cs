using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio13
{
    //Clase Carro
    class Carro
    {
        //Atributos de la clase Carro
        double peso;
        double altura;
        bool encendido = false;
        //Métodos get y set para obtner y asignar el peso y la altura.
        public double Peso
        {
            get { return peso; }
            
            set
            {
                //Validación si el valor ingreso es mayor a 0
                if (value <= 0 )
                {
                    Console.WriteLine("Peso invalido");
                }
                else
                {
                    //Asignación del valor entrante
                    peso = value;
                }
            }
        }
        public double Altura
        {
            get { return altura; }
            set
            {
                //Validación si el valor ingreso es mayor a 0
                if (value <= 0)
                {
                    Console.WriteLine("Altura invalida");
                }
                else
                {
                    //Asignación del valor entrante
                    altura = value;
                }
            }
        }
        //Método que cambia el estado del atributo "encendido" a true
        public void Encender()
        {
            //Asignación del valor true al atributo encendido
            encendido = true;
            //Mensaje de que el carro esta encendido
            Console.WriteLine("El carro esta encendido");
        }
        //Método que cambia el estado del atributo "encendido" a false
        public void Apagar()
        {
            //Asignación del valor true al atributo encendido
            encendido = false;
            //Mensaje de que el carro esta encendido
            Console.WriteLine("El carro esta apagado");
        }
        //Método que confirma es estado del atributo encendido.
        public void Estado()
        {
            //Si el carro esta encendido
            if(encendido)
            {
                //Mensaje de confirmación que el auto esta encendido.
                Console.WriteLine("Verificación el carro si se encuentra encendido");
            }
            //Si el carro no esta encendido
            else
            {
                //Mensaje de confirmación el carro no esta encendido.
                Console.WriteLine("Verificación el carro si se encuentra apagado");
            }
        }
        //Método Constructor con sobrecargo
        public Carro(double peso, double altura)
        {
            //Asignación de la variable a los atributos de la clase
            this.peso=peso;
            this.altura=altura;
        }
        //Método que informa el Peso y la Altura del carro
        public override string ToString()
        {
            //Retorna una cadena del peso, y la altura.
            return string.Format("El peso es: {0} \nLa altura es: {1}", peso, altura);
        }
    }
}
