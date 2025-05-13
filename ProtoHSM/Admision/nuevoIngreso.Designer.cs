namespace ProtoHSM
{
    partial class nuevoIngreso
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
            panel1 = new Panel();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            buttonCancelar = new Button();
            buttonOK = new Button();
            comboCama = new comboCama();
            label7 = new Label();
            textProcedimiento = new TextBox();
            label6 = new Label();
            label3 = new Label();
            textCURP = new TextBox();
            label1 = new Label();
            textdiagnostico = new TextBox();
            label5 = new Label();
            label4 = new Label();
            comboMedico = new MedicoSearchComboBox();
            comboPaciente = new PacienteSearchComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            panel1.Size = new Size(1064, 111);
            panel1.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SlateGray;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 101);
            panel4.Name = "panel4";
            panel4.Size = new Size(1064, 10);
            panel4.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(14, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 84);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(87, 30);
            label2.Name = "label2";
            label2.Size = new Size(425, 45);
            label2.TabIndex = 17;
            label2.Text = "Nuevo Ingreso Hospitalario";
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(255, 192, 192);
            buttonCancelar.Font = new Font("Calibri", 14.25F);
            buttonCancelar.Location = new Point(14, 474);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(132, 75);
            buttonCancelar.TabIndex = 7;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonOK
            // 
            buttonOK.BackColor = Color.FromArgb(192, 255, 192);
            buttonOK.Font = new Font("Calibri", 14.25F);
            buttonOK.Location = new Point(920, 474);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(132, 75);
            buttonOK.TabIndex = 6;
            buttonOK.Text = "Realizar Ingreso";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_Click;
            // 
            // comboCama
            // 
            comboCama.DropDownHeight = 92;
            comboCama.Font = new Font("Calibri", 14.25F);
            comboCama.FormattingEnabled = true;
            comboCama.IntegralHeight = false;
            comboCama.Location = new Point(801, 198);
            comboCama.MaxDropDownItems = 5;
            comboCama.Name = "comboCama";
            comboCama.Size = new Size(242, 31);
            comboCama.TabIndex = 75;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14.25F);
            label7.Location = new Point(21, 336);
            label7.Name = "label7";
            label7.Size = new Size(127, 23);
            label7.TabIndex = 72;
            label7.Text = "Procedimiento:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textProcedimiento
            // 
            textProcedimiento.Font = new Font("Calibri", 14.25F);
            textProcedimiento.Location = new Point(156, 334);
            textProcedimiento.Name = "textProcedimiento";
            textProcedimiento.Size = new Size(527, 31);
            textProcedimiento.TabIndex = 65;
            textProcedimiento.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F);
            label6.Location = new Point(696, 201);
            label6.Name = "label6";
            label6.Size = new Size(97, 23);
            label6.TabIndex = 71;
            label6.Text = "Habitación:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F);
            label3.Location = new Point(736, 247);
            label3.Name = "label3";
            label3.Size = new Size(57, 23);
            label3.TabIndex = 70;
            label3.Text = "CURP:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textCURP
            // 
            textCURP.BorderStyle = BorderStyle.FixedSingle;
            textCURP.Enabled = false;
            textCURP.Font = new Font("Calibri", 14.25F);
            textCURP.Location = new Point(801, 243);
            textCURP.Name = "textCURP";
            textCURP.Size = new Size(242, 31);
            textCURP.TabIndex = 69;
            textCURP.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F);
            label1.Location = new Point(42, 291);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 67;
            label1.Text = "Diagnostico:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textdiagnostico
            // 
            textdiagnostico.Font = new Font("Calibri", 14.25F);
            textdiagnostico.Location = new Point(156, 288);
            textdiagnostico.Name = "textdiagnostico";
            textdiagnostico.Size = new Size(527, 31);
            textdiagnostico.TabIndex = 64;
            textdiagnostico.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F);
            label5.Location = new Point(76, 198);
            label5.Name = "label5";
            label5.Size = new Size(72, 23);
            label5.TabIndex = 68;
            label5.Text = "Médico:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F);
            label4.Location = new Point(68, 245);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 66;
            label4.Text = "Paciente:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboMedico
            // 
            comboMedico.DisplayMember = "Nombre";
            comboMedico.DropDownHeight = 92;
            comboMedico.Font = new Font("Calibri", 14.25F);
            comboMedico.FormattingEnabled = true;
            comboMedico.IntegralHeight = false;
            comboMedico.Location = new Point(156, 193);
            comboMedico.MaxDropDownItems = 5;
            comboMedico.Name = "comboMedico";
            comboMedico.Size = new Size(527, 31);
            comboMedico.TabIndex = 76;
            comboMedico.ValueMember = "MedicoID";
            // 
            // comboPaciente
            // 
            comboPaciente.DisplayMember = "Nombre";
            comboPaciente.DropDownHeight = 92;
            comboPaciente.Font = new Font("Calibri", 14.25F);
            comboPaciente.FormattingEnabled = true;
            comboPaciente.IntegralHeight = false;
            comboPaciente.Location = new Point(156, 242);
            comboPaciente.MaxDropDownItems = 5;
            comboPaciente.Name = "comboPaciente";
            comboPaciente.Size = new Size(527, 31);
            comboPaciente.TabIndex = 77;
            comboPaciente.ValueMember = "PacienteID";
            comboPaciente.SelectionChangeCommitted += comboPaciente_SelectionChangeCommitted;
            // 
            // nuevoIngreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 561);
            Controls.Add(comboPaciente);
            Controls.Add(comboMedico);
            Controls.Add(comboCama);
            Controls.Add(label7);
            Controls.Add(textProcedimiento);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(textCURP);
            Controls.Add(label1);
            Controls.Add(textdiagnostico);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonOK);
            Name = "nuevoIngreso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HSM: Nuevo Ingreso";
            Load += nuevoIngreso_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonCancelar;
        private Button buttonOK;
        private Panel panel4;
        private Label label2;
        private PictureBox pictureBox1;
       
        private comboCama comboCama;
       
        private Label label7;
        private TextBox textProcedimiento;
        private Label label6;
        private Label label3;
        private TextBox textCURP;
        private Label label1;
        private TextBox textdiagnostico;
        private Label label5;
        private Label label4;
        private MedicoSearchComboBox comboMedico;
        private PacienteSearchComboBox comboPaciente;
    }
}