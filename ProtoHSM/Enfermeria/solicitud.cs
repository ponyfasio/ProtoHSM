using System.Data;

namespace ProtoHSM.Enfermeria
{
    public partial class entregaInsumos : Form
    {
        private DataTable dt;


        public entregaInsumos()
        {
            dt = new DataTable();
            dt.Columns.Add("Cantidad", typeof(int));
            dt.Columns.Add("Insumo", typeof(string));
            InitializeComponent();
        }

        private void buttonSolicitar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Solicitud realizada, surte los insumos en farmacia");
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textCantidad.Text.Trim(), out int cantidad) &&
                !string.IsNullOrWhiteSpace(textInsumo.Text))
            {

                dt.Rows.Add(cantidad, textInsumo.Text);
                listaInsumos.DataSource = dt;
                textInsumo.Clear();
                textCantidad.Text = "1";
                textInsumo.Select();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una cantidad válida y un nombre de insumo.");
            }
        }

        private void comboPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblcedula.Text = "125297";
            lblMedico.Text = "EFREN FLORES ALVAREZ";
            textUbicacion.Text = "MASTER-1";

        }
    }
}

