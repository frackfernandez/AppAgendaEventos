using CrossCutting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IServicioEvento
    {
        public List<EventoDto> MostrarEventos();
        public void RegistrarEvento(string row);
        public void ModificarEvento(int id, string row);
        public void EliminarEvento(int pos);
        public string ObtenerTiempoRestante(int id);
    }
}
