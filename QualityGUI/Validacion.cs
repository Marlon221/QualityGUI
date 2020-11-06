using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace QualityGUI
{
    class Validacion
    {
        public void LimpiarCampos(Control control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).Text = "";
                }
            }
        }

        public string ValidarCaracter(string dato)
        {
            if (dato.All(char.IsLetter))
            {
                return "Debe Digitar Solo Caracteres";
            }
            return "";
        }

        public string ValidarCamposVacios(string dato)
        {
            if (dato.Equals(""))
            {
                return "Debe Llenar Este Campo";
            }
            return "";
        }
        public string ValidarEntero(string dato)
        {
            if (DatoEntero(dato) == true)
            {
                return "Debe Digitar Solo Valores Enteros";
            }
            return "";
        }
        private bool DatoEntero(string dato)
        {
            try
            {
                Int32.Parse(dato);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private bool DatoDecimal(string dato)
        {
            try
            {
                decimal.Parse(dato);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public string ValidarDecimal(string dato)
        {
            if (DatoDecimal(dato) == true)
            {
                return "Debe Digitar Solo Valores Enteros";
            }

            return "";
        }
    }
}
