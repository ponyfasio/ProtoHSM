namespace ProtoHSM
{
    partial class menuEnfermeria
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
            panel5 = new Panel();
            panel2 = new Panel();
            buttonCamas = new Button();
            buttonServicios = new Button();
            buttonDieta = new Button();
            panel3 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            buttonSolicitud = new Button();
            panel1 = new Panel();
            labelHora = new Label();
            panel4 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabPage8 = new TabPage();
            tabPage7 = new TabPage();
            tabPage3 = new TabPage();
            dataGridView1 = new DataGridView();
            tabControl2 = new TabControl();
            tabPage5 = new TabPage();
            tabPage4 = new TabPage();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            button5 = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tabControl1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl2.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.SlateGray;
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(186, 107);
            panel5.Name = "panel5";
            panel5.Size = new Size(5, 459);
            panel5.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(buttonCamas);
            panel2.Controls.Add(buttonServicios);
            panel2.Controls.Add(buttonDieta);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(buttonSolicitud);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 459);
            panel2.TabIndex = 8;
            // 
            // buttonCamas
            // 
            buttonCamas.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCamas.Image = Properties.Resources.room;
            buttonCamas.Location = new Point(14, 16);
            buttonCamas.Name = "buttonCamas";
            buttonCamas.Size = new Size(149, 74);
            buttonCamas.TabIndex = 8;
            buttonCamas.Text = "Control de Camas";
            buttonCamas.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonCamas.UseVisualStyleBackColor = true;
            buttonCamas.Click += buttonCamas_Click;
            // 
            // buttonServicios
            // 
            buttonServicios.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonServicios.Image = Properties.Resources.servicion36;
            buttonServicios.Location = new Point(14, 248);
            buttonServicios.Name = "buttonServicios";
            buttonServicios.Size = new Size(149, 74);
            buttonServicios.TabIndex = 7;
            buttonServicios.Text = "Solicitud de Servicios";
            buttonServicios.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonServicios.UseVisualStyleBackColor = true;
            buttonServicios.Click += buttonServicios_Click;
            // 
            // buttonDieta
            // 
            buttonDieta.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDieta.Image = Properties.Resources.food;
            buttonDieta.Location = new Point(14, 364);
            buttonDieta.Name = "buttonDieta";
            buttonDieta.Size = new Size(149, 74);
            buttonDieta.TabIndex = 7;
            buttonDieta.Text = "Solicitud de Dieta";
            buttonDieta.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonDieta.UseVisualStyleBackColor = true;
            buttonDieta.Click += buttonDieta_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(tabControl1);
            panel3.Location = new Point(201, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(533, 448);
            panel3.TabIndex = 4;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(171, 92);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(200, 100);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(192, 72);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 72);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonSolicitud
            // 
            buttonSolicitud.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSolicitud.Image = Properties.Resources.solicitud;
            buttonSolicitud.Location = new Point(14, 132);
            buttonSolicitud.Name = "buttonSolicitud";
            buttonSolicitud.Size = new Size(149, 74);
            buttonSolicitud.TabIndex = 6;
            buttonSolicitud.Text = "Solicitud y Entrega de Insumos";
            buttonSolicitud.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonSolicitud.UseVisualStyleBackColor = true;
            buttonSolicitud.Click += buttonSolicitud_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(labelHora);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(754, 107);
            panel1.TabIndex = 7;
            // 
            // labelHora
            // 
            labelHora.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHora.ForeColor = Color.FromArgb(192, 0, 0);
            labelHora.Location = new Point(537, 26);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(110, 45);
            labelHora.TabIndex = 7;
            labelHora.Text = "23:59";
            // 
            // panel4
            // 
            panel4.BackColor = Color.SlateGray;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 102);
            panel4.Name = "panel4";
            panel4.Size = new Size(754, 5);
            panel4.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(110, 12);
            label2.Name = "label2";
            label2.Size = new Size(185, 45);
            label2.TabIndex = 2;
            label2.Text = "Enfermeria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(110, 57);
            label1.Name = "label1";
            label1.Size = new Size(253, 39);
            label1.TabIndex = 1;
            label1.Text = "Gabriela Caballero";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(31, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 84);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabPage8
            // 
            tabPage8.Location = new Point(4, 28);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(503, 394);
            tabPage8.TabIndex = 5;
            tabPage8.Text = "Habitaciones";
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(4, 28);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(503, 394);
            tabPage7.TabIndex = 4;
            tabPage7.Text = "Pacientes Activos";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.Location = new Point(4, 28);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(503, 394);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Extensiones";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 16);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(497, 363);
            dataGridView1.TabIndex = 1;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage8);
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage5);
            tabControl2.Controls.Add(tabPage7);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl2.Location = new Point(223, 123);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(511, 426);
            tabControl2.TabIndex = 9;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 28);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(503, 394);
            tabPage5.TabIndex = 7;
            tabPage5.Text = "Medicos";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.Transparent;
            tabPage4.BackgroundImageLayout = ImageLayout.None;
            tabPage4.Controls.Add(textBox2);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(textBox1);
            tabPage4.Controls.Add(label4);
            tabPage4.Controls.Add(label3);
            tabPage4.Location = new Point(4, 28);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(503, 394);
            tabPage4.TabIndex = 6;
            tabPage4.Text = "Medicamento";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(250, 39);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 27);
            textBox2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(323, 17);
            label5.Name = "label5";
            label5.Size = new Size(37, 19);
            label5.TabIndex = 8;
            label5.Text = "Tipo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 27);
            textBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 17);
            label4.Name = "label4";
            label4.Size = new Size(60, 19);
            label4.TabIndex = 6;
            label4.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 19);
            label3.TabIndex = 5;
            label3.Text = "Filtar por:";
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources.respaldo;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Location = new Point(653, 26);
            button5.Name = "button5";
            button5.Size = new Size(44, 45);
            button5.TabIndex = 9;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // menuEnfermeria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 566);
            Controls.Add(panel5);
            Controls.Add(tabControl2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "menuEnfermeria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HSM: Enfermeria";
            Load += menuEnfermeria_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl2.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Panel panel2;
        private Button buttonDieta;
        private Panel panel3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button buttonSolicitud;
        private Panel panel1;
        private Panel panel4;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private TabPage tabPage8;
        private TabPage tabPage7;
        private TabPage tabPage3;
        private DataGridView dataGridView1;
        private TabControl tabControl2;
        private Button buttonServicios;
        private TabPage tabPage4;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private TabPage tabPage5;
        private Button buttonCamas;
        private Label labelHora;
        private Button button5;
    }
}