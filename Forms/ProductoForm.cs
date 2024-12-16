using Perfumeria.Data;
using Perfumeria.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfumeria.Forms
{
    public partial class ProductoForm : Form
    {
        public ProductoForm()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            PerfumeriaContex context = new PerfumeriaContex();
            if (txtBusqueda.Text.Length > 0)
            {
                dataGridProducto.DataSource = context.Productos.Where(s => s.Nombre.Contains(txtBusqueda.Text)).ToList();
            }
            else
            {
                dataGridProducto.DataSource = context.Productos.ToList();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FmrNuevoProducto fmrNuevoProducto = new FmrNuevoProducto();
            fmrNuevoProducto.ShowDialog();
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idProductoEliminar = (int)dataGridProducto.CurrentRow.Cells[0].Value;
            string nombreProductoEliminar = (string)dataGridProducto.CurrentRow.Cells[1].Value;
            var resultado = MessageBox.Show($"¿Está seguro que desea Eliminar el producto {nombreProductoEliminar}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    var context = new PerfumeriaContex();
                    var producto = context.Productos.Find(idProductoEliminar);
                    context.Productos.Remove(producto);
                    context.SaveChanges();
                    CargarGrilla();
                }
                catch (Exception error)
                {

                    MessageBox.Show($"Error, ocurrio un problema al intentar borrar el producto {nombreProductoEliminar}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificar que haya una fila seleccionada en el DataGridView
            if (dataGridProducto.CurrentRow != null)
            {
                // Obtener el ID del producto seleccionado
                int idProductoEditar = (int)dataGridProducto.CurrentRow.Cells[0].Value;

                // Crear una instancia del formulario de edición de producto y pasar el ID
                FmrEditarProducto fmrEditarProducto = new FmrEditarProducto(idProductoEditar);

                // Mostrar el formulario de edición de producto
                fmrEditarProducto.ShowDialog();

                // Recargar la grilla después de la edición
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
