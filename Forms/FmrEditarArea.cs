﻿using Microsoft.EntityFrameworkCore;
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
    public partial class FmrEditarArea : Form
    {
        PerfumeriaContex context = new PerfumeriaContex();
        int idAreaEditado;
        Area? area;

        public FmrEditarArea(int idAreaEditar)
        {
            InitializeComponent();
            this.idAreaEditado = idAreaEditar;
            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {
            PerfumeriaContex context = new PerfumeriaContex();
            area = context.Areas.Find(idAreaEditado);
            if (area != null)
            {
                txtNombre.Text = area.Nombre;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            PerfumeriaContex context = new PerfumeriaContex();
            area.Nombre = txtNombre.Text;
            context.Entry(area).State = EntityState.Modified;
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
