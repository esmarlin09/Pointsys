using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Point_sys.Inventario.Clases
{
   public class ProductosAPIcs
    {

        public class save_produc
        {
            public string cod_barra { get; set; }
            public string image_url { get; set; }
        //    public int prod_cod { get; set; }
            public double prod_costo { get; set; }
            public double prod_costo_con_itbis { get; set; }
            public string prod_nombre { get; set; }
            public double prod_precio { get; set; }
            public double prod_precio_con_itbis { get; set; }
            public string referencia { get; set; }
            public int rentable { get; set; }
            public int stock_actual { get; set; }
            public int stock_minimo { get; set; }
            public int tipo_impuesto { get; set; }
        }
        public class consult_produc
        {
            public string cod_barra { get; set; }
            public string image_url { get; set; }
            public Nullable<int> prod_cod { get; set; }
            public Nullable<double> prod_costo { get; set; }
            public Nullable<double> prod_costo_con_itbis { get; set; }
            public string prod_nombre { get; set; }
            public Nullable<double> prod_precio { get; set; }
            public Nullable<double> prod_precio_con_itbis { get; set; }
            public string referencia { get; set; }
            public Nullable<bool> rentable { get; set; }
            public Nullable<int> stock_actual { get; set; }
            public Nullable<int> stock_minimo { get; set; }
            public Nullable<int> tipo_impuesto { get; set; }
        }

        public static string PostMessageToURL(string parameters, string url)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                string HtmlResult = wc.UploadString(url, "POST", parameters);
                return HtmlResult;
            }
        }
        public List<consult_produc> lista()
        {
            List<consult_produc> listreturn = new List<consult_produc>();

           

                string url = "http://144.91.118.20:9090/query/generico/productos";

                var Json = new WebClient().DownloadString(url);

                var dataclientealbert = JsonConvert.DeserializeObject<List<consult_produc>>(Json);
                listreturn = dataclientealbert;
            



            return listreturn;

        }

    }
}
