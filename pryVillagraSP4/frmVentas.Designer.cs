namespace pryVillagraSP4
{
    partial class frmVentas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvVentas = new DataGridView();
            colMozos = new DataGridViewTextBoxColumn();
            colComidas = new DataGridViewTextBoxColumn();
            colBebidasSinAlcohol = new DataGridViewTextBoxColumn();
            colBebidasConAlcohol = new DataGridViewTextBoxColumn();
            colPostres = new DataGridViewTextBoxColumn();
            lblGestiondeVentas = new Label();
            btnValidar = new Button();
            btnMozoDia = new Button();
            btnTotales = new Button();
            btnCerrar = new Button();
            txtTotalGeneral = new TextBox();
            txtMozoDia = new TextBox();
            txtImporteMozo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { colMozos, colComidas, colBebidasSinAlcohol, colBebidasConAlcohol, colPostres });
            dgvVentas.Location = new Point(12, 52);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.Size = new Size(545, 207);
            dgvVentas.TabIndex = 0;
            // 
            // colMozos
            // 
            colMozos.HeaderText = "Mozos";
            colMozos.Name = "colMozos";
            // 
            // colComidas
            // 
            colComidas.HeaderText = "Comidas";
            colComidas.Name = "colComidas";
            // 
            // colBebidasSinAlcohol
            // 
            colBebidasSinAlcohol.HeaderText = "Bebidas sin Alcohol";
            colBebidasSinAlcohol.Name = "colBebidasSinAlcohol";
            // 
            // colBebidasConAlcohol
            // 
            colBebidasConAlcohol.HeaderText = "Bebidas con Alcohol";
            colBebidasConAlcohol.Name = "colBebidasConAlcohol";
            // 
            // colPostres
            // 
            colPostres.HeaderText = "Postres";
            colPostres.Name = "colPostres";
            // 
            // lblGestiondeVentas
            // 
            lblGestiondeVentas.AutoSize = true;
            lblGestiondeVentas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestiondeVentas.Location = new Point(205, 9);
            lblGestiondeVentas.Name = "lblGestiondeVentas";
            lblGestiondeVentas.Size = new Size(141, 21);
            lblGestiondeVentas.TabIndex = 1;
            lblGestiondeVentas.Text = "Gestión de Ventas";
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(38, 294);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(101, 38);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar Datos";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // btnMozoDia
            // 
            btnMozoDia.Location = new Point(38, 353);
            btnMozoDia.Name = "btnMozoDia";
            btnMozoDia.Size = new Size(101, 38);
            btnMozoDia.TabIndex = 3;
            btnMozoDia.Text = "Mozo del Día";
            btnMozoDia.UseVisualStyleBackColor = true;
            btnMozoDia.Click += btnMozoDia_Click;
            // 
            // btnTotales
            // 
            btnTotales.Location = new Point(38, 423);
            btnTotales.Name = "btnTotales";
            btnTotales.Size = new Size(101, 38);
            btnTotales.TabIndex = 4;
            btnTotales.Text = "Totales";
            btnTotales.UseVisualStyleBackColor = true;
            btnTotales.Click += btnTotales_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(465, 442);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(101, 38);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtTotalGeneral
            // 
            txtTotalGeneral.Location = new Point(182, 432);
            txtTotalGeneral.Name = "txtTotalGeneral";
            txtTotalGeneral.Size = new Size(154, 23);
            txtTotalGeneral.TabIndex = 6;
            // 
            // txtMozoDia
            // 
            txtMozoDia.Location = new Point(182, 362);
            txtMozoDia.Name = "txtMozoDia";
            txtMozoDia.Size = new Size(100, 23);
            txtMozoDia.TabIndex = 7;
            // 
            // txtImporteMozo
            // 
            txtImporteMozo.Location = new Point(336, 362);
            txtImporteMozo.Name = "txtImporteMozo";
            txtImporteMozo.Size = new Size(55, 23);
            txtImporteMozo.TabIndex = 8;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 492);
            Controls.Add(txtImporteMozo);
            Controls.Add(txtMozoDia);
            Controls.Add(txtTotalGeneral);
            Controls.Add(btnCerrar);
            Controls.Add(btnTotales);
            Controls.Add(btnMozoDia);
            Controls.Add(btnValidar);
            Controls.Add(lblGestiondeVentas);
            Controls.Add(dgvVentas);
            Name = "frmVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas";
            Load += frmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVentas;
        private Label lblGestiondeVentas;
        private Button btnValidar;
        private Button btnMozoDia;
        private Button btnTotales;
        private Button btnCerrar;
        private TextBox txtTotalGeneral;
        private TextBox txtMozoDia;
        private TextBox txtImporteMozo;
        private DataGridViewTextBoxColumn colMozos;
        private DataGridViewTextBoxColumn colComidas;
        private DataGridViewTextBoxColumn colBebidasSinAlcohol;
        private DataGridViewTextBoxColumn colBebidasConAlcohol;
        private DataGridViewTextBoxColumn colPostres;
    }
}
