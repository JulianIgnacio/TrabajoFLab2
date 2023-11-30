namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTestConexion = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DgvPan = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnLimpiarDgv = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTestConexion
            // 
            this.btnTestConexion.Location = new System.Drawing.Point(610, 23);
            this.btnTestConexion.Name = "btnTestConexion";
            this.btnTestConexion.Size = new System.Drawing.Size(99, 59);
            this.btnTestConexion.TabIndex = 0;
            this.btnTestConexion.Text = "Test de Conexion";
            this.btnTestConexion.UseVisualStyleBackColor = true;
            this.btnTestConexion.Click += new System.EventHandler(this.btnTestConexion_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.75154F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.24846F));
            this.tableLayoutPanel1.Controls.Add(this.DgvPan, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(80, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.305475F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.69453F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(487, 347);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // DgvPan
            // 
            this.DgvPan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPan.Location = new System.Drawing.Point(3, 11);
            this.DgvPan.Name = "DgvPan";
            this.DgvPan.Size = new System.Drawing.Size(397, 333);
            this.DgvPan.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(608, 117);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(101, 51);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "MostrarDatos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnLimpiarDgv
            // 
            this.btnLimpiarDgv.Location = new System.Drawing.Point(610, 204);
            this.btnLimpiarDgv.Name = "btnLimpiarDgv";
            this.btnLimpiarDgv.Size = new System.Drawing.Size(99, 55);
            this.btnLimpiarDgv.TabIndex = 3;
            this.btnLimpiarDgv.Text = "Limpiar Data Grid View";
            this.btnLimpiarDgv.UseVisualStyleBackColor = true;
            this.btnLimpiarDgv.Click += new System.EventHandler(this.btnLimpiarDgv_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(610, 289);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(99, 37);
            this.btnProductos.TabIndex = 4;
            this.btnProductos.Text = "MostrarProductos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnLimpiarDgv);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnTestConexion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestConexion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DgvPan;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnLimpiarDgv;
        private System.Windows.Forms.Button btnProductos;
    }
}

