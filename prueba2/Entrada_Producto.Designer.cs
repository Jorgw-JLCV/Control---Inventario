using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using System;

namespace prueba2
{
    partial class Entrada_Producto
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
            this.label1 = new System.Windows.Forms.Label();
            this.add_stock_prod = new System.Windows.Forms.TextBox();
            this.addstock_btm = new System.Windows.Forms.Button();
            this.cancel_btm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la cantidad a agregar";
            // 
            // add_stock_prod
            // 
            this.add_stock_prod.Location = new System.Drawing.Point(179, 66);
            this.add_stock_prod.Name = "add_stock_prod";
            this.add_stock_prod.Size = new System.Drawing.Size(86, 20);
            this.add_stock_prod.TabIndex = 2;
            this.add_stock_prod.TextChanged += new System.EventHandler(this.add_stock_prod_TextChanged);
            // 
            // addstock_btm
            // 
            this.addstock_btm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(189)))), ((int)(((byte)(70)))));
            this.addstock_btm.Location = new System.Drawing.Point(64, 109);
            this.addstock_btm.Name = "addstock_btm";
            this.addstock_btm.Size = new System.Drawing.Size(64, 20);
            this.addstock_btm.TabIndex = 3;
            this.addstock_btm.Text = "Aceptar";
            this.addstock_btm.UseVisualStyleBackColor = false;
            this.addstock_btm.Click += new System.EventHandler(this.addstock_btm_Click);
            // 
            // cancel_btm
            // 
            this.cancel_btm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.cancel_btm.Location = new System.Drawing.Point(166, 109);
            this.cancel_btm.Name = "cancel_btm";
            this.cancel_btm.Size = new System.Drawing.Size(64, 20);
            this.cancel_btm.TabIndex = 4;
            this.cancel_btm.Text = "Cancelar";
            this.cancel_btm.UseVisualStyleBackColor = false;
            this.cancel_btm.Click += new System.EventHandler(this.Cancel_btm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(85)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 43);
            this.panel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(85)))), ((int)(((byte)(161)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "ENTRADA DE PRODUCTOS";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(365, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "LISTA DE PRODUCTOS";
            // 
            // Entrada_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 156);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancel_btm);
            this.Controls.Add(this.addstock_btm);
            this.Controls.Add(this.add_stock_prod);
            this.Controls.Add(this.label1);
            this.Name = "Entrada_Producto";
            this.Text = "ENTRADA_PRODUCTO";
            
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

   

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

 

        #endregion

        private Label label1;
        private TextBox add_stock_prod;
        private Button addstock_btm;
        private Button cancel_btm;
        private Panel panel1;
        private Label label4;
        private Label label5;

        public EventHandler Entrada_Producto_Load { get; private set; }
    }
}