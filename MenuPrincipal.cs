using Perfumeria.Forms;
using Perfumeria.Forms.MetodoDePagoForm;

namespace Perfumeria
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            this.FormClosing += MenuPrincipal_FormClosing; // Asigna el evento correcto
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show(
                "¿Está seguro de que desea salir del sistema?", // Mensaje
                "Confirmar salida",                            // Título
                MessageBoxButtons.YesNo,                       // Botones Sí/No
                MessageBoxIcon.Question                        // Ícono de pregunta
            );

            // Si el usuario elige "No", cancela el cierre del formulario
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Evita que el formulario se cierre
            }
        }

        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AreaForm areaForm = new AreaForm();
            areaForm.ShowDialog();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductoForm productoForm = new ProductoForm();
            productoForm.ShowDialog();
        }

        private void metodoPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetodoDePagoForm metodoDePagoForm = new MetodoDePagoForm();
            metodoDePagoForm.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteForm clienteForm = new ClienteForm();
            clienteForm.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ClienteForm clienteForm = new ClienteForm();
            clienteForm.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ProductoForm productoForm = new ProductoForm();
            productoForm.ShowDialog();
        }

        private void btnAreas_Click(object sender, EventArgs e)
        {
            AreaForm areaForm = new AreaForm();
            areaForm.ShowDialog();
        }

        private void btnMetodo_Click(object sender, EventArgs e)
        {
            MetodoDePagoForm metodoDePagoForm = new MetodoDePagoForm();
            metodoDePagoForm.ShowDialog();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "¿Está seguro de que desea salir del sistema?", // Mensaje
                "Confirmar salida",                            // Título
                MessageBoxButtons.YesNo,                       // Botones Sí/No
                MessageBoxIcon.Question                        // Ícono de pregunta
            );

            // Si el usuario elige "Sí", cierra el formulario
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Cierra toda la aplicación
            }
        }
    }
}
