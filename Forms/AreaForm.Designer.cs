﻿namespace Perfumeria.Forms
{
    partial class AreaForm
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
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnSalir = new Button();
            txtBusqueda = new TextBox();
            label1 = new Label();
            dataGridArea = new DataGridView();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridArea).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEliminar.Location = new Point(525, 338);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(116, 37);
            btnEliminar.TabIndex = 27;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Lime;
            btnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnGuardar.Location = new Point(61, 338);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 34);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "NUEVO";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Coral;
            btnSalir.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSalir.Location = new Point(706, 391);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(82, 34);
            btnSalir.TabIndex = 24;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(96, 38);
            txtBusqueda.Margin = new Padding(3, 2, 3, 2);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(633, 23);
            txtBusqueda.TabIndex = 23;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 38);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 22;
            label1.Text = "BUSCAR:";
            // 
            // dataGridArea
            // 
            dataGridArea.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridArea.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridArea.GridColor = Color.FromArgb(255, 192, 192);
            dataGridArea.Location = new Point(11, 70);
            dataGridArea.Margin = new Padding(3, 2, 3, 2);
            dataGridArea.Name = "dataGridArea";
            dataGridArea.RowHeadersWidth = 51;
            dataGridArea.RowTemplate.Height = 29;
            dataGridArea.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridArea.Size = new Size(778, 244);
            dataGridArea.TabIndex = 21;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Yellow;
            btnEditar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEditar.Location = new Point(309, 341);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(108, 34);
            btnEditar.TabIndex = 28;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click_2;
            // 
            // AreaForm
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
            Controls.Add(dataGridArea);
            Name = "AreaForm";
            Text = "AreaView";
            ((System.ComponentModel.ISupportInitialize)dataGridArea).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnSalir;
        private TextBox txtBusqueda;
        private Label label1;
        private DataGridView dataGridArea;
        private Button btnEditar;
    }
}