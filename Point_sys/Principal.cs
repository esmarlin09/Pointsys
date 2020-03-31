
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
//using static lotsys.StringConverters;
//using static lotsys.get_time_clase;
using System.IO;
using System.Threading;
using DevExpress.Utils.Helpers;
using DevExpress.XtraBars.Painters;
using DevExpress.Xpf.Printing;
namespace Point_sys
{
    public partial class Principal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int dia = 1;
        public static int banca_id = 1;
        public int usuario;
        public DateTime global_fecha;
        public Principal()
        {
        //    frm_login frm = new frm_login();
        //    frm.ShowDialog();
        //    banca_id = frm.banc;
        //    usuario = frm.f_usuario;
        //    if (frm.cerrar == true)
        //    {
        //        Application.Exit();
        //      //  this.Dispose();
        //        return;
        //    }
            InitializeComponent();
            
           
        }
        WebBrowser navegador = new WebBrowser();
        public string Moneda = "USD$";
       
        private void Form1_Load(object sender, EventArgs e)
        {
           
         
        }
        
        private void datos_cargados(object sender, EventArgs e)
        {
            


        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }
        private void validar_text( KeyPressEventArgs e)
        {
           
        }

        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
        }

          


      

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void layoutView1_CardClick(object sender, DevExpress.XtraGrid.Views.Layout.Events.CardClickEventArgs e)
        {
           
        }

        private void layoutView1_Click(object sender, EventArgs e)
        {
            
        }

        private void repositoryItemPictureEdit1_Click(object sender, EventArgs e)
        {
        }
        private void txt_monto_jugada_KeyDown(object sender, KeyEventArgs e)
        {
         
          
        }
        private void calcula_total()
        {
            
            
        }
       
        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
           
        }
        public Boolean cambiar_vacio = false;
        private void textEdit1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void backstageViewTabItem1_ItemPressed(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            
            
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void repositoryItemPictureEdit3_Click(object sender, EventArgs e)
        {
            
        }

        private void layoutView3_CardClick(object sender, DevExpress.XtraGrid.Views.Layout.Events.CardClickEventArgs e)
        {
        }

        private void layoutView4_CardClick(object sender, DevExpress.XtraGrid.Views.Layout.Events.CardClickEventArgs e)
        {
           
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }
        private Boolean validar()
        {
            return true;
        }
        public static int ticket_actual = 0;
       
       
        private void backstageViewTabItem2_ItemPressed(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
        }

        private void backstageViewTabItem3_ItemPressed(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        
        }

        private void backstageViewTabItem4_ItemPressed(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
           
        }

        private void recalcula_balance_cesta(List<string> numeros)
        {
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            global_fecha = global_fecha.AddSeconds(1);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
           
        }

        private void backstageViewTabItem5_ItemPressed(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
           
        }
    }
}
