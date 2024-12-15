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
    public partial class FmrNuevoMetodo : Form
    {
        PerfumeriaContex context = new PerfumeriaContex();


        public FmrNuevoMetodo()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var MetodoDePago = new MetodoDePago()
            {
                Nombre = txtNombre.Text,
            };
            context.MetodosDePago.Add(MetodoDePago);
            context.SaveChanges();
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
