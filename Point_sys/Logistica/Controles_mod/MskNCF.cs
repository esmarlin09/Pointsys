using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Point_sys.Logistica.Controles_mod
{
    public partial class MskNCF : MaskedTextBox
    {
        public DateTime _Fecha = DateTime.Now;
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Mask = "A0000000000";
            //if (base.Size.Height < 40)
            //    base.Size = new System.Drawing.Size(this.Size.Width, 40);
            //base.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            //if (_Fecha < new DateTime(2018, 3, 1))
            //    this.Mask = "A000000000000000000";
            //else
            //    this.Text = "";
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
