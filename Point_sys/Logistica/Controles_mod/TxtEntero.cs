using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_sys.Logistica.Controles_mod
{
    public partial class TxtEntero : Logistica.Controles_mod.Txtorigen
    {
      
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            ErrorProvider _LocalError = new ErrorProvider();
            base.OnKeyPress(e);

            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
            {
               _LocalError.SetError(this, "Solo insertar digitos");
                e.Handled = true;
            }
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            base.TextAlign = HorizontalAlignment.Right;
        }

    }
}
