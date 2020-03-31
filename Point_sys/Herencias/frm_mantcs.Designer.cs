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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.BtnCrear = new DevExpress.XtraTab.XtraTabPage();
            this.Btnmodificar = new DevExpress.XtraTab.XtraTabPage();
            this.Btnsalvar = new DevExpress.XtraEditors.SimpleButton();
            this.Btnretornar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.SuspendLayout();
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
            // xtraTabControl1
            // 
            this.xtraTabControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.xtraTabControl1.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.xtraTabControl1.Location = new System.Drawing.Point(-3, 3);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(732, 61);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.BtnCrear,
            this.Btnmodificar});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Image = global::Point_sys.Properties.Resources.crearcliente32;
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(721, 0);
            this.xtraTabPage1.Text = "Salvar";
            // 
            // BtnCrear
            // 
            this.BtnCrear.Image = global::Point_sys.Properties.Resources.crearcliente32;
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(721, 0);
            this.BtnCrear.Text = "Crear";
            // 
            // Btnmodificar
            // 
            this.Btnmodificar.Image = global::Point_sys.Properties.Resources.businessapplication_edit_male_user_thepencil_theclient_negocio_2321;
            this.Btnmodificar.Name = "Btnmodificar";
            this.Btnmodificar.Size = new System.Drawing.Size(721, 0);
            this.Btnmodificar.Text = "Modificar";
            // 
            // Btnsalvar
            // 
            this.Btnsalvar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.Btnsalvar.ImageOptions.Image = global::Point_sys.Properties.Resources.Save_37110;
            this.Btnsalvar.Location = new System.Drawing.Point(1, 4);
            this.Btnsalvar.Name = "Btnsalvar";
            this.Btnsalvar.Size = new System.Drawing.Size(110, 60);
            this.Btnsalvar.TabIndex = 3;
            this.Btnsalvar.Text = "Salvar";
            // 
            // Btnretornar
            // 
            this.Btnretornar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.Btnretornar.ImageOptions.Image = global::Point_sys.Properties.Resources._keyboard_return_90647;
            this.Btnretornar.Location = new System.Drawing.Point(621, 3);
            this.Btnretornar.Name = "Btnretornar";
            this.Btnretornar.Size = new System.Drawing.Size(110, 60);
            this.Btnretornar.TabIndex = 4;
            this.Btnretornar.Text = "Retornar";
            // 
            // frm_mantcs
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 418);
            this.Controls.Add(this.Btnsalvar);
            this.Controls.Add(this.Btnretornar);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_mantcs";
            this.Text = "frm_mantcs";
            this.Load += new System.EventHandler(this.frm_mantcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        public DevExpress.XtraEditors.SimpleButton Btnretornar;
        public DevExpress.XtraEditors.SimpleButton Btnsalvar;
        public DevExpress.XtraTab.XtraTabPage BtnCrear;
        public DevExpress.XtraTab.XtraTabPage Btnmodificar;
    }
}