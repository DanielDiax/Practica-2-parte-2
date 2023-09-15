using System;
using System.Collections.Generic;

namespace Practica_2_parte_2
{
    class Program
    {
        static void Main(string[] args)
        {

            ITarea tarea1 = new Tarea("Tarea 1", 2);
            ITarea tarea2 = new Tarea("Tarea 2", 4);
            ITarea tarea3 = new Tarea("Tarea 3", 5);

            IProyecto proyecto1 = new Proyecto();
            IProyecto proyecto2 = new Proyecto();

            proyecto1.AgregarTarea(tarea1);
            proyecto1.AgregarTarea(tarea2);
            proyecto2.AgregarTarea(tarea3);

            ListaDeTareas listaDeTareas = new ListaDeTareas();
            listaDeTareas.AgregarProyecto(proyecto1);
            listaDeTareas.AgregarProyecto(proyecto2);

            Console.WriteLine(listaDeTareas.ToString());
        }
    }
}
