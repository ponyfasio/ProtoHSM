using System.ComponentModel;

namespace ProtoHSM.Enfermeria
{

    public partial class cama : UserControl
    {
        ContextMenuStrip contextMenu;
        public cama()
        {
            InitializeComponent();
            //contextMenu = new ContextMenuStrip();
            //contextMenu.Items.Add("Ocupar Cama", null, "");
            //contextMenu.Items.Add("Solicitar Limpieza", null, solicitarLimpieza_Click);
            //contextMenu.Items.Add("Validar Limpieza", null, validarLimpieza);
            //contextMenu.Items.Add("Desocupar Cama", null, desocupar);
            //contextMenu.Items.Add("Deshabilitar Cama", null, deshabilitar);

            //iconAuditivo.Visible = false;
            //iconHabla.Visible = false;  
            //iconMental.Visible = false;
            //iconMovimiento.Visible = false;
            //iconPsicologico.Visible = false;
            //iconVisual.Visible = false;



            // contextMenu.Items.Add("Deshabilitar", null, Opcion2_Click);

        }

        private string _paciente, _medico, _procedimiento, _Cama;


        //        private void MostrarContextMenu(object sender, MouseEventArgs e)
        //        {
        //            if (e.Button == MouseButtons.Right)
        //            {
        //                // Mostrar el menú en coordenadas del control base
        //                var control = sender as Control;
        //                var location = control == this ? e.Location : this.PointToClient(control.PointToScreen(e.Location));
        //                contextMenu.Show(this, location);
        //            }
        //        }

        [Category("Datos Habitacion")]
#pragma warning disable WFO1000 // Falta la configuración de serialización de código para el contenido de la propiedad
        public string Paciente { get { return _paciente; } set { _paciente = value; labelPaciente.Text = "Paciente: " + value; } }
#pragma warning restore WFO1000 // Falta la configuración de serialización de código para el contenido de la propiedad
        [Category("Datos Habitacion")]
#pragma warning disable WFO1000 // Falta la configuración de serialización de código para el contenido de la propiedad
        public string Medico
#pragma warning restore WFO1000 // Falta la configuración de serialización de código para el contenido de la propiedad
        { get { return _medico; } set { _medico = value; labelMedico.Text = "Médico: " + value; } }
        [Category("Datos Habitacion")]

#pragma warning disable WFO1000 // Falta la configuración de serialización de código para el contenido de la propiedad
        public string Procedimiento
#pragma warning restore WFO1000 // Falta la configuración de serialización de código para el contenido de la propiedad
        { get { return _procedimiento; } set { _procedimiento = value; labelProcedimiento.Text = "Procedimiento: " + value; } }

        [Category("Datos Habitacion")]
#pragma warning disable WFO1000 // Falta la configuración de serialización de código para el contenido de la propiedad
        public string Cama
#pragma warning restore WFO1000 // Falta la configuración de serialización de código para el contenido de la propiedad
        { get { return _Cama; } set { _Cama = value; labelBed.Text = value; } }


        //        private void OcuparHabitacion_Click(object sender, EventArgs e)
        //        {
        //            using (ocuparCama form = new ocuparCama())
        //            {
        //                if (form.ShowDialog() == DialogResult.OK)
        //                {
        //                    // Este control representa tu cama
        //                    this.MostrarInformacionPaciente(form.InfoSeleccionada);
        //                }
        //            }
        //        }

        //        public void MostrarInformacionPaciente(PacienteInfo info)
        //        {
        //            labelPaciente.Text = info.Nombre;
        //            labelMedico.Text = info.Medico;
        //            labelProcedimiento.Text = info.Procedimiento;

        //            // Mostrar los iconos de acuerdo a las discapacidades
        //            iconHabla.Visible = info.DifHablar;
        //            iconAuditivo.Visible = info.DifOir;
        //            iconVisual.Visible = info.DifVer;
        //            iconPsicologico.Visible = info.DifPsicologica;
        //            iconMental.Visible = info.DifMental;
        //            iconMovimiento.Visible = info.DifMovimiento;

        //            this.BackColor = ColorTranslator.FromHtml("#EF9A9A"); // Color de cama ocupada
        //        }


        //        private void solicitarLimpieza_Click(object sender, EventArgs e)
        //        {
        //            this.BackColor = ColorTranslator.FromHtml("#FFF59D"); // Disponible
        //        }

        //        private void validarLimpieza(object sender, EventArgs e)
        //        {
        //            if (labelPaciente.Text != "Paciente: ")
        //            {
        //                this.BackColor = ColorTranslator.FromHtml("#EF9A9A"); // No Disponible
        //            }
        //            else
        //            {
        //                this.BackColor = ColorTranslator.FromHtml("#A5D6A7"); // Disponible
        //            }
        //        }

        //        private void deshabilitar(object sender, EventArgs e)
        //        {
        //            this.BackColor = ColorTranslator.FromHtml("#BDBDBD"); // Disponible
        //        }

        //        private void desocupar(object sender, EventArgs e)
        //        {
        //            labelMedico.Text = "Médico: ";
        //            labelPaciente.Text = "Paciente: ";
        //            labelProcedimiento.Text = "Procedimiento: ";
        //            this.BackColor = ColorTranslator.FromHtml("#FFF59D"); //Necesita limpieza
        //        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Mostrar el menú en coordenadas del control base
                var control = sender as Control;
                var location = control == this ? e.Location : this.PointToClient(control.PointToScreen(e.Location));
                contextMenu.Show(this, location);
            }
        }
    }
}
