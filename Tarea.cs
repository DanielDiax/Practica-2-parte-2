namespace Practica_2_parte_2
{
    class Tarea: ITarea
    {
        string descripcion = "";
        int prioridad = 0;

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Prioridad { get => prioridad; set => prioridad = value; }


        public Tarea(string descripcion, int prioridad)
        {
            Descripcion = descripcion;
            Prioridad = prioridad;
        }

        public string ObtenerDescripcion()
        {
            return (Descripcion);
        }

        public int ObtenerPrioridad()
        {
            return (Prioridad);
        }
    }
}
