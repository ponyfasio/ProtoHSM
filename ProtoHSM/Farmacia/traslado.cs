namespace ProtoHSM.Farmacia
{
    public partial class traslado : Form
    {
        public traslado()
        {
            InitializeComponent();
        }

        private void buttonSolicitar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Intentario trasladado correctamente");
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
