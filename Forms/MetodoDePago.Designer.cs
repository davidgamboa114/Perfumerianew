namespace Perfumeria.Forms.MetodoDePago
{
    partial class MetodoDePago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEditar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnSalir = new Button();
            txtBusqueda = new TextBox();
            label1 = new Label();
            dataGridMetodo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridMetodo).BeginInit();
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Yellow;
            btnEditar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEditar.Location = new Point(309, 335);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(108, 34);
            btnEditar.TabIndex = 35;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEliminar.Location = new Point(525, 332);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(116, 37);
            btnEliminar.TabIndex = 34;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Lime;
            btnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnGuardar.Location = new Point(61, 332);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 34);
            btnGuardar.TabIndex = 33;
            btnGuardar.Text = "NUEVO";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Coral;
            btnSalir.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSalir.Location = new Point(706, 385);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(82, 34);
            btnSalir.TabIndex = 32;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(96, 32);
            txtBusqueda.Margin = new Padding(3, 2, 3, 2);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(633, 23);
            txtBusqueda.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 32);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 30;
            label1.Text = "BUSCAR:";
            // 
            // dataGridMetodo
            // 
            dataGridMetodo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridMetodo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMetodo.GridColor = Color.FromArgb(255, 192, 192);
            dataGridMetodo.Location = new Point(11, 64);
            dataGridMetodo.Margin = new Padding(3, 2, 3, 2);
            dataGridMetodo.Name = "dataGridMetodo";
            dataGridMetodo.RowHeadersWidth = 51;
            dataGridMetodo.RowTemplate.Height = 29;
            dataGridMetodo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridMetodo.Size = new Size(778, 244);
            dataGridMetodo.TabIndex = 29;
            // 
            // MetodoDePago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnSalir);
            Controls.Add(txtBusqueda);
            Controls.Add(label1);
            Controls.Add(dataGridMetodo);
            Name = "MetodoDePago";
            Text = "MetodoDePago";
            ((System.ComponentModel.ISupportInitialize)dataGridMetodo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditar;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnSalir;
        private TextBox txtBusqueda;
        private Label label1;
        private DataGridView dataGridMetodo;
    }
}