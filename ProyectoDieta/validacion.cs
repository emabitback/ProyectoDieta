using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //agrega

namespace ProyectoDieta
{
    class validacion
    {

        public static void soloNumero(KeyPressEventArgs pe)
        {
            if (char.IsDigit(pe.KeyChar))
            {
                pe.Handled = false;
            }
            else if (char.IsControl(pe.KeyChar))
            {
                pe.Handled = false;
            }
            else
            {
                pe.Handled = true;

            }
        }



        public static void sololetras(KeyPressEventArgs pe)
        {
            if (char.IsLetter(pe.KeyChar))
            {
                pe.Handled = false;
            }
            else if (char.IsControl(pe.KeyChar))
            {
                pe.Handled = false;
            }
            else
            {
                pe.Handled = true;

            }
        }
    }
}
