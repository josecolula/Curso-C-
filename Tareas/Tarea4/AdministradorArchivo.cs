using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Tarea4
{
    //Clase AdministradorArchivo guarda los atributos y metodos escenciales. 
    class AdministradorArchivo
    {
        //Atributo que guarada la ruta del prompt.
        string ruta;
        //Método get y set para el atributo ruta.
        public string Ruta
        {
            get { return ruta; }
            set { ruta = value; }
        }
        //Método Constructor.
        public AdministradorArchivo() 
        {
        }
        //Método para iniciar la ruta del prompt.
        public void Iniciar()
        {
            ////Cadena de la ruta hacia el firectorio de documentos.
            ruta = @"c:\Users\" + Environment.UserName + @"\Documents";
            ruta = ruta.ToLower();
            if(!Directory.Exists(ruta))
            {
                ruta = @"c:\Usuarios\" + Environment.UserName + @"\Documentos";
                Console.Write(ruta + "> ");
            }
                       
        }
        //Método de impersión del prompt.
        public void Prompt()
        {
            Console.Write(ruta + "> ");
        }



    }
}
