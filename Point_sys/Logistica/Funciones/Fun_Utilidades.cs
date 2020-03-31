
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Point_sys.Logistica.Controles_mod;
using System.IO;
using System.Net;

namespace Point_sys.Logistica.Funciones
{
    public class Fun_Utilidades
    {
        //para obtener el string de la mask

        public static string Fun_String_Mask(MaskedTextBox mask)
        {
            string output = Regex.Replace(mask.Text, "-", "");

            return output;
        }
        public static Stream getUrl(string URL)
        {

            string strResp = "";
            HttpWebRequest request = ((HttpWebRequest)WebRequest.Create(URL));

            HttpWebResponse response = ((HttpWebResponse)request.GetResponse());

            try
            {

                return response.GetResponseStream();

            }
            catch
            {
                return response.GetResponseStream();
                //elError = ex.ToString();
            }

        }


        //para limpiar el formulario
        public static void limpiar_form(Form formuario)
        {
            foreach (Control item in formuario.Controls)
            {
                if (item is TextBox || item is MaskedTextBox || item is MaskedTextBox)
                {
                    item.Text = string.Empty;

                }
            }

        }
        //para convertir de string a entero
        public static int convertir_String_A_Entero(string valor)
        {
            int valor1 = 0;
            if (string.IsNullOrEmpty(valor) || !int.TryParse(valor, out valor1))
                return 0;
            else
                return Convert.ToInt32(valor);
        }
        //para convertir de string a double
        public static double convertir_String_A_double(string valor)
        {
            double valor1 = 0;
            if (string.IsNullOrEmpty(valor) || !double.TryParse(valor, out valor1))
                return 0;
            else

                return Convert.ToDouble((Convert.ToDouble(valor.ToString())).ToString("N2"));
        }


        //para validar que dataset que no sea null
        public static bool ValidarDataset(DataSet ds)
        {
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
                else return false;

            }
            else
                return false;
        }
        // para convertir de string a decimal o double
        public static double convertir_String_A_decimal(string valor)
        {
            double valor1 = 0;
            if (string.IsNullOrEmpty(valor) || !double.TryParse(valor, out valor1))
                return 0;
            else
                return Convert.ToDouble(valor);
        }
        //para validar los campos vacios
        public static bool validate_campos(Control[] array)
        {
            bool puede_salvar = true;
            ErrorProvider error = new ErrorProvider();
            foreach (Control item in array)
            {

                if (item is TextBox || item is ComboBox || item is ComboBox)
                {
                    if (item.Text == string.Empty)
                    {
                        error.SetError(item, "este campo no puede estar vacio");

                        puede_salvar = false;

                    }




                }
                if (item is MaskedTextBox)
                {
                    if (((MaskedTextBox)item).MaskFull == false)
                    {


                        error.SetError(item, "este campo no puede estar vacio");

                        puede_salvar = false;


                    }
                    else
                    {
                        error.SetError(item, string.Empty);

                    }

                }


            }
            return puede_salvar;

        }
    }
}
