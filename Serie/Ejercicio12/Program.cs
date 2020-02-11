using System;
using System.Collections.Generic;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creación de listas para el guardar los productos y los precios
            List<string> productos = new List<string>();
            List<float> precios = new List<float>();
            Console.WriteLine("Presione una tecla para comenzar");
            //Variable de Opción.
            ConsoleKeyInfo op;
            //Lectura de teclado
            op = Console.ReadKey(true);
            //Menu de opciones de la agenda
            //Ciclo mientras sea diferente a la opción A que es AgregarProducto.
            do
            {
                //Limpieza de consola
                Console.Clear();
                //Manejo de Excepciones
                try
                {
                    //Menú de opciones.
                    Console.WriteLine("Lista de compras");
                    Console.WriteLine("A) Agregar Productos");
                    Console.WriteLine("B) Terminar Lista");
                    Console.WriteLine("Selecciones una opción: ");
                    //Lectura de la opción.
                    op = Console.ReadKey(true);
                    switch (op.Key)
                    {
                        //Caso de Agregar un producto.
                        case ConsoleKey.A:
                            Console.WriteLine("Agregar Productos");
                            //Llama al método AgregarProductos y le pasamos las listas.
                            AgregarProductos(productos, precios);
                            Console.ReadKey();
                            break;
                        //Caso de Terminar Lista
                        case ConsoleKey.B:
                            Console.WriteLine("Terminar Lista");
                            //Llamar al método TerminarLista.
                            TerminarLista(productos, precios);
                            Console.ReadKey();
                            break;
                    }
                }
                //Mensaje Excepción si el formato ingresado no es el correcto.
                catch(FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                    Console.ReadKey();
                }


            } while (op.Key != ConsoleKey.B);
            Console.ReadKey();
        }
        //Método que agrega un producto a la lista.
        static void AgregarProductos(List<string> productos, List<float> precios)
        {
            Console.WriteLine("Ingresa el nombre del producto: ");
            //Lectura del nombre del producto.
            string nombre_p = Console.ReadLine();
            //Se agrega el nombre del producto a la lista de productos.
            productos.Add(nombre_p);
            Console.WriteLine("Ingresa el precio del producto: ");
            //Lectura del precio del producto.
            float precio_p = Convert.ToSingle(Console.ReadLine());
            //Se agrega el precio a la lista de precios.
            precios.Add(precio_p);
            Console.WriteLine("Se ha agregado un producto la lista");
        }
        //Método que Temina la lista, dando opción de "comprar" o "dejar producto".
        static void TerminarLista(List<string> productos, List<float> precios)
        {
            Console.Clear();
            //Variable que guarda el total del precio.
            float total=0;
            //Ciclo que imprime los productos con su precio y el total.
            for(int i=0; i< productos.Count; i++)
            {
                //Manejo de Excepciones
                try
                {
                    //indice - producto     precio
                    Console.WriteLine("{0} - {1}\t{2}", i + 1, productos[i], precios[i]);
                    total = total + precios[i];
                }
                //Excepción Argumento fuera de rango.
                catch(ArgumentOutOfRangeException ae)
                {
                    Console.WriteLine(ae.Message);
                    Console.WriteLine("Sea ingresado un dato mal, vuelva a hacer su lista");
                    Console.ReadKey();
                    Environment.Exit(1);
                }
                //Excepción Indice fuera de Rango
                catch(IndexOutOfRangeException ie)
                {
                    Console.WriteLine(ie.Message);
                    Console.WriteLine("Sea ingresado un dato mal, vuelva a hacer su lista");
                    Console.ReadKey();
                    Environment.Exit(1);
                }
                
                
            }
            Console.WriteLine("Total:\t{0}", total);
            Console.WriteLine("Desea:");
            Console.WriteLine("A) Comprar");
            Console.WriteLine("B) Dejar Producto");
            //Variable que almacena la opción.
            ConsoleKeyInfo opcion;
            Console.WriteLine("Selecciones una opción: ");
            opcion = Console.ReadKey(true);
            //Ciclo mientras la opción no sea la A, que es Comprar.
            do
            {
               switch(opcion.Key)
                {
                    //Caso Comprar.
                    case ConsoleKey.A:
                        Console.Clear();
                        Console.WriteLine("Comprar");
                        float tot = 0;
                        //Impresión de la lista de productos, con precios
                        for (int i = 0; i < productos.Count; i++)
                        {
                            //indice - producto     precio 
                            Console.WriteLine("{0} - {1}\t{2}", i + 1, productos[i], precios[i]);
                            tot = tot + precios[i];

                        }
                        //Impresión del total
                        Console.WriteLine("Total:\t{0}", tot);
                        //Mientras el total sea mayor a 500
                        while (tot > 500)
                        {
                            Console.WriteLine("Tiene que dejar producto");
                            Console.WriteLine("Ingrese el indice del producto que desea dejar: ");
                            //Lectura del indice del producto que desea dejar.
                            int indice = Convert.ToInt32(Console.ReadLine());
                            //Mientras el indice sea mayor al número de elementos en la lista, o sea menor igual a 0.
                            while (indice > productos.Count || indice <= 0)
                            {
                                Console.WriteLine("Indice no valido");
                                Console.WriteLine("Ingrese otro: ");
                                //Lectura del inidice del producto a dejar.
                                indice = Convert.ToInt32(Console.ReadLine());
                            }
                            //Eliminar el producto de la lista dado el indice, productos.
                            productos.RemoveAt(indice - 1);
                            //Eliminar el precio del lista dado el indice, precios.
                            precios.RemoveAt(indice - 1);
                            //Calculo del nuevo precio.
                            tot = tot - precios[indice - 1];
                            //Impresión de la lista de productos
                            for (int i = 0; i < productos.Count; i++)
                            {
                                Console.WriteLine("{0} - {1}\t{2}", i + 1, productos[i], precios[i]);
                                //tot = tot + precios[i];

                            }
                            //Impresión del total.
                            Console.WriteLine("Total:\t{0}", tot);
                        }
                        Console.ReadKey();
                        //Salir del programa.
                        Environment.Exit(1);
                        break;
                    //Opción Dejar Producto
                    case ConsoleKey.B:
                        //Si el número de elemntos de la lista sea mayor a 0.
                        if(productos.Count > 0)
                        {
                            //Impresión de la lista con indices, productos y precios.
                            for (int i = 0; i < productos.Count; i++)
                            {
                                //indice - producto     precio 
                                Console.WriteLine("{0} - {1}\t{2}", i + 1, productos[i], precios[i]);

                            }
                            Console.WriteLine("Ingresa el indice: ");
                            //Lectura del indice del producto a dejar.
                            int ind = Convert.ToInt32(Console.ReadLine());
                            //Mientras el indice sea mayor al número de elementos de la lista, o sea menor igual a 0. 
                            while (ind > productos.Count || ind <= 0)
                            {
                                Console.WriteLine("Indice no valido");
                                Console.WriteLine("Ingrese otro: ");
                                //Lectura del indice del producto a dejar.
                                ind = Convert.ToInt32(Console.ReadLine());
                            }
                            //Eliminar elementos de las listas, productos y precios.
                            productos.RemoveAt(ind - 1);
                            precios.RemoveAt(ind - 1);
                        }
                        //Si no hay elementos en la lista.
                        else
                        {
                            Console.WriteLine("No ahi productos que dejar");
                            Console.WriteLine("Vuelva a hacer su lista");
                            Console.ReadKey();
                            //Salir del programa.
                            Environment.Exit(1);
                        }
                        //LLamar al método TerminarLista, recursivo.
                        TerminarLista(productos, precios);
                        break;
                }

            } while (opcion.Key != ConsoleKey.A);

        }
    }

}
