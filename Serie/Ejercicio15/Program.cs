using System;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables del método
            ConsoleKeyInfo op;
            int num1 = 0;
            int num2 = 0;
            //Limpieza de la consola
            Console.Clear();
            //Manejo de Excepciones
            try
            {
                //Lectura de numeros ingresados
                Console.WriteLine("Calculadora");
                Console.WriteLine("Ingresa el primer número: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresa el segundo número: ");
                num2 = Convert.ToInt32(Console.ReadLine());

            }
            //Mensaje de Excepción si no se ingresa el formato adecuado
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("Ingrese dos numeros");
                Console.ReadKey();
            }
            //Mensaje de Excepción se el número ingresado sobrepasa el tamaño del tipo de dato.
            catch(OverflowException oe)
            {
                Console.WriteLine(oe.Message);
                Console.WriteLine("El número es demasiado grande");
                Console.ReadKey();
            }
            //Ciclo si no se ingresa la opcíon de salir
            do
            {
                Console.Clear();
                Console.WriteLine("Número 1: {0}\tNúmero 2: {1}", num1, num2);
                Console.WriteLine("A) Suma");
                Console.WriteLine("B) Resta");
                Console.WriteLine("C) Multiplicación");
                Console.WriteLine("D) División");
                Console.WriteLine("Esc) Salir");
                Console.WriteLine("Selecciones una opción: ");
                //Lectura opción elegida
                op = Console.ReadKey(true);
                switch (op.Key)
                {
                    //Caso Suma de numeros
                    case ConsoleKey.A:
                        Console.WriteLine("Opción Suma");
                        //Impresión del resultado de la suma de dos numeros
                        Console.WriteLine("El resultado de la suma es: " + Suma(num1, num2));
                        Console.ReadKey();
                        break;
                    //Caso Resta de numeros
                    case ConsoleKey.B:
                        Console.WriteLine("Opción Resta");
                        //Inpresión del resultado de la resta de dos numeros
                        Console.WriteLine("El resultado de la resta es: " + Resta(num1, num2));
                        Console.ReadKey();
                        break;
                    //Caso Multiplicación de numeros
                    case ConsoleKey.C:
                        Console.WriteLine("Opción Multiplicaión");
                        //Impresión del resultado de la multiplicación de dos numeros.
                        Console.WriteLine("El resultado de la multiplicación es: " + Multiplicacion(num1, num2));
                        Console.ReadKey();
                        break;
                    //Caso División de numeros.
                    case ConsoleKey.D:
                        Console.WriteLine("Opción División");
                        //Impresión del resultado de la división de dos numeros.
                        Console.WriteLine("El resultado de la division es: {0}",Division(num1, num2));
                        Console.ReadKey();
                        break;
                    //Caso Salir
                    case ConsoleKey.Escape:
                        Console.WriteLine();
                        Console.WriteLine("Adios :)");
                        break;
                }

            } while (op.Key != ConsoleKey.Escape);
            Console.ReadKey();
        }
        //Método que suma dos numeros
        static double Suma(int num1,int num2)
        {
            //Variable que guarda el resultado de la suma
            double resultado=0.0;
            //Manejo de Esxcepciones
            try
            {
                //Operación de suma de dos numeros.
                resultado = num1 + num2;
            }
            //Mensaje desbordamiento de tamaño de la variable.
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
                Console.WriteLine("El número es demasiado grande");
                Console.ReadKey();
            }
            //Retorna el resultado
            return resultado;
        }
        //Método que realiza la suma de dos numeros.
        static double Resta(int num1, int num2)
        {
            //Variable que guarda el resultado de la resta.
            double resultado=0.0;
            //Manejo de Excepciones 
            try
            {
                //Operación de resta.
                resultado = num1 - num2;
            }
            //Mensaje de desbordamiento de tamaño de variable.
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
                Console.WriteLine("El número es demasiado grande");
                Console.ReadKey();
            }
            //Retorno del resultdo e la resta.
            return resultado;
        }
        //Método que multiplica ods numeros.
        static double Multiplicacion(int num1, int num2)
        {
            //Variable que guarda el resultado de la multiplicación.
            double resultado = 0.0;
            //Manejo de Excepciones
            try
            {
                //Operación multiplicación de dos numeros.
                resultado = num1 * num2;
            }
            //Mensaje de desbordamiento de tamaño de variable.
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
                Console.WriteLine("El número es demasiado grande");
                Console.ReadKey();
            }
            //Retorno de resultado de la multiplicación.
            return resultado;
        }
        //Método que divide dos numeros.
        static double Division(int num1, int num2)
        {
            //Variable que guarda el resultado de la división.
            double resultado = 0;
            //Manejo de Excepciones
            try
            {
                //Operación de división.
                resultado = Convert.ToDouble(num1) / num2;
            }
            //Mensaje de excepción división entre 0
            catch(DivideByZeroException dz)
            {
                Console.WriteLine(dz.Message);
                Console.WriteLine("No se puede divir entre cero");
                Console.ReadKey();
            }
            //Mensaje de desbordamiento de tamaño de variable. 
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
                Console.WriteLine("El número es demasiado grande");
                Console.ReadKey();
            }
            //Retorna el resultado de la división.
            return resultado;
        }

    }
}
