using System;

namespace AgendaEventos.Dto
{
    public class Evento
    {
        static int cont = 1;
        public Evento(string titulo, DateTime fecha, string hora, string tipo, string lugar) 
        {
            Identificador = cont;
            Titulo = titulo;
            Fecha = fecha;
            Hora = hora;
            Tipo = tipo;
            Lugar = lugar;
            cont++;
        }
        public int Identificador {  get; set; }
        public string Titulo { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string Tipo { get; set; }
        public string Lugar { get; set; }
        //public IServicioEvento servicioEvento=null;

        public void Prueba2()
        {

        }
    }
}
