using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using AgendaEventos.Servicios;
using AgendaEventos.Dto;
using System.IO;

namespace AgendaEventos
{
    public partial class Form1 : Form
    {
        DataTable tabla;
        List<string> lista = new List<string>();
        static int cont = 1;

        string nombreArchivo = @"C:\Users\User\Desktop\doc.txt";


        public Form1()
        {
            InitializeComponent();
            Iniciar();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
        private void btnListar_Click(object sender, EventArgs e)
        {

        }

        private void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Identificador");
            tabla.Columns.Add("Titulo");
            tabla.Columns.Add("Fecha");
            tabla.Columns.Add("Hora");
            tabla.Columns.Add("Tipo de evento");
            tabla.Columns.Add("Lugar");
            dataGridCuadro.DataSource = tabla;
        }
        private void Agregar()
        {
            
            string titulo = textTitulo.Text;
            DateTime fecha = dateTimePickerFecha.Value.Date;
            string hora = textHora.Text;
            string tipo = textTipo.Text;
            string lugar = textLugar.Text;
            
            //ServicioEvento.AgregarEvento(new Evento(titulo, fecha, hora, tipo, lugar));

            string nuevoRegistro = $"{cont},{titulo},{fecha},{hora},{tipo},{lugar}";

            cont++;

            //lista.Add(nuevoRegistro);

            File.WriteAllText(nombreArchivo, nuevoRegistro);
        }
    }
}
