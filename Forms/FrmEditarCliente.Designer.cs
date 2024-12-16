namespace Perfumeria.Forms
{
    partial class FrmEditarCliente
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
            comboArea = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            ComboMetodo = new ComboBox();
            label4 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            comboProductos = new ComboBox();
            SuspendLayout();
            // 
            // comboArea
            // 
            comboArea.FormattingEnabled = true;
            comboArea.Location = new Point(260, 176);
            comboArea.Margin = new Padding(3, 2, 3, 2);
            comboArea.Name = "comboArea";
            comboArea.Size = new Size(344, 23);
            comboArea.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 176);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 18;
            label3.Text = "Area:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 126);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 16;
            label2.Text = "Productos";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(260, 79);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(344, 23);
            txtNombre.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 82);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 14;
            label1.Text = "Nombre:";
            // 
            // ComboMetodo
            // 
            ComboMetodo.FormattingEnabled = true;
            ComboMetodo.Location = new Point(289, 234);
            ComboMetodo.Margin = new Padding(3, 2, 3, 2);
            ComboMetodo.Name = "ComboMetodo";
            ComboMetodo.Size = new Size(315, 23);
            ComboMetodo.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(173, 237);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 20;
            label4.Text = "Metodo De Pago";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(499, 329);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 39);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(173, 329);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(96, 39);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // comboProductos
            // 
            comboProductos.FormattingEnabled = true;
            comboProductos.Location = new Point(260, 123);
            comboProductos.Margin = new Padding(3, 2, 3, 2);
            comboProductos.Name = "comboProductos";
            comboProductos.Size = new Size(344, 23);
            comboProductos.TabIndex = 24;
            // 
            // FrmEditarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboProductos);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(ComboMetodo);
            Controls.Add(label4);
            Controls.Add(comboArea);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "FrmEditarCliente";
            Text = "FrmEditarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboArea;
        private Label label3;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private ComboBox ComboMetodo;
        private Label label4;
        private Button btnCancelar;
        private Button btnGuardar;
        private ComboBox comboProductos;
    }
}