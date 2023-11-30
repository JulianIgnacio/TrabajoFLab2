namespace CapaPresentacion
{
    partial class Frm_Insumos
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
            this.lnomInsum = new System.Windows.Forms.Label();
            this.lPrecioI = new System.Windows.Forms.Label();
            this.lCantidadI = new System.Windows.Forms.Label();
            this.txtNombInsum = new System.Windows.Forms.TextBox();
            this.txtPrecioInsum = new System.Windows.Forms.TextBox();
            this.txtCantidadInsum = new System.Windows.Forms.TextBox();
            this.btnAgregarInsum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulario Insumos";
            // 
            // lnomInsum
            // 
            this.lnomInsum.AutoSize = true;
            this.lnomInsum.Location = new System.Drawing.Point(31, 90);
            this.lnomInsum.Name = "lnomInsum";
            this.lnomInsum.Size = new System.Drawing.Size(81, 13);
            this.lnomInsum.TabIndex = 1;
            this.lnomInsum.Text = "Nombre Insumo";
            // 
            // lPrecioI
            // 
            this.lPrecioI.AutoSize = true;
            this.lPrecioI.Location = new System.Drawing.Point(31, 136);
            this.lPrecioI.Name = "lPrecioI";
            this.lPrecioI.Size = new System.Drawing.Size(37, 13);
            this.lPrecioI.TabIndex = 2;
            this.lPrecioI.Text = "Precio";
            // 
            // lCantidadI
            // 
            this.lCantidadI.AutoSize = true;
            this.lCantidadI.Location = new System.Drawing.Point(31, 191);
            this.lCantidadI.Name = "lCantidadI";
            this.lCantidadI.Size = new System.Drawing.Size(49, 13);
            this.lCantidadI.TabIndex = 3;
            this.lCantidadI.Text = "Cantidad";
            // 
            // txtNombInsum
            // 
            this.txtNombInsum.Location = new System.Drawing.Point(224, 83);
            this.txtNombInsum.Name = "txtNombInsum";
            this.txtNombInsum.Size = new System.Drawing.Size(167, 20);
            this.txtNombInsum.TabIndex = 4;
            // 
            // txtPrecioInsum
            // 
            this.txtPrecioInsum.Location = new System.Drawing.Point(224, 136);
            this.txtPrecioInsum.Name = "txtPrecioInsum";
            this.txtPrecioInsum.Size = new System.Drawing.Size(167, 20);
            this.txtPrecioInsum.TabIndex = 5;
            // 
            // txtCantidadInsum
            // 
            this.txtCantidadInsum.Location = new System.Drawing.Point(224, 184);
            this.txtCantidadInsum.Name = "txtCantidadInsum";
            this.txtCantidadInsum.Size = new System.Drawing.Size(167, 20);
            this.txtCantidadInsum.TabIndex = 6;
            // 
            // btnAgregarInsum
            // 
            this.btnAgregarInsum.Location = new System.Drawing.Point(196, 258);
            this.btnAgregarInsum.Name = "btnAgregarInsum";
            this.btnAgregarInsum.Size = new System.Drawing.Size(115, 39);
            this.btnAgregarInsum.TabIndex = 7;
            this.btnAgregarInsum.Text = "Agregar Insumo";
            this.btnAgregarInsum.UseVisualStyleBackColor = true;
            this.btnAgregarInsum.Click += new System.EventHandler(this.btnAgregarInsum_Click);
            // 
            // Frm_Insumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 388);
            this.Controls.Add(this.btnAgregarInsum);
            this.Controls.Add(this.txtCantidadInsum);
            this.Controls.Add(this.txtPrecioInsum);
            this.Controls.Add(this.txtNombInsum);
            this.Controls.Add(this.lCantidadI);
            this.Controls.Add(this.lPrecioI);
            this.Controls.Add(this.lnomInsum);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Insumos";
            this.Text = "Frm_Insumos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lnomInsum;
        private System.Windows.Forms.Label lPrecioI;
        private System.Windows.Forms.Label lCantidadI;
        private System.Windows.Forms.TextBox txtNombInsum;
        private System.Windows.Forms.TextBox txtPrecioInsum;
        private System.Windows.Forms.TextBox txtCantidadInsum;
        private System.Windows.Forms.Button btnAgregarInsum;
    }
}