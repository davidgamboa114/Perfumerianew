using Microsoft.EntityFrameworkCore;
using Perfumeria.Data;
using Perfumeria.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Perfumeria.Forms
{
    public partial class FmrEditarProducto : Form
    {
        // Contexto de la base de datos
        PerfumeriaContex context = new PerfumeriaContex();

        // Variable para almacenar el ID del producto a editar
        private int idProductoEditar;

        // Constructor que recibe el ID del producto
        public FmrEditarProducto(int idProductoEditar)
        {
            InitializeComponent();
            this.idProductoEditar = idProductoEditar;
            CargarCategorias(); // Cargar las categorías en el ComboBox
            CargarDatosEnPantalla(); // Cargar los datos del producto
        }

        // Método para cargar las categorías en el ComboBox
        private void CargarCategorias()
        {
            comboCategorias.DataSource = Enum.GetValues(typeof(Categoria)).Cast<Categoria>().ToList();
        }

        // Método para cargar los datos del producto en los controles
        private void CargarDatosEnPantalla()
        {
            // Buscar el producto en la base de datos usando el ID
            var producto = context.Productos.Find(idProductoEditar);

            if (producto != null)
            {
                // Cargar los datos en los controles
                txtNombre.Text = producto.Nombre;
                comboCategorias.SelectedItem = producto.CategoriaProducto; // Seleccionar la categoría actual
            }
            else
            {
                MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para guardar los cambios realizados
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Buscar el producto en la base de datos
            var producto = context.Productos.Find(idProductoEditar);

            if (producto != null)
            {
                // Actualizar los datos del producto con los nuevos valores
                producto.Nombre = txtNombre.Text;
                producto.CategoriaProducto = (Categoria)comboCategorias.SelectedItem; // Actualizar la categoría seleccionada

                // Marcar el producto como modificado
                context.Entry(producto).State = EntityState.Modified;

                try
                {
                    // Guardar los cambios en la base de datos
                    context.SaveChanges();
                    MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Cerrar el formulario después de guardar
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar los cambios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para cancelar la edición y cerrar el formulario
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            // Mostrar mensaje de confirmación antes de cerrar
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de que deseas salir sin guardar los cambios?",
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
