using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_sys.Herencias
{
    public partial class mainformmant : frm_no_border
    {
        public mainformmant()
        {
            InitializeComponent();
        }
        public string SQL_opcion; protected virtual void Salvar()
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

            BtnCrear.Visible = true;
            Btnsalvar.Enabled = true;
            SQL_opcion = "POST";


        }
        protected virtual void Consultar()
        {



            //superTabStrip1.Tabs.Add(BtnCrear);
            BtnCrear.Visible = true;
            BtnCrear.Visible = true;
            Btnsalvar.Enabled = false;
            SQL_opcion = "Consultar";


        }
        private void mainformmant_Load(object sender, EventArgs e)
        {

        }

        private void Btnsalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            Crear();
        }

        private void Btnmodificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }
    }
}
