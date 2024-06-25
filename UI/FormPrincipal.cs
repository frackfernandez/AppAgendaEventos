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
            this.StartPosition = FormStartPosition.CenterScreen;
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
                if (item.Identificador == 0)
                {
                    continue;
                }
                dataGridView1.Rows.Add(item.Identificador.ToString(), item.Titulo, item.Fecha.ToString(), item.Hora.ToString(), item.Tipo, item.Lugar, item.Foto);
            }
        }
        private void RegistrarEvento()
        {
            DateOnly soloFecha;
            TimeOnly soloHora;

            // valida campos vacios
            if (textTitulo.Text == "" || comboBoxTipo.SelectedItem is null || textLugar.Text == "" || textFoto.Text == "")
            {
                MessageBox.Show("Campos incompletos!");
                return;
            }
            // valida fecha
            soloFecha = DateOnly.FromDateTime(dateTimePicker1.Value);
            if (soloFecha < DateOnly.FromDateTime(DateTime.Now))
            {
                MessageBox.Show("Fecha atrasada!");
                return;
            }
            // valid hora
            soloHora = TimeOnly.FromDateTime(timePicker.Value);
            if (soloFecha == DateOnly.FromDateTime(DateTime.Now))
            {
                if (soloHora < TimeOnly.FromDateTime(DateTime.Now))
                {
                    MessageBox.Show("Hora atrasada!");
                    return;
                }
            }

            // tipo evento
            if (comboBoxTipo.SelectedItem == "Online") // online
            {
                // valida URL
                if (!Uri.IsWellFormedUriString(textLugar.Text, UriKind.Absolute))
                {
                    MessageBox.Show("Url invalido");
                    return;
                }
            }
            else if (comboBoxTipo.SelectedItem == "Presencial") // presencial
            {
                // valida q empiece con "Av."
                if (!textLugar.Text.StartsWith("Av."))
                {
                    MessageBox.Show("El lugar debe iniciar con 'Av.'");
                    return;
                }
            }

            string row = $"{textTitulo.Text};{soloFecha};{soloHora};{comboBoxTipo.SelectedItem.ToString()};{textLugar.Text};{GuardarFoto()}";
            servicioEvento.RegistrarEvento(row);
            LimpiarCampos();
        }
        private void ModificarEvento()
        {
            DateOnly soloFecha;
            TimeOnly soloHora;

            // valida campos vacios
            if (textTitulo.Text == "" || comboBoxTipo.SelectedItem is null || textLugar.Text == "" || textFoto.Text == "")
            {
                MessageBox.Show("Campos incompletos!");
                return;
            }
            // valida fecha
            soloFecha = DateOnly.FromDateTime(dateTimePicker1.Value);
            if (soloFecha < DateOnly.FromDateTime(DateTime.Now))
            {
                MessageBox.Show("Fecha atrasada!");
                return;
            }
            // valid hora
            soloHora = TimeOnly.FromDateTime(timePicker.Value);
            if (soloFecha == DateOnly.FromDateTime(DateTime.Now))
            {
                if (soloHora < TimeOnly.FromDateTime(DateTime.Now))
                {
                    MessageBox.Show("Hora atrasada!");
                    return;
                }
            }
            // tipo evento
            if (comboBoxTipo.SelectedItem == "Online") // online
            {
                // valida URL
                if (!Uri.IsWellFormedUriString(textLugar.Text, UriKind.Absolute))
                {
                    MessageBox.Show("Url invalido");
                    return;
                }
            }
            else if (comboBoxTipo.SelectedItem == "Presencial") // presencial
            {
                // valida q empiece con "Av."
                if (!textLugar.Text.StartsWith("Av."))
                {
                    MessageBox.Show("El lugar debe iniciar con 'Av.'");
                    return;
                }
            }

            IdSeleccionado = int.Parse(textId.Text);
            string row = $"{IdSeleccionado};{textTitulo.Text};{soloFecha};{soloHora};{comboBoxTipo.SelectedItem.ToString()};{textLugar.Text};{ActualizarFoto()}";
            servicioEvento.ModificarEvento(IdSeleccionado, row);
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            textTitulo.Clear();
            dateTimePicker1.Value = DateTime.Now;
            timePicker.Value = DateTime.Now;
            comboBoxTipo.SelectedIndex = -1;
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
                if (indexRow < 0)
                {
                    return;
                }
                DataGridViewRow row = dataGridView1.Rows[indexRow];
                if (row.Cells[0].Value is null)
                {
                    return;
                }
                textId.Text = row.Cells[0].Value.ToString();
                textTitulo.Text = row.Cells[1].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(row.Cells[2].Value.ToString());
                timePicker.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                comboBoxTipo.Text = row.Cells[4].Value.ToString();
                textLugar.Text = row.Cells[5].Value.ToString();
                textFoto.Text = row.Cells[6].Value.ToString();
                //var aux = row.Cells[6].Value.ToString();
                //var aux2 = ImagenABase64(aux);
                //var aux3 = Base64AImage(aux2);
                //pictureBox1.Image = aux3;
                using (var stream = new MemoryStream(File.ReadAllBytes(row.Cells[6].Value.ToString())))
                {
                    pictureBox1.Image = Image.FromStream(stream);
                }
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
                using (var stream = new MemoryStream(File.ReadAllBytes(archivo.FileName)))
                {
                    pictureBox1.Image = Image.FromStream(stream);
                }
                textFoto.Text = archivo.FileName;
            }
        }
        private string GuardarFoto()
        {
            string rutaDestino = "";
            try
            {
                string carpetaDestino = Directory.GetCurrentDirectory() + @"\evento";
                string nombreFoto = @$"{textTitulo.Text}{Path.GetExtension(textFoto.Text)}";
                rutaDestino = Path.Combine(carpetaDestino, nombreFoto);

                File.Copy(textFoto.Text, rutaDestino, true);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Error al copiar la imagen: " + ex.Message);
            }

            return rutaDestino;
        }
        private string ActualizarFoto()
        {
            string rutaDestino = "";
            try
            {
                string carpetaDestino = Directory.GetCurrentDirectory() + @"\evento";
                string nombreFoto = @$"{textTitulo.Text}{Path.GetExtension(textFoto.Text)}";
                rutaDestino = Path.Combine(carpetaDestino, nombreFoto);

                string rutaAux = Path.Combine(carpetaDestino, Path.GetExtension(textFoto.Text));

                File.Copy(textFoto.Text, rutaAux, true);

                File.Copy(rutaAux, rutaDestino, true);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Error al copiar la imagen: " + ex.Message);
            }

            return rutaDestino;
        }


        private byte[] ImagenABase64(string ruta)
        {
            using (Image image = Image.FromFile(ruta))
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    // Guardar la imagen en el MemoryStream en formato PNG
                    image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);

                    // Convertir el MemoryStream a un arreglo de bytes
                    byte[] imageBytes = memoryStream.ToArray();

                    return imageBytes;
                }
            }
        }
        private Image Base64AImage(byte[] imageBytes)
        {
            using (MemoryStream memoryStream = new MemoryStream(imageBytes))
            {
                // Convertir el MemoryStream a un objeto Image
                Image image = Image.FromStream(memoryStream);
                return image;
            }
        }

        private void textTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento si se presiona un carácter no permitido.
                MessageBox.Show("Prohibido caracteres especiales");
            }
        }
    }
}
