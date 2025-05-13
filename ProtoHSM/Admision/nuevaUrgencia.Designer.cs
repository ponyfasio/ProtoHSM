namespace ProtoHSM.Admision
{
    partial class nuevaUrgencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            buttonOK = new Button();
            buttonCancelar = new Button();
            comboCama = new comboCama();
            comboPaciente = new PacienteSearchComboBox();
            comboMedico = new MedicoSearchComboBox();
            label7 = new Label();
            textProcedimiento = new TextBox();
            label6 = new Label();
            label3 = new Label();
            textCURP = new TextBox();
            label1 = new Label();
            textdiagnostico = new TextBox();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.SlateGray;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 108);
            panel4.Name = "panel4";
            panel4.Size = new Size(1064, 10);
            panel4.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 84);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(102, 39);
            label2.Name = "label2";
            label2.Size = new Size(255, 45);
            label2.TabIndex = 14;
            label2.Text = "Nueva Urgencia";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1064, 118);
            panel1.TabIndex = 49;
            // 
            // buttonOK
            // 
            buttonOK.BackColor = Color.FromArgb(192, 255, 192);
            buttonOK.Font = new Font("Segoe UI", 14.25F);
            buttonOK.Location = new Point(927, 498);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(125, 51);
            buttonOK.TabIndex = 50;
            buttonOK.Text = "Agregar";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_Click_1;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(255, 192, 192);
            buttonCancelar.Font = new Font("Segoe UI", 14.25F);
            buttonCancelar.Location = new Point(12, 498);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(116, 51);
            buttonCancelar.TabIndex = 51;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click_1;
            // 
            // comboCama
            // 
            comboCama.DropDownHeight = 92;
            comboCama.Font = new Font("Calibri", 14.25F);
            comboCama.FormattingEnabled = true;
            comboCama.IntegralHeight = false;
            comboCama.Location = new Point(794, 192);
            comboCama.MaxDropDownItems = 5;
            comboCama.Name = "comboCama";
            comboCama.Size = new Size(242, 31);
            comboCama.TabIndex = 63;
            // 
            // comboPaciente
            // 
            comboPaciente.DisplayMember = "Nombre";
            comboPaciente.DropDownHeight = 92;
            comboPaciente.Font = new Font("Calibri", 14.25F);
            comboPaciente.FormattingEnabled = true;
            comboPaciente.IntegralHeight = false;
            comboPaciente.Location = new Point(149, 238);
            comboPaciente.MaxDropDownItems = 5;
            comboPaciente.Name = "comboPaciente";
            comboPaciente.Size = new Size(561, 31);
            comboPaciente.TabIndex = 62;
            comboPaciente.ValueMember = "PacienteID";
            // 
            // comboMedico
            // 
            comboMedico.DisplayMember = "Nombre";
            comboMedico.DropDownHeight = 92;
            comboMedico.Font = new Font("Calibri", 14.25F);
            comboMedico.FormattingEnabled = true;
            comboMedico.IntegralHeight = false;
            comboMedico.Location = new Point(149, 190);
            comboMedico.MaxDropDownItems = 5;
            comboMedico.Name = "comboMedico";
            comboMedico.Size = new Size(561, 31);
            comboMedico.TabIndex = 61;
            comboMedico.ValueMember = "MedicoID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14.25F);
            label7.Location = new Point(14, 330);
            label7.Name = "label7";
            label7.Size = new Size(127, 23);
            label7.TabIndex = 60;
            label7.Text = "Procedimiento:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textProcedimiento
            // 
            textProcedimiento.Font = new Font("Calibri", 14.25F);
            textProcedimiento.Location = new Point(149, 328);
            textProcedimiento.Name = "textProcedimiento";
            textProcedimiento.Size = new Size(561, 31);
            textProcedimiento.TabIndex = 53;
            textProcedimiento.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F);
            label6.Location = new Point(728, 194);
            label6.Name = "label6";
            label6.Size = new Size(58, 23);
            label6.TabIndex = 59;
            label6.Text = "Cama:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F);
            label3.Location = new Point(729, 241);
            label3.Name = "label3";
            label3.Size = new Size(57, 23);
            label3.TabIndex = 58;
            label3.Text = "CURP:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textCURP
            // 
            textCURP.BorderStyle = BorderStyle.FixedSingle;
            textCURP.Enabled = false;
            textCURP.Font = new Font("Calibri", 14.25F);
            textCURP.Location = new Point(794, 237);
            textCURP.Name = "textCURP";
            textCURP.Size = new Size(242, 31);
            textCURP.TabIndex = 57;
            textCURP.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F);
            label1.Location = new Point(35, 285);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 55;
            label1.Text = "Diagnostico:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textdiagnostico
            // 
            textdiagnostico.Font = new Font("Calibri", 14.25F);
            textdiagnostico.Location = new Point(149, 282);
            textdiagnostico.Name = "textdiagnostico";
            textdiagnostico.Size = new Size(561, 31);
            textdiagnostico.TabIndex = 52;
            textdiagnostico.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F);
            label5.Location = new Point(69, 192);
            label5.Name = "label5";
            label5.Size = new Size(72, 23);
            label5.TabIndex = 56;
            label5.Text = "Médico:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F);
            label4.Location = new Point(61, 239);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 54;
            label4.Text = "Paciente:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nuevaUrgencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 561);
            Controls.Add(comboCama);
            Controls.Add(comboPaciente);
            Controls.Add(comboMedico);
            Controls.Add(label7);
            Controls.Add(textProcedimiento);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(textCURP);
            Controls.Add(label1);
            Controls.Add(textdiagnostico);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(buttonOK);
            Controls.Add(buttonCancelar);
            Controls.Add(panel1);
            Name = "nuevaUrgencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HSM: Nueva Urgencia";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel1;
        private Button buttonOK;
        private Button buttonCancelar;
        private comboCama comboCama;
        private PacienteSearchComboBox comboPaciente;
        private MedicoSearchComboBox comboMedico;
        private Label label7;
        private TextBox textProcedimiento;
        private Label label6;
        private Label label3;
        private TextBox textCURP;
        private Label label1;
        private TextBox textdiagnostico;
        private Label label5;
        private Label label4;
    }
}