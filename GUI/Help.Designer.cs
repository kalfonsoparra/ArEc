namespace GUI
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Label();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonHelp = new System.Windows.Forms.Button();
            this.botonInventario = new System.Windows.Forms.Button();
            this.botonClientes = new System.Windows.Forms.Button();
            this.botonFacturar = new System.Windows.Forms.Button();
            this.botonCotizar = new System.Windows.Forms.Button();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 451);
            this.panel1.TabIndex = 1;
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
            // botonHelp
            // 
            this.botonHelp.Location = new System.Drawing.Point(12, 320);
            this.botonHelp.Name = "botonHelp";
            this.botonHelp.Size = new System.Drawing.Size(210, 50);
            this.botonHelp.TabIndex = 5;
            this.botonHelp.Text = "Help";
            this.botonHelp.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(26, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 240);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Help";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(302, 406);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(84, 16);
            this.linkLabel3.TabIndex = 6;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "WHATSAPP";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(299, 371);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(79, 16);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "FACEBOOK";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(299, 336);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 16);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "INSTAGRAM";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(273, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 295);
            this.panel2.TabIndex = 7;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Help";
            this.Text = "Help";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label menu;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonHelp;
        private System.Windows.Forms.Button botonInventario;
        private System.Windows.Forms.Button botonClientes;
        private System.Windows.Forms.Button botonFacturar;
        private System.Windows.Forms.Button botonCotizar;
        private System.Windows.Forms.Button botonRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel2;
    }
}