using Perfumeria.Data;
using Perfumeria.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Perfumeria.Forms
{
    public partial class AreaForm : Form
    {
        public AreaForm()
        {
            InitializeComponent();
            CargarGrilla();
        }

        // Método para cargar los datos en la grilla
        private void CargarGrilla()
        {
            using (var context = new PerfumeriaContex())
            {
                // Buscar por texto de búsqueda o cargar todas las áreas
                var areas = txtBusqueda.Text.Length > 0
                    ? context.Areas.Where(s => s.Nombre.Contains(txtBusqueda.Text)).ToList()
                    : context.Areas.ToList();

                dataGridArea.DataSource = areas;
            }
        }

        // Eliminar área seleccionada
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            // Verificar si se seleccionó una fila
            if (dataGridArea.CurrentRow != null)
            {
                int idAEliminar = (int)dataGridArea.CurrentRow.Cells[0].Value;
                string nombreAreaEliminar = (string)dataGridArea.CurrentRow.Cells[1].Value;

                var resultado = MessageBox.Show($"¿Está seguro que desea Eliminar el área {nombreAreaEliminar}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        using (var context = new PerfumeriaContex())
                        {
                            var area = context.Areas.Find(idAEliminar);
                            if (area != null)
                            {
                                context.Areas.Remove(area);
                                context.SaveChanges();
                                CargarGrilla(); // Recargar la grilla después de eliminar
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: Ocurrió un problema al intentar eliminar el área {nombreAreaEliminar}. Detalle: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un área para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Editar área seleccionada
        private void btnEditar_Click_2(object sender, EventArgs e)
        {
            // Verificar si se seleccionó una fila
            if (dataGridArea.CurrentRow != null)
            {
                int idAreaEditar = (int)dataGridArea.CurrentRow.Cells[0].Value;
                FmrEditarArea fmrEditarArea = new FmrEditarArea(idAreaEditar);
                fmrEditarArea.ShowDialog();
                CargarGrilla(); // Recargar la grilla después de editar
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un área para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Guardar una nueva área
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FmrNuevaArea fmrNuevaArea = new FmrNuevaArea();
            fmrNuevaArea.ShowDialog();
            CargarGrilla(); // Recargar la grilla después de guardar
        }

        // Buscar mientras se escribe en el campo de búsqueda
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla(); // Recargar la grilla para reflejar la búsqueda
        }

        // Salir del formulario
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
    }
}
