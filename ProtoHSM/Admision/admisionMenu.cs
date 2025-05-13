using System.Data;

using Microsoft.Data.SqlClient;
using ProtoHSM.Admision;

namespace ProtoHSM
{
    public partial class admisionMenu : Form
    {
        private Controller controller;

        DataTable dt = new DataTable();
        DataTable dtMedicos = new DataTable();
        DataTable dtPaquetes = new DataTable();
        DataTable dtPacientes = new DataTable();




        public admisionMenu(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
            gridPaquetes.DataSource = controller.ObtenerPaquetes();
            gridMedicos.DataSource = controller.ObtenerMedicos();
            gridPaquetes.Columns["CostoTotal"].DefaultCellStyle.Format = "C2";
            gridPaquetes.Columns["Nombre"].Width = 400;
            gridPaquetes.Columns["Categoria"].Width = 300;
            gridPaquetes.Columns["CostoTotal"].Width = 200;
            gridExtensiones.DataSource = controller.ObtenerExtensiones();
            gridExtensiones.Columns["Extension"].Width = 150;
            gridExtensiones.Columns["Puesto"].Width = 500;
            LlenarGridPacientes();
           

            // gridPacientes.Columns["PacienteID"].Visible = false;
            //gridPacientes.Columns["TipoVisita"].Visible = false;


        }

        private void LlenarGridPacientes()
        {
            // 1. Traemos los datos
            DataTable dt = controller.ObtenerPacientesUltimaVisita();
            gridPacientes.DataSource = null; // Limpiar antes por seguridad
            gridPacientes.Columns.Clear();   // 🔥 Importante limpiar columnas previas
            gridPacientes.DataSource = dt;

            // 2. Agregamos el botón SOLO si no existe

            gridPacientes.Columns["Paciente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridPacientes.Columns["Médico Tratante"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // 3. Ajustes de presentación

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            controller.loadNuevoPaciente();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            nuevoMedicocs nuevoMed = new nuevoMedicocs(controller);
            nuevoMed.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            nuevaConsulta nuevaConsul = new nuevaConsulta(controller);
            nuevaConsul.ShowDialog();
            this.Show();
        }



        private void admisionMenu_Load(object sender, EventArgs e)
        {

        }




        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.buttonNuevoPaciente.Image = ((System.Drawing.Image)(Properties.Resources.pacienteColor60));
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.buttonNuevoPaciente.Image = ((System.Drawing.Image)(Properties.Resources.pacienteBlanco60));
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            this.button2.Image = ((System.Drawing.Image)(Properties.Resources.doctorColor60));
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.Image = ((System.Drawing.Image)(Properties.Resources.doctorBlanco60));
        }

        private void buttonUrgencia_MouseEnter(object sender, EventArgs e)
        {
            this.buttonUrgencia.Image = ((System.Drawing.Image)(Properties.Resources.urgenciaColor));
        }

        private void buttonIngreso_MouseEnter(object sender, EventArgs e)
        {
            this.buttonIngreso.Image = ((System.Drawing.Image)(Properties.Resources.hospitalColor));
        }

        private void buttonIngreso_MouseLeave(object sender, EventArgs e)
        {
            this.buttonIngreso.Image = ((System.Drawing.Image)(Properties.Resources.hospitalBlanco));
        }

        private void buttonUrgencia_MouseLeave(object sender, EventArgs e)
        {
            this.buttonUrgencia.Image = ((System.Drawing.Image)(Properties.Resources.urgenciaBlanco));
        }

        private void buttonConsulta_MouseEnter(object sender, EventArgs e)
        {
            this.buttonConsulta.Image = ((System.Drawing.Image)(Properties.Resources.consultaColor));
        }

        private void buttonConsulta_MouseLeave(object sender, EventArgs e)
        {
            this.buttonConsulta.Image = ((System.Drawing.Image)(Properties.Resources.consultaBlanco));
        }


        private void buttonIngreso_Click(object sender, EventArgs e)
        {
            // 1) Preguntar al usuario si esto es un re-ingreso
            var respuesta = MessageBox.Show(
                "¿Este ingreso corresponde a un RE-INGRESO?",
                "Confirmar tipo de ingreso",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                // 2a) Es re-ingreso → abre el formulario de reIngreso
                using (var frmRe = new reIngresoVista(controller))
                {
                   
                    frmRe.ShowDialog(this);
                  
                }
            }
            else
            {
                // 2b) No es re-ingreso → abre el formulario de nuevoIngreso
                using (var frmNew = new nuevoIngreso(controller))
                {
                    
                    frmNew.ShowDialog(this);
                   
                }
            }

          
        }

        private void buttonUrgencia_Click(object sender, EventArgs e)
        {
            this.Hide();
            nuevaUrgencia nUrgencia = new nuevaUrgencia(controller);
            nUrgencia.ShowDialog();
            this.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            LlenarGridPacientes();
        }
    }



}

