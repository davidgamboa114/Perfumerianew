﻿namespace Perfumeria.Forms
{
    partial class ClienteForm
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
            dataGridClientes = new DataGridView();
            btnGenerateReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).BeginInit();
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
            btnEditar.Click += btnEditar_Click;
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
            btnSalir.Click += btnSalir_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(96, 32);
            txtBusqueda.Margin = new Padding(3, 2, 3, 2);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(633, 23);
            txtBusqueda.TabIndex = 31;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
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
            // dataGridClientes
            // 
            dataGridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClientes.GridColor = Color.FromArgb(255, 192, 192);
            dataGridClientes.Location = new Point(11, 64);
            dataGridClientes.Margin = new Padding(3, 2, 3, 2);
            dataGridClientes.Name = "dataGridClientes";
            dataGridClientes.RowHeadersWidth = 51;
            dataGridClientes.RowTemplate.Height = 29;
            dataGridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridClientes.Size = new Size(778, 244);
            dataGridClientes.TabIndex = 29;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.Teal;
            btnGenerateReport.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnGenerateReport.Location = new Point(525, 385);
            btnGenerateReport.Margin = new Padding(3, 2, 3, 2);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(116, 37);
            btnGenerateReport.TabIndex = 36;
            btnGenerateReport.Text = "REPORTE";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGenerateReport);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnSalir);
            Controls.Add(txtBusqueda);
            Controls.Add(label1);
            Controls.Add(dataGridClientes);
            Name = "ClienteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ClienteForm";
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).EndInit();
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
        private DataGridView dataGridClientes;
        private Button btnGenerateReport;
    }
}