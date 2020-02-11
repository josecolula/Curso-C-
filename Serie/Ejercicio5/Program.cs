using System;
using System.Collections.Generic;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, long> agenda = new Dictionary<string, long>();
            try
            {
                ConsoleKeyInfo op;
                //Menu de opciones de la agenda
                do
                {                    
                    Console.Clear();
                    Console.WriteLine("Agenda Virtual");
                    Console.WriteLine("A) Agregar Contacto");
                    Console.WriteLine("B) Eliminar Contacto");
                    Console.WriteLine("C) Buscar Contacto");
                    Console.WriteLine("Esc) Salir");
                    Console.WriteLine("Selecciones una opción: ");
                    op = Console.ReadKey(true);
                    switch (op.Key)
                    {
                        //Caso de Agregar un contacto
                        case ConsoleKey.A:
                            Console.WriteLine("Opción Agregar Contacto");
                            AgregarContacto(agenda);
                            Console.ReadKey();
                            break;
                        //Caso de Eliminar un Contacto
                        case ConsoleKey.B:
                            Console.WriteLine("Opción Eiminar Contacto");
                            EliminarContacto(agenda);
                            Console.ReadKey();
                            break;
                        //Caso de Mostar un Contacto
                        case ConsoleKey.C:
                            Console.WriteLine("Opción Mostrar Contacto");
                            MostrarContacto(agenda);
                            Console.ReadKey();
                            break;
                        //Caso de Salir
                        case ConsoleKey.Escape:
                            Console.WriteLine("Adios :)");
                            break;
                    }

                } while (op.Key != ConsoleKey.Escape);
            }
            //Mensaje de Excepción de Formato Invalido
            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("Ingresa un dato valido");
            }
            Console.ReadKey();

        }
        //Mértodo que agrega un contacto a la agenda (diccionario)
        static void AgregarContacto(Dictionary<string,long> agenda)
        {
            try
            {
                //Ingreso de Datos del Usuario
                Console.WriteLine("Ingrese el nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el número telefonico: ");
                long numero = Convert.ToInt64(Console.ReadLine());
                //Agregar contacto a la agenda (diccionario)
                agenda.Add(nombre, numero);
                Console.WriteLine("Se ha agregado a {0} con el telefono {1}", nombre, agenda[nombre]);
            }
            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch(OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }
            
        }
        //Método que elimina un contacto de la agenda (diccionario)
        static void EliminarContacto(Dictionary<string,long>agenda)
        {
            //Ingreso del nombre del contacto a eliminar
            Console.WriteLine("Ingrese el nombre del contacto: ");
            string nombre_e = Console.ReadLine();
            long numero_e;
            //Si se encuentra el contacto se elimina
            if (agenda.TryGetValue(nombre_e, out numero_e))
            {
                Console.WriteLine("Se ha eliminado a {0} con el telefono {1}", nombre_e, agenda[nombre_e]);
                //Eliminar el contacto con el nombre dado
                agenda.Remove(nombre_e);
            }
            //Si no se encuentra el contacto, se imprime mensaje que no se puede eliminar.
            else
            {
                Console.WriteLine("No se puede eliminar");
                Console.WriteLine("No se encunetra ningún contacto con el nombre: " + nombre_e);
            }

            

        }
        //Método que busca un contacto en la agenda (diccionario)
        static void MostrarContacto(Dictionary<string, long> agenda)
        {
            //Ingreso del nombre del contacto
            Console.WriteLine("Ingrese el nombre del contacto: ");
            string nombre_f = Console.ReadLine();
            long numero_f;
            //Si se encuntra imprime los datos del contacto
            if(agenda.TryGetValue(nombre_f,out numero_f))
            {
                Console.WriteLine("Contacto Encontrado");
                Console.WriteLine("Nombre: " + nombre_f);
                Console.WriteLine("Telefono: " + numero_f);
            }
            //Sino no se encunetra manda mensaje
            else
            {
                Console.WriteLine("No existe un contacto con el nombre " + nombre_f);
            }
        }
    }
}
