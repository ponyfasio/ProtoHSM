namespace ProtoHSM.Farmacia
{
    partial class nuevaCompra
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
            textProveedor = new TextBox();
            listaInsumos = new DataGridView();
            buttonAdd = new Button();
            textPrecio = new TextBox();
            label7 = new Label();
            textCant = new TextBox();
            label6 = new Label();
            textCaducidad = new TextBox();
            label4 = new Label();
            textLote = new TextBox();
            label3 = new Label();
            textInsumo = new TextBox();
            label1 = new Label();
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
            panel1.Controls.Add(textProveedor);
            panel1.Controls.Add(listaInsumos);
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(textPrecio);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textCant);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textCaducidad);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textLote);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textInsumo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(buttonCancelar);
            panel1.Controls.Add(buttonSolicitar);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 467);
            panel1.TabIndex = 21;
            // 
            // textProveedor
            // 
            textProveedor.Font = new Font("Calibri", 12F);
            textProveedor.Location = new Point(93, 23);
            textProveedor.Name = "textProveedor";
            textProveedor.Size = new Size(459, 27);
            textProveedor.TabIndex = 1;
            textProveedor.TextAlign = HorizontalAlignment.Center;
            // 
            // listaInsumos
            // 
            listaInsumos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaInsumos.Location = new Point(12, 119);
            listaInsumos.Name = "listaInsumos";
            listaInsumos.Size = new Size(960, 288);
            listaInsumos.TabIndex = 44;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.DarkCyan;
            buttonAdd.Font = new Font("Marlett", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(906, 51);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(66, 62);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click_1;
            // 
            // textPrecio
            // 
            textPrecio.Font = new Font("Calibri", 12F);
            textPrecio.Location = new Point(795, 86);
            textPrecio.Name = "textPrecio";
            textPrecio.Size = new Size(105, 27);
            textPrecio.TabIndex = 6;
            textPrecio.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F);
            label7.Location = new Point(823, 58);
            label7.Name = "label7";
            label7.Size = new Size(49, 19);
            label7.TabIndex = 35;
            label7.Text = "Precio";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textCant
            // 
            textCant.Font = new Font("Calibri", 12F);
            textCant.Location = new Point(696, 86);
            textCant.Name = "textCant";
            textCant.Size = new Size(94, 27);
            textCant.TabIndex = 5;
            textCant.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F);
            label6.Location = new Point(710, 58);
            label6.Name = "label6";
            label6.Size = new Size(67, 19);
            label6.TabIndex = 35;
            label6.Text = "Cantidad";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textCaducidad
            // 
            textCaducidad.Font = new Font("Calibri", 12F);
            textCaducidad.Location = new Point(573, 86);
            textCaducidad.Name = "textCaducidad";
            textCaducidad.Size = new Size(117, 27);
            textCaducidad.TabIndex = 4;
            textCaducidad.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F);
            label4.Location = new Point(586, 58);
            label4.Name = "label4";
            label4.Size = new Size(90, 19);
            label4.TabIndex = 35;
            label4.Text = "F. Caducidad";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textLote
            // 
            textLote.Font = new Font("Calibri", 12F);
            textLote.Location = new Point(477, 86);
            textLote.Name = "textLote";
            textLote.Size = new Size(91, 27);
            textLote.TabIndex = 3;
            textLote.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F);
            label3.Location = new Point(504, 58);
            label3.Name = "label3";
            label3.Size = new Size(37, 19);
            label3.TabIndex = 35;
            label3.Text = "Lote";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textInsumo
            // 
            textInsumo.Font = new Font("Calibri", 12F);
            textInsumo.Location = new Point(12, 86);
            textInsumo.Name = "textInsumo";
            textInsumo.Size = new Size(459, 27);
            textInsumo.TabIndex = 2;
            textInsumo.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F);
            label1.Location = new Point(211, 58);
            label1.Name = "label1";
            label1.Size = new Size(56, 19);
            label1.TabIndex = 33;
            label1.Text = "Insumo";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F);
            label5.Location = new Point(10, 25);
            label5.Name = "label5";
            label5.Size = new Size(78, 19);
            label5.TabIndex = 30;
            label5.Text = "Proveedor:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(255, 192, 192);
            buttonCancelar.Font = new Font("Calibri", 12F);
            buttonCancelar.Location = new Point(12, 420);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(105, 44);
            buttonCancelar.TabIndex = 9;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonSolicitar
            // 
            buttonSolicitar.BackColor = Color.FromArgb(192, 255, 192);
            buttonSolicitar.Font = new Font("Calibri", 12F);
            buttonSolicitar.Location = new Point(867, 420);
            buttonSolicitar.Name = "buttonSolicitar";
            buttonSolicitar.Size = new Size(105, 44);
            buttonSolicitar.TabIndex = 8;
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
            panel4.Size = new Size(984, 10);
            panel4.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 23);
            label2.Name = "label2";
            label2.Size = new Size(626, 45);
            label2.TabIndex = 23;
            label2.Text = "Nueva Recepcion de Compra de Insumos";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 84);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // nuevaCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "nuevaCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HSM: Nueva compra de Insumos";
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
        private TextBox textLote;
        private Label label3;
        private TextBox textInsumo;
        private Label label1;
        private Label label5;
        private Button buttonCancelar;
        private Button buttonSolicitar;
        private Panel panel4;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox textProveedor;
        private TextBox textPrecio;
        private Label label7;
        private TextBox textCant;
        private Label label6;
        private TextBox textCaducidad;
        private Label label4;
    }
}