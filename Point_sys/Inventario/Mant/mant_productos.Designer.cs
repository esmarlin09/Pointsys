namespace Point_sys.Inventario.Mant
{
    partial class mant_productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mant_productos));
            this.txtreferencia = new Point_sys.Logistica.Controles_mod.TxtMayuscula();
            this.label12 = new System.Windows.Forms.Label();
            this.txtdescripcion = new Point_sys.Logistica.Controles_mod.TxtMayuscula();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuscar = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcod_pro = new Point_sys.Logistica.Controles_mod.TxtEntero();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcodigobarra = new Point_sys.Logistica.Controles_mod.TxtMayuscula();
            this.boolrentable = new DevExpress.XtraEditors.ToggleSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcosto = new Point_sys.Logistica.Controles_mod.TxtDecimal();
            this.txtcostoitbis = new Point_sys.Logistica.Controles_mod.TxtDecimal();
            this.txtprecioitbis = new Point_sys.Logistica.Controles_mod.TxtDecimal();
            this.txtprecio = new Point_sys.Logistica.Controles_mod.TxtDecimal();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtminimo = new Point_sys.Logistica.Controles_mod.TxtEntero();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbtipoitbis = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boolrentable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            // 
            // Btnmodificar
            // 
            this.Btnmodificar.FlatAppearance.BorderSize = 2;
            this.Btnmodificar.Click += new System.EventHandler(this.Btnmodificar_Click);
            // 
            // BtnCrear
            // 
            this.BtnCrear.FlatAppearance.BorderSize = 2;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // Btnsalvar
            // 
            this.Btnsalvar.FlatAppearance.BorderSize = 2;
            this.Btnsalvar.TabIndex = 0;
            this.Btnsalvar.Click += new System.EventHandler(this.Btnsalvar_Click_1);
            // 
            // btnretornar
            // 
            this.btnretornar.FlatAppearance.BorderSize = 2;
            this.btnretornar.Location = new System.Drawing.Point(724, 1);
            // 
            // panelEx1
            // 
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.LightGray;
            this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.White;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.StyleMouseDown.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelEx1.StyleMouseOver.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // txtreferencia
            // 
            this.txtreferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtreferencia.enabled_personalizado = false;
            this.txtreferencia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreferencia.Location = new System.Drawing.Point(136, 198);
            this.txtreferencia.Name = "txtreferencia";
            this.txtreferencia.Size = new System.Drawing.Size(173, 32);
            this.txtreferencia.TabIndex = 2;
            this.txtreferencia.Touch = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 21);
            this.label12.TabIndex = 57;
            this.label12.Text = "Referencia";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescripcion.enabled_personalizado = false;
            this.txtdescripcion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.Location = new System.Drawing.Point(136, 164);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(664, 32);
            this.txtdescripcion.TabIndex = 1;
            this.txtdescripcion.Touch = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 50;
            this.label1.Text = "Descripción";
            // 
            // btnbuscar
            // 
            this.btnbuscar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnbuscar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.ImageOptions.Image")));
            this.btnbuscar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnbuscar.Location = new System.Drawing.Point(257, 129);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(53, 29);
            this.btnbuscar.TabIndex = 55;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 51;
            this.label4.Text = "Código";
            // 
            // txtcod_pro
            // 
            this.txtcod_pro.enabled_personalizado = false;
            this.txtcod_pro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod_pro.Location = new System.Drawing.Point(136, 129);
            this.txtcod_pro.Name = "txtcod_pro";
            this.txtcod_pro.Size = new System.Drawing.Size(114, 32);
            this.txtcod_pro.TabIndex = 0;
            this.txtcod_pro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcod_pro.Touch = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(378, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 54;
            this.label6.Text = "BarCode";
            // 
            // txtcodigobarra
            // 
            this.txtcodigobarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodigobarra.enabled_personalizado = false;
            this.txtcodigobarra.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigobarra.Location = new System.Drawing.Point(468, 129);
            this.txtcodigobarra.Name = "txtcodigobarra";
            this.txtcodigobarra.Size = new System.Drawing.Size(332, 32);
            this.txtcodigobarra.TabIndex = 9;
            this.txtcodigobarra.Touch = false;
            // 
            // boolrentable
            // 
            this.boolrentable.Location = new System.Drawing.Point(134, 462);
            this.boolrentable.Name = "boolrentable";
            this.boolrentable.Properties.Appearance.BackColor = System.Drawing.Color.Snow;
            this.boolrentable.Properties.Appearance.Options.UseBackColor = true;
            this.boolrentable.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.boolrentable.Properties.OffText = "Off";
            this.boolrentable.Properties.OnText = "On";
            this.boolrentable.Size = new System.Drawing.Size(174, 30);
            this.boolrentable.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 59;
            this.label2.Text = "Costo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 60;
            this.label3.Text = "Costo + Itbis";
            // 
            // txtcosto
            // 
            this.txtcosto.enabled_personalizado = false;
            this.txtcosto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcosto.Location = new System.Drawing.Point(136, 268);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(173, 32);
            this.txtcosto.TabIndex = 4;
            this.txtcosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcosto.Touch = false;
            this.txtcosto.Validating += new System.ComponentModel.CancelEventHandler(this.txtcosto_Validating);
            // 
            // txtcostoitbis
            // 
            this.txtcostoitbis.Enabled = false;
            this.txtcostoitbis.enabled_personalizado = true;
            this.txtcostoitbis.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcostoitbis.Location = new System.Drawing.Point(136, 306);
            this.txtcostoitbis.Name = "txtcostoitbis";
            this.txtcostoitbis.Size = new System.Drawing.Size(173, 32);
            this.txtcostoitbis.TabIndex = 5;
            this.txtcostoitbis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcostoitbis.Touch = false;
            // 
            // txtprecioitbis
            // 
            this.txtprecioitbis.Enabled = false;
            this.txtprecioitbis.enabled_personalizado = true;
            this.txtprecioitbis.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecioitbis.Location = new System.Drawing.Point(136, 383);
            this.txtprecioitbis.Name = "txtprecioitbis";
            this.txtprecioitbis.Size = new System.Drawing.Size(173, 32);
            this.txtprecioitbis.TabIndex = 7;
            this.txtprecioitbis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtprecioitbis.Touch = false;
            // 
            // txtprecio
            // 
            this.txtprecio.enabled_personalizado = false;
            this.txtprecio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(136, 345);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(173, 32);
            this.txtprecio.TabIndex = 6;
            this.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtprecio.Touch = false;
            this.txtprecio.Validating += new System.ComponentModel.CancelEventHandler(this.txtprecio_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 64;
            this.label5.Text = "Precio + Itbis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 63;
            this.label7.Text = "Precio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 21);
            this.label9.TabIndex = 67;
            this.label9.Text = "Stock minimo";
            // 
            // txtminimo
            // 
            this.txtminimo.enabled_personalizado = false;
            this.txtminimo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtminimo.Location = new System.Drawing.Point(136, 421);
            this.txtminimo.Name = "txtminimo";
            this.txtminimo.Size = new System.Drawing.Size(173, 32);
            this.txtminimo.TabIndex = 8;
            this.txtminimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtminimo.Touch = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 465);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 21);
            this.label8.TabIndex = 70;
            this.label8.Text = "Rentable";
            // 
            // cmbtipoitbis
            // 
            this.cmbtipoitbis.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtipoitbis.FormattingEnabled = true;
            this.cmbtipoitbis.Location = new System.Drawing.Point(136, 235);
            this.cmbtipoitbis.Name = "cmbtipoitbis";
            this.cmbtipoitbis.Size = new System.Drawing.Size(173, 29);
            this.cmbtipoitbis.TabIndex = 3;
            this.cmbtipoitbis.SelectedIndexChanged += new System.EventHandler(this.cmbtipoitbis_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 21);
            this.label10.TabIndex = 72;
            this.label10.Text = "Tipo Itbis";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.Location = new System.Drawing.Point(587, 197);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(213, 133);
            this.pictureEdit1.TabIndex = 73;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(605, 333);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(173, 44);
            this.simpleButton2.TabIndex = 74;
            this.simpleButton2.Text = "Add Imagen";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // mant_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 509);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbtipoitbis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtminimo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtprecioitbis);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcostoitbis);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boolrentable);
            this.Controls.Add(this.txtreferencia);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcod_pro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcodigobarra);
            this.Name = "mant_productos";
            this.Text = "mant_productos";
            this.Load += new System.EventHandler(this.mant_productos_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.mant_productos_Paint);
            this.Controls.SetChildIndex(this.panelEx1, 0);
            this.Controls.SetChildIndex(this.txtcodigobarra, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtcod_pro, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnbuscar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtdescripcion, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.txtreferencia, 0);
            this.Controls.SetChildIndex(this.boolrentable, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtcosto, 0);
            this.Controls.SetChildIndex(this.txtcostoitbis, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtprecio, 0);
            this.Controls.SetChildIndex(this.txtprecioitbis, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtminimo, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.cmbtipoitbis, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.pictureEdit1, 0);
            this.Controls.SetChildIndex(this.simpleButton2, 0);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boolrentable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Logistica.Controles_mod.TxtMayuscula txtreferencia;
        private System.Windows.Forms.Label label12;
        private Logistica.Controles_mod.TxtMayuscula txtdescripcion;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnbuscar;
        private System.Windows.Forms.Label label4;
        private Logistica.Controles_mod.TxtEntero txtcod_pro;
        private System.Windows.Forms.Label label6;
        private Logistica.Controles_mod.TxtMayuscula txtcodigobarra;
        private DevExpress.XtraEditors.ToggleSwitch boolrentable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Logistica.Controles_mod.TxtDecimal txtcosto;
        private Logistica.Controles_mod.TxtDecimal txtcostoitbis;
        private Logistica.Controles_mod.TxtDecimal txtprecioitbis;
        private Logistica.Controles_mod.TxtDecimal txtprecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private Logistica.Controles_mod.TxtEntero txtminimo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbtipoitbis;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}