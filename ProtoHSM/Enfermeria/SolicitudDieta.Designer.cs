namespace ProtoHSM.Enfermeria
{
    partial class SolicitudDieta
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
            textBox1 = new TextBox();
            label6 = new Label();
            textAlergias = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            textUbicacion = new TextBox();
            comboPacientes = new ComboBox();
            label5 = new Label();
            buttonCancelar = new Button();
            buttonSolicitar = new Button();
            panel4 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textAlergias);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textUbicacion);
            panel1.Controls.Add(comboPacientes);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(buttonCancelar);
            panel1.Controls.Add(buttonSolicitar);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 365);
            panel1.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 12F);
            textBox1.Location = new Point(450, 120);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(327, 93);
            textBox1.TabIndex = 5;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F);
            label6.Location = new Point(452, 96);
            label6.Name = "label6";
            label6.Size = new Size(67, 19);
            label6.TabIndex = 37;
            label6.Text = "Detalles:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textAlergias
            // 
            textAlergias.Font = new Font("Calibri", 12F);
            textAlergias.Location = new Point(82, 120);
            textAlergias.Multiline = true;
            textAlergias.Name = "textAlergias";
            textAlergias.Size = new Size(357, 93);
            textAlergias.TabIndex = 4;
            textAlergias.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F);
            label3.Location = new Point(13, 124);
            label3.Name = "label3";
            label3.Size = new Size(66, 19);
            label3.TabIndex = 35;
            label3.Text = "Alergias:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Calibri", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "DIETA NORMAL", "DIETA LIQUIDA", "DIETA BLANDA", "DIETA ASTRINGENTE", "DIETA NEFROPATA", "DIETA SIN GRASA" });
            comboBox1.Location = new Point(82, 81);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(357, 27);
            comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F);
            label1.Location = new Point(28, 85);
            label1.Name = "label1";
            label1.Size = new Size(48, 19);
            label1.TabIndex = 34;
            label1.Text = "Dieta:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F);
            label4.Location = new Point(450, 42);
            label4.Name = "label4";
            label4.Size = new Size(161, 19);
            label4.TabIndex = 32;
            label4.Text = "Ubicación del Paciente:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textUbicacion
            // 
            textUbicacion.Font = new Font("Calibri", 12F);
            textUbicacion.Location = new Point(618, 38);
            textUbicacion.Name = "textUbicacion";
            textUbicacion.Size = new Size(159, 27);
            textUbicacion.TabIndex = 2;
            textUbicacion.TextAlign = HorizontalAlignment.Center;
            // 
            // comboPacientes
            // 
            comboPacientes.Font = new Font("Calibri", 12F);
            comboPacientes.FormattingEnabled = true;
            comboPacientes.Items.AddRange(new object[] { "CARLOS ALBERTO PINET GARZA" });
            comboPacientes.Location = new Point(82, 38);
            comboPacientes.Name = "comboPacientes";
            comboPacientes.Size = new Size(357, 27);
            comboPacientes.TabIndex = 1;
            comboPacientes.SelectedIndexChanged += comboPacientes_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F);
            label5.Location = new Point(7, 42);
            label5.Name = "label5";
            label5.Size = new Size(69, 19);
            label5.TabIndex = 30;
            label5.Text = "Paciente:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(255, 192, 192);
            buttonCancelar.Font = new Font("Calibri", 12F);
            buttonCancelar.Location = new Point(13, 309);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(105, 44);
            buttonCancelar.TabIndex = 7;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonSolicitar
            // 
            buttonSolicitar.BackColor = Color.FromArgb(192, 255, 192);
            buttonSolicitar.Font = new Font("Calibri", 12F);
            buttonSolicitar.Location = new Point(678, 309);
            buttonSolicitar.Name = "buttonSolicitar";
            buttonSolicitar.Size = new Size(105, 44);
            buttonSolicitar.TabIndex = 6;
            buttonSolicitar.Text = "Solicitar";
            buttonSolicitar.UseVisualStyleBackColor = false;
            buttonSolicitar.Click += buttonSolicitar_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SlateGray;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(784, 10);
            panel4.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 22);
            label2.Name = "label2";
            label2.Size = new Size(279, 45);
            label2.TabIndex = 23;
            label2.Text = "Solicitud de Dieta";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 84);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // SolicitudDieta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 457);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "SolicitudDieta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SolicitudDieta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private TextBox textUbicacion;
        private ComboBox comboPacientes;
        private Label label5;
        private Button buttonCancelar;
        private Button buttonSolicitar;
        private Panel panel4;
        private Label label2;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label3;
        private TextBox textAlergias;
        private TextBox textBox1;
        private Label label6;
    }
}