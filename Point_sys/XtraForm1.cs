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
using Point_sys.CXC.Mant.Cliente;
using Point_sys.Logistica.Funciones;

namespace Point_sys
{
    public partial class XtraForm1 : Form
    {
        string itbis;
        public string tipo_factura = "VENTA A CONTADO";
  
        double total;
        int tipoitbis;
        double totalitbis;
        string devuelta;
        bool abrirdevuelta = false;
        public XtraForm1()
        {
            InitializeComponent();
        }
        void navBarControl_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            //navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group);
        }
        void barButtonNavigation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {

        }

        private void txtcodigocliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            cliente_consulta fr = new cliente_consulta();
            if (fr.ShowDialog() == DialogResult.OK)
            {

                txtcodigocliente.Text = fr.idcliente.ToString();
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

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Control[] array1 = { txtcodpro, txtdescripcion, txtcantidad };
            if (Fun_Utilidades.validate_campos(array1))
            //if (txtcantidad.Text != string.Empty || Fun_Utilidades.convertir_String_A_Entero( txtcantidad.Text )<0)
            {
                if (txtdescuento.Text == "")
                {
                    txtdescuento.Text = "0";
                }
                //validar campos vacios
                Logistica.calculos.Result_calculo res =  Logistica.calculos.Calcular.retornar(Fun_Utilidades.convertir_String_A_Entero(itbis), Convert.ToDouble(txtimporte.Text));

                dataGridViewX1.Rows.Add(txtcodpro.Text, txtdescripcion.Text, txtcantidad.Text, txtprecio.Text, txtdescuento.Text, txtimporte.Text, res.Subtotal, res.itbis, tipoitbis);
                Control[] array = { txtcodpro, txtdescripcion, txtcantidad, txtdescuento, txtimporte, txtprecio };
                limpiartxt(array);
                //pictureBox1.Image = null;
                txtcodpro.Focus();
                calcular_Totalesgrid();
            }
            else
            {

            }
        }
        private void limpiartxt(Control[] array)
        {
            foreach (Control ctrl in array)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = string.Empty;
                }
            }
        }
        void competar_producto(long idproducto)
        {
            string cmd = "  select pro.*,itbis.tasaitbis as itbis from sysinvproductos pro inner join sysgentasaitbis itbis on pro.tipo_itbis = itbis.idtasaitbis where idproducto = '" + idproducto + "'";
            DataSet ds = new DataSet();
            ds = sql_funciones.Fun_Sql_Ejecutar(cmd);
            if (sql_funciones.fun_validards(ds))
            {
                txtdescripcion.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                itbis = ds.Tables[0].Rows[0]["itbis"].ToString();
                txtprecio.Text = ds.Tables[0].Rows[0]["precio2"].ToString();
                tipoitbis = Fun_Utilidades.convertir_String_A_Entero(ds.Tables[0].Rows[0]["tipo_itbis"].ToString());
                if (ds.Tables[0].Rows[0]["imagen"].ToString() != "")
                {
                  //  pictureBox1.Image = Base64ToImage(ds.Tables[0].Rows[0]["imagen"].ToString());
                }
                else
                {
                    //pictureBox1.Image = null;
                }
                txtcantidad.Focus();

            }
            else
            {
               MessageBox.Show("Este registro no existe", "Atencion");
          
                txtcodpro.Text = "";
                txtcodpro.Focus();
            }
        }
        private void calcular_Totalesgrid()
        {
            double importe = 0, itbis = 0, subtotal = 0;
            foreach (DataGridViewRow rows in dataGridViewX1.Rows)
            {
                if (rows.Cells["dgvimporte"].Value != null)
                    importe += Fun_Utilidades.convertir_String_A_decimal(rows.Cells["dgvimporte"].Value.ToString());
                if (rows.Cells["dgvitbis"].Value != null)
                    itbis += Fun_Utilidades.convertir_String_A_decimal(rows.Cells["dgvitbis"].Value.ToString());
                if (rows.Cells["dgvsubtotal"].Value != null)
                    subtotal += Fun_Utilidades.convertir_String_A_decimal(rows.Cells["dgvsubtotal"].Value.ToString());

            }
            totalitbis = itbis;
            total = importe;
            LBLTOTAL.Text = "<b><font size=" + "'+ 6'" + "><i>" + "" + "</i><font color=" + "'#00AA5A'" + "> " + "Total:   " + importe.ToString("n2") + "</font></font></b>";
            LBLITBIS.Text = "<b><font size=" + "'+ 6'" + "><i>" + "" + "</i><font color=" + "'#00AA5A'" + "> " + "Itbis:   " + itbis.ToString("n2") + "</font></font></b>";
            LBLSUBTOTAL.Text = "<b><font size=" + "'+ 6'" + "><i>" + "" + "</i><font color=" + "'#00AA5A'" + "> " + "Subtotal: " + subtotal.ToString("n2") + "</font></font></b>";
            lbltotalproductosgrid.Text = "Total Productos["+ dataGridViewX1.Rows.Count.ToString()+"]";
         
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewX1.Rows.Count > 0)
            {
                if (this.dataGridViewX1.Columns[dataGridViewX1.CurrentCell.ColumnIndex].Name == "eliminar")
                {
                    DialogResult result = MessageBox.Show("¿Seguro que desea eliminar?", "Aviso", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        eliminar_fila();
                        //txtcod_str.Focus();
                    }
                }
            }
        }
        void eliminar_fila()
        {

            dataGridViewX1.Rows.RemoveAt(dataGridViewX1.CurrentRow.Index);
            calcular_Totalesgrid();
        }
    }
    }
