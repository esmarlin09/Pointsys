using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_sys.Logistica.Controles_mod
{

    public partial class Txtorigen : TextBox
    {
       
        public bool _Focus = false;
        public string _Codigo = "";
        public ErrorProvider _LocalError = new ErrorProvider();
        public DataSet _Dataset = new DataSet();




        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            this.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
         

        }
       
        
        private bool valor;
        public bool Touch
        {
            get { return valor; }

            set
            {
                valor = value;
                if (valor)
                {
                    if (base.Size.Height < 40)
                        base.Size = new Size(this.Size.Width, 40);
                    base.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }

            }
        }

        private bool enabled_status = false;
        public bool enabled_personalizado
        {
            get { return enabled_status; }

            set
            {
                enabled_status = value;
            }
        }

        private const int WM_SETFOCUS = 0x07;
        private const int WM_ENABLE = 0x0A;
        private const int WM_SETCURSOR = 0x20;
        //protected override void WndProc(ref System.Windows.Forms.Message m)
        //{

        //    if (!enabled_status)
        //    {
        //        base.WndProc(ref m);
        //        if (base.BackColor == Color.FromArgb(240, 240, 240))
        //            base.BackColor = SystemColors.Window;
        //    }
        //    else if (!(m.Msg == WM_SETFOCUS || m.Msg == WM_ENABLE || m.Msg == WM_SETCURSOR))
        //    {
        //        base.WndProc(ref m);
        //        base.BackColor = ColorTranslator.FromHtml("#F0F0F0");
        //    }

        //}

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (enabled_personalizado == true)
            {
                e.Handled = true;
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (enabled_personalizado == true)
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyData == Keys.Up)
                {
                    SendKeys.Send("+{TAB}");
                }
                else if (e.KeyData == Keys.Down)
                {
                    SendKeys.Send("{TAB}");
                }
                else
                {
                    base.OnKeyDown(e);
                }
            }
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            //this.Select(0, 0);
            _Focus = true;
            if (enabled_personalizado == false)
                this.BackColor = Color.LightYellow;
            _Codigo = this.Text;
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            this.BackColor = SystemColors.Window;
            if (!string.IsNullOrEmpty(this.Text.Trim()))
            {
                //Funciones_Duke4.Funciones._ErrorProvider.SetError(this, string.Empty);
                this._LocalError.SetError(this, string.Empty);
            }

        }



        protected override void OnValidated(EventArgs e)
        {
            base.OnValidated(e);
            _Codigo = "";

        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (enabled_personalizado == true)
            {
                e.Handled = true;
            }
            else
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
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
