using Microsoft.EntityFrameworkCore;
using Perfumeria.Data;
using Perfumeria.Models;
using Perfumeria.ViewReport;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Perfumeria.Forms
{
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
            CargarGrilla();
        }

        // Método para cargar los clientes en el DataGridView
        private void CargarGrilla()
        {
            using (var context = new PerfumeriaContex())
            {
                var clientesConCategoria = context.Clientes
                    .Include(c => c.Producto)
                    .Include(c => c.MetodoDePago)
                    .Include(c => c.Area)
                    .Where(c => string.IsNullOrEmpty(txtBusqueda.Text) || c.Nombre.Contains(txtBusqueda.Text))
                    .Select(c => new
                    {
                        c.Id,
                        c.Nombre,
                        ProductoNombre = c.Producto.Nombre ?? "Sin producto",
                        MetodoDePagoNombre = c.MetodoDePago.Nombre ?? "Sin método de pago",
                        AreaNombre = c.Area.Nombre ?? "Sin área"
                    })
                    .ToList();

                dataGridClientes.DataSource = clientesConCategoria;

                // Configuración de las columnas del DataGridView
                dataGridClientes.Columns.Clear();
                dataGridClientes.Columns.Add("Nombre", "Nombre del Cliente");
                dataGridClientes.Columns["Nombre"].DataPropertyName = "Nombre";

                dataGridClientes.Columns.Add("ProductoNombre", "Producto");
                dataGridClientes.Columns["ProductoNombre"].DataPropertyName = "ProductoNombre";

                dataGridClientes.Columns.Add("MetodoDePagoNombre", "Método de Pago");
                dataGridClientes.Columns["MetodoDePagoNombre"].DataPropertyName = "MetodoDePagoNombre";

                dataGridClientes.Columns.Add("AreaNombre", "Área");
                dataGridClientes.Columns["AreaNombre"].DataPropertyName = "AreaNombre";
            }
        }

        // Crear nuevo cliente
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FmrNuevoCliente fmrNuevoCliente = new FmrNuevoCliente();
            fmrNuevoCliente.ShowDialog();
            CargarGrilla(); // Recargar la grilla después de crear un nuevo cliente
        }

        // Editar cliente seleccionado
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridClientes.CurrentRow != null)
            {
                int idAEditar = (int)dataGridClientes.CurrentRow.Cells[0].Value;

                FrmEditarCliente frmEditarCliente = new FrmEditarCliente(idAEditar);
                frmEditarCliente.ShowDialog();
                CargarGrilla(); // Recargar la grilla después de editar el cliente
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Filtrar resultados mientras se escribe en el campo de búsqueda
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        // Generar reporte del cliente seleccionado
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            var selectedClient = dataGridClientes.CurrentRow?.DataBoundItem as dynamic;

            if (selectedClient != null)
            {
                var clientViewReport = new ClienteViewReport(selectedClient.Id);
                clientViewReport.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para generar el reporte.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Salir de la aplicación
        private void btnSalir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
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

        // Eliminar cliente seleccionado
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridClientes.CurrentRow != null)
            {
                var clienteSeleccionado = dataGridClientes.CurrentRow?.DataBoundItem as dynamic;
                if (clienteSeleccionado != null)
                {
                    int clienteId = clienteSeleccionado.Id;

                    var result = MessageBox.Show(
                        "¿Estás seguro de que deseas eliminar este cliente?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            using (var context = new PerfumeriaContex())
                            {
                                var clienteAEliminar = context.Clientes.Find(clienteId);

                                if (clienteAEliminar != null)
                                {
                                    context.Clientes.Remove(clienteAEliminar);
                                    context.SaveChanges();
                                    MessageBox.Show("Cliente eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CargarGrilla(); // Recargar la grilla después de eliminar
                                }
                                else
                                {
                                    MessageBox.Show("El cliente no se encontró.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al eliminar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un cliente de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
