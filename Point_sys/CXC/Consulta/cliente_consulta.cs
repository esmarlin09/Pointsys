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
//using static Point_sys.CXC.Mant.Cliente.Client_web;

namespace Point_sys.CXC.Consulta
{
    public partial class cliente_consulta : Herencias.frm_no_border
    {
        public cliente_consulta()
        {
            
            InitializeComponent();
            
        }
        public long idcliente;

        private void cliente_consulta_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Consulta Clientes", this);
            
            inicio();
        }

        void inicio()

        {
            Client_web api = new Client_web();
            
            gridControl1.DataSource= api.lista(0);
            txttotalrows.Text = gridView1.RowCount.ToString();
            

        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            
        }
        
    
        
        private void Selec_idcliente()
        {

         
            if (gridView1.GetFocusedRowCellValue("id") != null)
            {

                idcliente =long.Parse( gridView1.GetFocusedRowCellValue("id").ToString());
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
            Selec_idcliente();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
           
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Selec_idcliente();
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