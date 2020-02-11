using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    //Clase Circulo
    class Circulo
    {
        //Atributo de la clase circulo
        double radio;
        //Método get y set del atrbuto radio
        public double Radio
        {
            get { return radio; }
            set
            {
                //Validación de l un múmero positivo del radio
                if (value <= 0)
                {
                    Console.WriteLine("Valor del Radio Invalido, se tomará el valor absoluto");
                    //Valor absoluto del número ingresado
                    radio = Math.Abs(value);
                }
                else
                {
                    radio = value;
                }
            }
        }
        //Método Constructor
        public Circulo() { }
        //Método Constructor con Sobrecargo
        public Circulo(double radio)
        {
            //Aasignación de lectura al atributo de la clase
            this.radio = radio;
        }
        //Método que calcula el area del circulo
        public void Area()
        {
            //Operación de calculo del areas
            double area = Math.PI * Math.Pow(radio, 2);
            //Impresión del área
            Console.WriteLine("Area del circulo: " + area);
        }
        //Método que calcula el perimetro del circulo
        public void Perimetro()
        {
            //Operación del calculo del perímetro
            double perimetro = 2 * Math.PI * radio;
            //Impresión del perímetro
            Console.WriteLine("Perimetro del circulo: " + perimetro);
        }
    }       
}
