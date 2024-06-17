namespace CrossCutting
{
    public class EventoDto
    {
        public int Identificador {  get; set; }
        public string Titulo { get; set; }
        public DateOnly Fecha { get; set; }
        public TimeOnly Hora { get; set; }
        public string Tipo { get; set; }
        public string Lugar { get; set; }
        public string Foto { get; set; }
    }
}
