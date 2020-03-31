using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_sys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtEntero1.Text = listBox1.Items.Count.ToString();
        }

        Image cargar_imagen(string url)
        {
            Image imagen = Properties.Resources.boorder_32x32;
         
            if (url != "")
            {
             

                var request = WebRequest.Create(url);
                try
                {
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        imagen =   Bitmap.FromStream(stream);
                        listBox2.Items.Add(url);
                        return imagen;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("La imagen del producto no pudo ser cargada " + e.ToString());


                }


               
          }
            return imagen;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items)
            {
                imageSlider1.Images.Add(cargar_imagen(item.ToString()));
            }
            txtEntero2.Text = listBox2.Items.Count.ToString();
            
        }

        private void imageSlider1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(imageSlider1.CurrentImageIndex.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(imageSlider1.CurrentImageIndex.ToString() + listBox2.Items[imageSlider1.CurrentImageIndex].ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
