namespace ProtoHSM.Farmacia
{
    partial class vistaEntrega
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
            labelPaciente = new Label();
            listaInsumos = new DataGridView();
            labelCedula = new Label();
            label8 = new Label();
            labelMedico = new Label();
            label6 = new Label();
            label4 = new Label();
            textUbicacion = new TextBox();
            label5 = new Label();
            buttonCancelar = new Button();
            buttonEntregar = new Button();
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
            panel1.Controls.Add(labelPaciente);
            panel1.Controls.Add(listaInsumos);
            panel1.Controls.Add(labelCedula);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(labelMedico);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textUbicacion);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(buttonCancelar);
            panel1.Controls.Add(buttonEntregar);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 564);
            panel1.TabIndex = 21;
            // 
            // labelPaciente
            // 
            labelPaciente.BorderStyle = BorderStyle.FixedSingle;
            labelPaciente.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPaciente.ForeColor = Color.Blue;
            labelPaciente.Location = new Point(135, 21);
            labelPaciente.Name = "labelPaciente";
            labelPaciente.Size = new Size(304, 29);
            labelPaciente.TabIndex = 45;
            labelPaciente.Text = "labelPaciente";
            labelPaciente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listaInsumos
            // 
            listaInsumos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaInsumos.Location = new Point(12, 107);
            listaInsumos.Name = "listaInsumos";
            listaInsumos.Size = new Size(765, 300);
            listaInsumos.TabIndex = 44;
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
            labelCedula.Text = "labelCedula";
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
            labelMedico.Text = "labelMedico";
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
            textUbicacion.TabIndex = 2;
            textUbicacion.Text = "textUbicacion";
            textUbicacion.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F);
            label5.Location = new Point(60, 25);
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
            // 
            // buttonEntregar
            // 
            buttonEntregar.BackColor = Color.FromArgb(192, 255, 192);
            buttonEntregar.Font = new Font("Calibri", 12F);
            buttonEntregar.Location = new Point(672, 438);
            buttonEntregar.Name = "buttonEntregar";
            buttonEntregar.Size = new Size(105, 44);
            buttonEntregar.TabIndex = 7;
            buttonEntregar.Text = "Entregar";
            buttonEntregar.UseVisualStyleBackColor = false;
            buttonEntregar.Click += buttonEntregar_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SlateGray;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(984, 10);
            panel4.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 23);
            label2.Name = "label2";
            label2.Size = new Size(312, 45);
            label2.TabIndex = 23;
            label2.Text = "Entrega de Insumos";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(8, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 84);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // vistaEntrega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "vistaEntrega";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "vistaEntrega";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)listaInsumos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView listaInsumos;
        private Label labelCedula;
        private Label label8;
        private Label labelMedico;
        private Label label6;
        private Label label4;
        private TextBox textUbicacion;
        private Label label5;
        private Button buttonCancelar;
        private Button buttonEntregar;
        private Panel panel4;
        private Label label2;
        private PictureBox pictureBox1;
        private Label labelPaciente;
    }
}