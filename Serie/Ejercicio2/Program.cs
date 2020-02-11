using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Ingreso de valores num1 y num2
                Console.WriteLine("Ingresa un número del 1 al 9: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresa un número del 1 al 9: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                //Ciclo que pide el valor de num1 y num2 si estos no estan en el rango (1-9)
                while((num1 < 1 || num1 > 9) || (num2 < 1) || (num2) > 9 )
                {
                    //Asignación de valores 
                    Console.WriteLine("Alguno de los numeros no esta en el rango del 1-9 ");
                    Console.WriteLine("Ingresa un número del 1 al 9: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresa un número del 1 al 9: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                }
                SustituyeNumeros(num1, num2);
            }
            //Excepción si no es el formato adecuado de entrada
            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("Ingresa numeros naturales");
            }
            //Excepción si el número ingreso es mayor que el formato.
            catch(OverflowException oe)
            {
                Console.WriteLine(oe.Message);
                Console.WriteLine("Ingresa numeros más pequeños");
            }
            Console.ReadKey();
        }
        //Metodo para sustitución de la palabra clap
        static void SustituyeNumeros(int num1,int num2)
        {
            //Ciclo de impresión del 1 al 100
            for(int i=1; i<=100;i++)
            {
                //Conversión de numeros a caddenas para saber si contiene el número
                string s1 = Convert.ToString(num1);
                string s2 = Convert.ToString(num2);
                string s3 = Convert.ToString(i);
                //Condición de impresión de la palabra clap, si es multiplo de num1 o de num2 o si i contiene a num1 o a num2
                if (((i % num1) == 0) || ((i % num2) == 0) || s3.Contains(s1) || s3.Contains(s2))
                {
                    //número -> clap
                    Console.WriteLine(i+"->"+"clap");
                }
                //Si no es multiplo de alguno número ingresado o no contiene alguno de los numeros ingresados.
                else
                {
                    //numero
                    Console.WriteLine(i);
                }
            }
        }
    }
}
