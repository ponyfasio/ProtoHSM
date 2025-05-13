namespace ProtoHSM.Enfermeria
{
    partial class entregaInsumos
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
            buttonAdd = new Button();
            lblcedula = new Label();
            label8 = new Label();
            lblMedico = new Label();
            label6 = new Label();
            textCantidad = new TextBox();
            label3 = new Label();
            textInsumo = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)listaInsumos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(listaInsumos);
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(lblcedula);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lblMedico);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textCantidad);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textInsumo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textUbicacion);
            panel1.Controls.Add(comboPacientes);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(buttonCancelar);
            panel1.Controls.Add(buttonSolicitar);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(789, 496);
            panel1.TabIndex = 18;
            // 
            // listaInsumos
            // 
            listaInsumos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaInsumos.Location = new Point(12, 191);
            listaInsumos.Name = "listaInsumos";
            listaInsumos.Size = new Size(765, 216);
            listaInsumos.TabIndex = 44;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.DarkCyan;
            buttonAdd.Font = new Font("Marlett", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(618, 136);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(156, 34);
            buttonAdd.TabIndex = 43;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // lblcedula
            // 
            lblcedula.BorderStyle = BorderStyle.FixedSingle;
            lblcedula.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcedula.ForeColor = Color.Blue;
            lblcedula.Location = new Point(618, 55);
            lblcedula.Name = "lblcedula";
            lblcedula.Size = new Size(159, 29);
            lblcedula.TabIndex = 41;
            lblcedula.TextAlign = ContentAlignment.MiddleCenter;
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
            // lblMedico
            // 
            lblMedico.BorderStyle = BorderStyle.FixedSingle;
            lblMedico.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMedico.ForeColor = Color.Blue;
            lblMedico.Location = new Point(135, 55);
            lblMedico.Name = "lblMedico";
            lblMedico.Size = new Size(304, 29);
            lblMedico.TabIndex = 39;
            lblMedico.TextAlign = ContentAlignment.MiddleCenter;
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
            // textCantidad
            // 
            textCantidad.Font = new Font("Calibri", 12F);
            textCantidad.Location = new Point(12, 140);
            textCantidad.Name = "textCantidad";
            textCantidad.Size = new Size(121, 27);
            textCantidad.TabIndex = 36;
            textCantidad.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F);
            label3.Location = new Point(36, 112);
            label3.Name = "label3";
            label3.Size = new Size(67, 19);
            label3.TabIndex = 35;
            label3.Text = "Cantidad";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textInsumo
            // 
            textInsumo.Font = new Font("Calibri", 12F);
            textInsumo.Location = new Point(142, 140);
            textInsumo.Name = "textInsumo";
            textInsumo.Size = new Size(459, 27);
            textInsumo.TabIndex = 34;
            textInsumo.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F);
            label1.Location = new Point(341, 112);
            label1.Name = "label1";
            label1.Size = new Size(56, 19);
            label1.TabIndex = 33;
            label1.Text = "Insumo";
            label1.TextAlign = ContentAlignment.MiddleRight;
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
            textUbicacion.TabIndex = 2;
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
            comboPacientes.TabIndex = 1;
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
            buttonCancelar.Location = new Point(12, 438);
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
            buttonSolicitar.Location = new Point(672, 438);
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
            panel4.Size = new Size(789, 10);
            panel4.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 25);
            label2.Name = "label2";
            label2.Size = new Size(325, 45);
            label2.TabIndex = 20;
            label2.Text = "Solicitud de Insumos";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 84);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // solicitudInsumos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 592);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "solicitudInsumos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HSM: Solicitud de Insumos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)listaInsumos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox comboPacientes;
        private Label label5;
        private Button buttonCancelar;
        private Button buttonSolicitar;
        private Panel panel4;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox textUbicacion;
        private TextBox textCantidad;
        private Label label3;
        private TextBox textInsumo;
        private Label label1;
        private Label lblMedico;
        private Label label6;
        private Label lblcedula;
        private Label label8;
        private Button buttonAdd;
        private DataGridView listaInsumos;
    }
}