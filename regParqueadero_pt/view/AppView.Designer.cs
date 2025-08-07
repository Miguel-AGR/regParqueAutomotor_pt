namespace regParqueadero_pt
{
    partial class AppView
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.automovilesDGV = new System.Windows.Forms.DataGridView();
            this.AppTabs = new System.Windows.Forms.TabControl();
            this.consultTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.agregarTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.marcaVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.automovilesDGV)).BeginInit();
            this.AppTabs.SuspendLayout();
            this.consultTab.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.agregarTab.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // automovilesDGV
            // 
            this.automovilesDGV.AllowUserToAddRows = false;
            this.automovilesDGV.AllowUserToDeleteRows = false;
            this.automovilesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.automovilesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.automovilesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marcaVehiculo,
            this.modeloVehiculo,
            this.fechaIngreso});
            this.automovilesDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.automovilesDGV.Location = new System.Drawing.Point(3, 152);
            this.automovilesDGV.Name = "automovilesDGV";
            this.automovilesDGV.ReadOnly = true;
            this.automovilesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.automovilesDGV.Size = new System.Drawing.Size(772, 301);
            this.automovilesDGV.TabIndex = 1;
            // 
            // AppTabs
            // 
            this.AppTabs.Controls.Add(this.consultTab);
            this.AppTabs.Controls.Add(this.agregarTab);
            this.AppTabs.Location = new System.Drawing.Point(3, 3);
            this.AppTabs.Name = "AppTabs";
            this.AppTabs.SelectedIndex = 0;
            this.AppTabs.Size = new System.Drawing.Size(768, 143);
            this.AppTabs.TabIndex = 1;
            // 
            // consultTab
            // 
            this.consultTab.Controls.Add(this.tableLayoutPanel2);
            this.consultTab.Location = new System.Drawing.Point(4, 22);
            this.consultTab.Name = "consultTab";
            this.consultTab.Padding = new System.Windows.Forms.Padding(3);
            this.consultTab.Size = new System.Drawing.Size(760, 117);
            this.consultTab.TabIndex = 0;
            this.consultTab.Text = "Consultar";
            this.consultTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.84888F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.15112F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnFiltrar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnActualizar, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(755, 108);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.12712F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.87288F));
            this.tableLayoutPanel3.Controls.Add(this.lblFechaFin, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dtpFechaInicio, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.dtpFechaFin, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblFechaInicio, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 14);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(452, 80);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(3, 53);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(54, 13);
            this.lblFechaFin.TabIndex = 5;
            this.lblFechaFin.Text = "Fecha Fin";
            this.lblFechaFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaInicio.Location = new System.Drawing.Point(126, 10);
            this.dtpFechaInicio.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(290, 20);
            this.dtpFechaInicio.TabIndex = 3;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaFin.Location = new System.Drawing.Point(126, 50);
            this.dtpFechaFin.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(290, 20);
            this.dtpFechaFin.TabIndex = 2;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(3, 13);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(65, 13);
            this.lblFechaInicio.TabIndex = 4;
            this.lblFechaInicio.Text = "Fecha Inicio";
            this.lblFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFiltrar.Location = new System.Drawing.Point(470, 36);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(120, 35);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.Location = new System.Drawing.Point(617, 36);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(120, 35);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // agregarTab
            // 
            this.agregarTab.Controls.Add(this.tableLayoutPanel4);
            this.agregarTab.Location = new System.Drawing.Point(4, 22);
            this.agregarTab.Name = "agregarTab";
            this.agregarTab.Padding = new System.Windows.Forms.Padding(3);
            this.agregarTab.Size = new System.Drawing.Size(760, 117);
            this.agregarTab.TabIndex = 1;
            this.agregarTab.Text = "Agregar";
            this.agregarTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.83524F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.16476F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel4.Controls.Add(this.btnAgregar, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnLimpiar, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(751, 104);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.Location = new System.Drawing.Point(477, 34);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 35);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiar.Location = new System.Drawing.Point(619, 34);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 35);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.45833F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.54166F));
            this.tableLayoutPanel1.Controls.Add(this.lblMarca, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblModelo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFechaIngreso, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtMarca, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtModelo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaIngreso, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 93);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(3, 9);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(86, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca Automovil";
            // 
            // lblModelo
            // 
            this.lblModelo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(3, 40);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(91, 13);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo Automovil";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(3, 71);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(90, 13);
            this.lblFechaIngreso.TabIndex = 2;
            this.lblFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMarca.Location = new System.Drawing.Point(124, 5);
            this.txtMarca.MaxLength = 50;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(310, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // txtModelo
            // 
            this.txtModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModelo.Location = new System.Drawing.Point(124, 36);
            this.txtModelo.MaxLength = 100;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(310, 20);
            this.txtModelo.TabIndex = 4;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(124, 67);
            this.dtpFechaIngreso.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(310, 20);
            this.dtpFechaIngreso.TabIndex = 5;
            this.dtpFechaIngreso.Value = new System.DateTime(2025, 8, 6, 0, 0, 0, 0);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.automovilesDGV, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.AppTabs, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(1, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.72311F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.27689F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(778, 456);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // marcaVehiculo
            // 
            this.marcaVehiculo.Frozen = true;
            this.marcaVehiculo.HeaderText = "Marca Vehiculo";
            this.marcaVehiculo.MinimumWidth = 220;
            this.marcaVehiculo.Name = "marcaVehiculo";
            this.marcaVehiculo.ReadOnly = true;
            this.marcaVehiculo.Width = 220;
            // 
            // modeloVehiculo
            // 
            this.modeloVehiculo.Frozen = true;
            this.modeloVehiculo.HeaderText = "Modelo Vehiculo";
            this.modeloVehiculo.MinimumWidth = 330;
            this.modeloVehiculo.Name = "modeloVehiculo";
            this.modeloVehiculo.ReadOnly = true;
            this.modeloVehiculo.Width = 330;
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.Frozen = true;
            this.fechaIngreso.HeaderText = "Fecha de Ingreso";
            this.fechaIngreso.MinimumWidth = 220;
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.ReadOnly = true;
            this.fechaIngreso.Width = 220;
            // 
            // AppView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Name = "AppView";
            this.Text = "Parque Automotor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.automovilesDGV)).EndInit();
            this.AppTabs.ResumeLayout(false);
            this.consultTab.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.agregarTab.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView automovilesDGV;
        private System.Windows.Forms.TabControl AppTabs;
        private System.Windows.Forms.TabPage consultTab;
        private System.Windows.Forms.TabPage agregarTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngreso;
    }
}
