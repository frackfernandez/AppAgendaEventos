using Business.Interfaces;
using CrossCutting;
using Persistence.Implementaciones;
using Persistence.Interfaces;

namespace Business.Implementaciones
{
    public class ServicioEvento : IServicioEvento
    {
        IRepositorioEvento repositorioEvento;
        public ServicioEvento() 
        {
            repositorioEvento = new RepositorioEvento();
        }
        public List<EventoDto> MostrarEventos()
        {
            var eventos = repositorioEvento.MostrarEventos();
            return eventos;
        }
        public void RegistrarEvento(string row)
        {
            repositorioEvento.RegistrarEvento(row);
        }
        public void ModificarEvento(int id, string newrow)
        {
            repositorioEvento.ModificarEvento(id, newrow);
        }
        public void EliminarEvento(int pos)
        {
            repositorioEvento.EliminarEvento(pos);
        }
        public string ObtenerTiempoRestante(int id)
        {
            return repositorioEvento.ObtenerTiempoRestante(id);
        }
    }
}
