using Perfumeria.Data;
using Perfumeria.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Perfumeria.Forms
{
    public partial class FmrNuevoProducto : Form
    {
        // Instancia del contexto de base de datos
        PerfumeriaContex context = new PerfumeriaContex();

        public FmrNuevoProducto()
        {
            InitializeComponent();
            CargarCategorias(); // Cargar las categorías al inicializar el formulario
        }

        // Método para cargar las categorías en el ComboBox
        private void CargarCategorias()
        {
            comboCategorias.DataSource = Enum.GetValues(typeof(Categoria)).Cast<Categoria>().ToList();
        }

        // Evento del botón Guardar
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que el usuario seleccionó una categoría
            if (comboCategorias.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una categoría.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear y asignar propiedades al nuevo producto
            var Producto = new Producto()
            {
                Nombre = txtNombre.Text,
                CategoriaProducto = (Categoria)comboCategorias.SelectedItem // Asignar la categoría seleccionada
            };

            // Guardar el producto en la base de datos
            context.Productos.Add(Producto);
            context.SaveChanges();

            // Cerrar el formulario
            this.Close();
        }

        // Evento del botón Cancelar
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de que deseas salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
