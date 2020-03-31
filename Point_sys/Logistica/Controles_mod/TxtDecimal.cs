using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_sys.Logistica.Controles_mod
{
    public partial class TxtDecimal : Logistica.Controles_mod.Txtorigen
    {
        int suma = 0;
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            base.TextAlign = HorizontalAlignment.Right;
        }

       



        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (enabled_personalizado == true)
            {
                e.Handled = true;
            }
            else
            {
                suma = 0;
                if (this.SelectionStart == 0 && e.KeyChar == ',' || this.SelectionStart == 0 && e.KeyChar == '.')
                    e.Handled = true;
                else
                    e.Handled = false;
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                    e.Handled = true;
                else if (e.KeyChar == '.' && this.Text.IndexOf('.') > -1)
                    e.Handled = true;
                else if (!char.IsControl(e.KeyChar))
                {
                    TextBox textBox = this;
                    if (textBox.Text.IndexOf('.') > -1 &&
                             textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 3)
                    {
                        e.Handled = true;
                    }
                    for (int i = 0; i < this.Text.Length; i++)
                    {
                        if (this.Text[i] != '.')
                            suma++;
                    }
                    if (textBox.SelectionStart >= 0 && textBox.SelectionStart < suma - 1)
                    {
                        e.Handled = false;
                    }
                }
            }
        }
        protected override void OnValidated(EventArgs e)
        {
            TextBox textBox = this;
            string ultimoCaracter = "";

            if (this.Text.Trim() != "")
                ultimoCaracter = textBox.Text.Substring(0, 1);

            if (ultimoCaracter.Equals(","))
            {
                this.Text = textBox.Text.Substring(1, this.Text.Length - 1);
                this.Text = String.Format("{0:N2}", Convert.ToDouble(this.Text)).Trim('$');
            }
            else if (this.Text.Trim() != "")
                this.Text = String.Format("{0:N2}", Convert.ToDouble(this.Text)).Trim('$');
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if (base.Text.Trim() == "")
                base.Text = "0.00";
        }
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if (base.Text.Trim() == "0.00")
                base.Text = "";
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            double confirma;
            if (this.ReadOnly == true && Double.TryParse(this.Text.Trim(), out confirma) || this.Enabled == false && Double.TryParse(this.Text.Trim(), out confirma))
            {
                this.Text = String.Format("{0:N2}", Convert.ToDouble(this.Text.Trim()));
            }
            else if (_Focus == false && this.Enabled == true && Double.TryParse(this.Text.Trim(), out confirma))
                this.Text = String.Format("{0:N2}", Convert.ToDouble(this.Text.Trim()));
        }
    }
}
