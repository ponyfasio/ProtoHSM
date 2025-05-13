using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProtoHSM.Models;

namespace ProtoHSM.Admision
{
    public partial class nuevaUrgencia : Form
    {
        private readonly Controller controller;

        public nuevaUrgencia(Controller _controller)
        {
            InitializeComponent();
            controller = _controller;
            this.Load += nuevaUrgencia_Load;

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


        private void nuevaUrgencia_Load(object sender, EventArgs e)
        {
            comboMedico.LoadItems();
            comboPaciente.LoadItems();
            comboCama.LoadItems(tipoCamaID: 1);
        }



        private void buttonOK_Click_1(object sender, EventArgs e)
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
            string diagnostico = textdiagnostico.Text.Trim();
            string procedimiento = textProcedimiento.Text.Trim();

            // **Nueva línea**: obtener el texto de la cama
            var camaDto = comboCama.CamaSeleccionada;
            if (camaDto == null || camaDto.CamaID == 0)
            {
                MessageBox.Show("Por favor, seleccione una cama.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboCama.Focus();
                return;
            }
            string cama = camaDto.NumeroCama;

            int usuarioID = controller.UsuarioActual.UsuarioID;

            try
            {
                controller.RegistrarVisita(
                    pacienteDto.PacienteID,
                    "Urgencia",
                    diagnostico,
                    procedimiento,
                    usuarioID,      // createdBy
                    medicoDto.MedicoID,
                    cama
                );

                MessageBox.Show("Ingreso hospitalario registrado correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar ingreso:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
