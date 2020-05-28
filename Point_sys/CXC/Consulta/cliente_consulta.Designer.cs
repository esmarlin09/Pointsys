namespace Point_sys.CXC.Consulta
{
    partial class cliente_consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cliente_consulta));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtMayuscula2 = new Point_sys.Logistica.Controles_mod.TxtMayuscula();
            this.txtEntero1 = new Point_sys.Logistica.Controles_mod.TxtEntero();
            this.txttotalrows = new Point_sys.Logistica.Controles_mod.TxtEntero();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dgvcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvrnc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvtelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvrazonsocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnretornar
            // 
            this.btnretornar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnretornar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnretornar.ImageOptions.Image")));
            this.btnretornar.Location = new System.Drawing.Point(689, 3);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(2, 38);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(140, 37);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Seleccionar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtMayuscula2
            // 
            this.txtMayuscula2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMayuscula2.enabled_personalizado = false;
            this.txtMayuscula2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMayuscula2.Location = new System.Drawing.Point(145, 109);
            this.txtMayuscula2.Name = "txtMayuscula2";
            this.txtMayuscula2.Size = new System.Drawing.Size(487, 32);
            this.txtMayuscula2.TabIndex = 3;
            this.txtMayuscula2.Touch = false;
            this.txtMayuscula2.Visible = false;
            // 
            // txtEntero1
            // 
            this.txtEntero1.enabled_personalizado = false;
            this.txtEntero1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntero1.Location = new System.Drawing.Point(14, 109);
            this.txtEntero1.Name = "txtEntero1";
            this.txtEntero1.Size = new System.Drawing.Size(129, 32);
            this.txtEntero1.TabIndex = 4;
            this.txtEntero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEntero1.Touch = false;
            this.txtEntero1.Visible = false;
            // 
            // txttotalrows
            // 
            this.txttotalrows.enabled_personalizado = false;
            this.txttotalrows.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalrows.Location = new System.Drawing.Point(134, 419);
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
            this.label1.Location = new System.Drawing.Point(3, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Clientes";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 77);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(804, 340);
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
            this.dgvrnc,
            this.dgvtelefono,
            this.dgvrazonsocial});
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
            this.dgvcodigo.Caption = "Código";
            this.dgvcodigo.FieldName = "id";
            this.dgvcodigo.MinWidth = 23;
            this.dgvcodigo.Name = "dgvcodigo";
            this.dgvcodigo.OptionsColumn.ReadOnly = true;
            this.dgvcodigo.Visible = true;
            this.dgvcodigo.VisibleIndex = 0;
            this.dgvcodigo.Width = 89;
            // 
            // dgvnombre
            // 
            this.dgvnombre.Caption = "Nombre";
            this.dgvnombre.FieldName = "nombre";
            this.dgvnombre.MinWidth = 23;
            this.dgvnombre.Name = "dgvnombre";
            this.dgvnombre.OptionsColumn.ReadOnly = true;
            this.dgvnombre.Visible = true;
            this.dgvnombre.VisibleIndex = 1;
            this.dgvnombre.Width = 425;
            // 
            // dgvrnc
            // 
            this.dgvrnc.Caption = "Rnc/Cédula";
            this.dgvrnc.FieldName = "cedrnc";
            this.dgvrnc.MinWidth = 23;
            this.dgvrnc.Name = "dgvrnc";
            this.dgvrnc.OptionsColumn.ReadOnly = true;
            this.dgvrnc.Visible = true;
            this.dgvrnc.VisibleIndex = 2;
            this.dgvrnc.Width = 111;
            // 
            // dgvtelefono
            // 
            this.dgvtelefono.Caption = "Teléfono";
            this.dgvtelefono.FieldName = "telefono";
            this.dgvtelefono.MinWidth = 23;
            this.dgvtelefono.Name = "dgvtelefono";
            this.dgvtelefono.OptionsColumn.ReadOnly = true;
            this.dgvtelefono.Visible = true;
            this.dgvtelefono.VisibleIndex = 3;
            this.dgvtelefono.Width = 110;
            // 
            // dgvrazonsocial
            // 
            this.dgvrazonsocial.Caption = "Razón Social";
            this.dgvrazonsocial.FieldName = "razon_social";
            this.dgvrazonsocial.MinWidth = 23;
            this.dgvrazonsocial.Name = "dgvrazonsocial";
            this.dgvrazonsocial.OptionsColumn.ReadOnly = true;
            this.dgvrazonsocial.Visible = true;
            this.dgvrazonsocial.VisibleIndex = 4;
            this.dgvrazonsocial.Width = 422;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Código";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre";
            this.label3.Visible = false;
            // 
            // cliente_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 453);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttotalrows);
            this.Controls.Add(this.txtEntero1);
            this.Controls.Add(this.txtMayuscula2);
            this.Controls.Add(this.simpleButton1);
            this.Name = "cliente_consulta";
            this.Text = "cliente_consulta";
            this.Load += new System.EventHandler(this.cliente_consulta_Load);
            this.Controls.SetChildIndex(this.simpleButton1, 0);
            this.Controls.SetChildIndex(this.txtMayuscula2, 0);
            this.Controls.SetChildIndex(this.txtEntero1, 0);
            this.Controls.SetChildIndex(this.txttotalrows, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
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
        private DevExpress.XtraGrid.Columns.GridColumn dgvtelefono;
        private DevExpress.XtraGrid.Columns.GridColumn dgvrazonsocial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}