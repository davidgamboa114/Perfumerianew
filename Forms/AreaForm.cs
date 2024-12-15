using Perfumeria.Data;
using Perfumeria.Forms;
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
    public partial class AreaForm : Form
    {
        public AreaForm()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            PerfumeriaContex context = new PerfumeriaContex();
            if (txtBusqueda.Text.Length > 0)
            {
                dataGridArea.DataSource = context.Areas.Where(s => s.Nombre.Contains(txtBusqueda.Text)).ToList();
            }
            else
            {
                dataGridArea.DataSource = context.Areas.ToList();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idAEliminar = (int)dataGridArea.CurrentRow.Cells[0].Value;
            string nombreAreaEliminar = (string)dataGridArea.CurrentRow.Cells[1].Value;
            var resultado = MessageBox.Show($"¿Está seguro que desea Eliminar el area {nombreAreaEliminar}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    var context = new PerfumeriaContex();
                    var area = context.Areas.Find(idAEliminar);
                    context.Areas.Remove(area);
                    context.SaveChanges();
                    CargarGrilla();
                }
                catch (Exception error)
                {

                    MessageBox.Show($"Error, ocurrio un problema al intentar borrar el area {nombreAreaEliminar}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEditar_Click_2(object sender, EventArgs e)
        {
            int idAEditar = (int)dataGridArea.CurrentRow.Cells[0].Value;
            FmrEditarArea fmrEditarArea = new FmrEditarArea(idAEditar);
            fmrEditarArea.ShowDialog();
            CargarGrilla();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FmrNuevaArea fmrNuevaArea = new FmrNuevaArea();
            fmrNuevaArea.ShowDialog();
            CargarGrilla();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}

