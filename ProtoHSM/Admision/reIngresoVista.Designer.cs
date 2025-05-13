namespace ProtoHSM.Admision
{
    partial class reIngresoVista
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
            comboPaciente = new PacienteSearchComboBox();
            label3 = new Label();
            textCURP = new TextBox();
            label4 = new Label();
            label1 = new Label();
            buttonCancelar = new Button();
            buttonOK = new Button();
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
            panel1.Size = new Size(975, 118);
            panel1.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SlateGray;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 108);
            panel4.Name = "panel4";
            panel4.Size = new Size(975, 10);
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
            label2.Size = new Size(166, 45);
            label2.TabIndex = 14;
            label2.Text = "Reingreso";
            // 
            // comboPaciente
            // 
            comboPaciente.DisplayMember = "Nombre";
            comboPaciente.DropDownHeight = 92;
            comboPaciente.Font = new Font("Calibri", 14.25F);
            comboPaciente.FormattingEnabled = true;
            comboPaciente.IntegralHeight = false;
            comboPaciente.Location = new Point(102, 206);
            comboPaciente.MaxDropDownItems = 5;
            comboPaciente.Name = "comboPaciente";
            comboPaciente.Size = new Size(526, 31);
            comboPaciente.TabIndex = 80;
            comboPaciente.ValueMember = "PacienteID";
            comboPaciente.SelectionChangeCommitted += comboPaciente_SelectionChangeCommitted;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F);
            label3.Location = new Point(646, 209);
            label3.Name = "label3";
            label3.Size = new Size(57, 23);
            label3.TabIndex = 78;
            label3.Text = "CURP:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textCURP
            // 
            textCURP.BorderStyle = BorderStyle.FixedSingle;
            textCURP.Enabled = false;
            textCURP.Font = new Font("Calibri", 14.25F);
            textCURP.Location = new Point(711, 205);
            textCURP.Name = "textCURP";
            textCURP.Size = new Size(242, 31);
            textCURP.TabIndex = 77;
            textCURP.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F);
            label4.Location = new Point(14, 207);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 75;
            label4.Text = "Paciente:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(226, 146);
            label1.Name = "label1";
            label1.Size = new Size(557, 23);
            label1.TabIndex = 81;
            label1.Text = "Ingresa el nombre del Paciente y confimalo con su CURP para continuar";
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(255, 192, 192);
            buttonCancelar.Font = new Font("Calibri", 14.25F);
            buttonCancelar.Location = new Point(13, 415);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(132, 75);
            buttonCancelar.TabIndex = 83;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonOK
            // 
            buttonOK.BackColor = Color.FromArgb(192, 255, 192);
            buttonOK.Font = new Font("Calibri", 14.25F);
            buttonOK.Location = new Point(831, 417);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(132, 75);
            buttonOK.TabIndex = 82;
            buttonOK.Text = "Buscar";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_Click_1;
            // 
            // reIngresoVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 504);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonOK);
            Controls.Add(label1);
            Controls.Add(comboPaciente);
            Controls.Add(label3);
            Controls.Add(textCURP);
            Controls.Add(label4);
            Controls.Add(panel1);
            Name = "reIngresoVista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HSM: Reingreso";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label label2;
        private PacienteSearchComboBox comboPaciente;
        private Label label3;
        private TextBox textCURP;
        private Label label4;
        private Label label1;
        private Button buttonCancelar;
        private Button buttonOK;
    }
}