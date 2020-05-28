using Newtonsoft.Json;
using Point_sys.Herencias;
using Point_sys.Inventario.Clases;
using Point_sys.Inventario.Consulta;
using Point_sys.Logistica.calculos;
using Point_sys.Logistica.Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Point_sys.Inventario.Clases.ProductosAPIcs;
using static Point_sys.Logistica.Funciones.sql_funciones;

namespace Point_sys.Inventario.Mant
{
    public partial class mant_productos : mainformmant
    {
        public mant_productos()
        {
            InitializeComponent();
        }
        string url;
        private void mant_productos_Load(object sender, EventArgs e)
        {
            Crear();
            Fun_Set_Nombre_Formulario("Registgro Productos", this);
            List<CmbItem_Add> cmbtipoclienNCF = new List<CmbItem_Add>();
            foreach (var item in Funciones_API.llenarcmb.listaitbis())
            {
                CmbItem_Add data = new CmbItem_Add();
                data.Name = item.tipo;
                data.Value = item.rowid.ToString();
                cmbtipoclienNCF.Add(data);

            }
            Logistica.Funciones.sql_funciones.Completar_Combobox(cmbtipoitbis, cmbtipoclienNCF);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Generales.frmslider_produ fr = new Generales.frmslider_produ();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                url = fr.url;
                if (url != "")
                {
                    pictureEdit1.Image = cargar_imagen(url);
                }
            }
        }
        Image cargar_imagen(string url)
        {
            Image imagen = Properties.Resources.boorder_32x32;
            url.Substring(1);
            if (url != "" && url.Substring(0) != "p")
            {


                var request = WebRequest.Create(url);
                try
                {
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        imagen = Bitmap.FromStream(stream);
                       
                        return imagen;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("La imagen del producto no pudo ser cargada " + e.ToString());


                }



            }
            return imagen;
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
        protected override void Crear()
        {

            base.Crear();
            lblestado.Text = "Creando";
            txtcod_pro.Enabled = false;
            btnbuscar.Visible = false;
            // txtcodigo.Text = sql_funciones.sqlfun_ultimo_codigo("idcliente", "syscxcclientes");

        }
        protected override void Modificar()
        {
            base.Modificar();
            txtcod_pro.Text = "";
            btnbuscar.Visible = true;
            txtcod_pro.Enabled = true;
            txtcod_pro.Focus();
            pictureEdit1.Image = null;


        }

        private void Btnsalvar_Click(object sender, EventArgs e)
        {
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Produc_consulta fr = new Produc_consulta();
            if (fr.ShowDialog() == DialogResult.OK)
            {

                completaproduc(fr.idproducto);
                // completacliente(fr.idcliente);
            }
        }
        void completaproduc(long produc)
        {
            ProductosAPIcs api = new ProductosAPIcs();

            foreach (var item in api.lista(produc))
            {
                txtcod_pro.Text = item.prod_cod.ToString();
                txtdescripcion.Text = item.prod_nombre;
                txtcodigobarra.Text = item.cod_barra;
                txtcosto.Text = item.prod_costo.ToString();
                txtcostoitbis.Text = item.prod_costo_con_itbis.ToString();
                txtminimo.Text = item.stock_minimo.ToString();
                txtprecio.Text = item.prod_precio.ToString();
                txtprecioitbis.Text = item.prod_precio_con_itbis.ToString();
                boolrentable.EditValue = item.rentable;
                txtreferencia.Text = item.referencia;
                cmbtipoitbis.SelectedValue = item.tipo_impuesto.ToString();
                if (item.image_url != "")
                {
                    pictureEdit1.Image = cargar_imagen(item.image_url);
                }

            }
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            Crear();
        }

        private void Btnmodificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void Btnsalvar_Click_1(object sender, EventArgs e)
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
            api.prod_costo = Logistica.Funciones.Fun_Utilidades.convertir_String_A_decimal(txtcosto.Text);
            api.prod_costo_con_itbis = Fun_Utilidades.convertir_String_A_decimal(txtcostoitbis.Text);
            api.prod_nombre = txtdescripcion.Text;
            api.prod_precio = Fun_Utilidades.convertir_String_A_decimal(txtprecio.Text);
            api.prod_precio_con_itbis = Fun_Utilidades.convertir_String_A_decimal(txtprecioitbis.Text);
            api.referencia = txtreferencia.Text;
            api.rentable = estado;
            api.stock_actual = 0;
            api.stock_minimo = Logistica.Funciones.Fun_Utilidades.convertir_String_A_Entero(txtminimo.Text);
            if (url != "")
            {
                api.image_url = url;
            }
            api.tipo_impuesto = Logistica.Funciones.Fun_Utilidades.convertir_String_A_Entero(cmbtipoitbis.SelectedValue.ToString());
            var json = JsonConvert.SerializeObject(api);
            ProductosAPIcs.PostMessageToURL(json, "http://144.91.118.20:9090/producto");
            Fun_Utilidades.limpiar_form(this);
            pictureEdit1.Image = null;
        }

        private void txtcosto_Validating(object sender, CancelEventArgs e)
        {
            if (txtcosto.Text != "")
            {
                calcular_costo();
            }
           

        }
        void calcular_costo()
        {
            Result_calculo res = Calcular.retornar(Fun_Utilidades.convertir_String_A_Entero(cmbtipoitbis.SelectedValue.ToString()), Convert.ToDouble(txtcosto.Text));
            txtcostoitbis.Text = (Fun_Utilidades.convertir_String_A_decimal(txtcosto.Text) + res.itbis).ToString("N2");

         

        }
        void calcular_precio()
        {
            Result_calculo res = Calcular.retornar(Fun_Utilidades.convertir_String_A_Entero(cmbtipoitbis.SelectedValue.ToString()), Convert.ToDouble(txtprecio.Text));
            txtprecioitbis.Text = (Fun_Utilidades.convertir_String_A_decimal(txtprecio.Text) + res.itbis).ToString("N2");

        }

        private void txtprecio_Validating(object sender, CancelEventArgs e)
        {
            if (txtprecio.Text != "")
            {
                calcular_precio();
            }
        }

        private void cmbtipoitbis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtprecio.Text != "")
            {
                calcular_precio();
            }
            if (txtcosto.Text != "")
            {
                calcular_costo();
            }
        }
    }
}
