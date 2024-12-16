using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using Perfumeria.Data;
using Perfumeria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Perfumeria.ViewReport
{
    public partial class ClienteViewReport : Form
    {
        private ReportViewer reporte;
        private readonly int ClienteId;

        public ClienteViewReport(int clienteId)
        {
            InitializeComponent();
            ClienteId = clienteId; // Cargar el cliente usando el ID
        }

        private void ClienteViewReport_Load(object sender, EventArgs e)
        {
            try
            {
                // Inicializa y configura el ReportViewer
                reporte = new ReportViewer
                {
                    Dock = DockStyle.Fill
                };
                this.Controls.Add(reporte);

                // Configura el reporte embebido
                reporte.LocalReport.ReportEmbeddedResource = "Perfumeria.Reports.ClienteReport.rdlc";

                // Obtén los datos del cliente seleccionado
                var cliente = ObtenerClienteConDatosRelacionados(ClienteId);
                if (cliente == null)
                {
                    MessageBox.Show("No se encontró el cliente con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Prepara los datos para el reporte
                var clienteData = new List<object>
                {
                    new
                    {
                        cliente.Id,
                        cliente.Nombre,
                        ProductoNombre = cliente.Producto?.Nombre ?? "Sin producto",
                        MetodoDePagoNombre = cliente.MetodoDePago?.Nombre ?? "Sin método de pago",
                        AreaNombre = cliente.Area?.Nombre ?? "Sin área"
                    }
                };

                // Limpia y añade la fuente de datos
                reporte.LocalReport.DataSources.Clear();
                reporte.LocalReport.DataSources.Add(new ReportDataSource("DSCliente", clienteData));

                // Configura el modo de visualización
                reporte.SetDisplayMode(DisplayMode.PrintLayout);
                reporte.ZoomMode = ZoomMode.Percent;
                reporte.ZoomPercent = 100;

                // Refresca el reporte
                reporte.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Cliente? ObtenerClienteConDatosRelacionados(int clienteId)
        {
            try
            {
                using (var context = new PerfumeriaContex())
                {
                    // Busca el cliente junto con sus relaciones
                    return context.Clientes
                        .Include(c => c.Producto)
                        .Include(c => c.MetodoDePago)
                        .Include(c => c.Area)
                        .FirstOrDefault(c => c.Id == clienteId);
                }
            }
            catch (Exception ex)
            {
                // Si ocurre un error en la consulta
                MessageBox.Show($"Error al obtener los datos del cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
