using Perfumeria.Forms;

namespace Perfumeria
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AreaForm areaForm = new AreaForm();
            areaForm.ShowDialog();
        }
    }
}
