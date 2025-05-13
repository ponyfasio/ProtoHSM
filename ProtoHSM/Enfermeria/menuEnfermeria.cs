using ProtoHSM.Enfermeria;

namespace ProtoHSM
{
    public partial class menuEnfermeria : Form
    {
        public menuEnfermeria()
        {
            InitializeComponent();
            labelHora.Text = DateTime.Now.ToString("HH:mm");
        }

        private void menuEnfermeria_Load(object sender, EventArgs e)
        {
        }

        private void buttonSolicitud_Click(object sender, EventArgs e)
        {
            entregaInsumos entregaIns = new entregaInsumos();
            this.Hide();
            entregaIns.ShowDialog();
            this.Show();
        }

        private void buttonCamas_Click(object sender, EventArgs e)
        {
            controlCamas controlCamas = new controlCamas();
            this.Hide();
            controlCamas.ShowDialog();
            this.Show();
        }

        private void buttonServicios_Click(object sender, EventArgs e)
        {
            solicitudServicios solicitudServicios = new solicitudServicios();
            this.Hide();
            solicitudServicios.ShowDialog();
            this.Show();
        }

        private void buttonDieta_Click(object sender, EventArgs e)
        {
            SolicitudDieta solDieta = new SolicitudDieta();
            this.Hide();
            solDieta.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}
