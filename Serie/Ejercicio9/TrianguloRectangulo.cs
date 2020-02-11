using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    //Clase Triangulo Rectangulo
    class TrianguloRectangulo
    {
        //Atributos de la clase TrianguloRectangulo
        double altura;
        double base_t;
        //double hipotenusa;
        //Métodos get y set para cada uno de los atributos.
        public double Altura
        {
            get { return altura; }
            set
            {
                //Validación si el valor ingresado es positivo
                if(value <= 0)
                {
                    Console.WriteLine("Valor del Cateto Invalido, se tomará el valor absoluto");
                    //Valor absoluto del número ingresado
                    altura = Math.Abs(value);
                }
                else
                {
                    //Asignación del valor ingresado a el atributo de la clase.
                    altura = value;
                }
            }
        }
        public double Base
        {
            get { return base_t; }
            set
            {
                //Validación si el valor ingresado es positivo
                if (value <= 0)
                {
                    Console.WriteLine("Valor del Cateto Invalido, se tomará el valor absoluto");
                    //Valor absoluto del número ingresado
                    base_t = Math.Abs(value);
                }
                else
                {
                    //Asignación del valor ingresado a el atributo de la clase.
                    base_t = value;
                }
            }

        }
        //Método Constructor
        public TrianguloRectangulo() { }
        //Método Constructor con Sobrecargo
        public TrianguloRectangulo(double base_t, double altura)
        {
            //Asiganción de los valores ingresados a los atributos de la clase
            this.base_t = base_t;
            this.altura = altura;
        }
        //Método que calcula el área del triangulo rectangulo
        public void Area()
        {
            try
            {
                //Operación de calculo del área
                double area = (base_t * altura) / 2;
                Console.WriteLine("Area del Triangulo Rectangulo: " + area);
            }
            //Excepción división entre 0
            catch(DivideByZeroException dz)
            {
                Console.WriteLine(dz.Message);
            }
            //Excepción desvodamiento de la variable
            catch(OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }
            
        }
        //Método que calcula el perímetro del triangulo rectangulo
        public void Perimetro()
        {
            //Operaciones de calculo del perímetro
            double temp = Math.Pow(base_t, 2) + Math.Pow(altura, 2);
            double hipotenusa = Math.Sqrt(temp);
            double perimetro = base_t + altura + hipotenusa;
            Console.WriteLine("Perimetro del Triangulo Rectangulo: " + perimetro);

        }
        //Método que calcula el angulo del traingulo rectangulo
        public void CalculoAngulos()
        {
            //Calculo de la hipotenusa del triangulo rectangulo
            double temp = Math.Pow(altura, 2) + Math.Pow(base_t, 2);
            double hipotenusa = Math.Sqrt(temp);
            //Calculo del angulo en radianes.
            double ang1 = Math.Asin(base_t / hipotenusa);
            //Operción de conversión de radianes a grados
            double ang1g = ang1 * (180.0 / Math.PI);
            Console.WriteLine("Angulo: " + ang1g);
            //Calculo del angulo en radianes.
            double ang2 = Math.Acos(base_t / hipotenusa);
            //Operción de conversión de radianes a grados
            double ang2g = ang2 * (180.0 / Math.PI);
            Console.WriteLine("Angulo: " + ang2g);
            //double ang3 = Math.Atan(altura / base_t);
            double ang3g = 90.00;
            //Comprobación de suma de angulo = 180
            Console.WriteLine("Angulo: " + ang3g);
            Console.WriteLine("Comprobación de angulos: {0}", ang1g + ang2g + ang3g);


        }

    }
}
