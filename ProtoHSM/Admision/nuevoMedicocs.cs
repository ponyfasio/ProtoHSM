using ProtoHSM.Models;

namespace ProtoHSM
{
    public partial class nuevoMedicocs : Form
    {
        private Controller controller;
        public nuevoMedicocs(Controller _controller)
        {
            controller = _controller;
            InitializeComponent();
        }




        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var medico = new Medico
                {
                    Nombre = textNombre.Text,
                    Especialidad = textEspecialidades.Text,
                    CedulaProfesional = textCedula.Text,
                    Telefono = textTel.Text
                };

                if (string.IsNullOrWhiteSpace(medico.Nombre) || string.IsNullOrWhiteSpace(medico.CedulaProfesional))
                {
                    MessageBox.Show("El nombre y la cédula profesional son obligatorios.");
                    return;
                }

                controller.RegistrarMedico(medico);
                MessageBox.Show("Médico registrado correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar médico: " + ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
