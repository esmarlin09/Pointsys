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
using Point_sys.CXC.Mant.Cliente;
using DevExpress.XtraReports.UI;
using DevExpress.LookAndFeel;
using Point_sys.Inventario.Clases;
//using static Point_sys.CXC.Mant.Cliente.Client_web;

namespace Point_sys.Inventario.Consulta
{
    public partial class Produc_consulta : Herencias.frm_no_border
    {
        public Produc_consulta()
        {
            
            InitializeComponent();
            
        }
        public long idproducto;

        private void cliente_consulta_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Consulta Productos", this);
            
            inicio();
        }

        void inicio()

        {
            ProductosAPIcs api = new ProductosAPIcs();
            
            gridControl1.DataSource= api.lista(0);
            txttotalrows.Text = gridView1.RowCount.ToString();
            

        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            
        }
        
    
        
        private void Selec_product()
        {

         
            if (gridView1.GetFocusedRowCellValue("prod_cod") != null)
            {

                idproducto =long.Parse( gridView1.GetFocusedRowCellValue("prod_cod").ToString());
               // MessageBox.Show(idcliente.ToString());
               DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Seleccione cliente para continuar");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            MessageBox.Show(gridView1.GetFocusedRowCellValue("id").ToString());
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //gridView1.current.Selected = true;
            Selec_product();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
           
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Selec_product();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            XtraReport report = new XtraReport();
            report.LoadLayout("Report1.repx");

            Client_web api = new Client_web();

            report.DataSource = api.lista(0);
            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                printTool.ShowPreviewDialog(UserLookAndFeel.Default);
            }
        }
    }
}