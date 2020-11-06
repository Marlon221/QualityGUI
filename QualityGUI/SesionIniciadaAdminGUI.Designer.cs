namespace QualityGUI
{
    partial class SesionIniciadaAdminGUI
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
            this.BtnCotizar = new System.Windows.Forms.Button();
            this.BtnMostrarCotizacion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnInstalacion = new System.Windows.Forms.Button();
            this.BtnMantenimiento = new System.Windows.Forms.Button();
            this.BtnAlquiler = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.BtnProveedor = new System.Windows.Forms.Button();
            this.BtnEmpleado = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnFacturar = new System.Windows.Forms.Button();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCotizar
            // 
            this.BtnCotizar.Location = new System.Drawing.Point(6, 19);
            this.BtnCotizar.Name = "BtnCotizar";
            this.BtnCotizar.Size = new System.Drawing.Size(75, 23);
            this.BtnCotizar.TabIndex = 0;
            this.BtnCotizar.Text = "Cotizar";
            this.BtnCotizar.UseVisualStyleBackColor = true;
            this.BtnCotizar.Click += new System.EventHandler(this.BtnCotizar_Click);
            // 
            // BtnMostrarCotizacion
            // 
            this.BtnMostrarCotizacion.Location = new System.Drawing.Point(88, 19);
            this.BtnMostrarCotizacion.Name = "BtnMostrarCotizacion";
            this.BtnMostrarCotizacion.Size = new System.Drawing.Size(141, 23);
            this.BtnMostrarCotizacion.TabIndex = 1;
            this.BtnMostrarCotizacion.Text = "Mostrar cotizaciones";
            this.BtnMostrarCotizacion.UseVisualStyleBackColor = true;
            this.BtnMostrarCotizacion.Click += new System.EventHandler(this.BtnMostrarCotizacion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnMostrarCotizacion);
            this.groupBox1.Controls.Add(this.BtnCotizar);
            this.groupBox1.Location = new System.Drawing.Point(9, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 57);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cotizaciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 208);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione la opcion que desea utilizar.";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BtnInstalacion);
            this.groupBox5.Controls.Add(this.BtnMantenimiento);
            this.groupBox5.Controls.Add(this.BtnAlquiler);
            this.groupBox5.Location = new System.Drawing.Point(6, 82);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(318, 56);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Servicio";
            // 
            // BtnInstalacion
            // 
            this.BtnInstalacion.Location = new System.Drawing.Point(208, 19);
            this.BtnInstalacion.Name = "BtnInstalacion";
            this.BtnInstalacion.Size = new System.Drawing.Size(100, 23);
            this.BtnInstalacion.TabIndex = 4;
            this.BtnInstalacion.Text = "Instalaciones";
            this.BtnInstalacion.UseVisualStyleBackColor = true;
            // 
            // BtnMantenimiento
            // 
            this.BtnMantenimiento.Location = new System.Drawing.Point(87, 19);
            this.BtnMantenimiento.Name = "BtnMantenimiento";
            this.BtnMantenimiento.Size = new System.Drawing.Size(115, 23);
            this.BtnMantenimiento.TabIndex = 4;
            this.BtnMantenimiento.Text = "Mantenimiento";
            this.BtnMantenimiento.UseVisualStyleBackColor = true;
            // 
            // BtnAlquiler
            // 
            this.BtnAlquiler.Location = new System.Drawing.Point(6, 19);
            this.BtnAlquiler.Name = "BtnAlquiler";
            this.BtnAlquiler.Size = new System.Drawing.Size(75, 23);
            this.BtnAlquiler.TabIndex = 4;
            this.BtnAlquiler.Text = "Alquiler";
            this.BtnAlquiler.UseVisualStyleBackColor = true;
            this.BtnAlquiler.Click += new System.EventHandler(this.BtnAlquiler_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnInventario);
            this.groupBox4.Controls.Add(this.BtnProveedor);
            this.groupBox4.Controls.Add(this.BtnEmpleado);
            this.groupBox4.Controls.Add(this.BtnCliente);
            this.groupBox4.Location = new System.Drawing.Point(6, 144);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(395, 56);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Visualizacion";
            // 
            // BtnInventario
            // 
            this.BtnInventario.Location = new System.Drawing.Point(314, 19);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(75, 23);
            this.BtnInventario.TabIndex = 5;
            this.BtnInventario.Text = "Inventario";
            this.BtnInventario.UseVisualStyleBackColor = true;
            // 
            // BtnProveedor
            // 
            this.BtnProveedor.Location = new System.Drawing.Point(208, 19);
            this.BtnProveedor.Name = "BtnProveedor";
            this.BtnProveedor.Size = new System.Drawing.Size(100, 23);
            this.BtnProveedor.TabIndex = 4;
            this.BtnProveedor.Text = "Proveedores";
            this.BtnProveedor.UseVisualStyleBackColor = true;
            // 
            // BtnEmpleado
            // 
            this.BtnEmpleado.Location = new System.Drawing.Point(87, 19);
            this.BtnEmpleado.Name = "BtnEmpleado";
            this.BtnEmpleado.Size = new System.Drawing.Size(115, 23);
            this.BtnEmpleado.TabIndex = 4;
            this.BtnEmpleado.Text = "Empleados";
            this.BtnEmpleado.UseVisualStyleBackColor = true;
            // 
            // BtnCliente
            // 
            this.BtnCliente.Location = new System.Drawing.Point(6, 19);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(75, 23);
            this.BtnCliente.TabIndex = 4;
            this.BtnCliente.Text = "Clientes";
            this.BtnCliente.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnFacturar);
            this.groupBox3.Location = new System.Drawing.Point(254, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(89, 56);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Facturas";
            // 
            // BtnFacturar
            // 
            this.BtnFacturar.Location = new System.Drawing.Point(6, 19);
            this.BtnFacturar.Name = "BtnFacturar";
            this.BtnFacturar.Size = new System.Drawing.Size(75, 23);
            this.BtnFacturar.TabIndex = 4;
            this.BtnFacturar.Text = "Facturar";
            this.BtnFacturar.UseVisualStyleBackColor = true;
            this.BtnFacturar.Click += new System.EventHandler(this.BtnFacturar_Click);
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.Location = new System.Drawing.Point(234, 15);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(88, 23);
            this.BtnCerrarSesion.TabIndex = 7;
            this.BtnCerrarSesion.Text = "Cerrar Sesion";
            this.BtnCerrarSesion.UseVisualStyleBackColor = true;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "(Aqui va la informacion del administrador)";
            // 
            // SesionIniciadaAdminGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(429, 277);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCerrarSesion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SesionIniciadaAdminGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quality";
            this.Load += new System.EventHandler(this.SesionIniciadaGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnCotizar;
        private System.Windows.Forms.Button BtnMostrarCotizacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnFacturar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnInstalacion;
        private System.Windows.Forms.Button BtnMantenimiento;
        private System.Windows.Forms.Button BtnAlquiler;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnInventario;
        private System.Windows.Forms.Button BtnProveedor;
        private System.Windows.Forms.Button BtnEmpleado;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Button BtnCerrarSesion;
        private System.Windows.Forms.Label label2;
    }
}