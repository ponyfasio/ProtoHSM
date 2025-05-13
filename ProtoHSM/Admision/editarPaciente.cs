using System;
using System.Windows.Forms;
using ProtoHSM.Enfermeria;
using ProtoHSM.Models;
using ProtoHSM; // Para poder instanciar nuevoIngreso

namespace ProtoHSM.Admision
{
    public partial class editarPaciente : Form
    {
        private readonly Controller controller;
        private readonly PacienteComboDTO pacienteDTO;
        private readonly int pacienteID;

        public editarPaciente(PacienteComboDTO _paciente, Controller _controller)
        {
            InitializeComponent();

            // 1) Asignar parámetros correctamente
            this.pacienteDTO = _paciente;
            this.pacienteID = _paciente.PacienteID;
            this.controller = _controller;

            // 2) Suscribir el Load para poblar campos
            this.Load += (s, e) => CargarDatosPaciente();
        }

        private void CargarDatosPaciente()
        {
            // Función auxiliar para mostrar "Sin especificar"
            string Safe(string value) =>
                string.IsNullOrWhiteSpace(value) ? "Sin especificar" : value;

            var (paciente, familiar) = controller.ObtenerPacienteCompletoPorID(pacienteID);
            if (paciente == null) return;

            // --- Datos básicos ---
            textNombres.Text = paciente.Nombres;
            textApellidos.Text = paciente.Apellidos;
            textCURP.Text = paciente.CURP;
            textTelPaciente.Text = paciente.Telefono ?? string.Empty;
            comboNacimiento.Value = paciente.FechaNacimiento;

            // --- Nacionalidad ---
            comboNacionalidad.Text = string.IsNullOrWhiteSpace(paciente.Nacionalidad)
                                        ? "Otra"
                                        : paciente.Nacionalidad;

            // --- Domicilio ---
            textCalle.Text = Safe(paciente.Calle);
            textNum.Text = Safe(paciente.Numero);
            textColonia.Text = Safe(paciente.Colonia);
            textEstado.Text = Safe(paciente.Estado);
            textCP.Text = Safe(paciente.CP);
            textMunicipio.Text = Safe(paciente.Municipio);

            // --- Sexo ---
            comboSexo.Items.Clear();
            comboSexo.Items.AddRange(new[] { "Hombre", "Mujer" });
            comboSexo.SelectedIndex = paciente.Sexo ? 1 : 0;

            // --- Estado civil, estudios y ocupación ---
            comboCivil.Text = Safe(paciente.EstadoCivil);
            comboEstudios.Text = Safe(paciente.Escolaridad);
            comboOcupacion.Text = Safe(paciente.Ocupacion);

            // --- Tratamientos y alergias ---
            textTratamientos.Text = Safe(paciente.TratamientosExistentes);
            textAlergiasMedicamentos.Text = Safe(paciente.AlergiasMedicamentos);
            textAlergiasAlimentos.Text = Safe(paciente.AlergiasAlimentos);
            textAlergiasAmbiente.Text = Safe(paciente.AlergiasAmbiente);
            textAlergiasMaterial.Text = Safe(paciente.AlergiasMaterial);

            // --- Dificultades y ayudas ---
            checkLentes.Checked = paciente.UsaLentes;
            checkEquipo.Checked = paciente.UsaEquipoAuditivo;
            checkAuditiva.Checked = paciente.DificultadAuditiva;
            checkHabla.Checked = paciente.DificultadHabla;
            checkVisual.Checked = paciente.DificultadVisual;
            checkCaminar.Checked = paciente.DificultadMotriz;
            checkMental.Checked = paciente.DificultadMental;
            checkPsicologica.Checked = paciente.DificultadPsicologica;

            // --- Datos de familiar ---
            if (familiar != null)
            {
                textFamiliar.Text = familiar.NombreCompleto;
                comboParentesco.Text = familiar.Parentesco;
                textTelFamiliar.Text = familiar.Telefono;
                textDomicilioFamiliar.Text = familiar.Domicilio;
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Mapear Paciente
                var paciente = new Paciente
                {
                    PacienteID = pacienteID,
                    Nombres = textNombres.Text.Trim(),
                    Apellidos = textApellidos.Text.Trim(),
                    Telefono = string.IsNullOrWhiteSpace(textTelPaciente.Text)
                                                    ? null
                                                    : textTelPaciente.Text.Trim(),
                    FechaNacimiento = comboNacimiento.Value,
                    Nacionalidad = string.IsNullOrWhiteSpace(comboNacionalidad.Text)
                                                    ? null
                                                    : comboNacionalidad.Text.Trim(),
                    Calle = string.IsNullOrWhiteSpace(textCalle.Text)
                                                    ? null
                                                    : textCalle.Text.Trim(),
                    Numero = string.IsNullOrWhiteSpace(textNum.Text)
                                                    ? null
                                                    : textNum.Text.Trim(),
                    Colonia = string.IsNullOrWhiteSpace(textColonia.Text)
                                                    ? null
                                                    : textColonia.Text.Trim(),
                    Estado = string.IsNullOrWhiteSpace(textEstado.Text)
                                                    ? null
                                                    : textEstado.Text.Trim(),
                    CP = string.IsNullOrWhiteSpace(textCP.Text)
                                                    ? null
                                                    : textCP.Text.Trim(),
                    Municipio = string.IsNullOrWhiteSpace(textMunicipio.Text)
                                                    ? null
                                                    : textMunicipio.Text.Trim(),
                    Sexo = comboSexo.SelectedIndex == 1,
                    EstadoCivil = string.IsNullOrWhiteSpace(comboCivil.Text)
                                                    ? null
                                                    : comboCivil.Text.Trim(),
                    Escolaridad = string.IsNullOrWhiteSpace(comboEstudios.Text)
                                                    ? null
                                                    : comboEstudios.Text.Trim(),
                    Ocupacion = string.IsNullOrWhiteSpace(comboOcupacion.Text)
                                                    ? null
                                                    : comboOcupacion.Text.Trim(),
                    TratamientosExistentes = string.IsNullOrWhiteSpace(textTratamientos.Text)
                                                    ? null
                                                    : textTratamientos.Text.Trim(),
                    AlergiasMedicamentos = string.IsNullOrWhiteSpace(textAlergiasMedicamentos.Text)
                                                    ? null
                                                    : textAlergiasMedicamentos.Text.Trim(),
                    AlergiasAlimentos = string.IsNullOrWhiteSpace(textAlergiasAlimentos.Text)
                                                    ? null
                                                    : textAlergiasAlimentos.Text.Trim(),
                    AlergiasAmbiente = string.IsNullOrWhiteSpace(textAlergiasAmbiente.Text)
                                                    ? null
                                                    : textAlergiasAmbiente.Text.Trim(),
                    AlergiasMaterial = string.IsNullOrWhiteSpace(textAlergiasMaterial.Text)
                                                    ? null
                                                    : textAlergiasMaterial.Text.Trim(),
                    DificultadHabla = checkHabla.Checked,
                    DificultadAuditiva = checkAuditiva.Checked,
                    DificultadVisual = checkVisual.Checked,
                    DificultadMental = checkMental.Checked,
                    DificultadPsicologica = checkPsicologica.Checked,
                    DificultadMotriz = checkCaminar.Checked,
                    UsaEquipoAuditivo = checkEquipo.Checked,
                    UsaLentes = checkLentes.Checked
                };

                // Mapear Familiar
                var familiar = new ResponsablePaciente
                {
                    NombreCompleto = string.IsNullOrWhiteSpace(textFamiliar.Text)
                                        ? null
                                        : textFamiliar.Text.Trim(),
                    Parentesco = string.IsNullOrWhiteSpace(comboParentesco.Text)
                                        ? null
                                        : comboParentesco.Text.Trim(),
                    Telefono = string.IsNullOrWhiteSpace(textTelFamiliar.Text)
                                        ? null
                                        : textTelFamiliar.Text.Trim(),
                    Domicilio = string.IsNullOrWhiteSpace(textDomicilioFamiliar.Text)
                                        ? null
                                        : textDomicilioFamiliar.Text.Trim()
                };

                bool actualizado = controller.ActualizarPacienteYResponsable(paciente, familiar);
                if (actualizado)
                {
                    MessageBox.Show(
                        "Datos del paciente actualizados correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    // --- Aquí reutilizamos el DTO original, no uno nuevo ---
                    var ingresoForm = new nuevoIngreso(controller, this.pacienteDTO);
                    this.Hide();
                    ingresoForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo actualizar el paciente.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Todos los campos son obligatorios.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDomicilio_Click(object sender, EventArgs e)
        {
            textDomicilioFamiliar.Text = textCalle.Text + " " + textNum.Text + " " + textColonia.Text + " CP:" + textCP.Text + " " + textEstado.Text + " " + textMunicipio.Text;
        }
    }
}
