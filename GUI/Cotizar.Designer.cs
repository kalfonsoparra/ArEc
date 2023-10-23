namespace GUI
{
    partial class Cotizar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Label();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonHelp = new System.Windows.Forms.Button();
            this.botonInventario = new System.Windows.Forms.Button();
            this.botonClientes = new System.Windows.Forms.Button();
            this.botonFacturar = new System.Windows.Forms.Button();
            this.botonCotizar = new System.Windows.Forms.Button();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botonSiguiente = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(244, 513);
            this.panel1.TabIndex = 1;
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.Location = new System.Drawing.Point(63, 9);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(120, 16);
            this.menu.TabIndex = 8;
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
            this.botonHelp.Click += new System.EventHandler(this.botonHelp_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Precio,
            this.Precio_Descuento,
            this.Cantidad});
            this.dataGridView1.Location = new System.Drawing.Point(448, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(902, 330);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(265, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 329);
            this.panel2.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 272);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(136, 22);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 217);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 22);
            this.textBox1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos";
            // 
            // botonSiguiente
            // 
            this.botonSiguiente.Location = new System.Drawing.Point(1238, 464);
            this.botonSiguiente.Name = "botonSiguiente";
            this.botonSiguiente.Size = new System.Drawing.Size(112, 35);
            this.botonSiguiente.TabIndex = 4;
            this.botonSiguiente.Text = "Siguiente";
            this.botonSiguiente.UseVisualStyleBackColor = true;
            this.botonSiguiente.Click += new System.EventHandler(this.botonSiguiente_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.textBox7);
            this.panel3.Controls.Add(this.textBox6);
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(860, 376);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 123);
            this.panel3.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(104, 81);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(199, 22);
            this.textBox7.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(104, 47);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(199, 22);
            this.textBox6.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(104, 13);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(199, 22);
            this.textBox5.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Iva";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Subtotal";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo Producto";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Producto";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio Unidad";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // Precio_Descuento
            // 
            this.Precio_Descuento.HeaderText = "Precio descuento";
            this.Precio_Descuento.MinimumWidth = 6;
            this.Precio_Descuento.Name = "Precio_Descuento";
            this.Precio_Descuento.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // Cotizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1361, 511);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.botonSiguiente);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cotizar";
            this.Text = "Cotizar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonHelp;
        private System.Windows.Forms.Button botonInventario;
        private System.Windows.Forms.Button botonClientes;
        private System.Windows.Forms.Button botonFacturar;
        private System.Windows.Forms.Button botonCotizar;
        private System.Windows.Forms.Button botonRegistrar;
        private System.Windows.Forms.Label menu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonSiguiente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}