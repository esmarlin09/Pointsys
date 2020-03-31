using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_sys.Logistica.Controles_mod
{
    public partial class MskTelefono : MaskedTextBox
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Mask = "(000)-000-0000";
            //if (base.Size.Height < 40)
            //  base.Size = new System.Drawing.Size(this.Size.Width, 40);
            // base.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            // this.Mask = "";
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            //this.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            //if (!string.IsNullOrEmpty(this.Text))
            //{
            //    if (this.Text.Length == 10)
            //    {
            //        this.Mask = "(000)-000-0000";
            //        _LocalError.SetError(this, string.Empty);
            //    }
            //    else
            //        _LocalError.SetError(this, "Información incompleta");
            //}
            //else
            //{
            //    this.Mask = "";
            //    _LocalError.SetError(this, string.Empty);

            //}
            //this.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        }
        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern IntPtr GetWindowDC(IntPtr hwnd);
        private const int WM_NCPAINT = 0x85;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCPAINT && this.Focused)
            {
                var dc = GetWindowDC(Handle);
                using (Graphics g = Graphics.FromHdc(dc))
                {
                    g.DrawRectangle(Pens.Red, 0, 0, Width - 1, Height - 1);
                }
            }
        }
    }
}
