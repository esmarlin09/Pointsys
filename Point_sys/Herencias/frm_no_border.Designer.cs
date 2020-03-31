namespace Point_sys.Herencias
{
    partial class frm_no_border
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_no_border));
            this.flowLayoutPanel1 = new System.Windows.Forms.Panel();
            this.LBLTITULO = new System.Windows.Forms.Label();
            this.Btnretornar = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(169)))), ((int)(((byte)(194)))));
            this.flowLayoutPanel1.Controls.Add(this.Btnretornar);
            this.flowLayoutPanel1.Controls.Add(this.LBLTITULO);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1202, 40);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseDown);
            // 
            // LBLTITULO
            // 
            this.LBLTITULO.AutoSize = true;
            this.LBLTITULO.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO.ForeColor = System.Drawing.Color.White;
            this.LBLTITULO.Location = new System.Drawing.Point(3, 0);
            this.LBLTITULO.Name = "LBLTITULO";
            this.LBLTITULO.Size = new System.Drawing.Size(107, 36);
            this.LBLTITULO.TabIndex = 1;
            this.LBLTITULO.Text = "label1";
            // 
            // Btnretornar
            // 
            this.Btnretornar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btnretornar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnretornar.Appearance.Options.UseFont = true;
            this.Btnretornar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.Btnretornar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.Btnretornar.Location = new System.Drawing.Point(612, 2);
            this.Btnretornar.Name = "Btnretornar";
            this.Btnretornar.Size = new System.Drawing.Size(110, 35);
            this.Btnretornar.TabIndex = 2;
            this.Btnretornar.Text = "Retornar";
            this.Btnretornar.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frm_no_border
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 533);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frm_no_border";
            this.Text = "frm_no_border";
            this.Load += new System.EventHandler(this.frm_no_border_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel flowLayoutPanel1;
        private System.Windows.Forms.Label LBLTITULO;
        public DevExpress.XtraEditors.SimpleButton Btnretornar;
    }
}