using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using System;

namespace prueba2
{
    partial class Crear_Producto
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
            this.name_prod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stock_min_add = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.precio_add = new System.Windows.Forms.TextBox();
            this.add_btm = new System.Windows.Forms.Button();
            this.cancel_btm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_prod
            // 
            this.name_prod.Location = new System.Drawing.Point(123, 66);
            this.name_prod.Name = "name_prod";
            this.name_prod.Size = new System.Drawing.Size(86, 20);
            this.name_prod.TabIndex = 0;
            this.name_prod.TextChanged += new System.EventHandler(this.name_prod_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stock Minimo:";
            // 
            // stock_min_add
            // 
            this.stock_min_add.Location = new System.Drawing.Point(123, 99);
            this.stock_min_add.Name = "stock_min_add";
            this.stock_min_add.Size = new System.Drawing.Size(86, 20);
            this.stock_min_add.TabIndex = 3;
            this.stock_min_add.TextChanged += new System.EventHandler(this.stock_min_add_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio:";
            // 
            // precio_add
            // 
            this.precio_add.Location = new System.Drawing.Point(123, 130);
            this.precio_add.Name = "precio_add";
            this.precio_add.Size = new System.Drawing.Size(86, 20);
            this.precio_add.TabIndex = 5;
            this.precio_add.TextChanged += new System.EventHandler(this.precio_add_TextChanged);
            // 
            // add_btm
            // 
            this.add_btm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(189)))), ((int)(((byte)(70)))));
            this.add_btm.Location = new System.Drawing.Point(46, 167);
            this.add_btm.Name = "add_btm";
            this.add_btm.Size = new System.Drawing.Size(69, 20);
            this.add_btm.TabIndex = 6;
            this.add_btm.Text = "Agregar";
            this.add_btm.UseVisualStyleBackColor = false;
            this.add_btm.Click += new System.EventHandler(this.add_prod_btm_Click);
            // 
            // cancel_btm
            // 
            this.cancel_btm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.cancel_btm.Location = new System.Drawing.Point(145, 167);
            this.cancel_btm.Name = "cancel_btm";
            this.cancel_btm.Size = new System.Drawing.Size(64, 20);
            this.cancel_btm.TabIndex = 7;
            this.cancel_btm.Text = "Cancelar";
            this.cancel_btm.UseVisualStyleBackColor = false;
            this.cancel_btm.Click += new System.EventHandler(this.cancel_btm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(85)))), ((int)(((byte)(161)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "CREAR PRODUCTO";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(85)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(1, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 43);
            this.panel1.TabIndex = 9;
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
            // Crear_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 217);
            this.Controls.Add(this.cancel_btm);
            this.Controls.Add(this.add_btm);
            this.Controls.Add(this.precio_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stock_min_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_prod);
            this.Controls.Add(this.panel1);
            this.Name = "Crear_Producto";
            this.Text = "CREAR_PRODUCTO";
            this.Load += new System.EventHandler(this.Crear_Producto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox name_prod;
        private Label label1;
        private Label label2;
        private TextBox stock_min_add;
        private Label label3;
        private TextBox precio_add;
        private Button add_btm;
        private Button cancel_btm;
        private Label label4;
        private Panel panel1;
        private Label label5;
        private EventHandler Crear_Producto_Load;
        private EventHandler label4_Click;
    }
}