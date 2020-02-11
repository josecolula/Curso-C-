/*
 * Investigación clase Math
 * Max =  Devuelve el número mayor de dos valores, Math.Max(x,y)
 * Min = Devuelve el número menor de dos valores, Math.Min(x,y).
 * Round = Redondeo de un número con decimales al valor proximo de acuerdo a las fracciones, Math.Round(x).
 * Sqrt = Obtiene la raíz cuadrada de un número entero o decimal, Math.Sqrt(x).
 * Truncate = Elimina los decimales de un número devolviendo solo la parte entera, Math.truncate(x).
 * Pow = Valor de x elevado a y, Math.Pow(x,y).
 * Exp = Valor de e elevado a x, Math.Exp(x).
 * Log = Logaritmo neperiano de x, Math.Log(x).
 * Random = Número aleatorio entre 0 y 1, Math.Random().
 * Cos = Coseno de x en radianes, Math.Cos(x).
 * Sin = Seno de x en radianes, Math.Sin(x).
 * Tan = Tangente de x, Math.Tan(x).
 * Abs = Valor absoluto de x, Math.Abs(x).
 * Acos = Arco Coseno de x (en radianes), Math.Acos(x)
 * Asin = Arco Seno de x (en radianes), Math.Asin(x)
 * Atan = Arco Tangente de x (en radianes), Math.Atan(x)
*/
using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Figuras");
            //Creación de objeto de las clases Circulo y TrianguloRectangulo
            Circulo c1 = new Circulo(8);
            TrianguloRectangulo t1 = new TrianguloRectangulo(9,6);
            Console.WriteLine();
            Console.WriteLine("Circulo");
            Console.WriteLine("Radio: " + c1.Radio);
            //Lama a los métodos del clase circulo
            c1.Area();
            c1.Perimetro();
            Console.WriteLine();
            Console.WriteLine("Triangulo rectangulo");
            Console.WriteLine("Altura: " + t1.Altura);
            Console.WriteLine("Base: " + t1.Base);
            //Llama a los métodos de la clase TrianguloRectangulo
            t1.Area();
            t1.Perimetro();
            t1.CalculoAngulos();

            Console.ReadKey();
        }
    }
}
