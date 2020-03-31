using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Point_sys.Logistica.Funciones
{
    
    
    class Funciones_API
    {
        
        /// <summary>
     /// Para llenar los CMB
     /// </summary>
        public class llenarcmb
        {
            public class condiciones
            {
                public string descripcion { get; set; }
                public int dias { get; set; }
                public int idcondicion { get; set; }
                public int nulo { get; set; }
            }



            public class titpocliente
            {
                public string descripcion { get; set; }
                public int id { get; set; }
            }

            public class tiponcf
            {
                public string descripcion { get; set; }
                public int final { get; set; }
                public int id { get; set; }
                public int secuencia { get; set; }
                public string serie { get; set; }
                public string tipo_ncf { get; set; }
                public bool usoventas { get; set; }
                public string vecimiento { get; set; }
            }
            public class tipoitbis
            {
                public double porc_impuesto { get; set; }
                public int rowid { get; set; }
                public string tipo { get; set; }
            }
            public static List<tipoitbis> listaitbis()
            {
                List<tipoitbis> listreturn = new List<tipoitbis>();

                string url = "http://144.91.118.20:9090/query/generico/itbis";


                var Json = new WebClient().DownloadString(url);

                var dataclientealbert = JsonConvert.DeserializeObject<List<tipoitbis>>(Json);
                return listreturn = dataclientealbert;
            }
            public static List<condiciones> listacondiciones()
            {
                List<condiciones> listreturn = new List<condiciones>();

                string url = "http://144.91.118.20:9090/query/generico/condiciones";


                var Json = new WebClient().DownloadString(url);

                var dataclientealbert = JsonConvert.DeserializeObject<List<condiciones>>(Json);
                return listreturn = dataclientealbert;
            }
            public static List<titpocliente> listatipocliente()
            {
                List<titpocliente> listreturn = new List<titpocliente>();

                string url = "http://144.91.118.20:9090/query/generico/tipocliente";


                var Json = new WebClient().DownloadString(url);

                var dataclientealbert = JsonConvert.DeserializeObject<List<titpocliente>>(Json);
                return listreturn = dataclientealbert;
            }

            public static List<tiponcf> listatipoNCF()
            {
                List<tiponcf> listreturn = new List<tiponcf>();

                string url = "http://144.91.118.20:9090/query/generico/comprobantes";


                var Json = new WebClient().DownloadString(url);

                var dataclientealbert = JsonConvert.DeserializeObject<List<tiponcf>>(Json);
                return listreturn = dataclientealbert;
            }




        }

    }
}
