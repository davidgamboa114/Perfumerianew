namespace Perfumeria
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            areaToolStripMenuItem = new ToolStripMenuItem();
            productoToolStripMenuItem = new ToolStripMenuItem();
            metodoPagoToolStripMenuItem = new ToolStripMenuItem();
            salirDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            btnClientes = new Button();
            btnProductos = new Button();
            btnAreas = new Button();
            btnMetodo = new Button();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, salirDelSistemaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, areaToolStripMenuItem, productoToolStripMenuItem, metodoPagoToolStripMenuItem });
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(48, 20);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(143, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // areaToolStripMenuItem
            // 
            areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            areaToolStripMenuItem.Size = new Size(143, 22);
            areaToolStripMenuItem.Text = "Area";
            areaToolStripMenuItem.Click += areaToolStripMenuItem_Click;
            // 
            // productoToolStripMenuItem
            // 
            productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            productoToolStripMenuItem.Size = new Size(143, 22);
            productoToolStripMenuItem.Text = "Producto";
            productoToolStripMenuItem.Click += productoToolStripMenuItem_Click;
            // 
            // metodoPagoToolStripMenuItem
            // 
            metodoPagoToolStripMenuItem.Name = "metodoPagoToolStripMenuItem";
            metodoPagoToolStripMenuItem.Size = new Size(143, 22);
            metodoPagoToolStripMenuItem.Text = "MetodoPago";
            metodoPagoToolStripMenuItem.Click += metodoPagoToolStripMenuItem_Click;
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            salirDelSistemaToolStripMenuItem.Size = new Size(105, 20);
            salirDelSistemaToolStripMenuItem.Text = "Salir Del Sistema";
            salirDelSistemaToolStripMenuItem.Click += salirDelSistemaToolStripMenuItem_Click;
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(126, 78);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(113, 64);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(126, 312);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(113, 64);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnAreas
            // 
            btnAreas.Location = new Point(537, 78);
            btnAreas.Name = "btnAreas";
            btnAreas.Size = new Size(113, 64);
            btnAreas.TabIndex = 3;
            btnAreas.Text = "Areas";
            btnAreas.UseVisualStyleBackColor = true;
            btnAreas.Click += btnAreas_Click;
            // 
            // btnMetodo
            // 
            btnMetodo.Location = new Point(537, 312);
            btnMetodo.Name = "btnMetodo";
            btnMetodo.Size = new Size(113, 64);
            btnMetodo.TabIndex = 4;
            btnMetodo.Text = "Metodo De Pago";
            btnMetodo.UseVisualStyleBackColor = true;
            btnMetodo.Click += btnMetodo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(725, 449);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMetodo);
            Controls.Add(btnAreas);
            Controls.Add(btnProductos);
            Controls.Add(btnClientes);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipal";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem areaToolStripMenuItem;
        private ToolStripMenuItem productoToolStripMenuItem;
        private ToolStripMenuItem metodoPagoToolStripMenuItem;
        private ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private Button btnClientes;
        private Button btnProductos;
        private Button btnAreas;
        private Button btnMetodo;
        private PictureBox pictureBox1;
    }
}
