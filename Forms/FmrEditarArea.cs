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
    public partial class FmrEditarArea : Form
    {
        PerfumeriaContex context = new PerfumeriaContex();
        int idCiudadAEditado;
        Area? area;
        private int idAEditar;

        public FmrEditarArea()
        {
            InitializeComponent();
        }

        public FmrEditarArea(int idAEditar)
        {
            this.idAEditar = idAEditar;
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
            this.Close();
        }
    }
}
