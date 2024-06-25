namespace UI
{
    partial class FormFiltrosEventos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            Identificador = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            TiempoRestante = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Lugar = new DataGridViewTextBoxColumn();
            Foto = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            textTituloEntrada = new TextBox();
            btnAplicarTitulo = new Button();
            label3 = new Label();
            dateTimePickerInicio = new DateTimePicker();
            dateTimePickerFin = new DateTimePicker();
            btnAplicarFechas = new Button();
            label4 = new Label();
            label5 = new Label();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Todo", "Proximos Eventos", "Eventos Pasados" });
            comboBox1.Location = new Point(572, 48);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 26);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.SeaGreen;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Identificador, Titulo, Fecha, Hora, TiempoRestante, Tipo, Lugar, Foto });
            dataGridView1.Location = new Point(12, 107);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 35;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(760, 547);
            dataGridView1.TabIndex = 2;
            // 
            // Identificador
            // 
            Identificador.HeaderText = "Id";
            Identificador.Name = "Identificador";
            Identificador.ReadOnly = true;
            Identificador.Width = 30;
            // 
            // Titulo
            // 
            Titulo.HeaderText = "Titulo";
            Titulo.Name = "Titulo";
            Titulo.ReadOnly = true;
            Titulo.Width = 160;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 80;
            // 
            // Hora
            // 
            Hora.HeaderText = "Hora";
            Hora.Name = "Hora";
            Hora.ReadOnly = true;
            Hora.Width = 80;
            // 
            // TiempoRestante
            // 
            TiempoRestante.HeaderText = "Tiempo restante";
            TiempoRestante.Name = "TiempoRestante";
            TiempoRestante.ReadOnly = true;
            TiempoRestante.Width = 160;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo de evento";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Width = 110;
            // 
            // Lugar
            // 
            Lugar.HeaderText = "Lugar";
            Lugar.Name = "Lugar";
            Lugar.ReadOnly = true;
            Lugar.Width = 140;
            // 
            // Foto
            // 
            Foto.HeaderText = "Foto";
            Foto.Name = "Foto";
            Foto.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(572, 10);
            label1.Name = "label1";
            label1.Size = new Size(165, 18);
            label1.TabIndex = 3;
            label1.Text = "Filtrar por tiempo restante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 10);
            label2.Name = "label2";
            label2.Size = new Size(102, 18);
            label2.TabIndex = 4;
            label2.Text = "Filtrar por titulo";
            // 
            // textTituloEntrada
            // 
            textTituloEntrada.Location = new Point(12, 35);
            textTituloEntrada.Margin = new Padding(3, 4, 3, 4);
            textTituloEntrada.Name = "textTituloEntrada";
            textTituloEntrada.Size = new Size(170, 23);
            textTituloEntrada.TabIndex = 5;
            // 
            // btnAplicarTitulo
            // 
            btnAplicarTitulo.Location = new Point(12, 65);
            btnAplicarTitulo.Margin = new Padding(3, 4, 3, 4);
            btnAplicarTitulo.Name = "btnAplicarTitulo";
            btnAplicarTitulo.Size = new Size(170, 30);
            btnAplicarTitulo.TabIndex = 6;
            btnAplicarTitulo.Text = "Aplicar";
            btnAplicarTitulo.UseVisualStyleBackColor = true;
            btnAplicarTitulo.Click += btnAplicarTitulo_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 10);
            label3.Name = "label3";
            label3.Size = new Size(164, 18);
            label3.TabIndex = 7;
            label3.Text = "Filtrar por rango de fechas";
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Location = new Point(240, 35);
            dateTimePickerInicio.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(170, 23);
            dateTimePickerInicio.TabIndex = 8;
            // 
            // dateTimePickerFin
            // 
            dateTimePickerFin.Location = new Point(240, 70);
            dateTimePickerFin.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerFin.Name = "dateTimePickerFin";
            dateTimePickerFin.Size = new Size(170, 23);
            dateTimePickerFin.TabIndex = 9;
            // 
            // btnAplicarFechas
            // 
            btnAplicarFechas.Location = new Point(420, 48);
            btnAplicarFechas.Margin = new Padding(3, 4, 3, 4);
            btnAplicarFechas.Name = "btnAplicarFechas";
            btnAplicarFechas.Size = new Size(100, 30);
            btnAplicarFechas.TabIndex = 10;
            btnAplicarFechas.Text = "Aplicar";
            btnAplicarFechas.UseVisualStyleBackColor = true;
            btnAplicarFechas.Click += btnAplicarFechas_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(207, 35);
            label4.Name = "label4";
            label4.Size = new Size(28, 18);
            label4.TabIndex = 11;
            label4.Text = "De:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(215, 70);
            label5.Name = "label5";
            label5.Size = new Size(20, 18);
            label5.TabIndex = 12;
            label5.Text = "a:";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(602, 669);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(170, 30);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += Volver_Click;
            // 
            // FormFiltrosEventos
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(784, 711);
            Controls.Add(btnVolver);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnAplicarFechas);
            Controls.Add(dateTimePickerFin);
            Controls.Add(dateTimePickerInicio);
            Controls.Add(label3);
            Controls.Add(btnAplicarTitulo);
            Controls.Add(textTituloEntrada);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormFiltrosEventos";
            Text = "Eventos";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox textTituloEntrada;
        private Button btnAplicarTitulo;
        private Label label3;
        private DateTimePicker dateTimePickerInicio;
        private DateTimePicker dateTimePickerFin;
        private Button btnAplicarFechas;
        private Label label4;
        private Label label5;
        private Button btnVolver;
        private DataGridViewTextBoxColumn Identificador;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn TiempoRestante;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Lugar;
        private DataGridViewTextBoxColumn Foto;
    }
}