﻿using Perfumeria.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfumeria.Forms.MetodoDePago
{
    public partial class MetodoDePago : Form
    {
        public MetodoDePago()
        {
            InitializeComponent();
            CargarGrilla();

        }

        private void CargarGrilla()
        {
            PerfumeriaContex context = new PerfumeriaContex();
            if (txtBusqueda.Text.Length > 0)
            {
                dataGridMetodo.DataSource = context.MetodosDePago.Where(s => s.Nombre.Contains(txtBusqueda.Text)).ToList();
            }
            else
            {
                dataGridMetodo.DataSource = context.MetodosDePago.ToList();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FmrNuevoMetodo fmrNuevoMetodo = new FmrNuevoMetodo();
            fmrNuevoMetodo.ShowDialog();
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idAEliminar = (int)dataGridMetodo.CurrentRow.Cells[0].Value;
            string nombreMetodoEliminar = (string)dataGridMetodo.CurrentRow.Cells[1].Value;
            var resultado = MessageBox.Show($"¿Está seguro que desea Eliminar el metodo de pago {nombreMetodoEliminar}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    var context = new PerfumeriaContex();
                    var metododepago = context.MetodosDePago.Find(idAEliminar);
                    context.MetodosDePago.Remove(metododepago);
                    context.SaveChanges();
                    CargarGrilla();
                }
                catch (Exception error)
                {

                    MessageBox.Show($"Error, ocurrio un problema al intentar borrar el metodo de pago {nombreMetodoEliminar}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}