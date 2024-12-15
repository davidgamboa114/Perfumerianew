using Microsoft.EntityFrameworkCore;
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
    public partial class FmrEditarProducto : Form
    {
        PerfumeriaContex context = new PerfumeriaContex();
        int idProductoEditado;
        Producto? producto;
        public FmrEditarProducto()
        {
            InitializeComponent();
            this.idProductoEditado = idProductoEditado;
            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {
            PerfumeriaContex context = new PerfumeriaContex();
            producto = context.Productos.Find(idProductoEditado);
            if (producto != null)
            {
                txtNombre.Text = producto.Nombre;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            PerfumeriaContex context = new PerfumeriaContex();
            producto.Nombre = txtNombre.Text;
            context.Entry(producto).State = EntityState.Modified;
            context.SaveChanges();
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
