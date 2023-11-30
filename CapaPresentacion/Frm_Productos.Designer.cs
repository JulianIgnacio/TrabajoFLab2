namespace CapaPresentacion
{
    partial class Frm_Productos
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
            this.lnomProduct = new System.Windows.Forms.Label();
            this.lPrecioP = new System.Windows.Forms.Label();
            this.lCantidadP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombProd = new System.Windows.Forms.TextBox();
            this.txtPrecioProd = new System.Windows.Forms.TextBox();
            this.txtCantidadProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lnomProduct
            // 
            this.lnomProduct.AutoSize = true;
            this.lnomProduct.Location = new System.Drawing.Point(37, 76);
            this.lnomProduct.Name = "lnomProduct";
            this.lnomProduct.Size = new System.Drawing.Size(90, 13);
            this.lnomProduct.TabIndex = 0;
            this.lnomProduct.Text = "Nombre Producto";
            // 
            // lPrecioP
            // 
            this.lPrecioP.AutoSize = true;
            this.lPrecioP.Location = new System.Drawing.Point(37, 131);
            this.lPrecioP.Name = "lPrecioP";
            this.lPrecioP.Size = new System.Drawing.Size(37, 13);
            this.lPrecioP.TabIndex = 0;
            this.lPrecioP.Text = "Precio";
            // 
            // lCantidadP
            // 
            this.lCantidadP.AutoSize = true;
            this.lCantidadP.Location = new System.Drawing.Point(37, 203);
            this.lCantidadP.Name = "lCantidadP";
            this.lCantidadP.Size = new System.Drawing.Size(49, 13);
            this.lCantidadP.TabIndex = 0;
            this.lCantidadP.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 1;
            // 
            // txtNombProd
            // 
            this.txtNombProd.Location = new System.Drawing.Point(218, 69);
            this.txtNombProd.Name = "txtNombProd";
            this.txtNombProd.Size = new System.Drawing.Size(167, 20);
            this.txtNombProd.TabIndex = 2;
            // 
            // txtPrecioProd
            // 
            this.txtPrecioProd.Location = new System.Drawing.Point(218, 128);
            this.txtPrecioProd.Name = "txtPrecioProd";
            this.txtPrecioProd.Size = new System.Drawing.Size(167, 20);
            this.txtPrecioProd.TabIndex = 2;
            // 
            // txtCantidadProd
            // 
            this.txtCantidadProd.Location = new System.Drawing.Point(218, 196);
            this.txtCantidadProd.Name = "txtCantidadProd";
            this.txtCantidadProd.Size = new System.Drawing.Size(167, 20);
            this.txtCantidadProd.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ventana Producto";
            this.label4.UseMnemonic = false;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(175, 256);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(110, 42);
            this.btnAgregarProducto.TabIndex = 4;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // Frm_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 361);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidadProd);
            this.Controls.Add(this.txtPrecioProd);
            this.Controls.Add(this.txtNombProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lCantidadP);
            this.Controls.Add(this.lPrecioP);
            this.Controls.Add(this.lnomProduct);
            this.Name = "Frm_Productos";
            this.Text = "Frm_Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lnomProduct;
        private System.Windows.Forms.Label lPrecioP;
        private System.Windows.Forms.Label lCantidadP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombProd;
        private System.Windows.Forms.TextBox txtPrecioProd;
        private System.Windows.Forms.TextBox txtCantidadProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregarProducto;
    }
}