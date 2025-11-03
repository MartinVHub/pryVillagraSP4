namespace pryVillagraSP4
{
    public partial class frmVentas : Form
    {
        float[,] ventas = new float[5, 4];
        string[] mozos = { "Julio", "Esteban", "Javier", "Gonzalo", "Alberto" };
        


        public frmVentas()
        {
            InitializeComponent();
            this.Load += frmVentas_Load; 
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            
            dgvVentas.Rows.Clear();         
            //dgvVentas.Rows.Add(mozos.Length);         
            for (int i = 0; i < mozos.Length; i++)
            //    dgvVentas.Rows[i].HeaderCell.Value = mozos[i];
                dgvVentas.Rows.Add(mozos[i]);

            dgvVentas.RowHeadersWidth = 100;
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;

            
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Desactivar los botones hasta validar
            btnMozoDia.Enabled = true;
            btnTotales.Enabled = false;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {

            try
            {
                for (int i = 1; i < 5; i++)
                {
                    for (int j = 1; j < 4; j++)
                    {
                        string valor = dgvVentas.Rows[i].Cells[j].Value.ToString();
                        if (float.TryParse(valor, out float importe))
                            ventas[i, j] = importe;
                        else
                            throw new Exception($"Dato no válido en la fila {i + 1}, columna {j + 1}");
                    }
                }

                MessageBox.Show("Datos validados correctamente", "Validación exitosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnMozoDia.Enabled = true;
                btnTotales.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnMozoDia.Enabled = false;
                btnTotales.Enabled = false;
            }
        }

        private void btnMozoDia_Click(object sender, EventArgs e)
        {
            float maxTotal = 0;
            string mejorMozo = "";
            for (int i = 0; i < 5; i++)
            {
                float totalMozo = 0;
                for (int j = 0; j < 4; j++)
                    totalMozo += ventas[i, j];

                if (totalMozo > maxTotal)
                {
                    maxTotal = totalMozo;
                    mejorMozo = mozos[i];
                }
            }

            txtMozoDia.Text = mejorMozo;
            txtImporteMozo.Text = maxTotal.ToString("0.00");
        }

        private void btnTotales_Click(object sender, EventArgs e)
        {
            float totalGeneral = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                    totalGeneral += ventas[i, j];
            }

            txtTotalGeneral.Text = totalGeneral.ToString("0.00");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


}
