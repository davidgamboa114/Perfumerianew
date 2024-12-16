
using Microsoft.Reporting.WinForms;
using Perfumeria.Data;
using Perfumeria.Models;
using System.ComponentModel.Design;

namespace Perfumeria.ViewReport
{
    public partial class ClienteViewReport : Form
    {
        private ReportViewer reporte;
        private readonly Cliente ClienteSeleccionado;

        public ClienteViewReport(Cliente cliente)
        {
            InitializeComponent();
            ClienteSeleccionado = cliente;
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
                var cliente = new List<Cliente> { ClienteSeleccionado };

                // Limpia y añade la fuente de datos
                reporte.LocalReport.DataSources.Clear();
                reporte.LocalReport.DataSources.Add(new ReportDataSource("DSCliente", cliente));

                // Configura el modo de visualización
                reporte.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
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
    }
}
