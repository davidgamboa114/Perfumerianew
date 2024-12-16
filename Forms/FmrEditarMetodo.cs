using Microsoft.EntityFrameworkCore;
using Perfumeria.Data;
using Perfumeria.Forms;
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
    public partial class FmrEditarMetodo : Form
    {
        PerfumeriaContex context = new PerfumeriaContex();
        private int idMetodoEditar;

        public FmrEditarMetodo()
        {
            InitializeComponent();
        }
        public FmrEditarMetodo(int idMetodoEditar)
        {
            this.idMetodoEditar = idMetodoEditar;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var metododepago = context.MetodosDePago.Find(idMetodoEditar);
            metododepago.Nombre = txtNombre.Text;
            context.Entry(metododepago).State = EntityState.Modified;
            context.SaveChanges();
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); DialogResult result = MessageBox.Show(
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
