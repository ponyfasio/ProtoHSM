namespace ProtoHSM.Compras
{
    partial class menuComprasView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            buttonUpdate = new Button();
            labelHora = new Label();
            panel4 = new Panel();
            labelDepto = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            buttonCompra = new Button();
            buttonProveedor = new Button();
            panel3 = new Panel();
            button1 = new Button();
            label1 = new Label();
            label3 = new Label();
            gridPacientes = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPacientes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(buttonUpdate);
            panel1.Controls.Add(labelHora);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(labelDepto);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1277, 107);
            panel1.TabIndex = 3;
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
            panel4.Size = new Size(1277, 5);
            panel4.TabIndex = 5;
            // 
            // labelDepto
            // 
            labelDepto.AutoSize = true;
            labelDepto.Font = new Font("Calibri", 48F);
            labelDepto.Location = new Point(82, 13);
            labelDepto.Name = "labelDepto";
            labelDepto.Size = new Size(263, 78);
            labelDepto.TabIndex = 2;
            labelDepto.Text = "Compras";
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
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(buttonCompra);
            panel2.Controls.Add(buttonProveedor);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(216, 530);
            panel2.TabIndex = 4;
            // 
            // buttonCompra
            // 
            buttonCompra.Font = new Font("Calibri", 18F);
            buttonCompra.Image = Properties.Resources.carrito_de_compras;
            buttonCompra.Location = new Point(12, 378);
            buttonCompra.Name = "buttonCompra";
            buttonCompra.Padding = new Padding(3);
            buttonCompra.Size = new Size(180, 140);
            buttonCompra.TabIndex = 10;
            buttonCompra.Text = "Nueva Compra";
            buttonCompra.TextAlign = ContentAlignment.BottomCenter;
            buttonCompra.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonCompra.UseVisualStyleBackColor = true;
            // 
            // buttonProveedor
            // 
            buttonProveedor.Font = new Font("Calibri", 18F);
            buttonProveedor.Image = Properties.Resources.cliente;
            buttonProveedor.Location = new Point(19, 13);
            buttonProveedor.Name = "buttonProveedor";
            buttonProveedor.Size = new Size(180, 140);
            buttonProveedor.TabIndex = 11;
            buttonProveedor.Text = "Nuevo Proveedor";
            buttonProveedor.TextAlign = ContentAlignment.BottomCenter;
            buttonProveedor.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonProveedor.UseVisualStyleBackColor = true;
            buttonProveedor.Click += buttonProveedor_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SlateGray;
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(211, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 530);
            panel3.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.respaldo;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.Location = new Point(1811, 13);
            button1.Name = "button1";
            button1.Size = new Size(66, 72);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(1646, 21);
            label1.Name = "label1";
            label1.Size = new Size(135, 64);
            label1.TabIndex = 7;
            label1.Text = "23:59";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 48F);
            label3.Location = new Point(837, 13);
            label3.Name = "label3";
            label3.Size = new Size(457, 78);
            label3.TabIndex = 1;
            label3.Text = "Lubeth Quezada";
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
            gridPacientes.Location = new Point(216, 107);
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
            gridPacientes.Size = new Size(1061, 530);
            gridPacientes.TabIndex = 5;
            // 
            // menuComprasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 637);
            Controls.Add(gridPacientes);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "menuComprasView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "menuComprasView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridPacientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonUpdate;
        private Label labelHora;
        private Panel panel4;
        private Label labelDepto;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button button1;
        private Label label1;
        private Label label3;
        private DataGridView gridPacientes;
        private Panel panel3;
        private Button buttonCompra;
        private Button buttonProveedor;
    }
}