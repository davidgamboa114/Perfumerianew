using Perfumeria.Data;
using Perfumeria.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfumeria.Forms
{
    public partial class FmrNuevoProducto : Form
    {
        PerfumeriaContex context = new PerfumeriaContex();

        public FmrNuevoProducto()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var Producto = new Producto()
            {
                Nombre = txtNombre.Text,
            };
            context.Productos.Add(Producto);
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
