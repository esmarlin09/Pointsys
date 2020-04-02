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
    public partial class frm_mantcs : Herencias.frm_no_border
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
            lblestado.Text = "Modificando";

        }
        protected virtual void Crear()
        {
            //superTabStrip1.Tabs.Remove(BtnCrear);
            // BtnCrear.Visible = false;
            //superTabStrip1.SelectedTabIndex = 1;
            lblestado.Text = "Creando";
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

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            Crear();
        }

        private void Btnmodificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void Btnretornar_Click(object sender, EventArgs e)
        {

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnsalvar_Click(object sender, EventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void superTabItem1_Click(object sender, EventArgs e)
        {
            Crear();
        }

        private void superTabItem2_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void Btnsalvar_Click_1(object sender, EventArgs e)
        {
            Salvar();
        }

        private void BtnCrear_Click_1(object sender, EventArgs e)
        {
            Crear();
        }

        private void Btnmodificar_Click_1(object sender, EventArgs e)
        {
            Modificar();
        }
    }
}