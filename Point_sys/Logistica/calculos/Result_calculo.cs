using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_sys.Logistica.calculos
{
   
        public class Result_calculo
        {

            public double itbis
            {
                get
                {
                    return m_itbis;
                }
                set
                {
                    m_itbis = value;
                }
            }
            private double m_itbis;
            public double Subtotal
            {
                get
                {
                    return m_subtotal;
                }
                set
                {
                    m_subtotal = value;
                }
            }
            private double m_subtotal;
        }
    }


