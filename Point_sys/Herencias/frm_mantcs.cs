using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Point_sys.Herencias
{
    public partial class frm_mantcs : DevExpress.XtraEditors.XtraForm
    {
        public frm_mantcs()
        {
            InitializeComponent();
        }
        public string SQL_opcion;
        private void frm_mantcs_Load(object sender, EventArgs e)
        {
           
        }
        protected virtual void Salvar()
        {

        }
        protected virtual void Modificar()
        {
            //superTabStrip1.AutoSelectAttachedControl = false;
            BtnCrear.Visible = true;
            // BtnModificar.Visible = false;
            Btnsalvar.Enabled = true;
            SQL_opcion = "MODIFICAR";


        }
        protected virtual void Crear()
        {
            //superTabStrip1.Tabs.Remove(BtnCrear);
            // BtnCrear.Visible = false;
            //superTabStrip1.SelectedTabIndex = 1;
            BtnCrear.Focus();

            Btnmodificar.Visible = true;
            Btnsalvar.Enabled = true;
            SQL_opcion = "POST";


        }
        protected virtual void Consultar()
        {
           


            //superTabStrip1.Tabs.Add(BtnCrear);
            BtnCrear.Visible = true;
            Btnmodificar.Visible = true;
            Btnsalvar.Enabled = false;
            SQL_opcion = "Consultar";


        }

        private void standaloneBarDockControl1_Click(object sender, EventArgs e)
        {

        }
    }
}