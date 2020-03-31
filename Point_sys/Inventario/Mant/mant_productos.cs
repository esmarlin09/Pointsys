using Newtonsoft.Json;
using Point_sys.Inventario.Clases;
using Point_sys.Inventario.Consulta;
using Point_sys.Logistica.Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Point_sys.Inventario.Clases.ProductosAPIcs;
using static Point_sys.Logistica.Funciones.sql_funciones;

namespace Point_sys.Inventario.Mant
{
    public partial class mant_productos : Herencias.frm_mantcs
    {
        public mant_productos()
        {
            InitializeComponent();
        }

        private void mant_productos_Load(object sender, EventArgs e)
        {
            List<CmbItem_Add> cmbtipoclienNCF = new List<CmbItem_Add>();
            foreach (var item in Funciones_API.llenarcmb.listaitbis())
            {
                CmbItem_Add data = new CmbItem_Add();
                data.Name = item.tipo;
                data.Value = item.rowid.ToString();
                cmbtipoclienNCF.Add(data);

            }
            Logistica.Funciones.sql_funciones.Completar_Combobox(cmbtipoitbis, cmbtipoclienNCF, "Seleccione");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Generales.frmslider_produ fr = new Generales.frmslider_produ();
            fr.ShowDialog();
        }

        private void Btnretornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mant_productos_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 3),
                            this.DisplayRectangle);
        }

        private void Btnsalvar_Click(object sender, EventArgs e)
        {
            int estado;
            if (boolrentable.EditValue.ToString() == "True")
            {
                estado = 1;
            }
            else
            {
                estado = 0;
            }
            save_produc api = new save_produc();
             api.cod_barra = txtcodigobarra.Text;
             api.image_url = "";
            //api.prod_cod = Logistica.Funciones.Fun_Utilidades.convertir_String_A_Entero( txtcod_pro.Text);
             api.prod_costo= Logistica.Funciones.Fun_Utilidades.convertir_String_A_decimal(txtcosto.Text);
             api.prod_costo_con_itbis =Fun_Utilidades.convertir_String_A_decimal(txtcostoitbis.Text);
             api.prod_nombre = txtdescripcion.Text;
             api.prod_precio = Fun_Utilidades.convertir_String_A_decimal(txtprecio.Text);
             api.prod_precio_con_itbis = Fun_Utilidades.convertir_String_A_decimal(txtprecioitbis.Text);
             api.referencia = txtreferencia.Text;
             api.rentable = estado;
             api.stock_actual = 0;
             api.stock_minimo = Logistica.Funciones.Fun_Utilidades.convertir_String_A_Entero(txtminimo.Text);
             api.tipo_impuesto = Logistica.Funciones.Fun_Utilidades.convertir_String_A_Entero(cmbtipoitbis.SelectedValue.ToString());
            var json = JsonConvert.SerializeObject(api);
            ProductosAPIcs.PostMessageToURL(json, "http://144.91.118.20:9090/producto");
            Fun_Utilidades.limpiar_form(this);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Produc_consulta fr = new Produc_consulta();
            if (fr.ShowDialog() == DialogResult.OK)
            {


               // completacliente(fr.idcliente);
            }
        }
    }
}
