using System.Data;
using System.Windows.Forms;

namespace ProtoHSM.Farmacia
{
    public partial class menuFarmacia : Form
    {
        Controller controller;

        public menuFarmacia(Controller _controller)
        {
            controller = _controller;
            InitializeComponent();
            gridPendientes.DataSource = controller.CargarSolicitudesPendientes();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && gridPendientes.Columns[e.ColumnIndex].Name == "Entregar")
            {
                int detalleID = Convert.ToInt32(gridPendientes.Rows[e.RowIndex].Cells["ID"].Value);

                // Abrir ventana de entrega y pasarle el ID
                vistaEntrega entregaForm = new vistaEntrega(controller, detalleID);
                entregaForm.ShowDialog();
            }
        }



        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void buttonDevolucion_Click(object sender, EventArgs e)
        {
            devolucion devolucion = new devolucion();
            this.Hide();
            devolucion.ShowDialog();
            this.Show();
        }

        private void buttonTraslado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + controller.UsuarioActual);

            traslado tras = new traslado();
            this.Hide();
            tras.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:MM");
        }

        private void buttonRequisicion_Click(object sender, EventArgs e)
        {

        }

        private void buttonCompra_Click(object sender, EventArgs e)
        {

        }
    }
}
