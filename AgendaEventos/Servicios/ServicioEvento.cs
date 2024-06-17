using AgendaEventos.Dto;
using System.Collections.Generic;

namespace AgendaEventos.Servicios
{
    public static class ServicioEvento
    {
        static List<Evento> listaEventos = new List<Evento> ();

        static string nombreArchivo = "Archivo.txt";

        public static void AgregarEvento(Evento evento)
        {
            listaEventos.Add (evento);
        }
    }    
}
