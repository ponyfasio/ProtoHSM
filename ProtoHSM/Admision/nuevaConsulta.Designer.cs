namespace ProtoHSM
{
    partial class nuevaConsulta
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
            comboPaciente = new PacienteSearchComboBox();
            comboMedico = new MedicoSearchComboBox();
            label3 = new Label();
            textCURP = new TextBox();
            label1 = new Label();
            textPadecimiento = new TextBox();
            label5 = new Label();
            label4 = new Label();
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
            panel1.Size = new Size(1064, 118);
            panel1.TabIndex = 12;
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
            label2.Size = new Size(253, 45);
            label2.TabIndex = 14;
            label2.Text = "Nueva Consulta";
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(255, 192, 192);
            buttonCancelar.Font = new Font("Calibri", 14.25F);
            buttonCancelar.Location = new Point(13, 462);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(132, 75);
            buttonCancelar.TabIndex = 42;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonOK
            // 
            buttonOK.BackColor = Color.FromArgb(192, 255, 192);
            buttonOK.Font = new Font("Calibri", 14.25F);
            buttonOK.Location = new Point(917, 462);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(132, 75);
            buttonOK.TabIndex = 4;
            buttonOK.Text = "Realizar Consulta";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_Click;
            // 
            // comboPaciente
            // 
            comboPaciente.DisplayMember = "Nombre";
            comboPaciente.DropDownHeight = 92;
            comboPaciente.Font = new Font("Calibri", 14.25F);
            comboPaciente.FormattingEnabled = true;
            comboPaciente.IntegralHeight = false;
            comboPaciente.Location = new Point(156, 244);
            comboPaciente.MaxDropDownItems = 5;
            comboPaciente.Name = "comboPaciente";
            comboPaciente.Size = new Size(526, 31);
            comboPaciente.TabIndex = 2;
            comboPaciente.ValueMember = "PacienteID";
            // 
            // comboMedico
            // 
            comboMedico.DisplayMember = "Nombre";
            comboMedico.DropDownHeight = 92;
            comboMedico.Font = new Font("Calibri", 14.25F);
            comboMedico.FormattingEnabled = true;
            comboMedico.IntegralHeight = false;
            comboMedico.Location = new Point(156, 196);
            comboMedico.MaxDropDownItems = 5;
            comboMedico.Name = "comboMedico";
            comboMedico.Size = new Size(526, 31);
            comboMedico.TabIndex = 1;
            comboMedico.ValueMember = "MedicoID";
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
            // textPadecimiento
            // 
            textPadecimiento.Font = new Font("Calibri", 14.25F);
            textPadecimiento.Location = new Point(156, 288);
            textPadecimiento.Name = "textPadecimiento";
            textPadecimiento.Size = new Size(526, 31);
            textPadecimiento.TabIndex = 3;
            textPadecimiento.TextAlign = HorizontalAlignment.Center;
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
            // nuevaConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 561);
            Controls.Add(comboPaciente);
            Controls.Add(comboMedico);
            Controls.Add(label3);
            Controls.Add(textCURP);
            Controls.Add(label1);
            Controls.Add(textPadecimiento);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonOK);
            Controls.Add(panel1);
            Name = "nuevaConsulta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HSM: Nueva Consulta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
            // comboPaciente.TextUpdate += comboPaciente_TextUpdate;
            // comboPaciente.SelectedIndexChanged += comboPaciente_SelectedIndexChanged;

        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Label label2;
        private PictureBox pictureBox1;
        private Button buttonCancelar;
        private Button buttonOK;
        private PacienteSearchComboBox comboPaciente;
        private MedicoSearchComboBox comboMedico;
        private Label label3;
        private TextBox textCURP;
        private Label label1;
        private TextBox textPadecimiento;
        private Label label5;
        private Label label4;
    }
}