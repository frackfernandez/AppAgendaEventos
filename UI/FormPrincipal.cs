using Business.Implementaciones;
using Business.Interfaces;

namespace UI
{
    public partial class FormPrincipal : Form
    {
        Thread th;

        IServicioEvento servicioEvento;
        int indexRow;
        int IdSeleccionado;
        private DateTimePicker timePicker;
        public FormPrincipal()
        {
            servicioEvento = new ServicioEvento();
            InitializeComponent();
            InitializeTimePicker();
            MostrarEventos();
            LimpiarCampos();
        }     
        private void InitializeTimePicker()
        {
            timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            timePicker.Location = new Point(130, 190);
            timePicker.Width = 200;
            Controls.Add(timePicker);
        }        
        private void MostrarEventos()
        {
            dataGridView1.Rows.Clear();
            var eventosDto = servicioEvento.MostrarEventos();

            foreach (var item in eventosDto)
            {
                dataGridView1.Rows.Add(item.Identificador.ToString(), item.Titulo, item.Fecha.ToString(), item.Hora.ToString(), item.Tipo, item.Lugar, item.Foto);
            }
        }
        private void RegistrarEvento()
        {
            DateTime fecha;
            DateTime hora;
            // valida campos vacios
            if (textTitulo.Text == "" || textTipo.Text == "" || textLugar.Text == "" || textFoto.Text == "")
            {
                MessageBox.Show("Campos incompletos!");
                return;
            }
            // valida fecha
            fecha = dateTimePicker1.Value;
            if (dateTimePicker1.Value == DateTime.Now)
            {
                MessageBox.Show("Fecha invalida!");
                return;
            }
            // valid hora
            hora = timePicker.Value;

            // valida tipo de evento (presencial u online)
            if (textTipo.Text.ToLower() == "online")
            {
                // valida URL
                if (!Uri.IsWellFormedUriString(textLugar.Text, UriKind.Absolute))
                {
                    MessageBox.Show("Url invalido");
                    return;
                }
                //if (!textLugar.Text.Contains("zoom.us/j/") && !textLugar.Text.Contains("meet.google.com/"))
                //{
                //    MessageBox.Show("Url invalido");
                //    return;
                //}
            }
            else if (textTipo.Text.ToLower() == "presencial")
            {
                // valida q empiece con "Av."
                if (!textLugar.Text.StartsWith("Av."))
                {
                    MessageBox.Show("El lugar debe iniciar con 'Av.'");
                    return;
                }
            }
            else
            {
                MessageBox.Show("El tipo de evento debe ser presencial u online!");
                return;
            }

            string row = $"{textTitulo.Text};{DateOnly.FromDateTime(fecha)};{DateOnly.FromDateTime(hora)};{textTipo.Text};{textLugar.Text};{GuardarFoto()}";
            servicioEvento.RegistrarEvento(row);
            LimpiarCampos();
        }
        private void ModificarEvento()
        {
            DateTime fecha;
            DateTime hora;
            // valida campos vacios
            if (textTitulo.Text == "" || textTipo.Text == "" || textLugar.Text == "" || textFoto.Text == "")
            {
                MessageBox.Show("Campos incompletos!");
                return;
            }
            // valida fecha
            fecha = dateTimePicker1.Value;
            if (dateTimePicker1.Value == DateTime.Now)
            {
                MessageBox.Show("Fecha invalida!");
                return;
            }
            // valid hora
            hora = timePicker.Value;

            // valida tipo de evento (presencial u online)
            if (textTipo.Text.ToLower() == "online")
            {
                //valida URL
                if (!Uri.IsWellFormedUriString(textLugar.Text, UriKind.Absolute))
                {
                    MessageBox.Show("Url invalido");
                    return;
                }
                //if (!textLugar.Text.Contains("zoom.us/j/") && !textLugar.Text.Contains("meet.google.com/"))
                //{
                //    MessageBox.Show("Url invalido");
                //    return;
                //}
            }
            else if (textTipo.Text.ToLower() == "presencial")
            {
                // valida q empiece con "Av."
                if (!textLugar.Text.StartsWith("Av."))
                {
                    MessageBox.Show("El lugar debe iniciar con 'Av.'");
                    return;
                }
            }
            else
            {
                MessageBox.Show("El tipo de evento debe ser presencial u online!");
                return;
            }

            IdSeleccionado = int.Parse(textId.Text);
            string row = $"{IdSeleccionado};{textTitulo.Text};{DateOnly.FromDateTime(fecha)};{TimeOnly.FromDateTime(hora)};{textTipo.Text};{textLugar.Text};{GuardarFoto()}";
            servicioEvento.ModificarEvento(IdSeleccionado, row);
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            textTitulo.Clear();
            dateTimePicker1.Value = DateTime.Now;
            timePicker.Value = DateTime.Now;
            textTipo.Clear();
            textLugar.Clear();
            textFoto.Clear();
            textId.Clear();
            pictureBox1.Image = null;
        }
        private void EliminarEvento()
        {
            try
            {
                if (textId.Text == "")
                {
                    MessageBox.Show("No se ha seleccionado ningun evento!");
                    return;
                }
                else
                {
                    IdSeleccionado = int.Parse(textId.Text);
                    servicioEvento.EliminarEvento(indexRow);
                }
            }
            catch (Exception) { }

        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarEvento();
            MostrarEventos();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[indexRow];
                textId.Text = row.Cells[0].Value.ToString();
                textTitulo.Text = row.Cells[1].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(row.Cells[2].Value.ToString());
                timePicker.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                textTipo.Text = row.Cells[4].Value.ToString();
                textLugar.Text = row.Cells[5].Value.ToString();
                textFoto.Text = row.Cells[6].Value.ToString();
                //pictureBox1.Image = Image.FromFile(row.Cells[6].Value.ToString());
                Image imagen = Image.FromFile(row.Cells[6].Value.ToString());
                //Image.FromFile(row.Cells[6].Value.ToString()).Dispose();
                pictureBox1.Image = imagen;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ModificarEvento();
            MostrarEventos();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarEvento();
            LimpiarCampos();
            MostrarEventos();
        }
        private void btnMasOpciones_Click(object sender, EventArgs e)
        {
            //Form2 ventana = new Form2();
            //ventana.Show();
            //this.Hide();

            th = new Thread(openNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
        private void openNewForm()
        {
            Application.Run(new FormFiltrosEventos());
        }
        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            CargarFoto();
        }
        private void CargarFoto()
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "archivos de imagenes (*.png; *.jpg; *.jpeg)| *.png; *.jpg; *.jpeg";

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(archivo.FileName);
                textFoto.Text = archivo.FileName;
            }
        }
        private string GuardarFoto()
        {
            string rutaDestino = string.Empty;
            try
            {
                string carpetaDestino = Directory.GetCurrentDirectory() + @"\evento";

                if (!Directory.Exists(carpetaDestino))
                {
                    Directory.CreateDirectory(carpetaDestino);
                }

                rutaDestino = Path.Combine(carpetaDestino, Path.GetFileName(textFoto.Text));

                File.Copy(textFoto.Text, rutaDestino, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al copiar la imagen: " + ex.Message);
            }

            return rutaDestino;
        }

    }
}
