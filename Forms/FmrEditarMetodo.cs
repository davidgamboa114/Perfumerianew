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
    public partial class FmrEditarMetodo : Form
    {
        PerfumeriaContex context = new PerfumeriaContex();
        int idMetodoEditado;
        MetodoDePago? metododepago;
        private int idMetodoEditar;
        public FmrEditarMetodo()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            PerfumeriaContex context = new PerfumeriaContex();
            MetodoDePago.Nombre = txtNombre.Text;
            context.Entry(area).State = EntityState.Modified;
            context.SaveChanges();
            this.Close();
        }
    }
}
