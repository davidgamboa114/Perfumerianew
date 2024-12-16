namespace Perfumeria.Forms
{
    partial class FmrNuevoCliente
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
            comboProductos = new ComboBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            ComboMetodo = new ComboBox();
            label4 = new Label();
            comboArea = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboProductos
            // 
            comboProductos.FormattingEnabled = true;
            comboProductos.Location = new Point(272, 129);
            comboProductos.Margin = new Padding(3, 2, 3, 2);
            comboProductos.Name = "comboProductos";
            comboProductos.Size = new Size(344, 23);
            comboProductos.TabIndex = 34;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(514, 325);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 38);
            btnCancelar.TabIndex = 33;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(185, 325);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(96, 38);
            btnGuardar.TabIndex = 32;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // ComboMetodo
            // 
            ComboMetodo.FormattingEnabled = true;
            ComboMetodo.Location = new Point(301, 240);
            ComboMetodo.Margin = new Padding(3, 2, 3, 2);
            ComboMetodo.Name = "ComboMetodo";
            ComboMetodo.Size = new Size(315, 23);
            ComboMetodo.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(185, 243);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 30;
            label4.Text = "Metodo De Pago";
            // 
            // comboArea
            // 
            comboArea.FormattingEnabled = true;
            comboArea.Location = new Point(272, 182);
            comboArea.Margin = new Padding(3, 2, 3, 2);
            comboArea.Name = "comboArea";
            comboArea.Size = new Size(344, 23);
            comboArea.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 182);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 28;
            label3.Text = "Area:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 132);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 27;
            label2.Text = "Productos";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(272, 85);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(344, 23);
            txtNombre.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 88);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 25;
            label1.Text = "Nombre:";
            // 
            // FmrNuevoCliente
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
            Name = "FmrNuevoCliente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FmrNuevoCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboProductos;
        private Button btnCancelar;
        private Button btnGuardar;
        private ComboBox ComboMetodo;
        private Label label4;
        private ComboBox comboArea;
        private Label label3;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
    }
}