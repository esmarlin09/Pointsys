using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_sys.Logistica.Funciones
{
    class sql_funciones
    {
        public static bool error = false;
        public static DataSet Fun_Sql_Ejecutar(string cmd)
        {
            error = false;
            DataSet ds = new DataSet();
            try
            {
                SqlConnection cn = new SqlConnection(Point_sys.Properties.Settings.Default.PointSysConnectionString);

                SqlDataAdapter da = new SqlDataAdapter(cmd, cn);

                cn.Close();
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Columns.Contains("ErrorNumber") )
                    {

                        //ErroresSQL fr = new ErroresSQL(ds.Tables[0].Rows[0]["ErrorMessage"].ToString());
                        //fr.ShowDialog();
                    cn.Dispose();
                        da.Dispose();

                        return null;

                    }
                  
                }

                cn.Dispose();
                da.Dispose();

            }

            catch (Exception ex)
            {
                //ErroresSQL fr = new ErroresSQL(ex.Message);
               // fr.ShowDialog();


                return null;
               

            }
            return ds;

        }
        public static string sqlfun_ultimo_codigo(string nombreCampo, string nombreTabla)
        {
            string cmd = "select MAX(" + nombreCampo.Trim() + ") as mayor from " + nombreTabla.Trim();
            double mayor = 0;
            DataSet ds = Fun_Sql_Ejecutar(cmd);
            try
            {
                mayor = Convert.ToDouble(ds.Tables[0].Rows[0][0].ToString()) + 1;
            }
            catch (Exception e)
            {
               // ErroresSQL fr = new ErroresSQL(e.Message);
               // fr.ShowDialog();
                throw;
            }
               
            
          
        
            return mayor.ToString();
        }
        public static bool fun_validards(DataSet ds)
        {
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;

        }

        public static string ultimasecuencia(string tipo,int sucursal)
        {
            string secuencia = "";
            string cmd= "select letra +'-' + RIGHT('000000000' + Ltrim(Rtrim(secuencia + 1)), 9) from sysgensecuencias WHERE descripcion = '"+ tipo+"' AND idsucursal = '"+ sucursal+"'";
            DataSet ds = Fun_Sql_Ejecutar(cmd);
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                    secuencia = ds.Tables[0].Rows[0][0].ToString();
            }
            else
                secuencia = string.Empty;

            return secuencia;
        }
        public class CmbItem
        {
            public string Name { get; set; }
            public string Value { get; set; }
            public CmbItem(string name, string value)
            {
                Name = name;
                Value = value;
            }
            public override string ToString()
            {
                return Name;
            }
        }
        public class CmbItem_Add
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

            public static void Completar_Combobox(ComboBox combo,List<CmbItem_Add> lista_add, string opcion = "")
        {
            List<CmbItem> lista = new List<CmbItem>();

            if (opcion != "")
                lista.Add(new CmbItem(opcion, "0"));
            for (int i = 0; i < lista_add.Count; i++)
            {
                lista.Add(new CmbItem(lista_add[i].Name, lista_add[i].Value));
            }
                
            combo.DisplayMember = "Name";
            combo.ValueMember = "Value";
            combo.DataSource = lista;
        }
    }
}
