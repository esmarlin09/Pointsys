using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Point_sys
{
    public partial class menu : DevExpress.XtraBars. Ribbon.RibbonForm
    {
        public menu()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            CXC.Mant.Cliente.mant_cliente fr = new CXC.Mant.Cliente.mant_cliente();
            fr.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Fun_abrir_Form_en_panel(new XtraForm1(), panelprincipal);
        }
        public static void Fun_abrir_Form_en_panel(Form frm_ident, DevExpress.XtraEditors.PanelControl panel )//,object formhija)
        {
            foreach (Control item in panel.Controls.OfType<Control>())
            {
                //if (item.Name == "bloodyControl")
                if (item is Form)
                {
                    ((Form)item).Close();
                }
                panel.Controls.Remove(item);
            }
            //if (panel.Controls.Count > 0)
            //    //panel.Controls.RemoveAt(0);
            //   panel.Controls.Clear();
            //Form fh = formhija as Form;
            frm_ident.TopLevel = false;
            frm_ident.Dock = DockStyle.Fill;
            panel.Controls.Add(frm_ident);
            panel.Tag = frm_ident;
            frm_ident.Show();

        }

        private void menu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lblhora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            CXC.Consulta.cliente_consulta fr = new CXC.Consulta.cliente_consulta();
            fr.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Generales.Mod_rep fr = new Generales.Mod_rep();
            fr.ShowDialog();
        }
    }
}