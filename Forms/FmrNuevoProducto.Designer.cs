namespace Perfumeria.Forms
{
    partial class FmrNuevoProducto
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
            label1 = new Label();
            txtNombre = new TextBox();
            BtnCancelar = new Button();
            BtnGuardar = new Button();
            label2 = new Label();
            comboCategorias = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(224, 157);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 15;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(325, 147);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(254, 23);
            txtNombre.TabIndex = 14;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(490, 267);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(89, 37);
            BtnCancelar.TabIndex = 13;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(222, 267);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(88, 37);
            BtnGuardar.TabIndex = 12;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 217);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 17;
            label2.Text = "Categoria";
            // 
            // comboCategorias
            // 
            comboCategorias.FormattingEnabled = true;
            comboCategorias.Location = new Point(325, 214);
            comboCategorias.Margin = new Padding(3, 2, 3, 2);
            comboCategorias.Name = "comboCategorias";
            comboCategorias.Size = new Size(247, 23);
            comboCategorias.TabIndex = 35;
            // 
            // FmrNuevoProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboCategorias);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGuardar);
            Name = "FmrNuevoProducto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FmrNuevoProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Button BtnCancelar;
        private Button BtnGuardar;
        private Label label2;
        private ComboBox comboCategorias;
    }
}