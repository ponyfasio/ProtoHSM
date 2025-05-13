namespace ProtoHSM
{
    partial class nuevoMedicocs
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
            label2 = new Label();
            pictureBox1 = new PictureBox();
            buttonCancelar = new Button();
            buttonAgregar = new Button();
            label7 = new Label();
            textEspecialidades = new TextBox();
            label4 = new Label();
            textCedula = new TextBox();
            label1 = new Label();
            textNombre = new TextBox();
            panel4 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            textTel = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(91, 31);
            label2.Name = "label2";
            label2.Size = new Size(239, 45);
            label2.TabIndex = 11;
            label2.Text = "Nuevo Médico";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 84);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(255, 192, 192);
            buttonCancelar.Font = new Font("Calibri", 18F);
            buttonCancelar.Location = new Point(16, 481);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(163, 68);
            buttonCancelar.TabIndex = 6;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.FromArgb(192, 255, 192);
            buttonAgregar.Font = new Font("Calibri", 18F);
            buttonAgregar.Location = new Point(609, 481);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(163, 68);
            buttonAgregar.TabIndex = 5;
            buttonAgregar.Text = "Agregar Médico";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 18F);
            label7.Location = new Point(39, 336);
            label7.Name = "label7";
            label7.Size = new Size(164, 29);
            label7.TabIndex = 29;
            label7.Text = "Especialidades:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textEspecialidades
            // 
            textEspecialidades.Font = new Font("Calibri", 18F);
            textEspecialidades.Location = new Point(209, 336);
            textEspecialidades.Multiline = true;
            textEspecialidades.Name = "textEspecialidades";
            textEspecialidades.Size = new Size(456, 81);
            textEspecialidades.TabIndex = 4;
            textEspecialidades.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 18F);
            label4.Location = new Point(115, 168);
            label4.Name = "label4";
            label4.Size = new Size(88, 29);
            label4.TabIndex = 28;
            label4.Text = "Cedula:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textCedula
            // 
            textCedula.Font = new Font("Calibri", 18F);
            textCedula.Location = new Point(209, 168);
            textCedula.Name = "textCedula";
            textCedula.Size = new Size(177, 37);
            textCedula.TabIndex = 1;
            textCedula.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F);
            label1.Location = new Point(103, 222);
            label1.Name = "label1";
            label1.Size = new Size(100, 29);
            label1.TabIndex = 27;
            label1.Text = "Nombre:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textNombre
            // 
            textNombre.Font = new Font("Calibri", 18F);
            textNombre.Location = new Point(209, 222);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(456, 37);
            textNombre.TabIndex = 2;
            textNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(784, 112);
            panel4.TabIndex = 30;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 10);
            panel2.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 18F);
            label3.Location = new Point(98, 277);
            label3.Name = "label3";
            label3.Size = new Size(104, 29);
            label3.TabIndex = 32;
            label3.Text = "Telefono:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textTel
            // 
            textTel.Font = new Font("Calibri", 18F);
            textTel.Location = new Point(209, 277);
            textTel.Name = "textTel";
            textTel.Size = new Size(456, 37);
            textTel.TabIndex = 3;
            textTel.TextAlign = HorizontalAlignment.Center;
            // 
            // nuevoMedicocs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(label3);
            Controls.Add(textTel);
            Controls.Add(panel4);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonAgregar);
            Controls.Add(label7);
            Controls.Add(textEspecialidades);
            Controls.Add(label4);
            Controls.Add(textCedula);
            Controls.Add(label1);
            Controls.Add(textNombre);
            Name = "nuevoMedicocs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HSM: Nuevo Médico";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private PictureBox pictureBox1;
        private Button buttonCancelar;
        private Button buttonAgregar;
        private Label label7;
        private TextBox textEspecialidades;
        private Label label4;
        private TextBox textCedula;
        private Label label1;
        private TextBox textNombre;
        private Panel panel4;
        private Panel panel2;
        private Label label3;
        private TextBox textTel;
    }
}