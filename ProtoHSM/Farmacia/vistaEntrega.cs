namespace ProtoHSM.Farmacia
{
    public partial class vistaEntrega : Form
    {

        private Controller controller;
    
        public vistaEntrega(Controller _controller, int detalleID)
        {
            InitializeComponent();
            this.controller = controller;
          
            CargarInfoSolicitud();
        }

        private void CargarInfoSolicitud()
        {
            
        }
        private void buttonEntregar_Click(object sender, EventArgs e)
        {

        }
    }
}
