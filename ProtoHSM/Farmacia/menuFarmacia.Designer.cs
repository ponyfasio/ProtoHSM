namespace ProtoHSM.Farmacia
{
    partial class menuFarmacia
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button5 = new Button();
            labelHora = new Label();
            panel5 = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            gridPendientes = new DataGridView();
            tabPage2 = new TabPage();
            tabPage8 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            buttonCancelar = new Button();
            panel2 = new Panel();
            buttonCompra = new Button();
            buttonRequisicion = new Button();
            buttonTraslado = new Button();
            buttonDevolucion = new Button();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPendientes).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(110, 6);
            label2.Name = "label2";
            label2.Size = new Size(185, 45);
            label2.TabIndex = 8;
            label2.Text = "Enfermeria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(110, 51);
            label1.Name = "label1";
            label1.Size = new Size(253, 39);
            label1.TabIndex = 7;
            label1.Text = "Gabriela Caballero";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(31, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 84);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(labelHora);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1784, 107);
            panel1.TabIndex = 10;
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources.respaldo;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Location = new Point(1713, 30);
            button5.Name = "button5";
            button5.Size = new Size(44, 45);
            button5.TabIndex = 9;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // labelHora
            // 
            labelHora.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHora.ForeColor = Color.FromArgb(192, 0, 0);
            labelHora.Location = new Point(1526, 30);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(108, 45);
            labelHora.TabIndex = 6;
            labelHora.Text = "23:59";
            // 
            // panel5
            // 
            panel5.BackColor = Color.SlateGray;
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 102);
            panel5.Name = "panel5";
            panel5.Size = new Size(1784, 5);
            panel5.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(104, 12);
            label3.Name = "label3";
            label3.Size = new Size(280, 82);
            label3.TabIndex = 2;
            label3.Text = "Farmacia";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.Logo;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(31, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 84);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage8);
            tabControl.Controls.Add(tabPage3);
            tabControl.Controls.Add(tabPage4);
            tabControl.Controls.Add(tabPage5);
            tabControl.Controls.Add(tabPage6);
            tabControl.Controls.Add(tabPage7);
            tabControl.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl.Location = new Point(215, 107);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1569, 854);
            tabControl.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(gridPendientes);
            tabPage1.Location = new Point(4, 35);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1561, 815);
            tabPage1.TabIndex = 8;
            tabPage1.Text = "Solicitudes Pendientes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridPendientes
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridPendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gridPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPendientes.Dock = DockStyle.Fill;
            gridPendientes.EnableHeadersVisualStyles = false;
            gridPendientes.Location = new Point(0, 0);
            gridPendientes.MultiSelect = false;
            gridPendientes.Name = "gridPendientes";
            gridPendientes.RowHeadersVisible = false;
            gridPendientes.Size = new Size(1561, 815);
            gridPendientes.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 35);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1536, 809);
            tabPage2.TabIndex = 9;
            tabPage2.Text = "Solicitudes Entregadas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            tabPage8.Location = new Point(4, 35);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(1536, 809);
            tabPage8.TabIndex = 11;
            tabPage8.Text = "Requisiciones";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 35);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1536, 809);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Compras";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.Transparent;
            tabPage4.BackgroundImageLayout = ImageLayout.None;
            tabPage4.Location = new Point(4, 35);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1536, 809);
            tabPage4.TabIndex = 6;
            tabPage4.Text = "Inventario General";
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 35);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1536, 809);
            tabPage5.TabIndex = 7;
            tabPage5.Text = "Farmacia";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 35);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1536, 809);
            tabPage6.TabIndex = 10;
            tabPage6.Text = "CENDIS";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(4, 35);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(1536, 809);
            tabPage7.TabIndex = 4;
            tabPage7.Text = "Almacén";
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(255, 192, 192);
            buttonCancelar.Font = new Font("Calibri", 12F);
            buttonCancelar.Location = new Point(0, 715);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(105, 44);
            buttonCancelar.TabIndex = 13;
            buttonCancelar.Text = "Salir";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonCompra);
            panel2.Controls.Add(buttonRequisicion);
            panel2.Controls.Add(buttonTraslado);
            panel2.Controls.Add(buttonDevolucion);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(217, 854);
            panel2.TabIndex = 14;
            // 
            // buttonCompra
            // 
            buttonCompra.Font = new Font("Calibri", 14.25F);
            buttonCompra.Image = Properties.Resources.verificar;
            buttonCompra.Location = new Point(20, 458);
            buttonCompra.Name = "buttonCompra";
            buttonCompra.Size = new Size(175, 135);
            buttonCompra.TabIndex = 10;
            buttonCompra.Text = "Nueva Orden de Compra";
            buttonCompra.TextAlign = ContentAlignment.BottomCenter;
            buttonCompra.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonCompra.UseVisualStyleBackColor = true;
            buttonCompra.Click += buttonCompra_Click;
            // 
            // buttonRequisicion
            // 
            buttonRequisicion.Font = new Font("Calibri", 14.25F);
            buttonRequisicion.Image = Properties.Resources.portapapeles;
            buttonRequisicion.Location = new Point(20, 245);
            buttonRequisicion.Name = "buttonRequisicion";
            buttonRequisicion.Size = new Size(175, 135);
            buttonRequisicion.TabIndex = 10;
            buttonRequisicion.Text = "    Nueva      Requisicion";
            buttonRequisicion.TextAlign = ContentAlignment.BottomCenter;
            buttonRequisicion.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonRequisicion.UseVisualStyleBackColor = true;
            buttonRequisicion.Click += buttonRequisicion_Click;
            // 
            // buttonTraslado
            // 
            buttonTraslado.Font = new Font("Calibri", 14.25F);
            buttonTraslado.Image = Properties.Resources.logistica;
            buttonTraslado.Location = new Point(20, 671);
            buttonTraslado.Name = "buttonTraslado";
            buttonTraslado.Size = new Size(175, 135);
            buttonTraslado.TabIndex = 9;
            buttonTraslado.Text = "Traslado de Inventarios";
            buttonTraslado.TextAlign = ContentAlignment.BottomCenter;
            buttonTraslado.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonTraslado.UseVisualStyleBackColor = true;
            buttonTraslado.Click += buttonTraslado_Click;
            // 
            // buttonDevolucion
            // 
            buttonDevolucion.Font = new Font("Calibri", 14.25F);
            buttonDevolucion.Image = Properties.Resources.devolucion_de_producto;
            buttonDevolucion.Location = new Point(20, 32);
            buttonDevolucion.Name = "buttonDevolucion";
            buttonDevolucion.Size = new Size(175, 135);
            buttonDevolucion.TabIndex = 9;
            buttonDevolucion.Text = "Nueva Devolucion de Insumos";
            buttonDevolucion.TextAlign = ContentAlignment.BottomCenter;
            buttonDevolucion.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonDevolucion.UseVisualStyleBackColor = true;
            buttonDevolucion.Click += buttonDevolucion_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SlateGray;
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(212, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 854);
            panel3.TabIndex = 6;
            // 
            // menuFarmacia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1784, 961);
            Controls.Add(panel2);
            Controls.Add(buttonCancelar);
            Controls.Add(tabControl);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "menuFarmacia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HSM: Farmacia";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridPendientes).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel5;
        private Label label3;
        private PictureBox pictureBox2;
        private TabControl tabControl;
        private TabPage tabPage3;
        private TabPage tabPage5;
        private TabPage tabPage7;
        private TabPage tabPage4;
        private Button buttonCancelar;
        private Panel panel2;
        private Panel panel3;
        private Button buttonTraslado;
        private Button buttonDevolucion;
        private Label labelHora;
        private Button button5;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage6;
        private DataGridView gridPendientes;
        private TabPage tabPage8;
        private Button buttonRequisicion;
        private Button buttonCompra;
    }
}