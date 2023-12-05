using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using System;

namespace ProyectoInso
{
    partial class Interface_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface_main));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add_prod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Retiro = new System.Windows.Forms.DataGridViewImageColumn();
            this.Ingreso = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Retiro,
            this.Ingreso});
            this.dataGridView1.Location = new System.Drawing.Point(42, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(842, 129);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // add_prod
            // 
            this.add_prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(161)))), ((int)(((byte)(77)))));
            this.add_prod.Location = new System.Drawing.Point(766, 63);
            this.add_prod.Name = "add_prod";
            this.add_prod.Size = new System.Drawing.Size(118, 24);
            this.add_prod.TabIndex = 1;
            this.add_prod.Text = "Crear Producto";
            this.add_prod.UseVisualStyleBackColor = false;
            this.add_prod.Click += new System.EventHandler(this.add_prod_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(365, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "LISTA DE PRODUCTOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Retiro";
            this.dataGridViewImageColumn1.Image = global::ProyectoInso.Properties.Resources.menos;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Ingreso";
            this.dataGridViewImageColumn2.Image = global::ProyectoInso.Properties.Resources.mas;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(85)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 43);
            this.panel1.TabIndex = 3;
            // 
            // Retiro
            // 
            this.Retiro.HeaderText = "Retiro";
            this.Retiro.Image = ((System.Drawing.Image)(resources.GetObject("Retiro.Image")));
            this.Retiro.Name = "Retiro";
            // 
            // Ingreso
            // 
            this.Ingreso.HeaderText = "Ingreso";
            this.Ingreso.Image = ((System.Drawing.Image)(resources.GetObject("Ingreso.Image")));
            this.Ingreso.Name = "Ingreso";
            // 
            // Interface_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 285);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.add_prod);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Interface_main";
            this.Text = "PRINCIPAL";
            this.Load += new System.EventHandler(this.Interface_main_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button add_prod;
        private Label label1;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private DataGridViewImageColumn dataGridViewImageColumn2;
        private Panel panel1;
        private DataGridViewImageColumn Retiro;
        private DataGridViewImageColumn Ingreso;
        private DataGridViewCellEventHandler dataGridView1_CellContentClick;
        private EventHandler label1_Click;

        public EventHandler Interface_main_Load_1 { get; private set; }
    }
}