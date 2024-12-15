using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Perfumeria.
namespace Perfumeria.Forms.Area
{
    public partial class FmrNuevaArea : Form
    {
        public FmrNuevaArea()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PerfumeriaContex context = new PerfumeriaContex();
            var profesor = new Profesor()
            {
                Nombre = txtNombre.Text,

            };
            context.Profesores.Add(profesor);
            context.SaveChanges();
            this.Close();
        }
    }
}
