namespace ProtoHSM.Enfermeria
{
    public partial class SolicitudDieta : Form
    {
        public SolicitudDieta()
        {
            InitializeComponent();
        }

        private void comboPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            textUbicacion.Text = "MASTER-1";
        }

        private void buttonSolicitar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dieta agregada correctamente");
            this.Close();

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
