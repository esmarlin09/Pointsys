using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Data;

namespace WindowsFormsApp6
{
   public class consultaAPI
    {
        public List<clienteconsult> lista (string entidad)
        {
           
                string url = "http://144.91.118.20:9090/"+entidad+"/find/all";
                var Json = new WebClient().DownloadString(url);
                var dataclientealbert=    JsonConvert.DeserializeObject<List<clienteconsult>>(Json);
                return dataclientealbert;
            
        }

    }

    


    public class clienteconsult
    {
        public string cedrnc { get; set; }
        public string celular { get; set; }
        public string comentario { get; set; }
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
    [AttributeUsage(AttributeTargets.Property)]
    public class DataColumnAttribute : Attribute { }
    public class Customer
    {
        [DataColumn]
        public Guid CustomerID { get; set; }

        [DataColumn]
        public string CustomerName { get; set; }

        [DataColumn]
        public string CustomerCode { get; set; }
    }
   




}
