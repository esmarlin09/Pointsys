namespace Point_sys.Inventario.Consulta
{
    partial class Produc_consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produc_consulta));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtMayuscula2 = new Point_sys.Logistica.Controles_mod.TxtMayuscula();
            this.txtEntero1 = new Point_sys.Logistica.Controles_mod.TxtEntero();
            this.txttotalrows = new Point_sys.Logistica.Controles_mod.TxtEntero();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dgvcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvreferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvrnc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtMayuscula1 = new Point_sys.Logistica.Controles_mod.TxtMayuscula();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnretornar
            // 
            this.btnretornar.FlatAppearance.BorderSize = 2;
            this.btnretornar.Location = new System.Drawing.Point(694, 1);
            // 
            // panelEx1
            // 
            this.panelEx1.Size = new System.Drawing.Size(1318, 38);
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
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(14, 44);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(145, 46);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Seleccionar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtMayuscula2
            // 
            this.txtMayuscula2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMayuscula2.enabled_personalizado = false;
            this.txtMayuscula2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMayuscula2.Location = new System.Drawing.Point(137, 96);
            this.txtMayuscula2.Name = "txtMayuscula2";
            this.txtMayuscula2.Size = new System.Drawing.Size(418, 32);
            this.txtMayuscula2.TabIndex = 3;
            this.txtMayuscula2.Touch = false;
            // 
            // txtEntero1
            // 
            this.txtEntero1.enabled_personalizado = false;
            this.txtEntero1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntero1.Location = new System.Drawing.Point(8, 96);
            this.txtEntero1.Name = "txtEntero1";
            this.txtEntero1.Size = new System.Drawing.Size(129, 32);
            this.txtEntero1.TabIndex = 4;
            this.txtEntero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEntero1.Touch = false;
            // 
            // txttotalrows
            // 
            this.txttotalrows.enabled_personalizado = false;
            this.txttotalrows.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalrows.Location = new System.Drawing.Point(157, 403);
            this.txttotalrows.Name = "txttotalrows";
            this.txttotalrows.Size = new System.Drawing.Size(129, 32);
            this.txttotalrows.TabIndex = 5;
            this.txttotalrows.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttotalrows.Touch = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Productos";
            // 
            // gridControl1
            // 
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(8, 134);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(796, 257);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.dgvcodigo,
            this.dgvnombre,
            this.dgvreferencia,
            this.dgvrnc});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.InvertSelection = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // dgvcodigo
            // 
            this.dgvcodigo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvcodigo.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.dgvcodigo.AppearanceCell.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.dgvcodigo.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvcodigo.AppearanceCell.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvcodigo.AppearanceCell.Options.UseBackColor = true;
            this.dgvcodigo.AppearanceCell.Options.UseBorderColor = true;
            this.dgvcodigo.AppearanceCell.Options.UseFont = true;
            this.dgvcodigo.AppearanceCell.Options.UseForeColor = true;
            this.dgvcodigo.AppearanceHeader.BackColor = System.Drawing.Color.LightGray;
            this.dgvcodigo.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvcodigo.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvcodigo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvcodigo.AppearanceHeader.Options.UseBackColor = true;
            this.dgvcodigo.AppearanceHeader.Options.UseBorderColor = true;
            this.dgvcodigo.AppearanceHeader.Options.UseFont = true;
            this.dgvcodigo.Caption = "Código";
            this.dgvcodigo.FieldName = "prod_cod";
            this.dgvcodigo.Name = "dgvcodigo";
            this.dgvcodigo.OptionsColumn.ReadOnly = true;
            this.dgvcodigo.Visible = true;
            this.dgvcodigo.VisibleIndex = 0;
            this.dgvcodigo.Width = 86;
            // 
            // dgvnombre
            // 
            this.dgvnombre.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvnombre.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.dgvnombre.AppearanceCell.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.dgvnombre.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvnombre.AppearanceCell.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvnombre.AppearanceCell.Options.UseBackColor = true;
            this.dgvnombre.AppearanceCell.Options.UseBorderColor = true;
            this.dgvnombre.AppearanceCell.Options.UseFont = true;
            this.dgvnombre.AppearanceCell.Options.UseForeColor = true;
            this.dgvnombre.AppearanceHeader.BackColor = System.Drawing.Color.LightGray;
            this.dgvnombre.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvnombre.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvnombre.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvnombre.AppearanceHeader.Options.UseBackColor = true;
            this.dgvnombre.AppearanceHeader.Options.UseBorderColor = true;
            this.dgvnombre.AppearanceHeader.Options.UseFont = true;
            this.dgvnombre.Caption = "Descripción";
            this.dgvnombre.FieldName = "prod_nombre";
            this.dgvnombre.Name = "dgvnombre";
            this.dgvnombre.OptionsColumn.ReadOnly = true;
            this.dgvnombre.Visible = true;
            this.dgvnombre.VisibleIndex = 1;
            this.dgvnombre.Width = 444;
            // 
            // dgvreferencia
            // 
            this.dgvreferencia.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvreferencia.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.dgvreferencia.AppearanceCell.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.dgvreferencia.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvreferencia.AppearanceCell.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvreferencia.AppearanceCell.Options.UseBackColor = true;
            this.dgvreferencia.AppearanceCell.Options.UseBorderColor = true;
            this.dgvreferencia.AppearanceCell.Options.UseFont = true;
            this.dgvreferencia.AppearanceCell.Options.UseForeColor = true;
            this.dgvreferencia.AppearanceHeader.BackColor = System.Drawing.Color.LightGray;
            this.dgvreferencia.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvreferencia.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvreferencia.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvreferencia.AppearanceHeader.Options.UseBackColor = true;
            this.dgvreferencia.AppearanceHeader.Options.UseBorderColor = true;
            this.dgvreferencia.AppearanceHeader.Options.UseFont = true;
            this.dgvreferencia.Caption = "Referencia";
            this.dgvreferencia.FieldName = "referencia";
            this.dgvreferencia.Name = "dgvreferencia";
            this.dgvreferencia.Visible = true;
            this.dgvreferencia.VisibleIndex = 2;
            this.dgvreferencia.Width = 149;
            // 
            // dgvrnc
            // 
            this.dgvrnc.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvrnc.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.dgvrnc.AppearanceCell.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.dgvrnc.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvrnc.AppearanceCell.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvrnc.AppearanceCell.Options.UseBackColor = true;
            this.dgvrnc.AppearanceCell.Options.UseBorderColor = true;
            this.dgvrnc.AppearanceCell.Options.UseFont = true;
            this.dgvrnc.AppearanceCell.Options.UseForeColor = true;
            this.dgvrnc.AppearanceHeader.BackColor = System.Drawing.Color.LightGray;
            this.dgvrnc.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvrnc.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvrnc.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvrnc.AppearanceHeader.Options.UseBackColor = true;
            this.dgvrnc.AppearanceHeader.Options.UseBorderColor = true;
            this.dgvrnc.AppearanceHeader.Options.UseFont = true;
            this.dgvrnc.Caption = "Precio";
            this.dgvrnc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.dgvrnc.FieldName = "prod_precio";
            this.dgvrnc.Name = "dgvrnc";
            this.dgvrnc.OptionsColumn.ReadOnly = true;
            this.dgvrnc.Visible = true;
            this.dgvrnc.VisibleIndex = 3;
            this.dgvrnc.Width = 97;
            // 
            // txtMayuscula1
            // 
            this.txtMayuscula1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMayuscula1.enabled_personalizado = false;
            this.txtMayuscula1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMayuscula1.Location = new System.Drawing.Point(555, 96);
            this.txtMayuscula1.Name = "txtMayuscula1";
            this.txtMayuscula1.Size = new System.Drawing.Size(249, 32);
            this.txtMayuscula1.TabIndex = 11;
            this.txtMayuscula1.Touch = false;
            // 
            // Produc_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 452);
            this.Controls.Add(this.txtMayuscula1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttotalrows);
            this.Controls.Add(this.txtEntero1);
            this.Controls.Add(this.txtMayuscula2);
            this.Controls.Add(this.simpleButton1);
            this.Name = "Produc_consulta";
            this.Text = "cliente_consulta";
            this.Load += new System.EventHandler(this.cliente_consulta_Load);
            this.Controls.SetChildIndex(this.simpleButton1, 0);
            this.Controls.SetChildIndex(this.txtMayuscula2, 0);
            this.Controls.SetChildIndex(this.txtEntero1, 0);
            this.Controls.SetChildIndex(this.txttotalrows, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.txtMayuscula1, 0);
            this.Controls.SetChildIndex(this.panelEx1, 0);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private Logistica.Controles_mod.TxtMayuscula txtMayuscula2;
        private Logistica.Controles_mod.TxtEntero txtEntero1;
        private Logistica.Controles_mod.TxtEntero txttotalrows;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn dgvcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn dgvnombre;
        private DevExpress.XtraGrid.Columns.GridColumn dgvrnc;
        private DevExpress.XtraGrid.Columns.GridColumn dgvreferencia;
        private Logistica.Controles_mod.TxtMayuscula txtMayuscula1;
    }
}