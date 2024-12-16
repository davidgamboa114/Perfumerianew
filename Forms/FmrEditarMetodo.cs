using Microsoft.EntityFrameworkCore;
using Perfumeria.Data;
using Perfumeria.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Perfumeria.Forms
{
    public partial class FmrEditarMetodo : Form
    {
        private PerfumeriaContex context = new PerfumeriaContex();
        private int idMetodoEditar; // Variable para almacenar el ID del método a editar

        // Constructor que recibe el ID del método a editar
        public FmrEditarMetodo(int idMetodoEditar)
        {
            InitializeComponent();
            this.idMetodoEditar = idMetodoEditar;
            CargarDatosEnPantalla(); // Llamada para cargar los datos del método de pago
        }

        // Método para cargar los datos del método de pago en los controles
        private void CargarDatosEnPantalla()
        {
            var metodoDePago = context.MetodosDePago.Find(idMetodoEditar);

            if (metodoDePago != null)
            {
                // Cargar el nombre del método de pago en el TextBox (puedes agregar más campos si es necesario)
                txtNombre.Text = metodoDePago.Nombre;
            }
            else
            {
                MessageBox.Show("Método de pago no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para guardar los cambios realizados
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var metodoDePago = context.MetodosDePago.Find(idMetodoEditar);

            if (metodoDePago != null)
            {
                // Actualizar los datos del método de pago
                metodoDePago.Nombre = txtNombre.Text;

                // Marcar el objeto como modificado y guardar los cambios
                context.Entry(metodoDePago).State = EntityState.Modified;

                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Método de pago actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Cerrar el formulario después de guardar
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar los cambios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Método de pago no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
