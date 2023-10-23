namespace GUI
{
    partial class Inicio_Sesion
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
            this.label2 = new System.Windows.Forms.Label();
            this.butonIngreso = new System.Windows.Forms.Button();
            this.butonSalida = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // butonIngreso
            // 
            this.butonIngreso.Location = new System.Drawing.Point(19, 9);
            this.butonIngreso.Name = "butonIngreso";
            this.butonIngreso.Size = new System.Drawing.Size(100, 35);
            this.butonIngreso.TabIndex = 2;
            this.butonIngreso.Text = "Ingresar";
            this.butonIngreso.UseVisualStyleBackColor = true;
            this.butonIngreso.Click += new System.EventHandler(this.butonIngreso_Click);
            // 
            // butonSalida
            // 
            this.butonSalida.Location = new System.Drawing.Point(138, 9);
            this.butonSalida.Name = "butonSalida";
            this.butonSalida.Size = new System.Drawing.Size(100, 35);
            this.butonSalida.TabIndex = 3;
            this.butonSalida.Text = "Salir";
            this.butonSalida.UseVisualStyleBackColor = true;
            this.butonSalida.Click += new System.EventHandler(this.butonSalida_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(113, 15);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(162, 22);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(113, 67);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(162, 22);
            this.txtContraseña.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(389, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 453);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.txtContraseña);
            this.panel2.Controls.Add(this.txtUsuario);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(58, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 101);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.butonIngreso);
            this.panel3.Controls.Add(this.butonSalida);
            this.panel3.Location = new System.Drawing.Point(93, 285);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 54);
            this.panel3.TabIndex = 7;
            // 
            // Inicio_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio_Sesion";
            this.Text = "Inicio_Sesion";
            this.Load += new System.EventHandler(this.Inicio_Sesion_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butonIngreso;
        private System.Windows.Forms.Button butonSalida;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}