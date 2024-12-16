using Microsoft.EntityFrameworkCore;
using Perfumeria.Data;
using Perfumeria.Models;
using Perfumeria.ViewReport;
using System.Data;

namespace Perfumeria.Forms
{
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            using (PerfumeriaContex context = new PerfumeriaContex())
            {
                if (txtBusqueda.Text.Length > 0)
                {
                    // Crear una lista anónima que contiene tanto los datos del cliente como el nombre de las propiedades relacionadas
                    var clientesConCategoria = context.Clientes
                        .Where(c => c.Nombre.Contains(txtBusqueda.Text))  // Filtrar por nombre
                        .Include(c => c.Producto)  // Incluir la relación Producto
                        .Include(c => c.MetodoDePago)  // Incluir la relación MetodoDePago
                        .Include(c => c.Area)  // Incluir la relación Area
                        .Select(c => new
                        {
                            c.Id,  // El ID del cliente
                            c.Nombre,  // Nombre del cliente
                            ProductoNombre = c.Producto.Nombre,  // Nombre del producto
                            MetodoDePagoNombre = c.MetodoDePago.Nombre,  // Nombre del método de pago
                            AreaNombre = c.Area.Nombre  // Nombre del área
                        })
                        .ToList();

                    dataGridClientes.DataSource = clientesConCategoria;
                }
                else
                {
                    // Crear una lista anónima que contiene tanto los datos del cliente como los nombres de las propiedades relacionadas para todos los clientes
                    var clientesConCategoria = context.Clientes
                        .Include(c => c.Producto)
                        .Include(c => c.MetodoDePago)
                        .Include(c => c.Area)
                        .Select(c => new
                        {
                            c.Id,  // El ID del cliente
                            c.Nombre,  // Nombre del cliente
                            ProductoNombre = c.Producto.Nombre,  // Nombre del producto
                            MetodoDePagoNombre = c.MetodoDePago.Nombre,  // Nombre del método de pago
                            AreaNombre = c.Area.Nombre  // Nombre del área
                        })
                        .ToList();

                    dataGridClientes.DataSource = clientesConCategoria;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FmrNuevoCliente fmrNuevoCliente = new FmrNuevoCliente();
            fmrNuevoCliente.ShowDialog();
            CargarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idAEditar = (int)dataGridClientes.CurrentRow.Cells[0].Value;

            FrmEditarCliente frmEditarCliente = new FrmEditarCliente(idAEditar);
            frmEditarCliente.ShowDialog();
            CargarGrilla();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // Obtener el Cliente Seleccionado
            var selectedClient = (Cliente)dataGridClientes.CurrentRow.DataBoundItem;

            if (selectedClient != null)
            {
                // Abre la ventana del reporte nuevo
                var clientViewReport = new ClienteViewReport(selectedClient);
                clientViewReport.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para generar el reporte");
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
