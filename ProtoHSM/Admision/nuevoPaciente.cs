using System.Diagnostics;
using Microsoft.Data.SqlClient;
using ProtoHSM.Models;

namespace ProtoHSM
{
    public partial class nuevoPaciente : Form
    {
        private Controller controller;
        private int usuarioID;


        public nuevoPaciente(Controller _controller, Usuario _usuarioID)
        {

            InitializeComponent();
            controller = _controller;
            usuarioID = _usuarioID.UsuarioID;


        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }





        private string filtrarCurp(string texto)
        {
            string conAcentos = "áéíóúÁÉÍÓÚàèìòùÀÈÌÒÙäëïöüÄËÏÖÜ-|$%&/()=?°!\"¡´+{},#°";
            string sinAcentos = "aeiouAEIOUaeiouAEIOUaeiouAEIOU                      ";

            for (int i = 0; i < conAcentos.Length; i++)
            {
                texto = texto.Replace(conAcentos[i], sinAcentos[i]);
            }

            // Primero reemplazamos múltiples espacios por uno solo
            while (texto.Contains(" "))
            {
                texto = texto.Replace(" ", "");
            }
            return texto; // Elimina espacios al inicio y final
        }



        private void nuevoPaciente_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {

            Clipboard.SetText(textCURP.Text);
            string url = $"https://www.gob.mx/curp/";

            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Necesario para abrir en navegador moderno
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir CURP: " + ex.Message);
            }
        }

        private void textCURP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
            filtrarCurp(textCURP.Text);
        }

        private void textCURP_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = textCURP.Text;
            string textoSinAcentos = filtrarCurp(textoOriginal);


            // Solo actualizamos si hay cambios para evitar bucles infinitos
            if (textoOriginal != textoSinAcentos)
            {
                textCURP.Text = textoSinAcentos;
                textCURP.SelectionStart = textoSinAcentos.Length; // Mantiene el cursor al final
            }
        }

        private void checkAuditiva_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAuditiva.Checked)
            {
                checkEquipo.Visible = true;
            }
            else
            {
                checkEquipo.Visible = false;
            }

        }

        private void checkVisual_CheckedChanged(object sender, EventArgs e)
        {
            if (checkVisual.Checked)
            {
                checkLentes.Visible = true;
            }
            else
            {
                checkLentes.Visible = false;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textCURP.Text) || controller.CurpExiste(textCURP.Text))
                {
                    MessageBox.Show("La CURP ya existe o está vacía.");
                    return;
                }

                // 🧩 1. Crear Paciente
                var paciente = new Paciente
                {
                    Nombres = textNombres.Text,
                    Apellidos = textApellidos.Text,
                    FechaNacimiento = comboNacimiento.Value,
                    Sexo = comboSexo.SelectedIndex == 1,
                    CURP = textCURP.Text,
                    Nacionalidad = comboNacionalidad.Text,
                    Calle = textCalle.Text,
                    Numero = textNum.Text,
                    Colonia = textColonia.Text,
                    CP = textCP.Text,
                    Estado = textEstado.Text,
                    Municipio = textMunicipio.Text,
                    Telefono = textTelPaciente.Text,
                    Escolaridad = comboEstudios.Text,
                    EstadoCivil = comboCivil.Text,
                    Ocupacion = comboOcupacion.Text,
                    Religion = comboReligion.Text,
                    TratamientosExistentes = textTratamientos.Text,
                    AlergiasMedicamentos = textAlergiasMedicamentos.Text,
                    AlergiasAlimentos = textAlergiasAlimentos.Text,
                    AlergiasAmbiente = textAlergiasAmbiente.Text,
                    AlergiasMaterial = textAlergiasMaterial.Text,
                    DificultadHabla = checkHabla.Checked,
                    DificultadAuditiva = checkAuditiva.Checked,
                    DificultadVisual = checkVisual.Checked,
                    DificultadMental = checkMental.Checked,
                    DificultadPsicologica = checkPsicologica.Checked,
                    DificultadMotriz = checkCaminar.Checked,
                    UsaEquipoAuditivo = checkEquipo.Checked,
                    UsaLentes = checkLentes.Checked,
                    NumeroPoliza = null
                };

                int pacienteID = controller.RegistrarPaciente(paciente, usuarioID);

                // 🧩 2. Crear Familiar
                var familiar = new FamiliarPaciente
                {
                    PacienteID = pacienteID,
                    Nombre = textFamiliar.Text,
                    Parentesco = comboParentesco.Text,
                    Telefono = textTelFamiliar.Text,
                    Domicilio = textDomicilioFamiliar.Text
                };

                controller.RegistrarFamiliar(familiar);

                MessageBox.Show("Paciente y responsable registrados correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonDomicilio_Click(object sender, EventArgs e)
        {
            textDomicilioFamiliar.Text = textCalle.Text + " " + textNum.Text + " " + textColonia.Text + " CP:" + textCP.Text + " " + textEstado.Text + " " + textMunicipio.Text;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboNacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
