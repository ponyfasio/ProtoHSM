using System;
using System.Windows.Forms;
using ProtoHSM.Enfermeria;
using ProtoHSM.Models;

namespace ProtoHSM
{
    public partial class nuevoIngreso : Form
    {
        private readonly Controller controller;
        private readonly PacienteComboDTO pacienteDTO;

        public nuevoIngreso(Controller _controller, PacienteComboDTO _paciente = null)
        {
            InitializeComponent();

            // 1) Asignar correctamente los parámetros
            this.controller = _controller;
            this.pacienteDTO = _paciente;

            // 2) Suscribir eventos antes de cargar ítems
            this.Load += nuevoIngreso_Load;
            comboPaciente.SelectionChangeCommitted += comboPaciente_SelectionChangeCommitted;
        }

        private void nuevoIngreso_Load(object sender, EventArgs e)
        {
            // 3) Cargo los combos
            comboMedico.LoadItems();
            comboPaciente.LoadItems();
            comboCama.LoadItems(tipoCamaID: 7);

            // 4) Si viene paciente, lo selecciono por ID y actualizo CURP/etiqueta
            if (pacienteDTO != null)
            {
                comboPaciente.SelectedValue = pacienteDTO.PacienteID;
                textCURP.Text = pacienteDTO.CURP;
                label2.Text = "Nuevo Reingreso Hospitalario";
            }
        }

        private void comboPaciente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var sel = comboPaciente.PacienteSeleccionado;
            textCURP.Text = sel?.CURP ?? string.Empty;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // Validaciones...
            var pacienteSel = comboPaciente.PacienteSeleccionado;
            if (pacienteSel == null || pacienteSel.PacienteID == 0)
            {
                MessageBox.Show("Por favor, seleccione un paciente.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboPaciente.Focus();
                return;
            }

            var medicoSel = comboMedico.MedicoSeleccionado;
            if (medicoSel == null || medicoSel.MedicoID == 0)
            {
                MessageBox.Show("Por favor, seleccione un médico.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboMedico.Focus();
                return;
            }

            var camaSel = comboCama.CamaSeleccionada;
            if (camaSel == null || camaSel.CamaID == 0)
            {
                MessageBox.Show("Por favor, seleccione una cama.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboCama.Focus();
                return;
            }

            try
            {
                controller.RegistrarVisita(
                    pacienteSel.PacienteID,
                    "Ingreso Hospitalario",
                    textdiagnostico.Text.Trim(),
                    textProcedimiento.Text.Trim(),
                    controller.UsuarioActual.UsuarioID,
                    medicoSel.MedicoID,
                    camaSel.NumeroCama
                );

                MessageBox.Show("Ingreso hospitalario registrado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar ingreso:\n{ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
