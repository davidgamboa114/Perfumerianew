using Perfumeria.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Perfumeria.Forms.MetodoDePagoForm
{
    public partial class MetodoDePagoForm : Form
    {
        public MetodoDePagoForm()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            PerfumeriaContex context = new PerfumeriaContex();
            if (txtBusqueda.Text.Length > 0)
            {
                dataGridMetodo.DataSource = context.MetodosDePago.Where(s => s.Nombre.Contains(txtBusqueda.Text)).ToList();
            }
            else
            {
                dataGridMetodo.DataSource = context.MetodosDePago.ToList();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FmrNuevoMetodo fmrNuevoMetodo = new FmrNuevoMetodo();
            fmrNuevoMetodo.ShowDialog();
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Intentamos obtener el valor de la celda de manera segura
            var cellValue = dataGridMetodo.CurrentRow.Cells[0].Value;
            if (cellValue != null && int.TryParse(cellValue.ToString(), out int idAEliminar))
            {
                string nombreMetodoEliminar = (string)dataGridMetodo.CurrentRow.Cells[1].Value;

                // Confirmar la eliminación
                var resultado = MessageBox.Show($"¿Está seguro que desea eliminar el método de pago {nombreMetodoEliminar}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        var context = new PerfumeriaContex();
                        var metodoDePago = context.MetodosDePago.Find(idAEliminar);

                        if (metodoDePago != null)
                        {
                            context.MetodosDePago.Remove(metodoDePago);
                            context.SaveChanges();
                            CargarGrilla();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el método de pago para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error al intentar eliminar el método de pago '{nombreMetodoEliminar}'.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("El ID seleccionado no es válido o no se pudo encontrar el valor correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Validamos si se ha seleccionado un método de pago
            var cellValue = dataGridMetodo.CurrentRow?.Cells[0].Value;

            if (cellValue != null && int.TryParse(cellValue.ToString(), out int idMetodoEditar))
            {
                // Verificamos que el formulario FmrEditarMetodo reciba el ID correctamente
                FmrEditarMetodo fmrEditarMetodo = new FmrEditarMetodo(idMetodoEditar);
                fmrEditarMetodo.ShowDialog();

                // Cargar la grilla nuevamente después de editar
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("No se seleccionó un método de pago válido para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
