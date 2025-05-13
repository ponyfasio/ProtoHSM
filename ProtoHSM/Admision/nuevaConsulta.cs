using ProtoHSM.Models;
using static ProtoHSM.Cajas.menuCajas;


namespace ProtoHSM
{
    public partial class nuevaConsulta : Form
    {
        private readonly MedicoSearchComboBox comboMedicos = new();
        private readonly Controller controller;

        public nuevaConsulta(Controller _controller)
        {
            InitializeComponent();
            controller = _controller;
            this.Load += NuevoIngreso_Load;

            // Suscribe el evento que disparará la asignación de CURP
            comboPaciente.SelectionChangeCommitted += comboPaciente_SelectionChangeCommitted;
        }

        private void comboPaciente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var sel = comboPaciente.PacienteSeleccionado;
            if (sel != null && sel.PacienteID != 0)
                textCURP.Text = sel.CURP;
            else
                textCURP.Clear();
        }


        private void NuevoIngreso_Load(object sender, EventArgs e)
        {
            comboMedico.LoadItems();
            comboPaciente.LoadItems();
         
        }
        
        

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // 1) Validar paciente
            var pacienteDto = comboPaciente.PacienteSeleccionado;
            if (pacienteDto == null || pacienteDto.PacienteID == 0)
            {
                MessageBox.Show("Por favor, seleccione un paciente.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboPaciente.Focus();
                return;
            }

            // 2) Validar médico
            var medicoDto = comboMedico.MedicoSeleccionado;
            if (medicoDto == null || medicoDto.MedicoID == 0)
            {
                MessageBox.Show("Por favor, seleccione un médico.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboMedico.Focus();
                return;
            }

            // 3) Otros campos
            string padecimiento = textPadecimiento.Text.Trim();
            int usuarioID = controller.UsuarioActual.UsuarioID;
            DateTime ahora = DateTime.Now;

            try
            {
                // 4) Llamada al SP
                controller.RegistrarVisita(
                    pacienteDto.PacienteID,
                    "Consulta Externa",
                    padecimiento,
                    null,
                    usuarioID,
                    medicoDto.MedicoID,
                    null
                   
                    
                
                );

                MessageBox.Show("Ingreso hospitalario registrado correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 5) Reiniciar formulario
                comboPaciente.SelectedIndex = 0;
                comboMedico.SelectedIndex = 0;
                textPadecimiento.Clear();
          
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar ingreso:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
