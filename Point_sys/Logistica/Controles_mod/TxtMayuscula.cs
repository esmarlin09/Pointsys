using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_sys.Logistica.Controles_mod
{
    public partial class TxtMayuscula : Logistica.Controles_mod.Txtorigen
    {
        private Color _NormalBorderColor = Color.Gray;
        private Color _FocusBorderColor = Color.Blue;
        public bool MaskFull { get; internal set; }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.BorderStyle = BorderStyle.Fixed3D;
            this.CharacterCasing = CharacterCasing.Upper;
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            var regex = new Regex(@"[^a-zA-Z0-9\b\s\-@().,]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
        
    }
}
