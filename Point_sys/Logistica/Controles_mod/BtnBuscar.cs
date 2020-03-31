using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_sys.Logistica.Controles_mod
{
    public partial class BtnBuscar : Button
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            //    this.Size = new Size(24, 24);
              this.Image = Properties.Resources.search1;
            //this.FlatStyle = FlatStyle.Flat;
            this.TabStop = false;
            this.FlatAppearance.BorderSize = 0;
        }


        //protected override void OnPaint(PaintEventArgs pevent)
        //{
        //    GraphicsPath grPath = new GraphicsPath();
        //    grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
        //    this.Region = new System.Drawing.Region(grPath);
        //    base.OnPaint(pevent);
        //}

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
           
            //   this.Image = Properties.Resources.search24;

        }

        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            base.OnMouseMove(mevent);
            
            //      this.Image = Properties.Resources.search32;
            this.BringToFront();
        }



    }
}
