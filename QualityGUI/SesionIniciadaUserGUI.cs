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
    public partial class SesionIniciadaUserGUI : Form
    {
        public SesionIniciadaUserGUI()
        {
            InitializeComponent();
        }

        private void cotizar_Click(object sender, EventArgs e)
        {
            Form cotizar = new CotizarGUI();
            cotizar.ShowDialog();
        }

        private void mostrarCotizacion_Click(object sender, EventArgs e)
        {
            Form mostrarCotizacion = new MostrarCotizacionGUI();
            mostrarCotizacion.ShowDialog();
        }

        private void facturar_Click(object sender, EventArgs e)
        {
            Form facturar = new FacturarGUI();
            facturar.ShowDialog();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
