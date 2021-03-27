using System;
using System.Collections.Generic;
using System.Text;


    class Usuario 
    {
        string Tarea { get; set; }
        int Duracion { get; set; }
        double Avance { get; set; }
        string Programador { get; set; }

        public Usuario()
        {

        }

        public Usuario(string tarea, int duracion, double avance, string programador)
        {
            Tarea = tarea;
            Duracion = duracion;
            Avance = avance;
            Programador = programador;
        }


    }
