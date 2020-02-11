using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingresa el tamaño de las matrices: ");
                //Lectura del tamaño de las matrices
                int tam = Convert.ToInt32(Console.ReadLine());
                //Ceación de matrices bidimensionales.
                double[,] m1 = new double[tam, tam];
                double[,] m2 = new double[tam, tam];
                //Lama al método de llenar matrices.
                Console.WriteLine("Matriz 1");
                LlenarMatriz(m1, tam);
                Console.WriteLine("Matriz 2");
                LlenarMatriz(m2, tam);


                ConsoleKeyInfo op;
                //Menu de opciones de la agenda
                do
                {
                    Console.Clear();
                    Console.WriteLine("Matriz 1");
                    //Llama al método Imprimir la matriz 1
                    Imprimir(m1, tam);
                    Console.WriteLine("Matriz 2:");
                    //Llama al método Imprimir la matriz 2
                    Imprimir(m2, tam);
                    Console.WriteLine();
                    Console.WriteLine("Operaciones con Matrices");
                    Console.WriteLine("A) Suma");
                    Console.WriteLine("B) Resta");
                    Console.WriteLine("C) Multiplicación");
                    Console.WriteLine("Esc) Salir");
                    Console.WriteLine("Selecciones una opción: ");
                    //Lectura de la opción.
                    op = Console.ReadKey(true);
                    switch (op.Key)
                    {
                        //Caso de Suma de Matrices
                        case ConsoleKey.A:
                            Console.WriteLine("Opción Suma");
                            //Llama al método Suma 
                            Suma(m1, m2, tam);
                            Console.ReadKey();
                            break;
                        //Caso de Resta de Matrices
                        case ConsoleKey.B:
                            Console.WriteLine("Opción Resta");
                            //Llama al método Resta 
                            Resta(m1, m2, tam);
                            Console.ReadKey();
                            break;
                        //Caso de Multiplicación de Matrices
                        case ConsoleKey.C:
                            Console.WriteLine("Opción Multiplicación");
                            //Llama al método Resta 
                            Multiplicacion(m1, m2, tam);
                            Console.ReadKey();
                            break;
                        //Caso de Salir
                        case ConsoleKey.Escape:
                            Console.WriteLine("Adios :)");
                            break;
                    }

                } while (op.Key != ConsoleKey.Escape);
            }
            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.ReadKey();
                Environment.Exit(1);
            }
            catch(OverflowException oe)
            {
                Console.WriteLine(oe.Message);
                Console.ReadKey();
                Environment.Exit(1);
            }


            Console.ReadKey();
        }
        //Método que ingresa valores a las matrices.
        static void LlenarMatriz(double[,] m1,int tam)
        {
            Console.WriteLine("El pimer número son las filas y el segundo las columnas");
            //Recorrido de Filas de la matriz
            for(int i=0; i < tam;i++)
            {
                //Recorrido de Columnas de la matriz
                for(int j=0;j < tam; j++)
                {
                    //Impresión de posición de la matriz.
                    Console.Write("matriz1[{0}][{1}]: ",i+1,j+1);
                    //Lectura de ingreso del valor en esa posición.
                    m1[i,j] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }
        //Método que imprime la Matriz en formato filas y columnas.
        static void Imprimir(double[,] matriz, int tam)
        {
            //Recorrido de filas de la matriz.
            for (int i = 0; i < tam; i++)
            {
                //Recorrido de columnas de la matriz.
                for (int j = 0; j < tam; j++)
                {
                    //Impresión del valor.
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        //Método que realiza la suma de dos matrices.
        static void Suma(double[,] m1 ,double[,] m2,int tam)
        {
            //Arreglo que guarda el resultado de la suma.
            double[,] resultado = new double[tam, tam];
            //Recorrido de filas de la matriz.
            for(int i=0;i<tam;i++)
            {
                //Recorrido de columnas de la matriz.
                for (int j=0;j<tam;j++)
                {
                    //Operación de suma elemento por elemento.
                    resultado[i, j] = m1[i, j] + m2[i, j];
                }
            }
            Console.WriteLine("Resultado");
            //Llama al método imprimir, para imprimir la matriz resultante.
            Imprimir(resultado,tam);
        }
        static void Resta(double[,] m1, double[,] m2, int tam)
        {
            //Arreglo que guarda el resultado de la suma.
            double[,] resultado = new double[tam, tam];
            //Recorrido de filas de la matriz.
            for (int i = 0; i < tam; i++)
            {
                //Recorrido de columnas de la matriz.
                for (int j = 0; j < tam; j++)
                {
                    //Operación de resta elemento por elemento.
                    resultado[i, j] = m1[i, j] - m2[i, j];
                }
            }
            Console.WriteLine("Resultado");
            //Llama al método imprimir, para imprimir la matriz resultante.
            Imprimir(resultado, tam);
        }
        static void Multiplicacion(double[,] m1, double[,] m2, int tam)
        {
            //Arreglo que guarda el resultado de la suma.
            double[,] resultado = new double[tam, tam];
            //Recorrido de filas de la matriz.
            for (int i = 0; i < tam; i++)
            {
                //Recorrido de columnas de la matriz.
                for (int j = 0; j < tam; j++)
                {
                    //Operación de multiplicación elemento por elemento.
                    resultado[i, j] = m1[i, j] * m2[i, j];
                }
            }
            Console.WriteLine("Resultado");
            //Llama al método imprimir, para imprimir la matriz resultante.
            Imprimir(resultado, tam);
        }

    }
}
