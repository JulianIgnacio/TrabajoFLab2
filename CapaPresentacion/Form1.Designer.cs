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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DgvPan = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.insumosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarDatosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarDatosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarDatosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDatosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPan)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.75154F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.24846F));
            this.tableLayoutPanel1.Controls.Add(this.DgvPan, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(151, 60);
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
            this.DgvPan.Location = new System.Drawing.Point(3, 10);
            this.DgvPan.Name = "DgvPan";
            this.DgvPan.Size = new System.Drawing.Size(397, 333);
            this.DgvPan.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insumosToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.testToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // insumosToolStripMenuItem
            // 
            this.insumosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarDatosToolStripMenuItem,
            this.insertarDatosToolStripMenuItem,
            this.editarDatosToolStripMenuItem,
            this.eliminarDatosToolStripMenuItem});
            this.insumosToolStripMenuItem.Name = "insumosToolStripMenuItem";
            this.insumosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.insumosToolStripMenuItem.Text = "Insumos";
            // 
            // mostrarDatosToolStripMenuItem
            // 
            this.mostrarDatosToolStripMenuItem.Name = "mostrarDatosToolStripMenuItem";
            this.mostrarDatosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.mostrarDatosToolStripMenuItem.Text = "Mostrar Datos";
            this.mostrarDatosToolStripMenuItem.Click += new System.EventHandler(this.mostrarDatosToolStripMenuItem_Click);
            // 
            // insertarDatosToolStripMenuItem
            // 
            this.insertarDatosToolStripMenuItem.Name = "insertarDatosToolStripMenuItem";
            this.insertarDatosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.insertarDatosToolStripMenuItem.Text = "Insertar Datos";
            this.insertarDatosToolStripMenuItem.Click += new System.EventHandler(this.insertarDatosToolStripMenuItem_Click);
            // 
            // editarDatosToolStripMenuItem
            // 
            this.editarDatosToolStripMenuItem.Name = "editarDatosToolStripMenuItem";
            this.editarDatosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.editarDatosToolStripMenuItem.Text = "Editar Datos";
            // 
            // eliminarDatosToolStripMenuItem
            // 
            this.eliminarDatosToolStripMenuItem.Name = "eliminarDatosToolStripMenuItem";
            this.eliminarDatosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.eliminarDatosToolStripMenuItem.Text = "Eliminar Datos";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarDatosToolStripMenuItem1,
            this.insertarDatosToolStripMenuItem1,
            this.editarDatosToolStripMenuItem1,
            this.eliminarDatosToolStripMenuItem1});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // mostrarDatosToolStripMenuItem1
            // 
            this.mostrarDatosToolStripMenuItem1.Name = "mostrarDatosToolStripMenuItem1";
            this.mostrarDatosToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.mostrarDatosToolStripMenuItem1.Text = "Mostrar Datos";
            this.mostrarDatosToolStripMenuItem1.Click += new System.EventHandler(this.mostrarDatosToolStripMenuItem1_Click);
            // 
            // insertarDatosToolStripMenuItem1
            // 
            this.insertarDatosToolStripMenuItem1.Name = "insertarDatosToolStripMenuItem1";
            this.insertarDatosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.insertarDatosToolStripMenuItem1.Text = "Insertar Datos";
            this.insertarDatosToolStripMenuItem1.Click += new System.EventHandler(this.insertarDatosToolStripMenuItem1_Click);
            // 
            // editarDatosToolStripMenuItem1
            // 
            this.editarDatosToolStripMenuItem1.Name = "editarDatosToolStripMenuItem1";
            this.editarDatosToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.editarDatosToolStripMenuItem1.Text = "Editar Datos";
            // 
            // eliminarDatosToolStripMenuItem1
            // 
            this.eliminarDatosToolStripMenuItem1.Name = "eliminarDatosToolStripMenuItem1";
            this.eliminarDatosToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.eliminarDatosToolStripMenuItem1.Text = "Eliminar Datos";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.salirToolStripMenuItem.Text = "Limpiar";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem1.Text = "Salir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPan)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DgvPan;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem insumosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarDatosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem insertarDatosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarDatosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarDatosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
    }
}

