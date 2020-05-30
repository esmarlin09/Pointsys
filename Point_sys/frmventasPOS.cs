using Point_sys.Herencias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_sys
{
    public partial class frmventasPOS : frm_no_border
    {
        public frmventasPOS()
        {
            InitializeComponent();
        }

        private void frmventasPOS_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Punto de Ventas", this);
            textEdit1.Focus();
        }

        private void textEdit1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void textEdit1_Enter(object sender, EventArgs e)
        {

            textEdit1.BackColor = Color.LightYellow;
        }

        private void textEdit1_Leave(object sender, EventArgs e)
        {
            textEdit1.BackColor = Color.White;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CXC.Consulta.cliente_consulta fr = new CXC.Consulta.cliente_consulta();
            fr.ShowDialog();
        }
    }
}
