namespace Point_sys.Herencias
{
    partial class frm_mantcs
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Btnsalvar = new System.Windows.Forms.Button();
            this.Btnmodificar = new System.Windows.Forms.Button();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.lblestado = new System.Windows.Forms.Label();
            this.panelEx1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnretornar
            // 
            this.btnretornar.FlatAppearance.BorderSize = 2;
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
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.Image = global::Point_sys.Properties.Resources._keyboard_return_90647;
            this.simpleButton1.Location = new System.Drawing.Point(-4, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(160, 60);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Retornar";
            // 
            // Btnsalvar
            // 
            this.Btnsalvar.BackColor = System.Drawing.Color.Transparent;
            this.Btnsalvar.FlatAppearance.BorderSize = 2;
            this.Btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnsalvar.Image = global::Point_sys.Properties.Resources.Save_37110;
            this.Btnsalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnsalvar.Location = new System.Drawing.Point(3, 4);
            this.Btnsalvar.Name = "Btnsalvar";
            this.Btnsalvar.Size = new System.Drawing.Size(144, 65);
            this.Btnsalvar.TabIndex = 2;
            this.Btnsalvar.Text = "Salvar";
            this.Btnsalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btnsalvar.UseVisualStyleBackColor = false;
            this.Btnsalvar.Click += new System.EventHandler(this.Btnsalvar_Click_1);
            // 
            // Btnmodificar
            // 
            this.Btnmodificar.BackColor = System.Drawing.Color.Transparent;
            this.Btnmodificar.FlatAppearance.BorderSize = 2;
            this.Btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnmodificar.Image = global::Point_sys.Properties.Resources.businessapplication_edit_male_user_thepencil_theclient_negocio_2321;
            this.Btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnmodificar.Location = new System.Drawing.Point(314, 3);
            this.Btnmodificar.Name = "Btnmodificar";
            this.Btnmodificar.Size = new System.Drawing.Size(144, 66);
            this.Btnmodificar.TabIndex = 1;
            this.Btnmodificar.Text = "Modificar";
            this.Btnmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btnmodificar.UseVisualStyleBackColor = false;
            this.Btnmodificar.Click += new System.EventHandler(this.Btnmodificar_Click_1);
            // 
            // BtnCrear
            // 
            this.BtnCrear.BackColor = System.Drawing.Color.Transparent;
            this.BtnCrear.FlatAppearance.BorderSize = 2;
            this.BtnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrear.Image = global::Point_sys.Properties.Resources.crearcliente32;
            this.BtnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCrear.Location = new System.Drawing.Point(158, 3);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(144, 66);
            this.BtnCrear.TabIndex = 0;
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCrear.UseVisualStyleBackColor = false;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click_1);
            // 
            // panelEx2
            // 
            this.panelEx2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelEx2.Controls.Add(this.lblestado);
            this.panelEx2.Controls.Add(this.Btnsalvar);
            this.panelEx2.Controls.Add(this.Btnmodificar);
            this.panelEx2.Controls.Add(this.BtnCrear);
            this.panelEx2.Location = new System.Drawing.Point(2, 37);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(896, 72);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.Color = System.Drawing.Color.LightGray;
            this.panelEx2.Style.BackColor2.Color = System.Drawing.Color.White;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.StyleMouseDown.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelEx2.StyleMouseOver.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelEx2.TabIndex = 43;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.ForeColor = System.Drawing.Color.Salmon;
            this.lblestado.Location = new System.Drawing.Point(562, 25);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(108, 41);
            this.lblestado.TabIndex = 44;
            this.lblestado.Text = "label1";
            // 
            // frm_mantcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 418);
            this.Controls.Add(this.panelEx2);
            this.Name = "frm_mantcs";
            this.Text = "frm_mantcs";
            this.Load += new System.EventHandler(this.frm_mantcs_Load);
            this.Controls.SetChildIndex(this.panelEx1, 0);
            this.Controls.SetChildIndex(this.panelEx2, 0);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        public System.Windows.Forms.Button Btnmodificar;
        public System.Windows.Forms.Button BtnCrear;
        public System.Windows.Forms.Button Btnsalvar;
        public System.Windows.Forms.Label lblestado;
    }
}