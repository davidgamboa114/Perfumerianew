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
    public partial class FmrNuevoCliente : Form
    {
        PerfumeriaContex context = new PerfumeriaContex();

        public FmrNuevoCliente()
        {
            InitializeComponent();
            LoadCombos();
        }
        private void LoadCombos()
        {

            comboProductos.DataSource = context.Productos.ToList();
            comboProductos.SelectedIndex = -1;
            comboProductos.DisplayMember = "Nombre";
            comboProductos.ValueMember = "Id";

            comboArea.DataSource = context.Areas.ToList();
            comboArea.SelectedIndex = -1;
            comboArea.DisplayMember = "Nombre";
            comboArea.ValueMember = "Id";

            ComboMetodo.DataSource = context.MetodosDePago.ToList();
            ComboMetodo.SelectedIndex = -1;
            ComboMetodo.DisplayMember = "Nombre";
            ComboMetodo.ValueMember = "Id";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var Cliente = new Cliente()
            {
                Nombre = txtNombre.Text,
                ProductoId = (int)comboProductos.SelectedValue,
                AreaId = (int)comboArea.SelectedValue,
                MetodoDePagoId = (int)ComboMetodo.SelectedValue,
            };
            context.Clientes.Add(Cliente);
            context.SaveChanges();
            this.Close();
        }
    }
}
