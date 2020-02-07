using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2
{
    class Alumno
    {
        string nombre;
        string ap_p;
        string ap_m;
        int cal_proyecto;
        int cant_tareas;
        int cant_part;
        int cal_final;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string ApellidoPaterno
        {
            get { return ap_p; }
            set { ap_p = value; }
        }
        public string ApellidoMaterno
        {
            get { return ap_m; }
            set { ap_m = value; }
        }
        public int CalificacionProyecto
        {
            get { return cal_proyecto; }
            set
            {
                if(value < 5)
                {
                    cal_proyecto = 5;
                }
                else if(value > 10)
                {
                    cal_proyecto = 10;
                }
                else
                {
                    cal_proyecto = value;
                }
            }
        }
        public int CantidadTareas
        {
            get { return cant_tareas; }
            set
            {
                if(value < 0)
                {
                    cant_tareas = 0;
                }
                else if(value > 5)
                {
                    cant_tareas = 5;
                }
                else
                {
                    cant_tareas = value;
                }
            }
        }
        public int CantidadParticipaciones
        {
            get { return cant_part; }
            set
            {
                if(value < 0)
                {
                    cant_part = 0;
                }
                else
                {
                    cant_part = value;
                }
            }
        }
        public int CalificacionFinal
        {
            get { return cal_final; }
            set
            {
                if(value > 100)
                {
                    cal_final = 100;
                }
                else if (value < 50)
                {
                    cal_final = 50;
                }
                else
                {
                    cal_final = value;
                }
            }
        }
        public Alumno() { }
        public override string ToString()
        {
            return string.Format("Bienvenido a la Calificadora de Alumnos");
        }

    }
}
