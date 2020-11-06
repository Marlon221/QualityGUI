namespace QualityGUI
{
    partial class SesionIniciadaUserGUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.facturar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mostrarCotizacion = new System.Windows.Forms.Button();
            this.cotizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "(Aqui va la informacion del administrador)";
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.Location = new System.Drawing.Point(231, 6);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(88, 23);
            this.BtnCerrarSesion.TabIndex = 11;
            this.BtnCerrarSesion.Text = "Cerrar Sesion";
            this.BtnCerrarSesion.UseVisualStyleBackColor = true;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 91);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione la opcion que desea utilizar.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.facturar);
            this.groupBox3.Location = new System.Drawing.Point(254, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(89, 56);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Facturas";
            // 
            // facturar
            // 
            this.facturar.Location = new System.Drawing.Point(6, 19);
            this.facturar.Name = "facturar";
            this.facturar.Size = new System.Drawing.Size(75, 23);
            this.facturar.TabIndex = 4;
            this.facturar.Text = "Facturar";
            this.facturar.UseVisualStyleBackColor = true;
            this.facturar.Click += new System.EventHandler(this.facturar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mostrarCotizacion);
            this.groupBox1.Controls.Add(this.cotizar);
            this.groupBox1.Location = new System.Drawing.Point(9, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 57);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cotizaciones";
            // 
            // mostrarCotizacion
            // 
            this.mostrarCotizacion.Location = new System.Drawing.Point(88, 19);
            this.mostrarCotizacion.Name = "mostrarCotizacion";
            this.mostrarCotizacion.Size = new System.Drawing.Size(141, 23);
            this.mostrarCotizacion.TabIndex = 1;
            this.mostrarCotizacion.Text = "Mostrar cotizaciones";
            this.mostrarCotizacion.UseVisualStyleBackColor = true;
            this.mostrarCotizacion.Click += new System.EventHandler(this.mostrarCotizacion_Click);
            // 
            // cotizar
            // 
            this.cotizar.Location = new System.Drawing.Point(6, 19);
            this.cotizar.Name = "cotizar";
            this.cotizar.Size = new System.Drawing.Size(75, 23);
            this.cotizar.TabIndex = 0;
            this.cotizar.Text = "Cotizar";
            this.cotizar.UseVisualStyleBackColor = true;
            this.cotizar.Click += new System.EventHandler(this.cotizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // SesionIniciadaUserGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(375, 151);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCerrarSesion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SesionIniciadaUserGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SesionIniciadaUserGUI";
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCerrarSesion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button facturar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button mostrarCotizacion;
        private System.Windows.Forms.Button cotizar;
        private System.Windows.Forms.Label label1;
    }
}