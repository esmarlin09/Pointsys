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
using Point_sys.CXC.Consulta;
using static Point_sys.Logistica.Funciones.sql_funciones;
using Newtonsoft.Json;
using Point_sys.Logistica.Funciones;
using static Point_sys.CXC.Mant.Cliente.Client_web;
using System.Net;
using Point_sys.Herencias;

namespace Point_sys.CXC.Mant.Cliente
{
    public partial class mant_cliente : mainformmant
    {
        public mant_cliente()
        {
            InitializeComponent();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            
            cargarcmb();

            Crear();

        }
        protected override void Crear()
        {
            Fun_Set_Nombre_Formulario("Registro Cliente", this);
            base.Crear();

            txtcodigocliente.Enabled = false;
            btnbuscar.Visible = false;
            // txtcodigo.Text = sql_funciones.sqlfun_ultimo_codigo("idcliente", "syscxcclientes");

        }
        protected override void Modificar()
        {
            base.Modificar();
            txtcodigocliente.Text = "";
            btnbuscar.Visible = true;
            txtcodigocliente.Enabled = true;
            txtcodigocliente.Focus();


        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            cliente_consulta fr = new cliente_consulta();
            if (fr.ShowDialog() == DialogResult.OK)
            {

              
                completacliente(fr.idcliente);
            }
        }
        void completacliente(long idcliente)
        {
            Client_web api = new Client_web();

            foreach (var item in api.lista(idcliente))
            {
                txtnombre.Text = item.nombre;
                txtdireccion.Text = item.direccion;
                txtcodigocliente.Text = item.id.ToString();
                mskRncCedula1.Text = item.cedrnc;
                mskTelefono1.Text = item.telefono;
            }
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {

        }

        private void Btnsalvar_Click(object sender, EventArgs e)
        {
           


        }
        void cargarcmb()
        {
            /*cmbcondiciones*/
            List<CmbItem_Add> cmbitems = new List<CmbItem_Add>();
            foreach (var item in Funciones_API.llenarcmb.listacondiciones())
            {
                CmbItem_Add data = new CmbItem_Add();
                data.Name = item.descripcion;
                data.Value = item.idcondicion.ToString();
                cmbitems.Add(data);

            }
            Logistica.Funciones.sql_funciones.Completar_Combobox(cmbcondicion, cmbitems,"Seleccione");

            /*cmbtipocliente*/
            List<CmbItem_Add> cmbtipoclien = new List<CmbItem_Add>();
            foreach (var item in Funciones_API.llenarcmb.listatipocliente())
            {
                CmbItem_Add data = new CmbItem_Add();
                data.Name = item.descripcion;
                data.Value = item.id.ToString();
                cmbtipoclien.Add(data);

            }
            Logistica.Funciones.sql_funciones.Completar_Combobox(cmbtipocliente, cmbtipoclien, "Seleccione");
            
            /*cmbtipoNCF*/

             List<CmbItem_Add> cmbtipoclienNCF = new List<CmbItem_Add>();
            foreach (var item in Funciones_API.llenarcmb.listatipoNCF())
            {
                CmbItem_Add data = new CmbItem_Add();
                data.Name = item.descripcion;
                data.Value = item.id.ToString();
                cmbtipoclienNCF.Add(data);

            }
            Logistica.Funciones.sql_funciones.Completar_Combobox(cmbtiponcf, cmbtipoclienNCF, "Seleccione");

        }

        private void cmbcondicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
          
           
        }

        private void Btnretornar_Click(object sender, EventArgs e)
        {

        }

        private void Btnsalvar_Click_1(object sender, EventArgs e)
        {
            Control[] array = { txtcodigocliente, txtnombre, txtdireccion, mskRncCedula1, mskTelefono1 };
            base.Salvar();
            if (Fun_Utilidades.validate_campos(array))
            {
                cliente_save api = new cliente_save();
                api.cedrnc = Fun_Utilidades.Fun_String_Mask(mskRncCedula1);
                api.celular = Fun_Utilidades.Fun_String_Mask(mskcelular);
                api.comentario = txtcomentario.Text;
                api.contacto = txtcontacto.Text;
                api.contacto_tel = Fun_Utilidades.Fun_String_Mask(msktelcontacto);
                api.direccion = txtdireccion.Text;
                api.idcondicion = 1;//Fun_Utilidades.convertir_String_A_Entero( cmbcondicion.SelectedValue.ToString());
                api.idtipocomprobante = 1;//Fun_Utilidades.convertir_String_A_Entero( cmbtiponcf.SelectedValue.ToString());
                api.limite_credito = Fun_Utilidades.convertir_String_A_double(txtlimitecredito.Text);
                api.nombre = txtnombre.Text;
                api.numero_adicional = Fun_Utilidades.Fun_String_Mask(mskTeladicional);
                api.razon_social = txtrazonsocial.Text;
                api.telefono = Fun_Utilidades.Fun_String_Mask(mskTelefono1);
                api.tipo = 1;//Fun_Utilidades.convertir_String_A_Entero( cmbtipocliente.SelectedValue.ToString());


                var json = JsonConvert.SerializeObject(api);
                Cliente.Client_web.PostMessageToURL(json, "http://144.91.118.20:9090/cliente");
                Fun_Utilidades.limpiar_form(this);


            }
        }

        private void BtnCrear_Click_1(object sender, EventArgs e)
        {
            Crear();
        }

        private void Btnmodificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }
    }
}