namespace ProtoHSM.Farmacia
{
    partial class devolucion
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
            comboBox1 = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            listaInsumos = new DataGridView();
            buttonAdd = new Button();
            textCantidad = new TextBox();
            label3 = new Label();
            textLote = new TextBox();
            textInsumo = new TextBox();
            label1 = new Label();
            label5 = new Label();
            buttonCancelar = new Button();
            buttonSolicitar = new Button();
            panel4 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            comboPacientesActivos1 = new comboPacientesActivos();
            label7 = new Label();
            textCURP = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listaInsumos).BeginInit();
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
            panel1.Size = new Size(1264, 102);
            panel1.TabIndex = 21;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Calibri", 15.75F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "FARMACIA", "CENDIS", "URGENCIAS" });
            comboBox1.Location = new Point(176, 169);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(218, 34);
            comboBox1.TabIndex = 48;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 15.75F);
            label6.Location = new Point(78, 172);
            label6.Name = "label6";
            label6.Size = new Size(92, 26);
            label6.TabIndex = 47;
            label6.Text = "Almacén:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 15.75F);
            label4.Location = new Point(717, 249);
            label4.Name = "label4";
            label4.Size = new Size(49, 26);
            label4.TabIndex = 45;
            label4.Text = "Lote";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // listaInsumos
            // 
            listaInsumos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaInsumos.Location = new Point(103, 466);
            listaInsumos.Name = "listaInsumos";
            listaInsumos.Size = new Size(814, 216);
            listaInsumos.TabIndex = 44;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.DarkCyan;
            buttonAdd.Font = new Font("Calibri", 15.75F);
            buttonAdd.Location = new Point(808, 267);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(92, 43);
            buttonAdd.TabIndex = 43;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textCantidad
            // 
            textCantidad.Font = new Font("Calibri", 15.75F);
            textCantidad.Location = new Point(90, 277);
            textCantidad.Name = "textCantidad";
            textCantidad.Size = new Size(121, 33);
            textCantidad.TabIndex = 36;
            textCantidad.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 15.75F);
            label3.Location = new Point(114, 249);
            label3.Name = "label3";
            label3.Size = new Size(88, 26);
            label3.TabIndex = 35;
            label3.Text = "Cantidad";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textLote
            // 
            textLote.Font = new Font("Calibri", 15.75F);
            textLote.Location = new Point(682, 277);
            textLote.Name = "textLote";
            textLote.Size = new Size(107, 33);
            textLote.TabIndex = 34;
            textLote.TextAlign = HorizontalAlignment.Center;
            // 
            // textInsumo
            // 
            textInsumo.Font = new Font("Calibri", 15.75F);
            textInsumo.Location = new Point(217, 277);
            textInsumo.Name = "textInsumo";
            textInsumo.Size = new Size(459, 33);
            textInsumo.TabIndex = 34;
            textInsumo.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15.75F);
            label1.Location = new Point(416, 249);
            label1.Name = "label1";
            label1.Size = new Size(75, 26);
            label1.TabIndex = 33;
            label1.Text = "Insumo";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 15.75F);
            label5.Location = new Point(79, 122);
            label5.Name = "label5";
            label5.Size = new Size(91, 26);
            label5.TabIndex = 30;
            label5.Text = "Paciente:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(255, 192, 192);
            buttonCancelar.Font = new Font("Calibri", 12F);
            buttonCancelar.Location = new Point(103, 713);
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
            buttonSolicitar.Location = new Point(811, 713);
            buttonSolicitar.Name = "buttonSolicitar";
            buttonSolicitar.Size = new Size(105, 44);
            buttonSolicitar.TabIndex = 7;
            buttonSolicitar.Text = "Devolver";
            buttonSolicitar.UseVisualStyleBackColor = false;
            buttonSolicitar.Click += buttonSolicitar_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SlateGray;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 92);
            panel4.Name = "panel4";
            panel4.Size = new Size(1264, 10);
            panel4.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 6);
            label2.Name = "label2";
            label2.Size = new Size(505, 78);
            label2.TabIndex = 23;
            label2.Text = "Nueva Devolución";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 84);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // comboPacientesActivos1
            // 
            comboPacientesActivos1.DisplayMember = "Nombre";
            comboPacientesActivos1.DropDownHeight = 92;
            comboPacientesActivos1.Font = new Font("Calibri", 15.75F);
            comboPacientesActivos1.FormattingEnabled = true;
            comboPacientesActivos1.IntegralHeight = false;
            comboPacientesActivos1.Location = new Point(176, 118);
            comboPacientesActivos1.MaxDropDownItems = 5;
            comboPacientesActivos1.Name = "comboPacientesActivos1";
            comboPacientesActivos1.Size = new Size(577, 34);
            comboPacientesActivos1.TabIndex = 49;
            comboPacientesActivos1.ValueMember = "PacienteID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 15.75F);
            label7.Location = new Point(801, 122);
            label7.Name = "label7";
            label7.Size = new Size(64, 26);
            label7.TabIndex = 72;
            label7.Text = "CURP:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textCURP
            // 
            textCURP.BorderStyle = BorderStyle.FixedSingle;
            textCURP.Enabled = false;
            textCURP.Font = new Font("Calibri", 15.75F);
            textCURP.Location = new Point(871, 119);
            textCURP.Name = "textCURP";
            textCURP.Size = new Size(242, 33);
            textCURP.TabIndex = 71;
            textCURP.TextAlign = HorizontalAlignment.Center;
            // 
            // devolucion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 871);
            Controls.Add(label7);
            Controls.Add(textCURP);
            Controls.Add(comboPacientesActivos1);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(listaInsumos);
            Controls.Add(label5);
            Controls.Add(buttonAdd);
            Controls.Add(buttonSolicitar);
            Controls.Add(textCantidad);
            Controls.Add(buttonCancelar);
            Controls.Add(label3);
            Controls.Add(textLote);
            Controls.Add(label1);
            Controls.Add(textInsumo);
            Name = "devolucion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HSM: Nueva Devolución";
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
        private Button buttonAdd;
        private TextBox textCantidad;
        private Label label3;
        private TextBox textInsumo;
        private Label label1;
        private Label label5;
        private Button buttonCancelar;
        private Button buttonSolicitar;
        private Panel panel4;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox textLote;
        private Label label6;
        private ComboBox comboBox1;
        private comboPacientesActivos comboPacientesActivos1;
        private Label label7;
        private TextBox textCURP;
    }
}