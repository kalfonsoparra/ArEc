namespace GUI
{
    partial class Menu_Principal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.botonCotizar = new System.Windows.Forms.Button();
            this.botonFacturar = new System.Windows.Forms.Button();
            this.botonClientes = new System.Windows.Forms.Button();
            this.botonInventario = new System.Windows.Forms.Button();
            this.botonHelp = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.menu);
            this.panel1.Controls.Add(this.botonSalir);
            this.panel1.Controls.Add(this.botonHelp);
            this.panel1.Controls.Add(this.botonInventario);
            this.panel1.Controls.Add(this.botonClientes);
            this.panel1.Controls.Add(this.botonFacturar);
            this.panel1.Controls.Add(this.botonCotizar);
            this.panel1.Controls.Add(this.botonRegistrar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 451);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.Location = new System.Drawing.Point(12, 40);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(210, 50);
            this.botonRegistrar.TabIndex = 0;
            this.botonRegistrar.Text = "Registrar";
            this.botonRegistrar.UseVisualStyleBackColor = true;
            this.botonRegistrar.Click += new System.EventHandler(this.botonRegistrar_Click);
            // 
            // botonCotizar
            // 
            this.botonCotizar.Location = new System.Drawing.Point(12, 96);
            this.botonCotizar.Name = "botonCotizar";
            this.botonCotizar.Size = new System.Drawing.Size(210, 50);
            this.botonCotizar.TabIndex = 1;
            this.botonCotizar.Text = "Cotizar";
            this.botonCotizar.UseVisualStyleBackColor = true;
            this.botonCotizar.Click += new System.EventHandler(this.botonCotizar_Click);
            // 
            // botonFacturar
            // 
            this.botonFacturar.Location = new System.Drawing.Point(12, 152);
            this.botonFacturar.Name = "botonFacturar";
            this.botonFacturar.Size = new System.Drawing.Size(210, 50);
            this.botonFacturar.TabIndex = 2;
            this.botonFacturar.Text = "Facturar";
            this.botonFacturar.UseVisualStyleBackColor = true;
            this.botonFacturar.Click += new System.EventHandler(this.botonFacturar_Click);
            // 
            // botonClientes
            // 
            this.botonClientes.Location = new System.Drawing.Point(12, 208);
            this.botonClientes.Name = "botonClientes";
            this.botonClientes.Size = new System.Drawing.Size(210, 50);
            this.botonClientes.TabIndex = 3;
            this.botonClientes.Text = "Clientes";
            this.botonClientes.UseVisualStyleBackColor = true;
            this.botonClientes.Click += new System.EventHandler(this.botonClientes_Click);
            // 
            // botonInventario
            // 
            this.botonInventario.Location = new System.Drawing.Point(12, 264);
            this.botonInventario.Name = "botonInventario";
            this.botonInventario.Size = new System.Drawing.Size(210, 50);
            this.botonInventario.TabIndex = 4;
            this.botonInventario.Text = "Inventario";
            this.botonInventario.UseVisualStyleBackColor = true;
            this.botonInventario.Click += new System.EventHandler(this.botonInventario_Click);
            // 
            // botonHelp
            // 
            this.botonHelp.Location = new System.Drawing.Point(12, 320);
            this.botonHelp.Name = "botonHelp";
            this.botonHelp.Size = new System.Drawing.Size(210, 50);
            this.botonHelp.TabIndex = 5;
            this.botonHelp.Text = "Help";
            this.botonHelp.UseVisualStyleBackColor = true;
            this.botonHelp.Click += new System.EventHandler(this.botonHelp_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(12, 376);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(210, 50);
            this.botonSalir.TabIndex = 6;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.Location = new System.Drawing.Point(63, 9);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(120, 16);
            this.menu.TabIndex = 7;
            this.menu.Text = "Menu de Opciones";
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_Principal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonRegistrar;
        private System.Windows.Forms.Label menu;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonHelp;
        private System.Windows.Forms.Button botonInventario;
        private System.Windows.Forms.Button botonClientes;
        private System.Windows.Forms.Button botonFacturar;
        private System.Windows.Forms.Button botonCotizar;
    }
}

