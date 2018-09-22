using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFBS.Presentacion
{
   public class validacion_Login
    {
        public static void validarUsuario(KeyPressEventArgs Press)
        {
            if (char.IsDigit(Press.KeyChar))
            {
                Press.Handled = false;
            }else if(char.IsControl(Press.KeyChar)){
                Press.Handled = false;
            }else
            {
                Press.Handled = true;
            }
        }
    }
}
