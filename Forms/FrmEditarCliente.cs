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
        PerfumeriaContex context = new PerfumeriaContex();
        int idClienteEditado;
        Cliente? cliente;

        public FrmEditarCliente(int idAEditar)
        {
            InitializeComponent();
            this.idClienteEditado = idAEditar;
            LoadCombos();
            CargarDatosPantalla();
        }

        private void CargarDatosPantalla()
        {
            cliente = context.Clientes.Find(idClienteEditado);
            if (cliente != null)
            {
                txtNombre.Text = cliente.Nombre;
                comboProductos.SelectedValue = cliente.ProductoId ?? 0;
                comboArea.SelectedValue = cliente.AreaId ?? 0;
                ComboMetodo.SelectedValue = cliente.MetodoDePagoId ?? 0;
            }
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cliente.Nombre = txtNombre.Text;
            cliente.ProductoId = (int?)comboProductos.SelectedValue;
            cliente.AreaId = (int?)comboArea.SelectedValue;
            cliente.MetodoDePagoId = (int?)ComboMetodo.SelectedValue;

            context.Entry(cliente).State = EntityState.Modified;
            context.SaveChanges();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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
