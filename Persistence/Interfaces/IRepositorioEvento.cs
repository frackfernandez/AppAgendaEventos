using CrossCutting;

namespace Persistence.Interfaces
{
    public interface IRepositorioEvento
    {
        public List<EventoDto> MostrarEventos();
        public void RegistrarEvento(string row);
        public void ModificarEvento(int id, string newrow);
        public void EliminarEvento(int pos);
        public string ObtenerTiempoRestante(int id);
    }
}
