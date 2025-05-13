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
    public partial class reIngresoVista : Form
    {
        private readonly Controller controller;
        public reIngresoVista(Controller _controller)
        {
            InitializeComponent();
            controller = _controller;
            this.Load += reIngresoVista_Load;

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


        private void reIngresoVista_Load(object sender, EventArgs e)
        {

            comboPaciente.LoadItems();

        }



       

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click_1(object sender, EventArgs e)
        {

            // 1) Asegúrate de que hay un paciente seleccionado
            var dto = comboPaciente.PacienteSeleccionado;
            if (dto == null || dto.PacienteID == 0)
            {
                MessageBox.Show(
                    "Por favor seleccione un paciente.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                comboPaciente.Focus();
                return;
            }

            // 2) Lanza la ventana de edición pasándole sólo el ID y el controller
            using (var frm = new editarPaciente(dto, controller))
            {
                this.Hide();
                frm.ShowDialog(this);
                this.Close();
            }

          
       
        }
    }
}
