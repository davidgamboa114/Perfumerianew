using Microsoft.EntityFrameworkCore;
using Perfumeria.Data;
using Perfumeria.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Perfumeria.Forms
{
    public partial class FrmEditarCliente : Form
    {
        private PerfumeriaContex context = new PerfumeriaContex();
        private int idClienteEditado;
        private Cliente cliente;

        // Constructor con el ID del cliente a editar
        public FrmEditarCliente(int idAEditar)
        {
            InitializeComponent();
            this.idClienteEditado = idAEditar;
            LoadCombos();
            CargarDatosPantalla();
        }

        // Método para cargar los datos del cliente en los controles
        private void CargarDatosPantalla()
        {
            cliente = context.Clientes.Find(idClienteEditado);
            if (cliente != null)
            {
                txtNombre.Text = cliente.Nombre;

                // Seleccionar los valores de los combos
                comboProductos.SelectedValue = cliente.ProductoId ?? -1;  // Usar -1 si es nulo
                comboArea.SelectedValue = cliente.AreaId ?? -1;
                ComboMetodo.SelectedValue = cliente.MetodoDePagoId ?? -1;
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();  // Cerrar si el cliente no es encontrado
            }
        }

        // Método para cargar los datos en los combos
        private void LoadCombos()
        {
            comboProductos.DataSource = context.Productos.ToList();
            comboProductos.DisplayMember = "Nombre";
            comboProductos.ValueMember = "Id";
            comboProductos.SelectedIndex = -1;  // No seleccionar ningún ítem por defecto

            comboArea.DataSource = context.Areas.ToList();
            comboArea.DisplayMember = "Nombre";
            comboArea.ValueMember = "Id";
            comboArea.SelectedIndex = -1;

            ComboMetodo.DataSource = context.MetodosDePago.ToList();
            ComboMetodo.DisplayMember = "Nombre";
            ComboMetodo.ValueMember = "Id";
            ComboMetodo.SelectedIndex = -1;
        }

        // Método para guardar los cambios del cliente
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) ||
                comboProductos.SelectedIndex == -1 ||
                comboArea.SelectedIndex == -1 ||
                ComboMetodo.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Actualizar los datos del cliente
            cliente.Nombre = txtNombre.Text;
            cliente.ProductoId = (int?)comboProductos.SelectedValue;
            cliente.AreaId = (int?)comboArea.SelectedValue;
            cliente.MetodoDePagoId = (int?)ComboMetodo.SelectedValue;

            try
            {
                // Marcar la entrada como modificada y guardar los cambios
                context.Entry(cliente).State = EntityState.Modified;
                context.SaveChanges();
                MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();  // Cerrar el formulario después de guardar
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los cambios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para cancelar la edición y salir
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de que deseas salir sin guardar los cambios?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();  // Cerrar el formulario
            }
        }
    }
}
