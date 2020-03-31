using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Point_sys.CXC.Mant.Cliente
{
   public class Client_web
    {
        public List<clienteconsult> lista(long idcliente)
        {
            List<clienteconsult> listreturn = new List<clienteconsult>();

            if (idcliente > 0)
            {
                string url = "http://144.91.118.20:9090/cliente/" + idcliente + "";

                var Json = new WebClient().DownloadString(url);

                var dataclientealbert = JsonConvert.DeserializeObject<clienteconsult>(Json);
                listreturn.Add(dataclientealbert);

            }
            else
            {

                string url = "http://144.91.118.20:9090/cliente/find/all";

                var Json = new WebClient().DownloadString(url);

                var dataclientealbert = JsonConvert.DeserializeObject<List<clienteconsult>>(Json);
                listreturn = dataclientealbert;
            }
           

           
            return listreturn;

        }
        public  static string PostMessageToURL(string parameters, string url)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                string HtmlResult = wc.UploadString(url, "POST", parameters);
                return HtmlResult;
            }
        }
        public class clienteconsult
        {
            public string cedrnc { get; set; }
            public string celular { get; set; }
            public string comentario { get; set; }
            public int idcondicion { get; set; }
            public int idtipocomprobante { get; set; }
            
            public string contacto { get; set; }
            public string contacto_tel { get; set; }
            public string direccion { get; set; }
            public int id { get; set; }
            public Nullable<double> limite_credito { get; set; } = 0;
            public string nombre { get; set; }
            public string numero_adicional { get; set; }
            public string razon_social { get; set; }
            public string telefono { get; set; }
            public int tipo { get; set; }

        }


        public class cliente_save
        {
            public string cedrnc { get; set; }
            public string celular { get; set; }
            public string comentario { get; set; }
            public int idcondicion { get; set; }
            public int idtipocomprobante { get; set; }
            public string contacto { get; set; }
            public string contacto_tel { get; set; }
            public string direccion { get; set; }
            //public int id { get; set; }
            public Nullable<double> limite_credito { get; set; } = 0;
            public string nombre { get; set; }
            public string numero_adicional { get; set; }
            public string razon_social { get; set; }
            public string telefono { get; set; }
            public int tipo { get; set; } = 0;

        }
        public class cliente_Mod
        {
            public string cedrnc { get; set; }
            public string celular { get; set; }
            public string comentario { get; set; }
            public int idcondicion { get; set; }
            public int idtipocomprobante { get; set; }
            public string contacto { get; set; }
            public string contacto_tel { get; set; }
            public string direccion { get; set; }
            public int id { get; set; }
            public Nullable<double> limite_credito { get; set; } = 0;
            public string nombre { get; set; }
            public string numero_adicional { get; set; }
            public string razon_social { get; set; }
            public string telefono { get; set; }
            public int tipo { get; set; } = 0;

        }
    }
}
