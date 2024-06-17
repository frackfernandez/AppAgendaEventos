using CrossCutting;
using Persistence.Interfaces;

namespace Persistence.Implementaciones
{
    public class RepositorioEvento : IRepositorioEvento
    {

        string nombreDoc = Directory.GetCurrentDirectory() + @"\evento.txt";

        public RepositorioEvento() {
            if (!File.Exists(nombreDoc))
            {
                File.Create(nombreDoc);
            }
        }
        
        public List<EventoDto> MostrarEventos()
        {
            var eventosDto = new List<EventoDto>();
            var rows = File.ReadAllText(nombreDoc);

            foreach (var row in rows.Split("\n"))
            {
                var datos = row.Split(";");
                var evento = new EventoDto();
                try
                {
                    evento.Identificador = Int32.Parse(datos[0]);
                    evento.Titulo = datos[1];
                    evento.Fecha = DateOnly.FromDateTime(DateTime.Parse(datos[2]));
                    evento.Hora = TimeOnly.FromDateTime(DateTime.Parse(datos[3]));
                    evento.Tipo = datos[4];
                    evento.Lugar = datos[5];
                    evento.Foto = datos[6];
                }
                catch (FormatException)
                { 
                }

                eventosDto.Add(evento);
            }

            return eventosDto;
        }
        public void RegistrarEvento(string row)
        {
            int id = NuevoId();
            StreamWriter sw = File.AppendText(nombreDoc);
            sw.Write($"\n{id};{row}");
            sw.Close();
        }
        public int NuevoId()
        {
            var eventosDto = new List<EventoDto>();
            var rows = File.ReadAllText(nombreDoc);

            int max = 0;

            foreach (var row in rows.Split("\n"))
            {
                var datos = row.Split(";");

                try
                {
                    if (Int32.Parse(datos[0]) > max)
                    {
                        max = Int32.Parse(datos[0]);
                    }
                }
                catch { }
            }

            return max+1;
        }
        public void ModificarEvento(int id,string newrow)
        {
            try
            {
                string todo = File.ReadAllText(nombreDoc);
                string[] lineas = todo.Split("\n");

                for (int i = 0; i < lineas.Length; i++)
                {
                    if (lineas[i].StartsWith(id.ToString()))
                    {
                        lineas[i] = newrow;
                        break;
                    }
                }

                File.WriteAllText(nombreDoc, string.Join("\n", lineas));

            }
            catch (Exception)
            {
            }
        }
        public void EliminarEvento(int pos)
        {
            try
            {
                string todo = File.ReadAllText(nombreDoc);
                string[] lineas = todo.Split("\n");
                
                // Desplaza los elementos restantes hacia la izquierda
                for (int i = pos; i < lineas.Length - 1; i++)
                {
                    lineas[i] = lineas[i + 1];
                }
                
                // Ajusta el tamaño del array eliminando el último elemento duplicado
                Array.Resize(ref lineas, lineas.Length - 1);                

                File.WriteAllText(nombreDoc, string.Join("\n", lineas));

            }
            catch (Exception)
            {
            }
        }
        public string ObtenerTiempoRestante(int id)
        {
            var eventosDto = new List<EventoDto>();
            var rows = File.ReadAllText(nombreDoc);

            foreach (var row in rows.Split("\n"))
            {
                var datos = row.Split(";");
                var evento = new EventoDto();
                try
                {
                    evento.Identificador = Int32.Parse(datos[0]);
                    evento.Titulo = datos[1];
                    evento.Fecha = DateOnly.FromDateTime(DateTime.Parse(datos[2]));
                    evento.Hora = TimeOnly.FromDateTime(DateTime.Parse(datos[3]));
                    evento.Tipo = datos[4];
                    evento.Lugar = datos[5];
                    evento.Foto = datos[6];
                }
                catch (FormatException)
                {
                }

                eventosDto.Add(evento);
            }

            DateTime fechaHoyCompleta = DateTime.Now;
            DateOnly fechahoy = DateOnly.FromDateTime(fechaHoyCompleta);
            int diasR = 0;
            int mesesR = 0;
            int restadiasxmes = 0;

            try
            {
                foreach (var item in eventosDto)
                {
                    if (item.Identificador == id)
                    {
                        diasR = item.Fecha.DayOfYear - fechahoy.DayOfYear;
                        mesesR = item.Fecha.Month - fechahoy.Month;
                        restadiasxmes = diasR - DateTime.DaysInMonth(2024,item.Fecha.Month) - 1;
                    }
                }
            } catch (Exception) { }

            TimeOnly horahoy = TimeOnly.FromDateTime(fechaHoyCompleta);
            int horasR = 0;
            int minutosR = 0;

            try
            {
                foreach (var item in eventosDto)
                {
                    if (item.Identificador == id)
                    {
                        horasR = item.Hora.Hour - horahoy.Hour;
                        minutosR = item.Hora.Minute - horahoy.Minute;
                    }
                }
            } catch (Exception) { }             

            if (diasR <= 0)
            {
                if (horasR <= 0 && minutosR <= 30)
                {
                    return "En directo";
                }
                else if (horasR <= 0 && minutosR > 30)
                {
                    return "Falta 1 hora";
                }
                else if (horasR == 1 && minutosR < 30)
                {
                    return "Falta 1 hora";
                }
                else
                {
                    if (minutosR >= 30)
                    {
                        horasR++;
                    }
                    return $"Faltan {horasR} horas";
                }
            }
            else if (diasR == 1)
            {
                if (horasR < 0)
                {
                    return $"Faltan {horasR * -1} horas";
                }
                else if (horasR == 0)
                {
                    return $"Falta 1 dia";
                }
                else if (horasR == 1)
                {
                    return $"Falta 1 dia y 1 hora";
                }
                else
                {
                    return $"Falta 1 dia y {horasR} horas";
                }
            }
            else if (diasR > 1 && diasR <= 30)
            {
                if (horasR < 1)
                {
                    return $"Faltan {diasR} dias";
                }
                else if (horasR == 1)
                {
                    return $"Faltan {diasR} dias y 1 hora";
                }
                else
                {
                    return $"Faltan {diasR} dias y {horasR} horas";
                }
            }
            else
            {
                if (mesesR == 1 && restadiasxmes <= 0)
                {
                    return "Falta 1 mes";
                }
                else if (mesesR == 1 && restadiasxmes == 1)
                {
                    return "Falta 1 mes y 1 dia";
                }
                else if (mesesR == 1)
                {
                    return $"Falta 1 mes y {restadiasxmes} dias";                    
                }                
                else
                {
                    return $"Faltan {mesesR} meses";
                }
            }
        }
    }
}
