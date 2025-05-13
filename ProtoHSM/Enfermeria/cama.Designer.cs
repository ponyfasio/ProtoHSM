namespace ProtoHSM.Enfermeria
{
    partial class cama
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            labelPaciente = new Label();
            labelBed = new Label();
            labelMedico = new Label();
            labelProcedimiento = new Label();
            panel1 = new Panel();
            iconHabla = new PictureBox();
            iconVisual = new PictureBox();
            iconAuditivo = new PictureBox();
            iconPsicologico = new PictureBox();
            iconMovimiento = new PictureBox();
            iconMental = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconHabla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconVisual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconAuditivo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPsicologico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconMovimiento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconMental).BeginInit();
            SuspendLayout();
            // 
            // labelPaciente
            // 
            labelPaciente.Font = new Font("Calibri", 9F);
            labelPaciente.Location = new Point(54, 96);
            labelPaciente.Name = "labelPaciente";
            labelPaciente.Size = new Size(197, 19);
            labelPaciente.TabIndex = 0;
            labelPaciente.Text = "JUAN CARLOS PEREZ CRUZ";
            labelPaciente.TextAlign = ContentAlignment.MiddleCenter;
            labelPaciente.MouseDown += panel1_MouseDown;
            // 
            // labelBed
            // 
            labelBed.Font = new Font("Eras Bold ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBed.Location = new Point(57, 52);
            labelBed.Name = "labelBed";
            labelBed.Size = new Size(197, 31);
            labelBed.TabIndex = 1;
            labelBed.Text = "URG-1";
            labelBed.TextAlign = ContentAlignment.MiddleCenter;
            labelBed.MouseDown += panel1_MouseDown;
            // 
            // labelMedico
            // 
            labelMedico.Font = new Font("Calibri", 9F);
            labelMedico.Location = new Point(54, 115);
            labelMedico.Name = "labelMedico";
            labelMedico.Size = new Size(197, 19);
            labelMedico.TabIndex = 2;
            labelMedico.Text = "EFREN FLORES ALVAREZ";
            labelMedico.TextAlign = ContentAlignment.MiddleCenter;
            labelMedico.MouseDown += panel1_MouseDown;
            // 
            // labelProcedimiento
            // 
            labelProcedimiento.Font = new Font("Calibri", 9F);
            labelProcedimiento.Location = new Point(54, 134);
            labelProcedimiento.Name = "labelProcedimiento";
            labelProcedimiento.Size = new Size(197, 19);
            labelProcedimiento.TabIndex = 3;
            labelProcedimiento.Text = "COLONOSCOPIA";
            labelProcedimiento.TextAlign = ContentAlignment.MiddleCenter;
            labelProcedimiento.MouseDown += panel1_MouseDown;
            // 
            // panel1
            // 
            panel1.Controls.Add(iconHabla);
            panel1.Controls.Add(iconVisual);
            panel1.Controls.Add(iconAuditivo);
            panel1.Controls.Add(iconPsicologico);
            panel1.Controls.Add(iconMovimiento);
            panel1.Controls.Add(iconMental);
            panel1.Controls.Add(labelBed);
            panel1.Controls.Add(labelPaciente);
            panel1.Controls.Add(labelMedico);
            panel1.Controls.Add(labelProcedimiento);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 160);
            panel1.TabIndex = 4;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // iconHabla
            // 
            iconHabla.BackgroundImage = Properties.Resources.habla;
            iconHabla.BackgroundImageLayout = ImageLayout.Center;
            iconHabla.Location = new Point(250, 0);
            iconHabla.Name = "iconHabla";
            iconHabla.Size = new Size(50, 43);
            iconHabla.TabIndex = 7;
            iconHabla.TabStop = false;
            iconHabla.Visible = false;
            // 
            // iconVisual
            // 
            iconVisual.BackgroundImage = Properties.Resources.vista;
            iconVisual.BackgroundImageLayout = ImageLayout.Center;
            iconVisual.Location = new Point(200, 0);
            iconVisual.Name = "iconVisual";
            iconVisual.Size = new Size(50, 43);
            iconVisual.TabIndex = 6;
            iconVisual.TabStop = false;
            iconVisual.Visible = false;
            // 
            // iconAuditivo
            // 
            iconAuditivo.BackgroundImage = Properties.Resources.sordera;
            iconAuditivo.BackgroundImageLayout = ImageLayout.Center;
            iconAuditivo.Location = new Point(150, 0);
            iconAuditivo.Name = "iconAuditivo";
            iconAuditivo.Size = new Size(50, 43);
            iconAuditivo.TabIndex = 5;
            iconAuditivo.TabStop = false;
            iconAuditivo.Visible = false;
            // 
            // iconPsicologico
            // 
            iconPsicologico.BackgroundImage = Properties.Resources.psicologicos;
            iconPsicologico.BackgroundImageLayout = ImageLayout.Center;
            iconPsicologico.Location = new Point(100, 0);
            iconPsicologico.Name = "iconPsicologico";
            iconPsicologico.Size = new Size(50, 43);
            iconPsicologico.TabIndex = 4;
            iconPsicologico.TabStop = false;
            iconPsicologico.Visible = false;
            // 
            // iconMovimiento
            // 
            iconMovimiento.BackgroundImage = Properties.Resources.movimiento;
            iconMovimiento.BackgroundImageLayout = ImageLayout.Center;
            iconMovimiento.Location = new Point(50, 0);
            iconMovimiento.Name = "iconMovimiento";
            iconMovimiento.Size = new Size(50, 43);
            iconMovimiento.TabIndex = 4;
            iconMovimiento.TabStop = false;
            iconMovimiento.Visible = false;
            // 
            // iconMental
            // 
            iconMental.BackgroundImage = Properties.Resources.mental;
            iconMental.BackgroundImageLayout = ImageLayout.Center;
            iconMental.Location = new Point(0, 0);
            iconMental.Name = "iconMental";
            iconMental.Size = new Size(50, 43);
            iconMental.TabIndex = 4;
            iconMental.TabStop = false;
            iconMental.Visible = false;
            // 
            // cama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "cama";
            Size = new Size(300, 165);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconHabla).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconVisual).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconAuditivo).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPsicologico).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconMovimiento).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconMental).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelPaciente;
        private Label labelBed;
        private Label labelMedico;
        private Label labelProcedimiento;
        private Panel panel1;
        private PictureBox iconPsicologico;
        private PictureBox iconMovimiento;
        private PictureBox iconMental;
        private PictureBox iconAuditivo;
        private PictureBox iconHabla;
        private PictureBox iconVisual;
    }
}
