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
using System.Net;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace Point_sys.Generales
{
    public partial class frmslider_produ : Herencias.frm_no_border
    {
        public frmslider_produ()
        {
            InitializeComponent();
        }
       ListBox lista_url = new ListBox();
        ListBox lista_urladd = new ListBox();
        private void frmslider_produ_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Slider Productos", this);
            






        }
        void cargarimagenApi()
        {
            //List<guardarurl> listaof = new List<guardarurl>();
            //guardarurl LIST = new guardarurl();
            foreach (var item in lista_())
            {
                lista_url.Items.Add(item.url);
            }
           

        }

        Image cargar_imagen(string url)
        {
            Image imagen = Properties.Resources.boorder_32x32;
            url.Substring(1);
            if (url != "" && url.Substring(0)!="p")
            {


                var request = WebRequest.Create(url);
                try
                {
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        imagen = Bitmap.FromStream(stream);
                        lista_urladd.Items.Add(url);
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in lista_())
            {
                lista_url.Items.Add(item.url);
            }

            foreach (var item in lista_url.Items)
            {
                imageSlider1.Images.Add(cargar_imagen(item.ToString()));
            }
            // txtEntero2.Text = listBox2.Items.Count.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(imageSlider1.CurrentImageIndex.ToString() + lista_urladd.Items[imageSlider1.CurrentImageIndex].ToString());
        }

      public  class guardarurl
        {
            public string url { get; set; }
            public int idproducto { get; set; }
        }
        public List<guardarurl> lista_()
        {
            List<guardarurl> listreturn = new List<guardarurl>();


                string url = "http://144.91.118.20:9090/query/generico/imagen";

                var Json = new WebClient().DownloadString(url);

                var dataclientealbert = JsonConvert.DeserializeObject<List<guardarurl>>(Json);
                listreturn = dataclientealbert;
            



            return listreturn;

        }
        //List<guardarurl> listurl = new List<guardarurl>();
        //void save()
        //{
        //    guardarurl datos = new guardarurl();
        //    foreach (var item in listBox1.Items)
        //    {
        //        datos.url = item.ToString();
        //        datos.idproducto = 2;
        //        listurl.Add(datos);
        //    }

        //    var json = JsonConvert.SerializeObject(listurl);
        //   PostMessageToURL(json, "http://144.91.118.20:9090/query/genericoguardar/rutaimagen");


        //}
        public static string PostMessageToURL(string parameters, string url)
        {
            //parameters = parameters.Replace(char.Parse("["), char.Parse(""));
            //parameters = parameters.Replace(char.Parse("]"), char.Parse(""));
            //string parametro = parameters.Replace("[", "");
          // parametro = parametro.Replace("]", "");//Regex.Replace(parameters, "]]", "");

            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                string HtmlResult = wc.UploadString(url, "POST", parameters);
                return HtmlResult;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           // save();
        }
    }
}