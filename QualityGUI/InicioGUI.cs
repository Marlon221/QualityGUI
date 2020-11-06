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
    public partial class InicioGUI : Form
    {
        Validacion validacion = new Validacion();
        public InicioGUI()
        {
            InitializeComponent();
        }

        private void Registrarse_Click(object sender, EventArgs e)
        {
            Form registro = new RegistroGUI();
            registro.ShowDialog();
        }
        private void iniciarSesion_Click(object sender, EventArgs e)
        {
            if ((TbxUsuario.Text.ToUpper().Trim() == "ADMIN") && (TbxContraseña.Text.ToUpper().Trim() == "ADMIN"))
            {
                Form sesion = new SesionIniciadaAdminGUI();
                sesion.ShowDialog();
            }
            //else
            //{
            //    //validacion.
            //    //MessageBox.Show("Usuario y/o Contraseña Incorrectos");
            //}
            if ((TbxUsuario.Text.ToUpper().Trim() == "USER") && (TbxContraseña.Text.ToUpper().Trim() == "USER"))
            {
                Form sesion = new SesionIniciadaUserGUI();
                sesion.ShowDialog();
            }
        }

        private void TbxUsuario_TextChanged(object sender, EventArgs e)
        {
           // errorProvider1.SetError(TbxUsuario, );
        }

        private void TbxContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
