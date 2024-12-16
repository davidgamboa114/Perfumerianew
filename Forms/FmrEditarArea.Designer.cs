namespace Perfumeria.Forms
{
    partial class FmrEditarArea
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
            BtnGuardar = new Button();
            BtnCancelar = new Button();
            txtNombre = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(209, 289);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(88, 37);
            BtnGuardar.TabIndex = 0;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(477, 289);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(89, 37);
            BtnCancelar.TabIndex = 1;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(312, 169);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(254, 23);
            txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 179);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // FmrEditarArea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGuardar);
            Name = "FmrEditarArea";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FmrEditarArea";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGuardar;
        private Button BtnCancelar;
        private TextBox txtNombre;
        private Label label1;
    }
}