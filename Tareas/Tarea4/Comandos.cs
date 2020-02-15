using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Tarea4
{
    //Clase Comandos que hereda los metodos y atributos de la clase AdministradorArchivos.
    //Contiene los atributos y metodos de comandos.
    class Comandos : AdministradorArchivo
    {
        //Atributos que conteneedores de comandos y argumentos.
        string comando;
        string argumento;
        string argumento2;
        string history;
        static int i;
        //Métodos get y set de cada argumento.
        public string Argumento
        {
            get { return argumento; }
            set { argumento = value; }
        }
        public string Comando
        {
            get { return comando; }
            set { comando = value; }
        }
        public string Historial
        {
            get { return history; }
            set { history = value; }
        }
        public string Argumento2
        {
            get { return argumento2; }
            set { argumento2 = value; }
        }
        //Método para Listar el Contenido del directorio especificado.
        public void ListarContenido()
        {
            
            string aux2 = "";
            
            int j = Argumento.Length;
            
            try
            {
                //Si el directorio termina con \
                if (Argumento[j - 1] == '\\')
                {
                    aux2 = Argumento.Substring(0, j - 1);
                    Argumento = aux2;
                }
                //Si se trata del directorio "c:\"
                if (Argumento == "c:")
                {
                    Argumento = Argumento + "\\";
                }
                //Si se trata de un subdirectorio de la ruta donde se encuntra el prompt.
                if (!Argumento.Contains("\\") && Argumento != Ruta)
                {
                    Argumento = Ruta + "\\" + Argumento;
                }
                //Si existe el directorio.
                if (Directory.Exists(Argumento))
                {
                    //Variables que guardan la lista de carpetas y archivos del directorio especficado.
                    var files = Directory.EnumerateFiles(Argumento, "*");
                    var directorys = Directory.EnumerateDirectories(Argumento, "*");
                    //Ciclos que imprimen las carpetas y archivos.
                    foreach (string directory in directorys)
                    {
                        if (Argumento == "c:\\")
                        {
                            string directoryName = directory.Substring(Argumento.Length);
                            Console.WriteLine(directoryName);
                        }
                        else
                        {
                            string directoryName = directory.Substring(Argumento.Length + 1);
                            Console.WriteLine(directoryName);
                        }
                    }
                    foreach (string file in files)
                    {
                        if (Argumento == "c:\\")
                        {
                            string fileName = file.Substring(Argumento.Length);
                            Console.WriteLine(fileName);
                        }
                        else
                        {
                            string fileName = file.Substring(Argumento.Length + 1);
                            Console.WriteLine(fileName);
                        }

                    }
                }
                //Si no se encunetra la ruta especificada.
                else
                {
                    Console.WriteLine("El sistema no puede encontrar la ruta especificada");
                }
            }
            //Excepción argumentos invalidos
            catch(IndexOutOfRangeException ie)
            {
                Console.WriteLine("Espacios Invalidos");
            }

 
        }
        //Método que limipia la pantalla.
        public void Limpiar()
        {
            Console.Clear();
        }
        //Método para salir de la aplicación.
        public void Salir()
        {
            Environment.Exit(1);
        }
        //Método para mostrar el historial, de comandos.
        public void MostrarHistorial()
        {
            Console.WriteLine(history);

        }
        //Método para cambiar de directorio.
        public void CambiarDirectorio()
        {
            //Si se trata del comando "cd .."
            if (Argumento == "..")
            {
                string[] aux  = Ruta.Split(@"\");
                string aux2 = "";
                //Ciclo para quitar el última carpeta de la ruta.
                for(int i=0;i<aux.Length-1; i++)
                {
                    //Si la ruta es igual es c:\
                    if(aux.Length-1 == 1)
                    {
                        aux2 = aux[i] + "\\";
                    }
                    //Si se trata de otra ruta.
                    else
                    {
                        if (i == 0)
                        {
                            aux2 = aux2 + aux[i];
                        }
                        else
                        {
                            aux2 = aux2 + "\\" + aux[i];
                        }
                    }

                }
                Ruta = aux2;

            }
            //Si se trata de "cd ruta"
            else
            {
                string aux2 = "";
                int j = Argumento.Length;
                //Si el argumento (ruta) contiene una "\" al finalizar.
                if (Argumento[j - 1] == '\\')
                {
                    aux2 = Argumento.Substring(0, j - 1);
                    Argumento = aux2;
                }
                //Si se trata del directorio "C:\"
                if (Argumento == "c:")
                {
                    Argumento = Argumento + "\\";
                }
                //Si se trata de un subcarpeta del directorio actual del prompt.
                if (!Argumento.Contains("\\") && Argumento != Ruta)
                {
                    Argumento = Ruta + "\\" + Argumento;
                }
                //Si existe el directorio(ruta).
                if (Directory.Exists(Argumento))
                {
                    Ruta = Argumento;
                }
                //Si no existe la ruta.
                else
                {
                    Console.WriteLine("El sistema no puede encontrar la ruta especificada");
                }
            }
        }
        //Método para crear un archivo.
        public void CrearArchivo()
        {
            //Crear un archivo en el directroio actual del prompt.
            if (!Argumento.Contains("\\") && Argumento != Ruta)
            {
                Argumento = Ruta + "\\" + Argumento;
            }
            //Si no existe el archivo.
            if(!File.Exists(Argumento))
            {
                try
                {
                    //Creación del archivo.
                    using (StreamWriter sw = File.CreateText(Argumento));
                }
                catch(IOException io)
                {
                    Console.WriteLine("Nombre del archivo o la ruta no son correctas");
                }
                catch(UnauthorizedAccessException ua)
                {
                    Console.WriteLine("Nombre del archivo o la ruta no son correctas");
                }
            }
            else
            {
                Console.WriteLine("Archivo ya existe");
            }

        }
        //Método para cambiar de directorio un archivo.
        public void MoverArchivo()
        {
            string copy = "";
            string arg = Argumento;
            //Si la directorio a donde se va a mover, no termina con una "\"
            if (!(Argumento2[Argumento2.Length - 1] == '\\'))
            {
                //Si se trata de la ruta del archivo.
                if (Argumento.Contains("\\"))
                {
                    string[] name = Argumento.Split("\\");
                    arg = name[name.Length - 1];
                }
                copy = Argumento2 + "\\" + arg;
            }
            //Si termina en "\"
            else
            {
                if (Argumento.Contains("\\"))
                {
                    string[] name2 = Argumento.Split("\\");
                    arg = name2[name2.Length - 1];
                }
                copy = Argumento2 + arg;
            }
            //Archivo que se encuntra en el directorio actual del prompt.
            if (!Argumento.Contains("\\") && Argumento != Ruta)
            {
                Argumento = Ruta + "\\" + Argumento;
            }
            //Si existe el archivo.
            if(File.Exists(Argumento))
            {
                //Si existe el directorio, destino.
                if(Directory.Exists(Argumento2))
                {
                    try
                    {
                        //Si no existe el archivo en el directorio destino.
                        if (!File.Exists(copy))
                        {
                            File.Copy(Argumento, copy);
                            File.Delete(Argumento);
                        }
                        else
                        {
                            Console.WriteLine("Existe un archivo igual en la directorio destino");
                        }
                    }
                    catch (UnauthorizedAccessException ua)
                    {
                        Console.WriteLine("No cuentas con los privilegios para editar el directorio");
                    }
                }
                //Si los argumentos no tienen el mismo formato.
                else if (Argumento2[0] == ' ')
                {
                    Console.WriteLine("Los argumentos deben llevar el mismo formato");
                    Console.WriteLine("Las dos rutas deben de llevar comillas(\") o sin comillas");
                }
                else
                {
                    Console.WriteLine("Directorio no encontrado");
                }


            }
            else
            {
                Console.WriteLine("Archivo inexistente");
            }
        }
    }
}
