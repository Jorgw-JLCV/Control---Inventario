using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace prueba2
{
    partial class Salida_Producto
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
            this.cancel_btm = new System.Windows.Forms.Button();
            this.res_stock_btm = new System.Windows.Forms.Button();
            this.res_stock_prod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancel_btm
            // 
            this.cancel_btm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.cancel_btm.Location = new System.Drawing.Point(161, 121);
            this.cancel_btm.Name = "cancel_btm";
            this.cancel_btm.Size = new System.Drawing.Size(64, 20);
            this.cancel_btm.TabIndex = 9;
            this.cancel_btm.Text = "Cancelar";
            this.cancel_btm.UseVisualStyleBackColor = false;
            this.cancel_btm.Click += new System.EventHandler(this.Cancel_btm_Click);
            // 
            // res_stock_btm
            // 
            this.res_stock_btm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(189)))), ((int)(((byte)(70)))));
            this.res_stock_btm.Location = new System.Drawing.Point(59, 121);
            this.res_stock_btm.Name = "res_stock_btm";
            this.res_stock_btm.Size = new System.Drawing.Size(64, 20);
            this.res_stock_btm.TabIndex = 8;
            this.res_stock_btm.Text = "Aceptar";
            this.res_stock_btm.UseVisualStyleBackColor = false;
            this.res_stock_btm.Click += new System.EventHandler(this.res_stock_btm_Click);
            // 
            // res_stock_prod
            // 
            this.res_stock_prod.Location = new System.Drawing.Point(174, 78);
            this.res_stock_prod.Name = "res_stock_prod";
            this.res_stock_prod.Size = new System.Drawing.Size(86, 20);
            this.res_stock_prod.TabIndex = 7;
            this.res_stock_prod.TextChanged += new System.EventHandler(this.res_stock_prod_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese la cantidad a retirar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(85)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 43);
            this.panel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(85)))), ((int)(((byte)(161)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "SALIDA DE PRODUCTOS";
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
            // Salida_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 185);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancel_btm);
            this.Controls.Add(this.res_stock_btm);
            this.Controls.Add(this.res_stock_prod);
            this.Controls.Add(this.label1);
            this.Name = "Salida_Producto";
            this.Text = "SALIDA_PRODUCTO";
            this.Load += new System.EventHandler(this.Salida_Producto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cancel_btm;
        private Button res_stock_btm;
        private TextBox res_stock_prod;
        private Label label1;
        private Panel panel1;
        private Label label4;
        private Label label5;
    }
}