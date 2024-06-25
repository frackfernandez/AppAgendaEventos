namespace UI
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Identificador = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Lugar = new DataGridViewTextBoxColumn();
            Foto = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textTitulo = new TextBox();
            textLugar = new TextBox();
            textFoto = new TextBox();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            label15 = new Label();
            textId = new TextBox();
            btnMasOpciones = new Button();
            btnCargarFoto = new Button();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            comboBoxTipo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.SeaGreen;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Identificador, Titulo, Fecha, Hora, Tipo, Lugar, Foto });
            dataGridView1.Location = new Point(12, 330);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 35;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(760, 324);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
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
            label1.Location = new Point(300, 10);
            label1.Name = "label1";
            label1.Size = new Size(147, 18);
            label1.TabIndex = 1;
            label1.Text = "CONTROL DE EVENTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 90);
            label2.Name = "label2";
            label2.Size = new Size(49, 18);
            label2.TabIndex = 2;
            label2.Text = "Titulo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 140);
            label3.Name = "label3";
            label3.Size = new Size(50, 18);
            label3.TabIndex = 3;
            label3.Text = "Fecha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 190);
            label4.Name = "label4";
            label4.Size = new Size(42, 18);
            label4.TabIndex = 4;
            label4.Text = "Hora:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 240);
            label5.Name = "label5";
            label5.Size = new Size(109, 18);
            label5.TabIndex = 5;
            label5.Text = "Tipo de Evento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(73, 290);
            label6.Name = "label6";
            label6.Size = new Size(47, 18);
            label6.TabIndex = 6;
            label6.Text = "Lugar:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(350, 40);
            label7.Name = "label7";
            label7.Size = new Size(42, 18);
            label7.TabIndex = 7;
            label7.Text = "Foto:";
            // 
            // textTitulo
            // 
            textTitulo.Location = new Point(130, 90);
            textTitulo.Name = "textTitulo";
            textTitulo.Size = new Size(200, 23);
            textTitulo.TabIndex = 8;
            textTitulo.KeyPress += textTitulo_KeyPress;
            // 
            // textLugar
            // 
            textLugar.Location = new Point(130, 290);
            textLugar.Name = "textLugar";
            textLugar.Size = new Size(200, 23);
            textLugar.TabIndex = 12;
            // 
            // textFoto
            // 
            textFoto.Location = new Point(400, 40);
            textFoto.Name = "textFoto";
            textFoto.ReadOnly = true;
            textFoto.Size = new Size(230, 23);
            textFoto.TabIndex = 13;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(650, 100);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(110, 30);
            btnRegistrar.TabIndex = 14;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(650, 140);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 30);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(650, 180);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(110, 30);
            btnActualizar.TabIndex = 30;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(650, 220);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 30);
            btnEliminar.TabIndex = 31;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(25, 40);
            label15.Name = "label15";
            label15.Size = new Size(95, 18);
            label15.TabIndex = 32;
            label15.Text = "Identificador:";
            // 
            // textId
            // 
            textId.Location = new Point(130, 40);
            textId.Name = "textId";
            textId.ReadOnly = true;
            textId.Size = new Size(200, 23);
            textId.TabIndex = 33;
            // 
            // btnMasOpciones
            // 
            btnMasOpciones.Location = new Point(602, 669);
            btnMasOpciones.Name = "btnMasOpciones";
            btnMasOpciones.Size = new Size(170, 30);
            btnMasOpciones.TabIndex = 36;
            btnMasOpciones.Text = "Aplicar Filtros";
            btnMasOpciones.UseVisualStyleBackColor = true;
            btnMasOpciones.Click += btnMasOpciones_Click;
            // 
            // btnCargarFoto
            // 
            btnCargarFoto.BackColor = SystemColors.Control;
            btnCargarFoto.FlatAppearance.BorderColor = Color.DarkGreen;
            btnCargarFoto.FlatAppearance.BorderSize = 2;
            btnCargarFoto.ForeColor = SystemColors.ControlText;
            btnCargarFoto.Location = new Point(350, 75);
            btnCargarFoto.Name = "btnCargarFoto";
            btnCargarFoto.Size = new Size(110, 30);
            btnCargarFoto.TabIndex = 37;
            btnCargarFoto.Text = "Elegir";
            btnCargarFoto.UseVisualStyleBackColor = false;
            btnCargarFoto.Click += btnCargarFoto_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(350, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(130, 140);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 39;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Presencial", "Online" });
            comboBoxTipo.Location = new Point(130, 237);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(200, 26);
            comboBoxTipo.TabIndex = 40;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(784, 711);
            Controls.Add(comboBoxTipo);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(btnCargarFoto);
            Controls.Add(btnMasOpciones);
            Controls.Add(textId);
            Controls.Add(label15);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(textFoto);
            Controls.Add(textLugar);
            Controls.Add(textTitulo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("Trebuchet MS", 10F);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "FormPrincipal";
            RightToLeft = RightToLeft.No;
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Eventos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textTitulo;
        private TextBox textTipo;
        private TextBox textLugar;
        private TextBox textFoto;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Label label15;
        private TextBox textId;
        private Button btnMasOpciones;
        private Button btnCargarFoto;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn Identificador;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Lugar;
        private DataGridViewTextBoxColumn Foto;
        private ComboBox comboBoxTipo;
    }
}
