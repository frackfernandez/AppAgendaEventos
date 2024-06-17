using Business.Implementaciones;
using Business.Interfaces;

namespace UI
{
    public partial class FormFiltrosEventos : Form
    {
        Thread th;

        IServicioEvento servicioEvento;
        public FormFiltrosEventos()
        {
            servicioEvento = new ServicioEvento();
            InitializeComponent();
            MostrarEventos();
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            if (index == 0)
            {
                MostrarEventos();
            }
            if (index == 1)
            {
                MostrarEventosProximos();
            }
            if (index == 2)
            {
                MostrarEventosPasados();
            }

        }
        private void MostrarEventos()
        {
            dataGridView1.Rows.Clear();
            var eventosDto = servicioEvento.MostrarEventos();

            foreach (var item in eventosDto)
            {
                if (item.Fecha < DateOnly.FromDateTime(DateTime.Now))
                {
                    dataGridView1.Rows.Add(item.Identificador.ToString(), item.Titulo, item.Fecha.ToString(), item.Hora, "----", item.Tipo, item.Lugar, item.Foto);
                }
                else
                {
                    dataGridView1.Rows.Add(item.Identificador.ToString(), item.Titulo, item.Fecha.ToString(), item.Hora, ObtenerRestante(item.Identificador), item.Tipo, item.Lugar, item.Foto);
                }

            }
        }
        private void MostrarEventosPasados()
        {
            dataGridView1.Rows.Clear();
            var eventosDto = servicioEvento.MostrarEventos();

            foreach (var item in eventosDto)
            {
                if (item.Fecha < DateOnly.FromDateTime(DateTime.Now))
                {
                    dataGridView1.Rows.Add(item.Identificador.ToString(), item.Titulo, item.Fecha.ToString(), item.Hora, "----", item.Tipo, item.Lugar, item.Foto);
                }
            }
        }
        private void MostrarEventosProximos()
        {
            dataGridView1.Rows.Clear();
            var eventosDto = servicioEvento.MostrarEventos();

            foreach (var item in eventosDto)
            {
                if (item.Fecha >= DateOnly.FromDateTime(DateTime.Now))
                {
                    dataGridView1.Rows.Add(item.Identificador.ToString(), item.Titulo, item.Fecha.ToString(), item.Hora, ObtenerRestante(item.Identificador), item.Tipo, item.Lugar, item.Foto);
                }
            }
        }
        private string ObtenerRestante(int id)
        {
            return servicioEvento.ObtenerTiempoRestante(id);
        }
        private void MostrarTitulo(string tituloentrada)
        {
            dataGridView1.Rows.Clear();
            var eventosDto = servicioEvento.MostrarEventos();

            foreach (var item in eventosDto)
            {
                if (item.Titulo.ToLower().Contains(tituloentrada.ToLower()))
                {
                    if (item.Fecha < DateOnly.FromDateTime(DateTime.Now))
                    {
                        dataGridView1.Rows.Add(item.Identificador.ToString(), item.Titulo, item.Fecha.ToString(), item.Hora, "----", item.Tipo, item.Lugar, item.Foto);
                    }
                    else
                    {
                        dataGridView1.Rows.Add(item.Identificador.ToString(), item.Titulo, item.Fecha.ToString(), item.Hora, ObtenerRestante(item.Identificador), item.Tipo, item.Lugar, item.Foto);
                    }
                }
            }
        }
        private void btnAplicarTitulo_Click(object sender, EventArgs e)
        {
            if (textTituloEntrada.Text == "")
            {
                MessageBox.Show("Por favor llena el campo!");
                return;
            }
            else
            {
                MostrarTitulo(textTituloEntrada.Text);
            }

        }
        private void MostrarFechas(DateOnly finicio, DateOnly ffinal)
        {
            dataGridView1.Rows.Clear();
            var eventosDto = servicioEvento.MostrarEventos();

            foreach (var item in eventosDto)
            {
                if (item.Fecha >= finicio && item.Fecha <= ffinal)
                {
                    if (item.Fecha < DateOnly.FromDateTime(DateTime.Now))
                    {
                        dataGridView1.Rows.Add(item.Identificador.ToString(), item.Titulo, item.Fecha.ToString(), item.Hora, "----", item.Tipo, item.Lugar, item.Foto);
                    }
                    else
                    {
                        dataGridView1.Rows.Add(item.Identificador.ToString(), item.Titulo, item.Fecha.ToString(), item.Hora, ObtenerRestante(item.Identificador), item.Tipo, item.Lugar, item.Foto);
                    }
                }
            }
        }
        private void btnAplicarFechas_Click(object sender, EventArgs e)
        {
            DateOnly finicio = DateOnly.FromDateTime(dateTimePickerInicio.Value);
            DateOnly ffinal = DateOnly.FromDateTime(dateTimePickerFin.Value);

            if (finicio > ffinal)
            {
                MessageBox.Show("La fecha inicial debe ser anterior a la final");
                return;
            }

            MostrarFechas(finicio, ffinal);
        }
        private void Volver_Click(object sender, EventArgs e)
        {
            th = new Thread(openNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
        private void openNewForm()
        {
            Application.Run(new FormPrincipal());
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
