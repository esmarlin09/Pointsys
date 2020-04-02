using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_sys.Logistica.calculos
{
   
        public class Calcular
        {
            /// <summary>
            ///     ...ING.ESMARLIN PEREZ(PointSYS)
            ///     ''' Método para calcular el itbis incluido del precio
            ///     ...Formula : depende del tipo de itbis por ejemplo si es 18 se divide el precio por 1.18
            ///     ''' </summary>
            ///     ''' <param name="tipo">El tipo de itbis del producto usar</param>
            ///     ''' <param name="precio">precio del producto multiplicado por la cantidad</param>
            ///     ''' <returns></returns>

            public static Result_calculo retornar(int tipo, double precio)
            {
                var result = new Result_calculo();

                double subtotal = 0;
                double itbis = 0;

                if (tipo == 1)
                {
                    subtotal = precio ;
                    itbis = subtotal * 0.18;


                }
                if (tipo == 2)
                {
                    subtotal = precio ;
                    itbis = subtotal * 0.16;


                }
                if (tipo == 3)
                {
                    subtotal = precio ;
                    itbis = subtotal * 0.18;


                }
                if (subtotal > 0 && itbis > 0)
                {
                    result.itbis = itbis;
                    result.Subtotal = subtotal;


                }
                return result;

            }

        }
    }



