namespace ProtoHSM
{
    partial class admisionMenu
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel2 = new Panel();
            buttonConsulta = new Button();
            buttonUrgencia = new Button();
            buttonIngreso = new Button();
            panel3 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            button2 = new Button();
            buttonNuevoPaciente = new Button();
            panel1 = new Panel();
            buttonUpdate = new Button();
            labelHora = new Label();
            panel4 = new Panel();
            labelDepto = new Label();
            labelUsername = new Label();
            pictureBox1 = new PictureBox();
            tabControl2 = new TabControl();
            tabPage7 = new TabPage();
            tabPage3 = new TabPage();
            gridMedicos = new DataGridView();
            label3 = new Label();
            tabPage6 = new TabPage();
            gridExtensiones = new DataGridView();
            tabPage5 = new TabPage();
            gridPaquetes = new DataGridView();
            tabPage4 = new TabPage();
            tabPage8 = new TabPage();
            panel5 = new Panel();
            Precio = new DataGridViewTextBoxColumn();
            Paquete = new DataGridViewTextBoxColumn();
            gridPacientes = new DataGridView();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tabControl1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl2.SuspendLayout();
            tabPage7.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridMedicos).BeginInit();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridExtensiones).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPaquetes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridPacientes).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(buttonConsulta);
            panel2.Controls.Add(buttonUrgencia);
            panel2.Controls.Add(buttonIngreso);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(buttonNuevoPaciente);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(205, 878);
            panel2.TabIndex = 3;
            // 
            // buttonConsulta
            // 
            buttonConsulta.Font = new Font("Calibri", 18F);
            buttonConsulta.Image = Properties.Resources.consultaBlanco;
            buttonConsulta.Location = new Point(11, 364);
            buttonConsulta.Name = "buttonConsulta";
            buttonConsulta.Size = new Size(180, 140);
            buttonConsulta.TabIndex = 7;
            buttonConsulta.Text = "Nueva Consulta";
            buttonConsulta.TextAlign = ContentAlignment.BottomCenter;
            buttonConsulta.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonConsulta.UseVisualStyleBackColor = true;
            buttonConsulta.Click += button4_Click;
            buttonConsulta.MouseEnter += buttonConsulta_MouseEnter;
            buttonConsulta.MouseLeave += buttonConsulta_MouseLeave;
            // 
            // buttonUrgencia
            // 
            buttonUrgencia.Font = new Font("Calibri", 18F);
            buttonUrgencia.Image = Properties.Resources.urgenciaBlanco;
            buttonUrgencia.Location = new Point(9, 722);
            buttonUrgencia.Name = "buttonUrgencia";
            buttonUrgencia.Size = new Size(180, 140);
            buttonUrgencia.TabIndex = 7;
            buttonUrgencia.Text = "Nueva Urgencia";
            buttonUrgencia.TextAlign = ContentAlignment.BottomCenter;
            buttonUrgencia.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonUrgencia.UseVisualStyleBackColor = true;
            buttonUrgencia.Click += buttonUrgencia_Click;
            buttonUrgencia.MouseEnter += buttonUrgencia_MouseEnter;
            buttonUrgencia.MouseLeave += buttonUrgencia_MouseLeave;
            // 
            // buttonIngreso
            // 
            buttonIngreso.Font = new Font("Calibri", 18F);
            buttonIngreso.Image = Properties.Resources.hospitalBlanco;
            buttonIngreso.Location = new Point(11, 543);
            buttonIngreso.Name = "buttonIngreso";
            buttonIngreso.Size = new Size(180, 140);
            buttonIngreso.TabIndex = 7;
            buttonIngreso.Text = "Nuevo Ingreso";
            buttonIngreso.TextAlign = ContentAlignment.BottomCenter;
            buttonIngreso.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonIngreso.UseVisualStyleBackColor = true;
            buttonIngreso.Click += buttonIngreso_Click;
            buttonIngreso.MouseEnter += buttonIngreso_MouseEnter;
            buttonIngreso.MouseLeave += buttonIngreso_MouseLeave;
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
            // button2
            // 
            button2.Font = new Font("Calibri", 18F);
            button2.Image = Properties.Resources.doctorBlanco60;
            button2.Location = new Point(13, 185);
            button2.Name = "button2";
            button2.Padding = new Padding(3);
            button2.Size = new Size(180, 140);
            button2.TabIndex = 6;
            button2.Text = "Nuevo Médico";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.MouseEnter += button2_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;
            // 
            // buttonNuevoPaciente
            // 
            buttonNuevoPaciente.Font = new Font("Calibri", 18F);
            buttonNuevoPaciente.Image = Properties.Resources.pacienteBlanco60;
            buttonNuevoPaciente.Location = new Point(13, 6);
            buttonNuevoPaciente.Name = "buttonNuevoPaciente";
            buttonNuevoPaciente.Size = new Size(180, 140);
            buttonNuevoPaciente.TabIndex = 6;
            buttonNuevoPaciente.Text = "Nuevo Paciente";
            buttonNuevoPaciente.TextAlign = ContentAlignment.BottomCenter;
            buttonNuevoPaciente.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonNuevoPaciente.UseVisualStyleBackColor = true;
            buttonNuevoPaciente.Click += button1_Click;
            buttonNuevoPaciente.MouseEnter += button1_MouseEnter;
            buttonNuevoPaciente.MouseLeave += button1_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(buttonUpdate);
            panel1.Controls.Add(labelHora);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(labelDepto);
            panel1.Controls.Add(labelUsername);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1904, 107);
            panel1.TabIndex = 2;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.Transparent;
            buttonUpdate.BackgroundImage = Properties.Resources.respaldo;
            buttonUpdate.BackgroundImageLayout = ImageLayout.Zoom;
            buttonUpdate.FlatAppearance.BorderColor = Color.White;
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.Location = new Point(1811, 13);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(66, 72);
            buttonUpdate.TabIndex = 8;
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // labelHora
            // 
            labelHora.Font = new Font("Calibri", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHora.ForeColor = Color.FromArgb(192, 0, 0);
            labelHora.Location = new Point(1646, 21);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(135, 64);
            labelHora.TabIndex = 7;
            labelHora.Text = "23:59";
            // 
            // panel4
            // 
            panel4.BackColor = Color.SlateGray;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 102);
            panel4.Name = "panel4";
            panel4.Size = new Size(1904, 5);
            panel4.TabIndex = 5;
            // 
            // labelDepto
            // 
            labelDepto.AutoSize = true;
            labelDepto.Font = new Font("Calibri", 48F);
            labelDepto.Location = new Point(82, 13);
            labelDepto.Name = "labelDepto";
            labelDepto.Size = new Size(278, 78);
            labelDepto.TabIndex = 2;
            labelDepto.Text = "Admisión";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Calibri", 48F);
            labelUsername.Location = new Point(837, 13);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(457, 78);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Lubeth Quezada";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(9, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 84);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage7);
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage6);
            tabControl2.Controls.Add(tabPage5);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Controls.Add(tabPage8);
            tabControl2.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl2.Location = new Point(216, 113);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(1677, 864);
            tabControl2.TabIndex = 4;
            // 
            // tabPage7
            // 
            tabPage7.BackColor = SystemColors.ActiveCaption;
            tabPage7.Controls.Add(gridPacientes);
            tabPage7.Location = new Point(4, 38);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(1669, 822);
            tabPage7.TabIndex = 4;
            tabPage7.Text = "Censo Hospitalario";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.ActiveCaption;
            tabPage3.Controls.Add(gridMedicos);
            tabPage3.Controls.Add(label3);
            tabPage3.Location = new Point(4, 38);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1669, 822);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Médicos";
            // 
            // gridMedicos
            // 
            gridMedicos.AllowUserToAddRows = false;
            gridMedicos.AllowUserToDeleteRows = false;
            gridMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridMedicos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridMedicos.BackgroundColor = SystemColors.ActiveCaption;
            gridMedicos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle5.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.MidnightBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            gridMedicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            gridMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            gridMedicos.DefaultCellStyle = dataGridViewCellStyle6;
            gridMedicos.Dock = DockStyle.Fill;
            gridMedicos.EnableHeadersVisualStyles = false;
            gridMedicos.Location = new Point(3, 3);
            gridMedicos.MultiSelect = false;
            gridMedicos.Name = "gridMedicos";
            gridMedicos.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.MidnightBlue;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            gridMedicos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            gridMedicos.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gridMedicos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            gridMedicos.ScrollBars = ScrollBars.Vertical;
            gridMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridMedicos.Size = new Size(1663, 816);
            gridMedicos.TabIndex = 1;
            // 
            // label3
            // 
            label3.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 3);
            label3.Name = "label3";
            label3.Size = new Size(1139, 812);
            label3.TabIndex = 2;
            label3.Text = "Médicos";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // tabPage6
            // 
            tabPage6.BackColor = SystemColors.ActiveCaption;
            tabPage6.Controls.Add(gridExtensiones);
            tabPage6.Location = new Point(4, 38);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1669, 822);
            tabPage6.TabIndex = 7;
            tabPage6.Text = "Extensiones y Contactos";
            // 
            // gridExtensiones
            // 
            gridExtensiones.AllowUserToAddRows = false;
            gridExtensiones.AllowUserToDeleteRows = false;
            gridExtensiones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridExtensiones.BackgroundColor = SystemColors.ActiveCaption;
            gridExtensiones.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle9.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.MidnightBlue;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            gridExtensiones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            gridExtensiones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            gridExtensiones.DefaultCellStyle = dataGridViewCellStyle10;
            gridExtensiones.Dock = DockStyle.Fill;
            gridExtensiones.EnableHeadersVisualStyles = false;
            gridExtensiones.Location = new Point(0, 0);
            gridExtensiones.MultiSelect = false;
            gridExtensiones.Name = "gridExtensiones";
            gridExtensiones.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = Color.MidnightBlue;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            gridExtensiones.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            gridExtensiones.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gridExtensiones.RowsDefaultCellStyle = dataGridViewCellStyle12;
            gridExtensiones.ScrollBars = ScrollBars.Vertical;
            gridExtensiones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridExtensiones.Size = new Size(1669, 822);
            gridExtensiones.TabIndex = 2;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = SystemColors.ActiveCaption;
            tabPage5.Controls.Add(gridPaquetes);
            tabPage5.Location = new Point(4, 38);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1669, 822);
            tabPage5.TabIndex = 6;
            tabPage5.Text = "Paquetes";
            // 
            // gridPaquetes
            // 
            gridPaquetes.AllowUserToAddRows = false;
            gridPaquetes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = Color.WhiteSmoke;
            gridPaquetes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            gridPaquetes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridPaquetes.BackgroundColor = SystemColors.ActiveCaption;
            gridPaquetes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle14.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.SelectionBackColor = Color.MidnightBlue;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            gridPaquetes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            gridPaquetes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = SystemColors.Window;
            dataGridViewCellStyle15.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle15.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = Color.White;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            gridPaquetes.DefaultCellStyle = dataGridViewCellStyle15;
            gridPaquetes.Dock = DockStyle.Fill;
            gridPaquetes.EnableHeadersVisualStyles = false;
            gridPaquetes.Location = new Point(0, 0);
            gridPaquetes.MultiSelect = false;
            gridPaquetes.Name = "gridPaquetes";
            gridPaquetes.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = SystemColors.Control;
            dataGridViewCellStyle16.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle16.ForeColor = Color.White;
            dataGridViewCellStyle16.SelectionBackColor = Color.MidnightBlue;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            gridPaquetes.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            gridPaquetes.RowHeadersVisible = false;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gridPaquetes.RowsDefaultCellStyle = dataGridViewCellStyle17;
            gridPaquetes.ScrollBars = ScrollBars.Vertical;
            gridPaquetes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridPaquetes.Size = new Size(1669, 822);
            gridPaquetes.TabIndex = 2;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = SystemColors.ActiveCaption;
            tabPage4.Location = new Point(4, 38);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1669, 822);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Servicios";
            // 
            // tabPage8
            // 
            tabPage8.BackColor = SystemColors.ActiveCaption;
            tabPage8.Location = new Point(4, 38);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(1669, 822);
            tabPage8.TabIndex = 5;
            tabPage8.Text = "Agenda QX";
            // 
            // panel5
            // 
            panel5.BackColor = Color.SlateGray;
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(205, 107);
            panel5.Name = "panel5";
            panel5.Size = new Size(5, 878);
            panel5.TabIndex = 6;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // Paquete
            // 
            Paquete.HeaderText = "Paquete";
            Paquete.Name = "Paquete";
            // 
            // gridPacientes
            // 
            gridPacientes.AllowUserToAddRows = false;
            gridPacientes.AllowUserToDeleteRows = false;
            gridPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridPacientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridPacientes.BackgroundColor = SystemColors.ActiveCaption;
            gridPacientes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridPacientes.DefaultCellStyle = dataGridViewCellStyle2;
            gridPacientes.Dock = DockStyle.Fill;
            gridPacientes.EnableHeadersVisualStyles = false;
            gridPacientes.Location = new Point(0, 0);
            gridPacientes.MultiSelect = false;
            gridPacientes.Name = "gridPacientes";
            gridPacientes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridPacientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gridPacientes.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gridPacientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            gridPacientes.ScrollBars = ScrollBars.Vertical;
            gridPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridPacientes.Size = new Size(1669, 822);
            gridPacientes.TabIndex = 2;
            // 
            // admisionMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1904, 985);
            Controls.Add(panel5);
            Controls.Add(tabControl2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "admisionMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HSM: Admision";
            Load += admisionMenu_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl2.ResumeLayout(false);
            tabPage7.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridMedicos).EndInit();
            tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridExtensiones).EndInit();
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridPaquetes).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridPacientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button buttonNuevoPaciente;
        private Panel panel3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabControl tabControl2;
        private Button buttonConsulta;
        private Button buttonIngreso;
        private Button button2;
        private Panel panel4;
        private Panel panel5;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Paquete;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private Label labelHora;
        private Button buttonUpdate;
        private Button buttonUrgencia;
        private DataGridView gridExtensiones;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private DataGridView gridMedicos;
        private TabPage tabPage5;
        private Label label3;
        private DataGridView gridPaquetes;
        private TabPage tabPage6;
        private Label labelDepto;
        private Label labelUsername;
        private DataGridView gridPacientes;
    }
}