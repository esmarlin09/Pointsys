﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Runtime.InteropServices;

namespace Point_sys.Herencias
{
    public partial class frm_no_border : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_no_border()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void frm_no_border_Load(object sender, EventArgs e)
        {

        }
        protected void Fun_Set_Nombre_Formulario(string Primer, Form currentForm)
        {
            LBLTITULO.Text = Primer;
            currentForm.Text = string.Empty;
            currentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            currentForm.ControlBox = false;
            currentForm.StartPosition = FormStartPosition.CenterScreen;
            //currentForm.BackColor = SystemColors.GradientActiveCaption;
            //bar1.Size = new Size(currentForm.Size.Width + 10, 38);
            //BtnHelp.Location = new Point((currentForm.Size.Width - 50), 0);
        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}