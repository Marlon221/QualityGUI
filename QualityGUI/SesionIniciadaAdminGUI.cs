using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QualityGUI
{
    public partial class SesionIniciadaAdminGUI : Form
    {
        public SesionIniciadaAdminGUI()
        {
            InitializeComponent();
        }
        
        private void SesionIniciadaGUI_Load(object sender, EventArgs e)
        {

        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCotizar_Click(object sender, EventArgs e)
        {
            Form cotizar = new CotizarGUI();
            cotizar.ShowDialog();
        }

        private void BtnMostrarCotizacion_Click(object sender, EventArgs e)
        {
            Form mostrarCotizacion = new MostrarCotizacionGUI();
            mostrarCotizacion.ShowDialog();
        }

        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            Form facturar = new FacturarGUI();
            facturar.ShowDialog();
        }

        private void BtnAlquiler_Click(object sender, EventArgs e)
        {

        }
    }
}
