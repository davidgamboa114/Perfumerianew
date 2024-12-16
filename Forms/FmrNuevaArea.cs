using Perfumeria.Data;
using Perfumeria.Models;

namespace Perfumeria.Forms
{
    public partial class FmrNuevaArea : Form
    {
        PerfumeriaContex context = new PerfumeriaContex();
        public FmrNuevaArea()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var Area = new Area()
            {
                Nombre = txtNombre.Text,
            };
            context.Areas.Add(Area);
            context.SaveChanges();
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
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
