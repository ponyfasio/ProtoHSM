using System.Data;

namespace ProtoHSM.Enfermeria
{

    public partial class solicitudServicios : Form
    {
        private DataTable dt;

        public solicitudServicios()
        {
            dt = new DataTable();
            dt.Columns.Add("Tipo de Servicio", typeof(string));
            dt.Columns.Add("Servicio", typeof(string));
            InitializeComponent();
        }

        private void buttonSolicitar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Servicios cargados correctamente");
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelCedula.Text = "125297";
            labelMedico.Text = "EFREN FLORES ALVAREZ";
            textUbicacion.Text = "MASTER-1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt.Rows.Add("Hospital", "Oxigeno");
            updateGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt.Rows.Add("Hospital", "Monitor");
            updateGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dt.Rows.Add("Hospital", "Ventilador");
            updateGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dt.Rows.Add("Hospital", "Oxigeno Alto Flujo");
            updateGrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dt.Rows.Add("Imagen", "TAC");
            updateGrid();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dt.Rows.Add("Imagen", "Rayos X");
            updateGrid();
        }

        private void updateGrid()
        {
            listaInsumos.DataSource = dt;
            listaInsumos.Update();
        }
    }
}
