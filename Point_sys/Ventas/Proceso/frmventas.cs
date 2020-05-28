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
using Point_sys.CXC.Mant.Cliente;
using Point_sys.CXC.Consulta;
using DevExpress.XtraGrid;
using System.IO;
using System.Net;
using Point_sys.Logistica.Funciones;

namespace Point_sys.Ventas.Proceso
{
    public partial class frmventas : Form
    {
        public frmventas()
        {
            InitializeComponent();
        }

        private void ribbonStatusBar1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void frmventas_Load(object sender, EventArgs e)
        {
           
              lblsubtotal.Text = "Sub Total: " + Environment.NewLine + "500.00";
              lbltotalitbis.Text = "Total Itbis: " + Environment.NewLine + "100.00";
              lbltotal.Text = "Total Neto: " + Environment.NewLine + "600.00";
           
               
        }

        private void simpleButton3_Click(object sender, EventArgs e)
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

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtcodigocliente_Validating(object sender, CancelEventArgs e)
        {
            if (txtcodigocliente.Text != "")
            {
                completacliente(long.Parse(txtcodigocliente.Text));
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {



            CreatNewRow(50,60);

            //gridView1.AddNewRow();

            //gridView1.SetRowCellValue(GridControl.NewItemRowHandle, gridView1.Columns["dgvproducto"], "esmarlin");
            //gridView1.SetRowCellValue(GridControl.NewItemRowHandle, gridView1.Columns["dgvdescripcion"], "perez");
        }
        private void CreatNewRow(int val1, int val2)
        {
            gridView1.AddNewRow();

            int rowHandle = gridView1.GetRowHandle(gridView1.DataRowCount);
            
                gridView1.SetRowCellValue(rowHandle, gridView1.Columns["dgvproducto"], val1);
                gridView1.SetRowCellValue(rowHandle, gridView1.Columns[1], val2);
               
            
        }
       

        private void button1_Click(object sender, EventArgs e)
        {

           
        }
        void cargar_imagen(string url)
        {
            if (url != "")
            {

                var request = WebRequest.Create(url);
                try
                {
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureEdit1.Image = Bitmap.FromStream(stream);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("La imagen del producto no pudo ser cargada "+e.ToString());

                   
                }
            }
            
        }
    }
}