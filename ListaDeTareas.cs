using System.Collections.Generic;
using System;

namespace Practica_2_parte_2
{
    class ListaDeTareas
    {
        private List<IProyecto> proyectos = new List<IProyecto>();

        public void AgregarProyecto(IProyecto proyecto)
        {
            proyectos.Add(proyecto);
        }

        public int CalcularPrioridadTotalDeTodasLasTareas()
        {
            int totalPrioridad = 0;
            foreach (var proyecto in proyectos)
            {
                totalPrioridad += proyecto.CalcularPrioridadTotal();
            }
            return totalPrioridad;
        }

        public override string ToString()
        {
            return $"Prioridad total de todas las tareas en todos los proyectos: {CalcularPrioridadTotalDeTodasLasTareas()}";
        }
    }
}
