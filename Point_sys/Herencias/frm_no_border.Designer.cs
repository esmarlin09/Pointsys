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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnretornar = new DevExpress.XtraEditors.SimpleButton();
            this.LBLTITULO = new System.Windows.Forms.Label();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnretornar);
            this.panelEx1.Controls.Add(this.LBLTITULO);
            this.panelEx1.Location = new System.Drawing.Point(-1, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1386, 38);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.panelEx1.Style.ForeColor.Color = System.Drawing.Color.White;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.StyleMouseDown.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelEx1.StyleMouseOver.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelEx1.TabIndex = 42;
            this.panelEx1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelEx1_MouseDown);
            // 
            // btnretornar
            // 
            this.btnretornar.Appearance.BorderColor = System.Drawing.Color.Black;
            this.btnretornar.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnretornar.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnretornar.Appearance.Options.UseBorderColor = true;
            this.btnretornar.Appearance.Options.UseFont = true;
            this.btnretornar.Appearance.Options.UseForeColor = true;
            this.btnretornar.AppearanceDisabled.BorderColor = System.Drawing.Color.Black;
            this.btnretornar.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnretornar.AppearanceHovered.BorderColor = System.Drawing.Color.Black;
            this.btnretornar.AppearanceHovered.Options.UseBorderColor = true;
            this.btnretornar.AppearancePressed.BorderColor = System.Drawing.Color.White;
            this.btnretornar.AppearancePressed.Options.UseBorderColor = true;
            this.btnretornar.ImageOptions.Image = global::Point_sys.Properties.Resources.doubleprev_32x32;
            this.btnretornar.Location = new System.Drawing.Point(482, 5);
            this.btnretornar.Name = "btnretornar";
            this.btnretornar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnretornar.Size = new System.Drawing.Size(119, 32);
            this.btnretornar.TabIndex = 45;
            this.btnretornar.Text = "Retornar";
            this.btnretornar.Click += new System.EventHandler(this.btnretornar_Click);
            // 
            // LBLTITULO
            // 
            this.LBLTITULO.AutoSize = true;
            this.LBLTITULO.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTITULO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBLTITULO.Location = new System.Drawing.Point(3, 5);
            this.LBLTITULO.Name = "LBLTITULO";
            this.LBLTITULO.Size = new System.Drawing.Size(68, 23);
            this.LBLTITULO.TabIndex = 1;
            this.LBLTITULO.Text = "label1";
            // 
            // frm_no_border
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(828, 533);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_no_border";
            this.Text = "frm_no_border";
            this.Load += new System.EventHandler(this.frm_no_border_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frm_no_border_Paint);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LBLTITULO;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        public DevExpress.XtraEditors.SimpleButton btnretornar;
    }
}