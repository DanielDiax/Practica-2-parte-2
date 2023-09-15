using System.Collections.Generic;
using System;

namespace Practica_2_parte_2
{
    class Proyecto : IProyecto
    {
        List<ITarea> tareas = new List<ITarea>();

        public void AgregarTarea(ITarea tarea)
        {
            //Console.WriteLine("Ingrese la cantidad de tareas");
            //int t = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ingrese la descripcion de la tarea");
            //string descripcion = Console.ReadLine();

            //Console.WriteLine("Ingrese la prioridad de la tarea");
            //int prioridad = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < t; i++)
            //{
            //    tareas.Add(new Tarea(descripcion, prioridad));
            //}

            tareas.Add(tarea);
        }

        public int CalcularPrioridadTotal()
        {
            int totalPrioridad = 0;

            foreach (var tarea in tareas)
            {
                totalPrioridad += tarea.ObtenerPrioridad();

            }
            return totalPrioridad;
        }
    }
}
