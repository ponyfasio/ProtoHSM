namespace ProtoHSM.Enfermeria
{
    partial class solicitudServicios
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
            listaInsumos = new DataGridView();
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            tabPage1 = new TabPage();
            button6 = new Button();
            button5 = new Button();
            tabPage2 = new TabPage();
            labelCedula = new Label();
            label8 = new Label();
            labelMedico = new Label();
            label6 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)listaInsumos).BeginInit();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(listaInsumos);
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(labelCedula);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(labelMedico);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textUbicacion);
            panel1.Controls.Add(comboPacientes);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(buttonCancelar);
            panel1.Controls.Add(buttonSolicitar);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 468);
            panel1.TabIndex = 21;
            // 
            // listaInsumos
            // 
            listaInsumos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaInsumos.Location = new Point(320, 122);
            listaInsumos.Name = "listaInsumos";
            listaInsumos.Size = new Size(452, 282);
            listaInsumos.TabIndex = 45;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 98);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(289, 306);
            tabControl1.TabIndex = 42;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(button1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(281, 278);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Hospital";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(15, 148);
            button3.Name = "button3";
            button3.Size = new Size(86, 36);
            button3.TabIndex = 0;
            button3.Text = "Ventilador";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(107, 23);
            button4.Name = "button4";
            button4.Size = new Size(156, 36);
            button4.TabIndex = 0;
            button4.Text = "Oxígeno Alto Flujo";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(15, 85);
            button2.Name = "button2";
            button2.Size = new Size(86, 36);
            button2.TabIndex = 0;
            button2.Text = "Monitor";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(15, 23);
            button1.Name = "button1";
            button1.Size = new Size(86, 36);
            button1.TabIndex = 0;
            button1.Text = "Oxígeno";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(button5);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(281, 278);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Imagen";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(119, 18);
            button6.Name = "button6";
            button6.Size = new Size(86, 36);
            button6.TabIndex = 1;
            button6.Text = "Rayos X";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(15, 18);
            button5.Name = "button5";
            button5.Size = new Size(86, 36);
            button5.TabIndex = 1;
            button5.Text = "TAC";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(281, 278);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Laboratorio";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelCedula
            // 
            labelCedula.BorderStyle = BorderStyle.FixedSingle;
            labelCedula.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCedula.ForeColor = Color.Blue;
            labelCedula.Location = new Point(618, 55);
            labelCedula.Name = "labelCedula";
            labelCedula.Size = new Size(159, 29);
            labelCedula.TabIndex = 41;
            labelCedula.Text = "180548";
            labelCedula.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F);
            label8.Location = new Point(553, 60);
            label8.Name = "label8";
            label8.Size = new Size(58, 19);
            label8.TabIndex = 40;
            label8.Text = "Cédula:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelMedico
            // 
            labelMedico.BorderStyle = BorderStyle.FixedSingle;
            labelMedico.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMedico.ForeColor = Color.Blue;
            labelMedico.Location = new Point(135, 55);
            labelMedico.Name = "labelMedico";
            labelMedico.Size = new Size(304, 29);
            labelMedico.TabIndex = 39;
            labelMedico.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F);
            label6.Location = new Point(10, 60);
            label6.Name = "label6";
            label6.Size = new Size(119, 19);
            label6.TabIndex = 38;
            label6.Text = "Medico Tratante:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F);
            label4.Location = new Point(450, 25);
            label4.Name = "label4";
            label4.Size = new Size(161, 19);
            label4.TabIndex = 32;
            label4.Text = "Ubicación del Paciente:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textUbicacion
            // 
            textUbicacion.Font = new Font("Calibri", 12F);
            textUbicacion.Location = new Point(618, 21);
            textUbicacion.Name = "textUbicacion";
            textUbicacion.Size = new Size(159, 27);
            textUbicacion.TabIndex = 31;
            textUbicacion.TextAlign = HorizontalAlignment.Center;
            // 
            // comboPacientes
            // 
            comboPacientes.Font = new Font("Calibri", 12F);
            comboPacientes.FormattingEnabled = true;
            comboPacientes.Items.AddRange(new object[] { "CARLOS ALBERTO PINET GARZA" });
            comboPacientes.Location = new Point(82, 21);
            comboPacientes.Name = "comboPacientes";
            comboPacientes.Size = new Size(357, 27);
            comboPacientes.TabIndex = 2;
            comboPacientes.SelectedIndexChanged += comboPacientes_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F);
            label5.Location = new Point(10, 25);
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
            buttonCancelar.Location = new Point(12, 416);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(105, 44);
            buttonCancelar.TabIndex = 8;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonSolicitar
            // 
            buttonSolicitar.BackColor = Color.FromArgb(192, 255, 192);
            buttonSolicitar.Font = new Font("Calibri", 12F);
            buttonSolicitar.Location = new Point(667, 416);
            buttonSolicitar.Name = "buttonSolicitar";
            buttonSolicitar.Size = new Size(105, 44);
            buttonSolicitar.TabIndex = 7;
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
            label2.Size = new Size(331, 45);
            label2.TabIndex = 23;
            label2.Text = "Solicitud de Servicios";
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
            // solicitudServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "solicitudServicios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HSM: Solicitud de Servicios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)listaInsumos).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelCedula;
        private Label label8;
        private Label labelMedico;
        private Label label6;
        private Label label4;
        private TextBox textUbicacion;
        private ComboBox comboPacientes;
        private Label label5;
        private Button buttonCancelar;
        private Button buttonSolicitar;
        private Panel panel4;
        private Label label2;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView listaInsumos;
        private TabPage tabPage3;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button6;
        private Button button5;
    }
}